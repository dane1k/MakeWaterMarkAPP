using MyGraphic;
using System.Diagnostics;
using System.Drawing.Imaging;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace MakeWaterMarkAPP
{
	public partial class Form1 : Form
	{
		List<string> fileNames = new();
		string? watermarkName=null;
		string? saveFilePath = null;

		public Form1()
		{
			InitializeComponent();
			bProcessing.Enabled = false;
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



		private void bProcessing_Click(object sender, EventArgs e)
		{
			//timer1.Start();

			int counter = 0;
			progressBar1.Value = 0;
			progressBar1.Maximum = fileNames.Count;

			foreach (string fileName in fileNames)
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
                        //myImage.Image.Save(finalSave);
					}
				}
				progressBar1.Value = counter++;
			}
            Process.Start(Environment.GetEnvironmentVariable("WINDIR") +  @"\explorer.exe", saveFilePath);
            //MessageBox.Show("Processing completed!");
            // timer1.Stop();
            //progressBar1.Value = 0;
        }
		private void bSave_Click(object sender, EventArgs e)
		{
			DialogResult result = folderSaveDialog.ShowDialog();
			if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderSaveDialog.SelectedPath))
			{
				saveFilePath = folderSaveDialog.SelectedPath;
				// Process.Start(saveFilePath);
			}
            CheckProcessing();

        }
        // string destinationPath = Path.Combine(destinationFolder, $"{Path.GetFileNameWithoutExtension(image.FileName)}_WITHWATERMARK.png");

        private void timer1_Tick(object sender, EventArgs e)
		{
			progressBar1.Increment(1);
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
