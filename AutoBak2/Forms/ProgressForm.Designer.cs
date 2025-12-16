namespace AutoBak2.Forms
{
    partial class ProgressForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProgressForm));
            progressBar = new ProgressBar();
            buttonProgressAbort = new Button();
            imageListHighQualityIcons = new ImageList(components);
            imageListIcons = new ImageList(components);
            label3 = new Label();
            label2 = new Label();
            labelWriteoutProgressSource = new Label();
            labelWriteoutProgressDestination = new Label();
            SuspendLayout();
            // 
            // progressBar
            // 
            progressBar.Location = new Point(40, 82);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(705, 29);
            progressBar.TabIndex = 0;
            // 
            // buttonProgressAbort
            // 
            buttonProgressAbort.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonProgressAbort.ImageAlign = ContentAlignment.MiddleRight;
            buttonProgressAbort.ImageKey = "icon_stopall.png";
            buttonProgressAbort.ImageList = imageListHighQualityIcons;
            buttonProgressAbort.Location = new Point(342, 133);
            buttonProgressAbort.Name = "buttonProgressAbort";
            buttonProgressAbort.Size = new Size(93, 36);
            buttonProgressAbort.TabIndex = 1;
            buttonProgressAbort.Text = "Abort";
            buttonProgressAbort.TextAlign = ContentAlignment.MiddleLeft;
            buttonProgressAbort.UseVisualStyleBackColor = true;
            // 
            // imageListHighQualityIcons
            // 
            imageListHighQualityIcons.ColorDepth = ColorDepth.Depth32Bit;
            imageListHighQualityIcons.ImageStream = (ImageListStreamer)resources.GetObject("imageListHighQualityIcons.ImageStream");
            imageListHighQualityIcons.TransparentColor = Color.Transparent;
            imageListHighQualityIcons.Images.SetKeyName(0, "icon_Check.png");
            imageListHighQualityIcons.Images.SetKeyName(1, "icon_blitz.png");
            imageListHighQualityIcons.Images.SetKeyName(2, "icon_clear.png");
            imageListHighQualityIcons.Images.SetKeyName(3, "icon_clearconsole.png");
            imageListHighQualityIcons.Images.SetKeyName(4, "icon_console.png");
            imageListHighQualityIcons.Images.SetKeyName(5, "icon_create.png");
            imageListHighQualityIcons.Images.SetKeyName(6, "icon_delete.png");
            imageListHighQualityIcons.Images.SetKeyName(7, "icon_disable.png");
            imageListHighQualityIcons.Images.SetKeyName(8, "icon_download.png");
            imageListHighQualityIcons.Images.SetKeyName(9, "icon_Edit.png");
            imageListHighQualityIcons.Images.SetKeyName(10, "icon_enable.png");
            imageListHighQualityIcons.Images.SetKeyName(11, "icon_export.png");
            imageListHighQualityIcons.Images.SetKeyName(12, "icon_help.png");
            imageListHighQualityIcons.Images.SetKeyName(13, "icon_import.png");
            imageListHighQualityIcons.Images.SetKeyName(14, "icon_information.png");
            imageListHighQualityIcons.Images.SetKeyName(15, "icon_inject.png");
            imageListHighQualityIcons.Images.SetKeyName(16, "icon_Load.png");
            imageListHighQualityIcons.Images.SetKeyName(17, "icon_reload.png");
            imageListHighQualityIcons.Images.SetKeyName(18, "icon_remove.png");
            imageListHighQualityIcons.Images.SetKeyName(19, "icon_Save.png");
            imageListHighQualityIcons.Images.SetKeyName(20, "icon_settings.png");
            imageListHighQualityIcons.Images.SetKeyName(21, "icon_Start.png");
            imageListHighQualityIcons.Images.SetKeyName(22, "icon_stopall.png");
            imageListHighQualityIcons.Images.SetKeyName(23, "icon_Uncheck.png");
            imageListHighQualityIcons.Images.SetKeyName(24, "icon_upload.png");
            imageListHighQualityIcons.Images.SetKeyName(25, "icon_website.png");
            imageListHighQualityIcons.Images.SetKeyName(26, "icon_Save2.png");
            // 
            // imageListIcons
            // 
            imageListIcons.ColorDepth = ColorDepth.Depth32Bit;
            imageListIcons.ImageStream = (ImageListStreamer)resources.GetObject("imageListIcons.ImageStream");
            imageListIcons.TransparentColor = Color.Transparent;
            imageListIcons.Images.SetKeyName(0, "icon_blitz.png");
            imageListIcons.Images.SetKeyName(1, "icon_Check.png");
            imageListIcons.Images.SetKeyName(2, "icon_create.png");
            imageListIcons.Images.SetKeyName(3, "icon_delete.png");
            imageListIcons.Images.SetKeyName(4, "icon_disable.png");
            imageListIcons.Images.SetKeyName(5, "icon_download.png");
            imageListIcons.Images.SetKeyName(6, "icon_Edit.png");
            imageListIcons.Images.SetKeyName(7, "icon_enable.png");
            imageListIcons.Images.SetKeyName(8, "icon_export.png");
            imageListIcons.Images.SetKeyName(9, "icon_help.png");
            imageListIcons.Images.SetKeyName(10, "icon_import.png");
            imageListIcons.Images.SetKeyName(11, "icon_information.png");
            imageListIcons.Images.SetKeyName(12, "icon_inject.png");
            imageListIcons.Images.SetKeyName(13, "icon_Load.png");
            imageListIcons.Images.SetKeyName(14, "icon_reload.png");
            imageListIcons.Images.SetKeyName(15, "icon_Save.png");
            imageListIcons.Images.SetKeyName(16, "icon_settings.png");
            imageListIcons.Images.SetKeyName(17, "icon_Start.png");
            imageListIcons.Images.SetKeyName(18, "icon_stopall.png");
            imageListIcons.Images.SetKeyName(19, "icon_Uncheck.png");
            imageListIcons.Images.SetKeyName(20, "icon_upload.png");
            imageListIcons.Images.SetKeyName(21, "icon_website.png");
            imageListIcons.Images.SetKeyName(22, "icon_clear.png");
            imageListIcons.Images.SetKeyName(23, "icon_console.png");
            imageListIcons.Images.SetKeyName(24, "icon_remove.png");
            imageListIcons.Images.SetKeyName(25, "icon_clearconsole.png");
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 53);
            label3.Name = "label3";
            label3.Size = new Size(88, 20);
            label3.TabIndex = 7;
            label3.Text = "Destination:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(71, 20);
            label2.Name = "label2";
            label2.Size = new Size(57, 20);
            label2.TabIndex = 6;
            label2.Text = "Source:";
            // 
            // labelWriteoutProgressSource
            // 
            labelWriteoutProgressSource.AutoSize = true;
            labelWriteoutProgressSource.Location = new Point(147, 21);
            labelWriteoutProgressSource.Name = "labelWriteoutProgressSource";
            labelWriteoutProgressSource.Size = new Size(50, 20);
            labelWriteoutProgressSource.TabIndex = 8;
            labelWriteoutProgressSource.Text = "label1";
            // 
            // labelWriteoutProgressDestination
            // 
            labelWriteoutProgressDestination.AutoSize = true;
            labelWriteoutProgressDestination.Location = new Point(147, 53);
            labelWriteoutProgressDestination.Name = "labelWriteoutProgressDestination";
            labelWriteoutProgressDestination.Size = new Size(50, 20);
            labelWriteoutProgressDestination.TabIndex = 9;
            labelWriteoutProgressDestination.Text = "label4";
            // 
            // ProgressForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 181);
            Controls.Add(labelWriteoutProgressDestination);
            Controls.Add(labelWriteoutProgressSource);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(buttonProgressAbort);
            Controls.Add(progressBar);
            Name = "ProgressForm";
            Text = "Progress";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public ProgressBar progressBar;
        private Button buttonProgressAbort;
        private ImageList imageListIcons;
        private ImageList imageListHighQualityIcons;
        private Label label3;
        private Label label2;
        private Label labelWriteoutProgressSource;
        private Label labelWriteoutProgressDestination;
    }
}