namespace VideoCombine {
    public partial class VideoCombine : Form {
        string _lastOutput = string.Empty;
        readonly SettingsManager _settingsManager;

        public VideoCombine() {
            InitializeComponent();
            _settingsManager = new SettingsManager();
            var settings = _settingsManager.Get();
            if(!string.IsNullOrEmpty(settings.FfmpegPath))
                FfmpegPath.Text = settings.FfmpegPath;
            InitOutFileName();
        }

        private void TrimQuotes(object sender, EventArgs e) {
            ((TextBox)sender).Text = ((TextBox)sender).Text.Trim('"');
        }

        bool ValidateFfmpeg() {
            var valid = File.Exists(FfmpegPath.Text);
            FfmpegPathError.Visible = !valid;

            if(valid) {
                var settings = _settingsManager.Get();
                settings.FfmpegPath = FfmpegPath.Text;
                _settingsManager.Save(settings);
            }

            return valid;
        }

        bool ValidateInputVideo() {
            var valid = File.Exists(InputVideo.Text);
            InputVideoError.Visible = !valid;
            return valid;
        }

        bool ValidateInputAudio() {
            var valid = File.Exists(InputAudio.Text);
            InputAudioError.Visible = !valid;
            return valid;
        }

        bool ValidateOutputDir() {
            var valid = Directory.Exists(OutputDir.Text);
            OutputDirError.Visible = !valid;
            return valid;
        }

        bool ValidateOutputFilename() {
            var valid = !string.IsNullOrWhiteSpace(OutputFileName.Text);
            OutputFileNameError.Visible = !valid;
            return valid;
        }

        bool ValidateAll() {
            List<bool> validations = [
                ValidateFfmpeg(),
                ValidateInputVideo(),
                ValidateInputAudio(),
                ValidateOutputDir(),
                ValidateOutputFilename()
            ];

            return !validations.Where(valid => !valid).Any();
        }

        void InitOutFileName() {
            OutputFileName.Text = $"combined-audio--{DateTime.Now:yyyy-MM-dd--hh-mm-ss}.mp4";
        }

        void OnComplete(bool error, string output) {
            SaveButton.Enabled = true;
            _lastOutput = output;
            ExecutionOutput.ForeColor = error ? Color.Red : Color.Green;
            ExecutionOutput.Text = error
                ? "An error occurred"
                : "Execution successful";

            if(!error) {
                InputVideo.Text = string.Empty;
                InputAudio.Text = string.Empty;

            }
        }

        private void SaveButton_Click(object sender, EventArgs e) {
            var valid = ValidateAll();
            SaveError.Visible = !valid;
            if(!valid) return;

            ExecutionOutput.Visible = true;
            ExecutionOutput.ForeColor = Color.Green;
            ExecutionOutput.Text = "Executing, please wait...";

            SaveButton.Enabled = false;
            new FfmpegCombiner(FfmpegPath.Text).Combine(
                InputVideo.Text,
                InputAudio.Text,
                Path.Combine(OutputDir.Text, OutputFileName.Text),
                result => Invoke((MethodInvoker)delegate { OnComplete(result.Error, result.Output); })
            );
        }

        private void FfmpegPath_Leave(object sender, EventArgs e) {
            ValidateFfmpeg();
        }

        private void InputVideo_Leave(object sender, EventArgs e) {
            var valid = ValidateInputVideo();
            if(valid && string.IsNullOrEmpty(OutputDir.Text))
                OutputDir.Text = Directory.GetParent(InputVideo.Text)?.FullName;
        }

        private void InputAudio_Leave(object sender, EventArgs e) {
            ValidateInputAudio();
        }

        private void OutputDir_Leave(object sender, EventArgs e) {
            ValidateOutputDir();
        }

        private void OutputFileName_Leave(object sender, EventArgs e) {
            ValidateOutputFilename();
        }

        private void ViewLastOutput_Click(object sender, EventArgs e) {
            MessageBox.Show(_lastOutput);
        }

        private void VideoCombine_DragEnter(object sender, DragEventArgs e) {
            if(e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
        }

        private void VideoCombine_DragDrop(object sender, DragEventArgs e) {
            string[] filePaths = (string[])e.Data.GetData(DataFormats.FileDrop);
            if(filePaths.Length != 0) {
                if(string.IsNullOrEmpty(InputVideo.Text)){
                    InputVideo.Text = filePaths[0];
                    InputVideo_Leave(InputVideo, null);
                } else if(string.IsNullOrEmpty(InputAudio.Text)) {
                    InputAudio.Text = filePaths[0];
                    InputAudio_Leave(InputAudio, null);
                } else {
                    InputVideo.Text = filePaths[0];
                    InputVideo_Leave(InputVideo, null);
                }
            }
        }
    }
}
