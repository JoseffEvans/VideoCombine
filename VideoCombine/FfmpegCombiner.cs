using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoCombine {
    public class FfmpegCombiner(string ffmpegExe) {
        public class Result {
            public bool Error { get; set; }
            public required string Output { get; set; }
        }

        readonly string _ffmpeg = ffmpegExe;

        public void Combine(string inputVideo, string inputAudio, string output, Action<Result> onComplete) {
            var thread = new Thread( () => {
                var parameters = "" +
                    $"-i \"{inputVideo}\" " +
                    $"-i \"{inputAudio}\" " +
                    $"-c:v copy " +
                    $"-c:a aac " +
                    $"-map 0:v:0 " +
                    $"-map 1:a:0 " +
                    $"{output}";

                var process = new Process {
                    StartInfo = new ProcessStartInfo(_ffmpeg, parameters) {
                        UseShellExecute = false,
                        RedirectStandardOutput = true,
                        RedirectStandardError = true,
                        CreateNoWindow = true
                    }
                };

                var ffmpegOut = $"Input:\n{parameters}\n\nOutput:\n";
                process.OutputDataReceived += (sender, args) => ffmpegOut += $"{args.Data}\n";
                process.ErrorDataReceived += (sender, args) => ffmpegOut += $"{args.Data}\n";

                process.Start();
                process.BeginOutputReadLine();
                process.BeginErrorReadLine();

                try {
                    process.WaitForExit();
                } catch(Exception) { } finally {
                    try { process.Kill(); } catch(Exception) { }
                }

                onComplete(new Result {
                    Error = process.ExitCode != 0,
                    Output = ffmpegOut
                });
            });

            thread.Start();
        }
            
    }
}
