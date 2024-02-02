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
            button1 = new Button();
            bOpen = new Button();
            folderBrowserDialog1 = new FolderBrowserDialog();
            lvFiles = new ListView();
            FileName = new ColumnHeader();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(491, 317);
            button1.Name = "button1";
            button1.Size = new Size(142, 49);
            button1.TabIndex = 0;
            button1.Text = "btn_addwatermarkTest";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
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
            lvFiles.Size = new Size(410, 349);
            lvFiles.TabIndex = 2;
            lvFiles.UseCompatibleStateImageBehavior = false;
            lvFiles.View = View.Details;
            // 
            // FileName
            // 
            FileName.Text = "FileName";
            FileName.Width = 400;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lvFiles);
            Controls.Add(bOpen);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button bOpen;
        private FolderBrowserDialog folderBrowserDialog1;
        private ListView lvFiles;
        private ColumnHeader FileName;
    }
}
