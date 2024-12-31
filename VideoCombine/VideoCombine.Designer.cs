namespace VideoCombine {
    partial class VideoCombine {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            FfmpegPath = new TextBox();
            InputVideo = new TextBox();
            InputAudio = new TextBox();
            OutputDir = new TextBox();
            OutputFileName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            FfmpegPathError = new Label();
            InputVideoError = new Label();
            InputAudioError = new Label();
            OutputDirError = new Label();
            OutputFileNameError = new Label();
            SaveButton = new Button();
            SaveError = new Label();
            ExecutionOutput = new Label();
            ViewLastOutput = new Button();
            SuspendLayout();
            // 
            // FfmpegPath
            // 
            FfmpegPath.Location = new Point(32, 24);
            FfmpegPath.Name = "FfmpegPath";
            FfmpegPath.Size = new Size(482, 23);
            FfmpegPath.TabIndex = 0;
            FfmpegPath.TextChanged += TrimQuotes;
            FfmpegPath.Leave += FfmpegPath_Leave;
            // 
            // InputVideo
            // 
            InputVideo.Location = new Point(32, 81);
            InputVideo.Name = "InputVideo";
            InputVideo.Size = new Size(482, 23);
            InputVideo.TabIndex = 1;
            InputVideo.TextChanged += TrimQuotes;
            InputVideo.Leave += InputVideo_Leave;
            // 
            // InputAudio
            // 
            InputAudio.Location = new Point(32, 138);
            InputAudio.Name = "InputAudio";
            InputAudio.Size = new Size(482, 23);
            InputAudio.TabIndex = 2;
            InputAudio.TextChanged += TrimQuotes;
            InputAudio.Leave += InputAudio_Leave;
            // 
            // OutputDir
            // 
            OutputDir.Location = new Point(32, 195);
            OutputDir.Name = "OutputDir";
            OutputDir.Size = new Size(482, 23);
            OutputDir.TabIndex = 3;
            OutputDir.TextChanged += TrimQuotes;
            OutputDir.Leave += OutputDir_Leave;
            // 
            // OutputFileName
            // 
            OutputFileName.Location = new Point(32, 254);
            OutputFileName.Name = "OutputFileName";
            OutputFileName.Size = new Size(482, 23);
            OutputFileName.TabIndex = 4;
            OutputFileName.Leave += OutputFileName_Leave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 6);
            label1.Name = "label1";
            label1.Size = new Size(75, 15);
            label1.TabIndex = 5;
            label1.Text = "Ffmpeg path";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 63);
            label2.Name = "label2";
            label2.Size = new Size(68, 15);
            label2.TabIndex = 6;
            label2.Text = "Input Video";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 120);
            label3.Name = "label3";
            label3.Size = new Size(70, 15);
            label3.TabIndex = 7;
            label3.Text = "Input Audio";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(32, 177);
            label4.Name = "label4";
            label4.Size = new Size(63, 15);
            label4.TabIndex = 8;
            label4.Text = "Output Dir";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(32, 236);
            label5.Name = "label5";
            label5.Size = new Size(96, 15);
            label5.TabIndex = 9;
            label5.Text = "Output Filename";
            // 
            // FfmpegPathError
            // 
            FfmpegPathError.AutoSize = true;
            FfmpegPathError.ForeColor = Color.Red;
            FfmpegPathError.Location = new Point(520, 27);
            FfmpegPathError.Name = "FfmpegPathError";
            FfmpegPathError.Size = new Size(113, 15);
            FfmpegPathError.TabIndex = 10;
            FfmpegPathError.Text = "Invalid Ffmpeg Path";
            FfmpegPathError.Visible = false;
            // 
            // InputVideoError
            // 
            InputVideoError.AutoSize = true;
            InputVideoError.ForeColor = Color.Red;
            InputVideoError.Location = new Point(520, 84);
            InputVideoError.Name = "InputVideoError";
            InputVideoError.Size = new Size(102, 15);
            InputVideoError.TabIndex = 11;
            InputVideoError.Text = "Invalid Video Path";
            InputVideoError.Visible = false;
            // 
            // InputAudioError
            // 
            InputAudioError.AutoSize = true;
            InputAudioError.ForeColor = Color.Red;
            InputAudioError.Location = new Point(520, 141);
            InputAudioError.Name = "InputAudioError";
            InputAudioError.Size = new Size(104, 15);
            InputAudioError.TabIndex = 12;
            InputAudioError.Text = "Invalid Audio Path";
            InputAudioError.Visible = false;
            // 
            // OutputDirError
            // 
            OutputDirError.AutoSize = true;
            OutputDirError.ForeColor = Color.Red;
            OutputDirError.Location = new Point(520, 198);
            OutputDirError.Name = "OutputDirError";
            OutputDirError.Size = new Size(101, 15);
            OutputDirError.TabIndex = 13;
            OutputDirError.Text = "Invalid Output Dir";
            OutputDirError.Visible = false;
            // 
            // OutputFileNameError
            // 
            OutputFileNameError.AutoSize = true;
            OutputFileNameError.ForeColor = Color.Red;
            OutputFileNameError.Location = new Point(521, 257);
            OutputFileNameError.Name = "OutputFileNameError";
            OutputFileNameError.Size = new Size(139, 15);
            OutputFileNameError.TabIndex = 14;
            OutputFileNameError.Text = "Invalid Output File Name";
            OutputFileNameError.Visible = false;
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(32, 292);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(63, 23);
            SaveButton.TabIndex = 15;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // SaveError
            // 
            SaveError.AutoSize = true;
            SaveError.ForeColor = Color.Red;
            SaveError.Location = new Point(101, 296);
            SaveError.Name = "SaveError";
            SaveError.Size = new Size(174, 15);
            SaveError.TabIndex = 16;
            SaveError.Text = "Validation errors, unable to save";
            SaveError.Visible = false;
            // 
            // ExecutionOutput
            // 
            ExecutionOutput.AutoSize = true;
            ExecutionOutput.ForeColor = Color.Green;
            ExecutionOutput.Location = new Point(32, 318);
            ExecutionOutput.Name = "ExecutionOutput";
            ExecutionOutput.Size = new Size(93, 15);
            ExecutionOutput.TabIndex = 17;
            ExecutionOutput.Text = "ExecutionOuput";
            ExecutionOutput.Visible = false;
            // 
            // ViewLastOutput
            // 
            ViewLastOutput.Location = new Point(451, 296);
            ViewLastOutput.Name = "ViewLastOutput";
            ViewLastOutput.Size = new Size(128, 23);
            ViewLastOutput.TabIndex = 18;
            ViewLastOutput.Text = "View Last Output";
            ViewLastOutput.UseVisualStyleBackColor = true;
            ViewLastOutput.Click += ViewLastOutput_Click;
            // 
            // VideoCombine
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ViewLastOutput);
            Controls.Add(ExecutionOutput);
            Controls.Add(SaveError);
            Controls.Add(SaveButton);
            Controls.Add(OutputFileNameError);
            Controls.Add(OutputDirError);
            Controls.Add(InputAudioError);
            Controls.Add(InputVideoError);
            Controls.Add(FfmpegPathError);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(OutputFileName);
            Controls.Add(OutputDir);
            Controls.Add(InputAudio);
            Controls.Add(InputVideo);
            Controls.Add(FfmpegPath);
            Name = "VideoCombine";
            Text = "Video Combine";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox FfmpegPath;
        private TextBox InputVideo;
        private TextBox InputAudio;
        private TextBox OutputDir;
        private TextBox OutputFileName;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label FfmpegPathError;
        private Label InputVideoError;
        private Label InputAudioError;
        private Label OutputDirError;
        private Label OutputFileNameError;
        private Button SaveButton;
        private Label SaveError;
        private Label ExecutionOutput;
        private Button ViewLastOutput;
    }
}
