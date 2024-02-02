using MyGraphic;

namespace MakeWaterMarkAPP
{
	public partial class Form1 : Form
	{
		List<string> fileNames = new();
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			using (Image image = Image.FromFile(@"C:\TRYING\TESTS\Photoes\_1060261.jpg"))
			{
				using (Image watermarkImage = Image.FromFile(@"C:\TRYING\TESTS\Logo\logo.png"))
				{
					Image res = WatermarkLib.AddWatermark(image, watermarkImage);
					res.Save(@"C:\TRYING\Export\_1060261WITHWATERMARK.jpg");

				}
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
		}
	}
}
