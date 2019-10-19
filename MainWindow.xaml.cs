using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Threading.Tasks;
using System.Diagnostics;

namespace BayoudGUI {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {

        private string progname = "BayoudGUI";
        private WebClient webClient = new WebClient();

        public MainWindow() {
            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

            if (!File.Exists("youtube-dl.exe")) {
                MessageBox.Show(
                        $"youtube-dl.exe is not present, and {progname} will attempt to download it.\n" +
                         "It's best you try to update after this.\n" +
                        $"{progname} will appear after a few seconds.",
                        progname,
                        MessageBoxButton.OK,
                        MessageBoxImage.Exclamation
                    );
                webClient.DownloadFile(
                    "https://github.com/ytdl-org/youtube-dl/releases/download/2019.10.16/youtube-dl.exe",
                    "youtube-dl.exe");
            }

            InitializeComponent();
            win.Width += 10;
            win.Height += 10;

            Gffstuff.Visibility = Visibility.Hidden;

            if (File.Exists("ff.ini")) {
                string[] ffini = File.ReadAllText("ff.ini").Split('\n');
                txtFFCmd.Text = ffini[0];
                txtFFFileExt.Text = ffini[1];
            }

            webClient.DownloadProgressChanged += webClientProgress;
            webClient.DownloadFileCompleted += webClientFinish;
            webClient.DownloadDataCompleted += webClientFinish;
            webClient.DownloadStringCompleted += webClientFinish;
        }

        private void webClientFinish(object sender, System.ComponentModel.AsyncCompletedEventArgs e) {
            progress.Visibility = Visibility.Hidden;
        }

        private void webClientProgress(object sender, DownloadProgressChangedEventArgs e) {
            progress.Visibility = Visibility.Visible;
            progress.Value = e.ProgressPercentage;
        }

        private async void ChkFF_Checked(object sender, RoutedEventArgs e) {
            if (!File.Exists("ffmpeg.exe")) {
                chkFF.IsChecked = false;
                bool ffmb = MessageBox.Show(
                    $"FFMPEG isn't in the same directory as {progname}. Download it?",
                    progname,
                    MessageBoxButton.YesNo, MessageBoxImage.Exclamation
                ) == MessageBoxResult.Yes;
                if (ffmb) {
                    chkFF.IsEnabled = false;
                    await webClient.DownloadFileTaskAsync(
                        "https://ffmpeg.zeranoe.com/builds/win64/static/ffmpeg-latest-win64-static.zip",
                        "ffmpeg_latest.zip"
                    );
                    lblStatus.Content = "Unzipping FFMPEG";
                    lblStatus.Visibility = Visibility.Visible;
                    await unzipffmpeg();
                    lblStatus.Visibility = Visibility.Hidden;
                    chkFF.IsEnabled = true; chkFF.IsChecked = true;
                } else {
                    chkFF.IsChecked = false;
                    return;
                }
            }
            Gffstuff.Visibility = Visibility.Visible;

            Task unzipffmpeg() {
                return Task.Run(() => {
                    ZipFile.ExtractToDirectory("ffmpeg_latest.zip", "ffmpeg_latest");
                    File.Delete("ffmpeg_latest.zip");
                    File.Move(@"ffmpeg_latest\ffmpeg-latest-win64-static\bin\ffmpeg.exe", "ffmpeg.exe");
                    Directory.Delete("ffmpeg_latest", true);
                });
            }
        }

        private void ChkFF_Unchecked(object sender, RoutedEventArgs e) {
            Gffstuff.Visibility = Visibility.Hidden;
        }

        private void Button_Click(object sender, RoutedEventArgs e) {
            // ffmpeg options save button
            File.WriteAllText(
                "ff.ini",
                $"{txtFFCmd.Text}\n{txtFFFileExt.Text}"
            );
        }

        private async void ButtonDownload_Click(object sender, RoutedEventArgs e) {
            /*
            Console.WriteLine("Download button click");
            string ffs = "";
            if ((bool)chkFF.IsChecked) ffs = $"--exec \"ffmpeg -i '{{}}' {txtFFCmd.Text} '{{}}.{txtFFFileExt.Text}'\" ";
            ProcessStartInfo startInfo = new ProcessStartInfo {
                FileName = "youtube-dl.exe",
                Arguments = $"{ffs}\"{textBoxURL.Text}\"",
                CreateNoWindow = true,
                RedirectStandardOutput = true,
                UseShellExecute = false,
                WorkingDirectory = "."
            };
            Process ytdl_process = new Process {
                StartInfo = startInfo
            };
            Console.WriteLine("Process created");
            ytdl_process.EnableRaisingEvents = true;
            ytdl_process.OutputDataReceived += processdata;
            ytdl_process.Exited += processexit;
            Console.WriteLine("Events bound");
            ytdl_process.Start();
            Console.WriteLine("Process started");
            */

            string eargs = "";
            string fn = "%(title)";

            if ((bool)boxDLAud.IsChecked) eargs += "-x ";
            if ((bool)chkFF.IsChecked) fn = "out";

            ProcessStartInfo startInfo = new ProcessStartInfo {
                FileName = "youtube-dl.exe",
                Arguments = $"{eargs}-o \"{fn}.%(ext)s\" \"{textBoxURL.Text}\""
            };
            Process ytdl_process = Process.Start(startInfo);
            if ((bool)chkFF.IsChecked) {
                await (Task.Run(() => {
                    ytdl_process.WaitForExit();
                    ProcessStartInfo startInfo1 = new ProcessStartInfo {
                        FileName = "ffmpeg.exe",
                        Arguments = $"-i out.* {txtFFCmd.Text} \"{txtFFFileExt.Text}\""
                    };
                    Process.Start(startInfo1);
                }));
            }
        }

        private void processexit(object sender, EventArgs e) {
            lblStatus.Visibility = Visibility.Hidden;
            Console.WriteLine("Process Exit");
        }

        private void processdata(object sender, DataReceivedEventArgs e) {
            Console.WriteLine($"PDATA: {e.Data}");
            lblStatus.Content = e.Data;
            lblStatus.Visibility = Visibility.Visible;
        }

        private void ButtonUpdate_Click(object sender, RoutedEventArgs e) {
            ProcessStartInfo startInfo = new ProcessStartInfo {
                FileName = "youtube-dl.exe",
                Arguments = "-U"
            };
            Process.Start(startInfo);
        }
    }
}
