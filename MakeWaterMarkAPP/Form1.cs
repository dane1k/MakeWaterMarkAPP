using MyGraphic;
using System.Diagnostics;

namespace MakeWaterMarkAPP
{
    public partial class Form1 : Form
    {
        List<string> fileNames = new();
        System.Timers.Timer t;
        string? watermarkName;
        string? saveFilePath;

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

        // Checks if processing can be initiated
        private void CheckProcessing()
        {
            // Enable processing if file names, watermark and save file path are provided
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

                fileNames = files.ToList(); // Selected file names

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

            // Process each file in parallel
            Parallel.ForEach(fileNames, new ParallelOptions { MaxDegreeOfParallelism = 8 }, (x) =>
            {
                Thread.CurrentThread.Priority = ThreadPriority.Lowest; // Set thread priority
                Debug.WriteLine(Interlocked.Increment(ref counter)); // Increment counter and log progress
                ProcessOne(x); // Process the file
            });

            // Open save folder in file explorer
            Process.Start(Environment.GetEnvironmentVariable("WINDIR") + @"\explorer.exe", saveFilePath);
            t.Stop();
        }

        // Update progress bar
        private void UpdateProgressBar(int val)
        {
            Action f = () => progressBar1.Value = val; // Update progress bar value
            if (progressBar1.InvokeRequired)
            {
                progressBar1.Invoke(f);
            }
            else
            {
                progressBar1.Value = val;
            }
        }

        // Process each file
        private void ProcessOne(String fileName)
        {
            using (Image image = Image.FromFile(fileName))
            {
                using (Image watermarkImage = Image.FromFile(watermarkName))
                {
                    // Check the dimensions of the watermark image
                    int watermarkWidth = watermarkImage.Width;
                    int watermarkHeight = watermarkImage.Height;

                    // Determine coordinates for the bottom-right corner
                    int x = image.Width - watermarkWidth;
                    int y = image.Height - watermarkHeight;

                    // Create a new bitmap with the watermark
                    using (Bitmap bmp = new Bitmap(image))
                    {
                        using (Graphics graphics = Graphics.FromImage(bmp))
                        {
                            // Draw the watermark on the image
                            graphics.DrawImage(watermarkImage, new Rectangle(x, y, watermarkWidth, watermarkHeight));
                        }

                        // Save the image with the watermark
                        string filePathName = Path.GetFileName(fileName);
                        string finalSave = Path.Combine(saveFilePath, filePathName);
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

        private void saveFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        // Class to hold image data
        public class MyImage
        {
            public string FileName { get; set; }
            public Image Image { get; set; }
        }
    }
}
