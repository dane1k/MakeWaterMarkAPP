using MyGraphic;
using System.Diagnostics;

namespace MakeWaterMarkAPP
{
	public partial class Form1 : Form
	{
		List<string> fileNames = new();
		System.Timers.Timer t;
		string? watermarkName= "C:\\TRYING\\TESTS\\Logo\\logo.png";
		string? saveFilePath = "C:\\TRYING\\Export";

		public Form1()
		{
			InitializeComponent();
			bProcessing.Enabled = false;
			t = new System.Timers.Timer(100);
            t.Elapsed += Timer1_Tick;
		}

        private void Timer1_Tick(object? sender, EventArgs e)
        {
			UpdateProgressBar(counter);
        }

        private void CheckProcessing()
		{
			if (fileNames.Count > 0 && watermarkName != null && saveFilePath != null)
			{
				bProcessing.Enabled = true;
			}
		}


		private void bOpen_Click(object sender, EventArgs e)
		{
			DialogResult result = folderBrowserDialog1.ShowDialog();
			if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowserDialog1.SelectedPath))
			{
				string[] files = Directory.GetFiles(folderBrowserDialog1.SelectedPath);

				fileNames = files.ToList();

				lvFiles.Items.AddRange(fileNames.ConvertAll(x => new ListViewItem(x)).ToArray());
			}
			CheckProcessing();
		}

		private void bAddWatermark_Click(object sender, EventArgs e)
		{
			if (openFileDialog1.ShowDialog() == DialogResult.OK)
			{
				
			}
			CheckProcessing();
		}

		private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
		{
			watermarkName = (sender as FileDialog).FileName;
			tbWaterMark.Text = watermarkName;
		}

		int counter = 0;
        private void bProcessing_Click(object sender, EventArgs e)
		{
			t.Start();

			counter = 0;

			progressBar1.Value = 0;
			progressBar1.Maximum = fileNames.Count;

            Parallel.ForEach(fileNames, new ParallelOptions { MaxDegreeOfParallelism = 8 }, (x) =>
			{
				Thread.CurrentThread.Priority = ThreadPriority.Lowest;
                Debug.WriteLine(Interlocked.Increment(ref counter));
                ProcessOne(x);
            });

            Process.Start(Environment.GetEnvironmentVariable("WINDIR") +  @"\explorer.exe", saveFilePath);
             t.Stop();
            
        }

        private void UpdateProgressBar(int val)
        {
			Action f = () => progressBar1.Value = val;
			if (progressBar1.InvokeRequired)
			{
				progressBar1.Invoke(f);
			}
			else
			{
				progressBar1.Value = val;
			}
        }

        private void ProcessOne(String fileName)
		{
            using (Image image = Image.FromFile(fileName))
            {
                using (Image watermarkImage = Image.FromFile(watermarkName))
                {
                    Image res = WatermarkLib.AddWatermark(image, watermarkImage);

                    var myImage = new MyImage();
                    myImage.FileName = fileName;
                    myImage.Image = res;
                    string filePathName = Path.GetFileName(fileName);
                    string finalSave = Path.Combine(saveFilePath, filePathName);
                    using (Bitmap bmp = new Bitmap(myImage.Image, myImage.Image.Width, myImage.Image.Height))
                    {
                        bmp.Save(finalSave);
                    }
                }
            }
        }
		private void bSave_Click(object sender, EventArgs e)
		{
			DialogResult result = folderSaveDialog.ShowDialog();
			if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderSaveDialog.SelectedPath))
			{
				saveFilePath = folderSaveDialog.SelectedPath;
			}
            CheckProcessing();

        }

        private void timer1_Tick(object sender, EventArgs e)
		{
			UpdateProgressBar(counter);
		}
		private void saveFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
		{

		}
		private void progressBar1_Click(object sender, EventArgs e)
		{

		}

		public class MyImage
		{
			public string FileName { get; set; }
			public Image Image { get; set; }
		}
	}
}
