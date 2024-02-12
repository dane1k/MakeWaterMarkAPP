namespace MakeWaterMarkAPP
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            bOpen = new Button();
            folderBrowserDialog1 = new FolderBrowserDialog();
            lvFiles = new ListView();
            FileName = new ColumnHeader();
            bAddWatermark = new Button();
            openFileDialog1 = new OpenFileDialog();
            tbWaterMark = new TextBox();
            bSave = new Button();
            saveFileDialog1 = new SaveFileDialog();
            bProcessing = new Button();
            progressBar1 = new ProgressBar();
            timer1 = new System.Windows.Forms.Timer(components);
            folderSaveDialog = new FolderBrowserDialog();
            rbVTop = new RadioButton();
            lbChoosePosition = new Label();
            lbVertical = new Label();
            rbVCenter = new RadioButton();
            rbVBottom = new RadioButton();
            rbHTop = new RadioButton();
            rbHCenter = new RadioButton();
            rbHBottom = new RadioButton();
            lbHorizontal = new Label();
            SuspendLayout();
            // 
            // bOpen
            // 
            bOpen.Location = new Point(38, 21);
            bOpen.Name = "bOpen";
            bOpen.Size = new Size(92, 30);
            bOpen.TabIndex = 1;
            bOpen.Text = "Open";
            bOpen.UseVisualStyleBackColor = true;
            bOpen.Click += bOpen_Click;
            // 
            // lvFiles
            // 
            lvFiles.Columns.AddRange(new ColumnHeader[] { FileName });
            lvFiles.Location = new Point(12, 74);
            lvFiles.Name = "lvFiles";
            lvFiles.Size = new Size(327, 349);
            lvFiles.TabIndex = 2;
            lvFiles.UseCompatibleStateImageBehavior = false;
            lvFiles.View = View.Details;
            // 
            // FileName
            // 
            FileName.Text = "FileName";
            FileName.Width = 400;
            // 
            // bAddWatermark
            // 
            bAddWatermark.Location = new Point(173, 21);
            bAddWatermark.Name = "bAddWatermark";
            bAddWatermark.Size = new Size(126, 30);
            bAddWatermark.TabIndex = 3;
            bAddWatermark.Text = "Add Watermark";
            bAddWatermark.UseVisualStyleBackColor = true;
            bAddWatermark.Click += bAddWatermark_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.FileOk += openFileDialog1_FileOk;
            // 
            // tbWaterMark
            // 
            tbWaterMark.Location = new Point(340, 26);
            tbWaterMark.Name = "tbWaterMark";
            tbWaterMark.Size = new Size(336, 23);
            tbWaterMark.TabIndex = 4;
            // 
            // bSave
            // 
            bSave.Location = new Point(713, 25);
            bSave.Name = "bSave";
            bSave.Size = new Size(75, 23);
            bSave.TabIndex = 5;
            bSave.Text = "Save";
            bSave.UseVisualStyleBackColor = true;
            bSave.Click += bSave_Click;
            // 
            // saveFileDialog1
            // 
            saveFileDialog1.FileOk += saveFileDialog1_FileOk;
            // 
            // bProcessing
            // 
            bProcessing.Location = new Point(369, 74);
            bProcessing.Name = "bProcessing";
            bProcessing.Size = new Size(75, 23);
            bProcessing.TabIndex = 6;
            bProcessing.Text = "Processing";
            bProcessing.UseVisualStyleBackColor = true;
            bProcessing.Click += bProcessing_Click;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(369, 115);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(405, 23);
            progressBar1.TabIndex = 7;
            progressBar1.Click += progressBar1_Click;
            // 
            // rbVTop
            // 
            rbVTop.AutoSize = true;
            rbVTop.Location = new Point(369, 236);
            rbVTop.Name = "rbVTop";
            rbVTop.Size = new Size(44, 19);
            rbVTop.TabIndex = 8;
            rbVTop.TabStop = true;
            rbVTop.Text = "Top";
            rbVTop.UseVisualStyleBackColor = true;
            // 
            // lbChoosePosition
            // 
            lbChoosePosition.AutoSize = true;
            lbChoosePosition.Location = new Point(510, 175);
            lbChoosePosition.Name = "lbChoosePosition";
            lbChoosePosition.Size = new Size(84, 15);
            lbChoosePosition.TabIndex = 9;
            lbChoosePosition.Text = "Select Position";
            // 
            // lbVertical
            // 
            lbVertical.AutoSize = true;
            lbVertical.Location = new Point(369, 209);
            lbVertical.Name = "lbVertical";
            lbVertical.Size = new Size(48, 15);
            lbVertical.TabIndex = 10;
            lbVertical.Text = "Vertical:";
            // 
            // rbVCenter
            // 
            rbVCenter.AutoSize = true;
            rbVCenter.Location = new Point(500, 236);
            rbVCenter.Name = "rbVCenter";
            rbVCenter.Size = new Size(60, 19);
            rbVCenter.TabIndex = 11;
            rbVCenter.TabStop = true;
            rbVCenter.Text = "Center";
            rbVCenter.UseVisualStyleBackColor = true;
            // 
            // rbVBottom
            // 
            rbVBottom.AutoSize = true;
            rbVBottom.Location = new Point(657, 236);
            rbVBottom.Name = "rbVBottom";
            rbVBottom.Size = new Size(65, 19);
            rbVBottom.TabIndex = 12;
            rbVBottom.TabStop = true;
            rbVBottom.Text = "Bottom";
            rbVBottom.UseVisualStyleBackColor = true;
            // 
            // rbHTop
            // 
            rbHTop.AutoSize = true;
            rbHTop.Location = new Point(369, 317);
            rbHTop.Name = "rbHTop";
            rbHTop.Size = new Size(44, 19);
            rbHTop.TabIndex = 13;
            rbHTop.TabStop = true;
            rbHTop.Text = "Top";
            rbHTop.UseVisualStyleBackColor = true;
            // 
            // rbHCenter
            // 
            rbHCenter.AutoSize = true;
            rbHCenter.Location = new Point(500, 317);
            rbHCenter.Name = "rbHCenter";
            rbHCenter.Size = new Size(60, 19);
            rbHCenter.TabIndex = 14;
            rbHCenter.TabStop = true;
            rbHCenter.Text = "Center";
            rbHCenter.UseVisualStyleBackColor = true;
            // 
            // rbHBottom
            // 
            rbHBottom.AutoSize = true;
            rbHBottom.Location = new Point(657, 317);
            rbHBottom.Name = "rbHBottom";
            rbHBottom.Size = new Size(65, 19);
            rbHBottom.TabIndex = 15;
            rbHBottom.TabStop = true;
            rbHBottom.Text = "Bottom";
            rbHBottom.UseVisualStyleBackColor = true;
            // 
            // lbHorizontal
            // 
            lbHorizontal.AutoSize = true;
            lbHorizontal.Location = new Point(369, 285);
            lbHorizontal.Name = "lbHorizontal";
            lbHorizontal.Size = new Size(62, 15);
            lbHorizontal.TabIndex = 16;
            lbHorizontal.Text = "Horizontal";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbHorizontal);
            Controls.Add(rbHBottom);
            Controls.Add(rbHCenter);
            Controls.Add(rbHTop);
            Controls.Add(rbVBottom);
            Controls.Add(rbVCenter);
            Controls.Add(lbVertical);
            Controls.Add(lbChoosePosition);
            Controls.Add(rbVTop);
            Controls.Add(progressBar1);
            Controls.Add(bProcessing);
            Controls.Add(bSave);
            Controls.Add(tbWaterMark);
            Controls.Add(bAddWatermark);
            Controls.Add(lvFiles);
            Controls.Add(bOpen);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button bOpen;
        private FolderBrowserDialog folderBrowserDialog1;
        private ListView lvFiles;
        private ColumnHeader FileName;
        private Button bAddWatermark;
        private OpenFileDialog openFileDialog1;
        private TextBox tbWaterMark;
        private Button bSave;
        private SaveFileDialog saveFileDialog1;
        private Button bProcessing;
        private ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
        private FolderBrowserDialog folderSaveDialog;
        private RadioButton rbVTop;
        private Label lbChoosePosition;
        private Label lbVertical;
        private RadioButton rbVCenter;
        private RadioButton rbVBottom;
        private RadioButton rbHTop;
        private RadioButton rbHCenter;
        private RadioButton rbHBottom;
        private Label lbHorizontal;
    }
}
