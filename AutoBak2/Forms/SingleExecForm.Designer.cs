namespace AutoBak2.Forms
{
    partial class SingleExecForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SingleExecForm));
            comboBoxJobSelection = new ComboBox();
            imageListHighQualityIcons = new ImageList(components);
            imageListIcons = new ImageList(components);
            singleExecuteButton = new Button();
            richTextBox1 = new RichTextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            linkLabelBrowseToSource = new LinkLabel();
            linkLabelBrowseToDestination = new LinkLabel();
            label4 = new Label();
            SuspendLayout();
            // 
            // comboBoxJobSelection
            // 
            comboBoxJobSelection.FormattingEnabled = true;
            comboBoxJobSelection.Location = new Point(211, 41);
            comboBoxJobSelection.Name = "comboBoxJobSelection";
            comboBoxJobSelection.Size = new Size(276, 28);
            comboBoxJobSelection.TabIndex = 0;
            comboBoxJobSelection.SelectedIndexChanged += comboBoxJobSelection_SelectedIndexChanged;
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
            // singleExecuteButton
            // 
            singleExecuteButton.ImageIndex = 21;
            singleExecuteButton.ImageList = imageListHighQualityIcons;
            singleExecuteButton.Location = new Point(103, 25);
            singleExecuteButton.Name = "singleExecuteButton";
            singleExecuteButton.Size = new Size(65, 58);
            singleExecuteButton.TabIndex = 1;
            singleExecuteButton.UseVisualStyleBackColor = true;
            singleExecuteButton.Click += singleExecuteButton_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(27, 124);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(582, 74);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 101);
            label1.Name = "label1";
            label1.Size = new Size(115, 20);
            label1.TabIndex = 3;
            label1.Text = "Job Description:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(58, 222);
            label2.Name = "label2";
            label2.Size = new Size(57, 20);
            label2.TabIndex = 4;
            label2.Text = "Source:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 255);
            label3.Name = "label3";
            label3.Size = new Size(88, 20);
            label3.TabIndex = 5;
            label3.Text = "Destination:";
            // 
            // linkLabelBrowseToSource
            // 
            linkLabelBrowseToSource.AutoSize = true;
            linkLabelBrowseToSource.Location = new Point(121, 222);
            linkLabelBrowseToSource.Name = "linkLabelBrowseToSource";
            linkLabelBrowseToSource.Size = new Size(177, 20);
            linkLabelBrowseToSource.TabIndex = 6;
            linkLabelBrowseToSource.TabStop = true;
            linkLabelBrowseToSource.Text = "linkLabelBrowseToSource";
            linkLabelBrowseToSource.Click += linkLabelBrowseToSource_Click;
            // 
            // linkLabelBrowseToDestination
            // 
            linkLabelBrowseToDestination.AutoSize = true;
            linkLabelBrowseToDestination.Location = new Point(121, 255);
            linkLabelBrowseToDestination.Name = "linkLabelBrowseToDestination";
            linkLabelBrowseToDestination.Size = new Size(208, 20);
            linkLabelBrowseToDestination.TabIndex = 7;
            linkLabelBrowseToDestination.TabStop = true;
            linkLabelBrowseToDestination.Text = "linkLabelBrowseToDestination";
            linkLabelBrowseToDestination.Click += linkLabelBrowseToDestination_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(310, 18);
            label4.Name = "label4";
            label4.Size = new Size(76, 20);
            label4.TabIndex = 8;
            label4.Text = "Select Job";
            // 
            // SingleExecForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(637, 308);
            Controls.Add(label4);
            Controls.Add(linkLabelBrowseToDestination);
            Controls.Add(linkLabelBrowseToSource);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(richTextBox1);
            Controls.Add(singleExecuteButton);
            Controls.Add(comboBoxJobSelection);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "SingleExecForm";
            Text = "Single Execution";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxJobSelection;
        private ImageList imageListHighQualityIcons;
        private ImageList imageListIcons;
        private Button singleExecuteButton;
        private RichTextBox richTextBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private LinkLabel linkLabelBrowseToSource;
        private LinkLabel linkLabelBrowseToDestination;
        private Label label4;
    }
}