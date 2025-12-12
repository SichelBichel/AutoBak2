namespace AutoBak2
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            addInstanceToolStripMenuItem = new ToolStripMenuItem();
            deleteInstanceToolStripMenuItem = new ToolStripMenuItem();
            stopAllInstancesToolStripMenuItem = new ToolStripMenuItem();
            optionsToolStripMenuItem = new ToolStripMenuItem();
            importToolStripMenuItem = new ToolStripMenuItem();
            exportToolStripMenuItem = new ToolStripMenuItem();
            openConfigfolderToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            showHelpWindowToolStripMenuItem = new ToolStripMenuItem();
            settingsToolStripMenuItem = new ToolStripMenuItem();
            visitWebsiteToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            groupBox4 = new GroupBox();
            comboBox1 = new ComboBox();
            button1 = new Button();
            imageListHighQualityIcons = new ImageList(components);
            tabPage2 = new TabPage();
            label9 = new Label();
            groupBox3 = new GroupBox();
            richTextBoxJobDescription = new RichTextBox();
            label10 = new Label();
            panel4 = new Panel();
            groupBoxProtocol = new GroupBox();
            radioButtonGz = new RadioButton();
            radioButtonRar = new RadioButton();
            radioButton7z = new RadioButton();
            radioButtonZip = new RadioButton();
            checkBoxArchive = new CheckBox();
            label11 = new Label();
            textBoxJobName = new TextBox();
            panel5 = new Panel();
            buttonOpenJobFolder = new Button();
            imageListIcons = new ImageList(components);
            buttonNewJob = new Button();
            buttonDeleteJob = new Button();
            buttonEditJob = new Button();
            buttonSaveJob = new Button();
            label12 = new Label();
            comboBoxJobSelection = new ComboBox();
            groupBox2 = new GroupBox();
            label7 = new Label();
            panel3 = new Panel();
            button4 = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            button15 = new Button();
            button3 = new Button();
            label5 = new Label();
            textBoxExclusionPath = new TextBox();
            label6 = new Label();
            buttonSelectSourcePath = new Button();
            label4 = new Label();
            textBoxSourcePath = new TextBox();
            groupBox1 = new GroupBox();
            panel2 = new Panel();
            checkBoxUseSourcedirectoryName = new CheckBox();
            label3 = new Label();
            textBoxSubdirectoryName = new TextBox();
            label2 = new Label();
            checkBoxCreateSubdirectory = new CheckBox();
            label1 = new Label();
            textBoxDestinationPath = new TextBox();
            buttonSelectDestinationPath = new Button();
            tabPage3 = new TabPage();
            label8 = new Label();
            menuStrip1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBox4.SuspendLayout();
            tabPage2.SuspendLayout();
            groupBox3.SuspendLayout();
            panel4.SuspendLayout();
            groupBoxProtocol.SuspendLayout();
            panel5.SuspendLayout();
            groupBox2.SuspendLayout();
            panel3.SuspendLayout();
            groupBox1.SuspendLayout();
            panel2.SuspendLayout();
            tabPage3.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.ControlDarkDark;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, optionsToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(1451, 30);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addInstanceToolStripMenuItem, deleteInstanceToolStripMenuItem, stopAllInstancesToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            fileToolStripMenuItem.Click += fileToolStripMenuItem_Click;
            // 
            // addInstanceToolStripMenuItem
            // 
            addInstanceToolStripMenuItem.Name = "addInstanceToolStripMenuItem";
            addInstanceToolStripMenuItem.Size = new Size(224, 26);
            addInstanceToolStripMenuItem.Text = "Add Instance";
            // 
            // deleteInstanceToolStripMenuItem
            // 
            deleteInstanceToolStripMenuItem.Name = "deleteInstanceToolStripMenuItem";
            deleteInstanceToolStripMenuItem.Size = new Size(235, 26);
            deleteInstanceToolStripMenuItem.Text = "Delete Instance (N/A)";
            // 
            // stopAllInstancesToolStripMenuItem
            // 
            stopAllInstancesToolStripMenuItem.Name = "stopAllInstancesToolStripMenuItem";
            stopAllInstancesToolStripMenuItem.Size = new Size(224, 26);
            stopAllInstancesToolStripMenuItem.Text = "Stop All Instances";
            // 
            // optionsToolStripMenuItem
            // 
            optionsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { importToolStripMenuItem, exportToolStripMenuItem, openConfigfolderToolStripMenuItem });
            optionsToolStripMenuItem.ForeColor = SystemColors.ActiveCaptionText;
            optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            optionsToolStripMenuItem.Size = new Size(67, 24);
            optionsToolStripMenuItem.Text = "Config";
            optionsToolStripMenuItem.Click += optionsToolStripMenuItem_Click;
            // 
            // importToolStripMenuItem
            // 
            importToolStripMenuItem.Name = "importToolStripMenuItem";
            importToolStripMenuItem.Size = new Size(224, 26);
            importToolStripMenuItem.Text = "Import";
            // 
            // exportToolStripMenuItem
            // 
            exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            exportToolStripMenuItem.Size = new Size(224, 26);
            exportToolStripMenuItem.Text = "Export";
            // 
            // openConfigfolderToolStripMenuItem
            // 
            openConfigfolderToolStripMenuItem.Name = "openConfigfolderToolStripMenuItem";
            openConfigfolderToolStripMenuItem.Size = new Size(224, 26);
            openConfigfolderToolStripMenuItem.Text = "Open Configfolder";
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { showHelpWindowToolStripMenuItem, settingsToolStripMenuItem, visitWebsiteToolStripMenuItem, aboutToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(55, 24);
            helpToolStripMenuItem.Text = "Help";
            // 
            // showHelpWindowToolStripMenuItem
            // 
            showHelpWindowToolStripMenuItem.Name = "showHelpWindowToolStripMenuItem";
            showHelpWindowToolStripMenuItem.Size = new Size(223, 26);
            showHelpWindowToolStripMenuItem.Text = "Show Help Window";
            // 
            // settingsToolStripMenuItem
            // 
            settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            settingsToolStripMenuItem.Size = new Size(223, 26);
            settingsToolStripMenuItem.Text = "Settings";
            // 
            // visitWebsiteToolStripMenuItem
            // 
            visitWebsiteToolStripMenuItem.Name = "visitWebsiteToolStripMenuItem";
            visitWebsiteToolStripMenuItem.Size = new Size(223, 26);
            visitWebsiteToolStripMenuItem.Text = "Visit Website";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(223, 26);
            aboutToolStripMenuItem.Text = "About";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(14, 36);
            tabControl1.Margin = new Padding(3, 4, 3, 4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1424, 855);
            tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.Silver;
            tabPage1.Controls.Add(groupBox4);
            tabPage1.ForeColor = SystemColors.ActiveCaptionText;
            tabPage1.Location = new Point(4, 29);
            tabPage1.Margin = new Padding(3, 4, 3, 4);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3, 4, 3, 4);
            tabPage1.Size = new Size(1416, 822);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Control";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(comboBox1);
            groupBox4.Controls.Add(button1);
            groupBox4.Location = new Point(6, 8);
            groupBox4.Margin = new Padding(3, 4, 3, 4);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(3, 4, 3, 4);
            groupBox4.Size = new Size(499, 133);
            groupBox4.TabIndex = 1;
            groupBox4.TabStop = false;
            groupBox4.Text = "Single Copy";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(183, 50);
            comboBox1.Margin = new Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(292, 28);
            comboBox1.TabIndex = 2;
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Segoe UI", 9F);
            button1.ImageAlign = ContentAlignment.TopCenter;
            button1.ImageKey = "icon_Start.png";
            button1.ImageList = imageListHighQualityIcons;
            button1.Location = new Point(34, 29);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(115, 67);
            button1.TabIndex = 1;
            button1.Text = "Start Job";
            button1.TextAlign = ContentAlignment.BottomCenter;
            button1.UseVisualStyleBackColor = true;
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
            // tabPage2
            // 
            tabPage2.BackColor = Color.Silver;
            tabPage2.Controls.Add(label9);
            tabPage2.Controls.Add(groupBox3);
            tabPage2.Controls.Add(panel5);
            tabPage2.Controls.Add(groupBox2);
            tabPage2.Controls.Add(groupBox1);
            tabPage2.ForeColor = SystemColors.ActiveCaptionText;
            tabPage2.Location = new Point(4, 29);
            tabPage2.Margin = new Padding(3, 4, 3, 4);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3, 4, 3, 4);
            tabPage2.Size = new Size(1416, 822);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Job Editor";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 32F, FontStyle.Bold);
            label9.Location = new Point(171, 176);
            label9.Name = "label9";
            label9.Size = new Size(337, 72);
            label9.TabIndex = 31;
            label9.Text = "JOB EDITOR";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(richTextBoxJobDescription);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(panel4);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(textBoxJobName);
            groupBox3.Location = new Point(7, 255);
            groupBox3.Margin = new Padding(3, 4, 3, 4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 4, 3, 4);
            groupBox3.Size = new Size(686, 305);
            groupBox3.TabIndex = 30;
            groupBox3.TabStop = false;
            groupBox3.Text = "General";
            // 
            // richTextBoxJobDescription
            // 
            richTextBoxJobDescription.Location = new Point(7, 108);
            richTextBoxJobDescription.Margin = new Padding(3, 4, 3, 4);
            richTextBoxJobDescription.Name = "richTextBoxJobDescription";
            richTextBoxJobDescription.Size = new Size(671, 77);
            richTextBoxJobDescription.TabIndex = 58;
            richTextBoxJobDescription.Text = "";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(7, 84);
            label10.Name = "label10";
            label10.Size = new Size(112, 20);
            label10.TabIndex = 57;
            label10.Text = "Job Description";
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(groupBoxProtocol);
            panel4.Controls.Add(checkBoxArchive);
            panel4.Location = new Point(5, 195);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(674, 102);
            panel4.TabIndex = 55;
            // 
            // groupBoxProtocol
            // 
            groupBoxProtocol.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxProtocol.BackColor = Color.Silver;
            groupBoxProtocol.Controls.Add(radioButtonGz);
            groupBoxProtocol.Controls.Add(radioButtonRar);
            groupBoxProtocol.Controls.Add(radioButton7z);
            groupBoxProtocol.Controls.Add(radioButtonZip);
            groupBoxProtocol.FlatStyle = FlatStyle.Flat;
            groupBoxProtocol.Location = new Point(170, 7);
            groupBoxProtocol.Margin = new Padding(3, 4, 3, 4);
            groupBoxProtocol.Name = "groupBoxProtocol";
            groupBoxProtocol.Padding = new Padding(3, 4, 3, 4);
            groupBoxProtocol.Size = new Size(494, 76);
            groupBoxProtocol.TabIndex = 2;
            groupBoxProtocol.TabStop = false;
            groupBoxProtocol.Text = "Format";
            // 
            // radioButtonGz
            // 
            radioButtonGz.AutoSize = true;
            radioButtonGz.Location = new Point(185, 28);
            radioButtonGz.Margin = new Padding(3, 4, 3, 4);
            radioButtonGz.Name = "radioButtonGz";
            radioButtonGz.Size = new Size(49, 24);
            radioButtonGz.TabIndex = 3;
            radioButtonGz.TabStop = true;
            radioButtonGz.Text = ".gz";
            radioButtonGz.UseVisualStyleBackColor = true;
            // 
            // radioButtonRar
            // 
            radioButtonRar.AutoSize = true;
            radioButtonRar.Location = new Point(63, 29);
            radioButtonRar.Margin = new Padding(3, 4, 3, 4);
            radioButtonRar.Name = "radioButtonRar";
            radioButtonRar.Size = new Size(51, 24);
            radioButtonRar.TabIndex = 2;
            radioButtonRar.TabStop = true;
            radioButtonRar.Text = ".rar";
            radioButtonRar.UseVisualStyleBackColor = true;
            // 
            // radioButton7z
            // 
            radioButton7z.AutoSize = true;
            radioButton7z.Location = new Point(120, 29);
            radioButton7z.Margin = new Padding(3, 4, 3, 4);
            radioButton7z.Name = "radioButton7z";
            radioButton7z.Size = new Size(48, 24);
            radioButton7z.TabIndex = 1;
            radioButton7z.TabStop = true;
            radioButton7z.Text = ".7z";
            radioButton7z.UseVisualStyleBackColor = true;
            // 
            // radioButtonZip
            // 
            radioButtonZip.AutoSize = true;
            radioButtonZip.Location = new Point(7, 29);
            radioButtonZip.Margin = new Padding(3, 4, 3, 4);
            radioButtonZip.Name = "radioButtonZip";
            radioButtonZip.Size = new Size(53, 24);
            radioButtonZip.TabIndex = 0;
            radioButtonZip.TabStop = true;
            radioButtonZip.Text = ".zip";
            radioButtonZip.UseVisualStyleBackColor = true;
            // 
            // checkBoxArchive
            // 
            checkBoxArchive.AutoSize = true;
            checkBoxArchive.Location = new Point(31, 36);
            checkBoxArchive.Margin = new Padding(3, 4, 3, 4);
            checkBoxArchive.Name = "checkBoxArchive";
            checkBoxArchive.Size = new Size(80, 24);
            checkBoxArchive.TabIndex = 54;
            checkBoxArchive.Text = "Archive";
            checkBoxArchive.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(7, 25);
            label11.Name = "label11";
            label11.Size = new Size(76, 20);
            label11.TabIndex = 53;
            label11.Text = "Job Name";
            // 
            // textBoxJobName
            // 
            textBoxJobName.Location = new Point(7, 49);
            textBoxJobName.Margin = new Padding(3, 4, 3, 4);
            textBoxJobName.Name = "textBoxJobName";
            textBoxJobName.Size = new Size(671, 27);
            textBoxJobName.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(buttonOpenJobFolder);
            panel5.Controls.Add(buttonNewJob);
            panel5.Controls.Add(buttonDeleteJob);
            panel5.Controls.Add(buttonEditJob);
            panel5.Controls.Add(buttonSaveJob);
            panel5.Controls.Add(label12);
            panel5.Controls.Add(comboBoxJobSelection);
            panel5.Location = new Point(7, 20);
            panel5.Margin = new Padding(3, 4, 3, 4);
            panel5.Name = "panel5";
            panel5.Size = new Size(685, 147);
            panel5.TabIndex = 29;
            // 
            // buttonOpenJobFolder
            // 
            buttonOpenJobFolder.Cursor = Cursors.Hand;
            buttonOpenJobFolder.Font = new Font("Segoe UI", 9F);
            buttonOpenJobFolder.ImageAlign = ContentAlignment.TopCenter;
            buttonOpenJobFolder.ImageIndex = 13;
            buttonOpenJobFolder.ImageList = imageListIcons;
            buttonOpenJobFolder.Location = new Point(543, 75);
            buttonOpenJobFolder.Margin = new Padding(3, 4, 3, 4);
            buttonOpenJobFolder.Name = "buttonOpenJobFolder";
            buttonOpenJobFolder.Size = new Size(126, 57);
            buttonOpenJobFolder.TabIndex = 7;
            buttonOpenJobFolder.Text = "Open Job Folder";
            buttonOpenJobFolder.TextAlign = ContentAlignment.BottomCenter;
            buttonOpenJobFolder.UseVisualStyleBackColor = true;
            buttonOpenJobFolder.Click += buttonOpenJobFolder_Click;
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
            // buttonNewJob
            // 
            buttonNewJob.Cursor = Cursors.Hand;
            buttonNewJob.ImageAlign = ContentAlignment.TopCenter;
            buttonNewJob.ImageIndex = 6;
            buttonNewJob.ImageList = imageListIcons;
            buttonNewJob.Location = new Point(15, 75);
            buttonNewJob.Margin = new Padding(3, 4, 3, 4);
            buttonNewJob.Name = "buttonNewJob";
            buttonNewJob.Size = new Size(126, 57);
            buttonNewJob.TabIndex = 6;
            buttonNewJob.Text = "New Job";
            buttonNewJob.TextAlign = ContentAlignment.BottomCenter;
            buttonNewJob.UseVisualStyleBackColor = true;
            buttonNewJob.Click += buttonNewJob_Click;
            // 
            // buttonDeleteJob
            // 
            buttonDeleteJob.Cursor = Cursors.Hand;
            buttonDeleteJob.Font = new Font("Segoe UI", 9F);
            buttonDeleteJob.ImageAlign = ContentAlignment.TopCenter;
            buttonDeleteJob.ImageIndex = 3;
            buttonDeleteJob.ImageList = imageListIcons;
            buttonDeleteJob.Location = new Point(413, 75);
            buttonDeleteJob.Margin = new Padding(3, 4, 3, 4);
            buttonDeleteJob.Name = "buttonDeleteJob";
            buttonDeleteJob.Size = new Size(126, 57);
            buttonDeleteJob.TabIndex = 5;
            buttonDeleteJob.Text = "Delete Job";
            buttonDeleteJob.TextAlign = ContentAlignment.BottomCenter;
            buttonDeleteJob.UseVisualStyleBackColor = true;
            buttonDeleteJob.Click += buttonDeleteJob_Click;
            // 
            // buttonEditJob
            // 
            buttonEditJob.Cursor = Cursors.Hand;
            buttonEditJob.Font = new Font("Segoe UI", 9F);
            buttonEditJob.ImageAlign = ContentAlignment.TopCenter;
            buttonEditJob.ImageIndex = 16;
            buttonEditJob.ImageList = imageListIcons;
            buttonEditJob.Location = new Point(280, 75);
            buttonEditJob.Margin = new Padding(3, 4, 3, 4);
            buttonEditJob.Name = "buttonEditJob";
            buttonEditJob.Size = new Size(126, 57);
            buttonEditJob.TabIndex = 4;
            buttonEditJob.Text = "Edit Job";
            buttonEditJob.TextAlign = ContentAlignment.BottomCenter;
            buttonEditJob.UseVisualStyleBackColor = true;
            buttonEditJob.Click += buttonEditJob_Click;
            // 
            // buttonSaveJob
            // 
            buttonSaveJob.Cursor = Cursors.Hand;
            buttonSaveJob.ImageAlign = ContentAlignment.TopCenter;
            buttonSaveJob.ImageIndex = 15;
            buttonSaveJob.ImageList = imageListIcons;
            buttonSaveJob.Location = new Point(147, 75);
            buttonSaveJob.Margin = new Padding(3, 4, 3, 4);
            buttonSaveJob.Name = "buttonSaveJob";
            buttonSaveJob.Size = new Size(126, 57);
            buttonSaveJob.TabIndex = 2;
            buttonSaveJob.Text = "Save Job";
            buttonSaveJob.TextAlign = ContentAlignment.BottomCenter;
            buttonSaveJob.UseVisualStyleBackColor = true;
            buttonSaveJob.Click += buttonSaveJob_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 10F);
            label12.Location = new Point(264, 0);
            label12.Name = "label12";
            label12.Size = new Size(109, 23);
            label12.TabIndex = 1;
            label12.Text = "Job Manager";
            // 
            // comboBoxJobSelection
            // 
            comboBoxJobSelection.FormattingEnabled = true;
            comboBoxJobSelection.Location = new Point(3, 36);
            comboBoxJobSelection.Margin = new Padding(3, 4, 3, 4);
            comboBoxJobSelection.Name = "comboBoxJobSelection";
            comboBoxJobSelection.Size = new Size(676, 28);
            comboBoxJobSelection.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(panel3);
            groupBox2.Controls.Add(buttonSelectSourcePath);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(textBoxSourcePath);
            groupBox2.Location = new Point(722, 8);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(686, 801);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Source";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(9, 107);
            label7.Name = "label7";
            label7.Size = new Size(76, 20);
            label7.TabIndex = 59;
            label7.Text = "Exclusions";
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(button4);
            panel3.Controls.Add(flowLayoutPanel1);
            panel3.Controls.Add(button15);
            panel3.Controls.Add(button3);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(textBoxExclusionPath);
            panel3.Controls.Add(label6);
            panel3.Location = new Point(5, 131);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(674, 662);
            panel3.TabIndex = 58;
            // 
            // button4
            // 
            button4.Cursor = Cursors.Hand;
            button4.Font = new Font("Segoe UI", 9F);
            button4.ImageAlign = ContentAlignment.TopCenter;
            button4.ImageKey = "icon_delete.png";
            button4.ImageList = imageListHighQualityIcons;
            button4.Location = new Point(551, 21);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(118, 63);
            button4.TabIndex = 61;
            button4.Text = "Delete All";
            button4.TextAlign = ContentAlignment.BottomCenter;
            button4.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BorderStyle = BorderStyle.Fixed3D;
            flowLayoutPanel1.Location = new Point(3, 91);
            flowLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(665, 564);
            flowLayoutPanel1.TabIndex = 60;
            // 
            // button15
            // 
            button15.Cursor = Cursors.Hand;
            button15.Font = new Font("Segoe UI", 9F);
            button15.ImageAlign = ContentAlignment.TopCenter;
            button15.ImageKey = "icon_create.png";
            button15.ImageList = imageListHighQualityIcons;
            button15.Location = new Point(427, 21);
            button15.Margin = new Padding(3, 4, 3, 4);
            button15.Name = "button15";
            button15.Size = new Size(118, 63);
            button15.TabIndex = 59;
            button15.Text = "Create Exclusion";
            button15.TextAlign = ContentAlignment.BottomCenter;
            button15.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(389, 49);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(32, 35);
            button3.TabIndex = 58;
            button3.Text = "🔍";
            button3.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 28);
            label5.Name = "label5";
            label5.Size = new Size(114, 20);
            label5.TabIndex = 55;
            label5.Text = "Directory Name";
            // 
            // textBoxExclusionPath
            // 
            textBoxExclusionPath.Location = new Point(3, 52);
            textBoxExclusionPath.Margin = new Padding(3, 4, 3, 4);
            textBoxExclusionPath.Name = "textBoxExclusionPath";
            textBoxExclusionPath.Size = new Size(378, 27);
            textBoxExclusionPath.TabIndex = 54;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(49, 48);
            label6.Name = "label6";
            label6.Size = new Size(50, 20);
            label6.TabIndex = 0;
            label6.Text = "label6";
            // 
            // buttonSelectSourcePath
            // 
            buttonSelectSourcePath.Location = new Point(647, 47);
            buttonSelectSourcePath.Margin = new Padding(3, 4, 3, 4);
            buttonSelectSourcePath.Name = "buttonSelectSourcePath";
            buttonSelectSourcePath.Size = new Size(32, 35);
            buttonSelectSourcePath.TabIndex = 57;
            buttonSelectSourcePath.Text = "🔍";
            buttonSelectSourcePath.UseVisualStyleBackColor = true;
            buttonSelectSourcePath.Click += buttonSelectSourcePath_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(7, 25);
            label4.Name = "label4";
            label4.Size = new Size(86, 20);
            label4.TabIndex = 56;
            label4.Text = "Source Path";
            // 
            // textBoxSourcePath
            // 
            textBoxSourcePath.Location = new Point(7, 49);
            textBoxSourcePath.Margin = new Padding(3, 4, 3, 4);
            textBoxSourcePath.Name = "textBoxSourcePath";
            textBoxSourcePath.Size = new Size(636, 27);
            textBoxSourcePath.TabIndex = 54;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(panel2);
            groupBox1.Controls.Add(checkBoxCreateSubdirectory);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBoxDestinationPath);
            groupBox1.Controls.Add(buttonSelectDestinationPath);
            groupBox1.Location = new Point(7, 568);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(686, 241);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Destination";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(checkBoxUseSourcedirectoryName);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(textBoxSubdirectoryName);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(5, 131);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(674, 102);
            panel2.TabIndex = 55;
            // 
            // checkBoxUseSourcedirectoryName
            // 
            checkBoxUseSourcedirectoryName.AutoSize = true;
            checkBoxUseSourcedirectoryName.Location = new Point(408, 43);
            checkBoxUseSourcedirectoryName.Margin = new Padding(3, 4, 3, 4);
            checkBoxUseSourcedirectoryName.Name = "checkBoxUseSourcedirectoryName";
            checkBoxUseSourcedirectoryName.Size = new Size(207, 24);
            checkBoxUseSourcedirectoryName.TabIndex = 56;
            checkBoxUseSourcedirectoryName.Text = "Use Sourcedirectory Name";
            checkBoxUseSourcedirectoryName.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 16);
            label3.Name = "label3";
            label3.Size = new Size(114, 20);
            label3.TabIndex = 55;
            label3.Text = "Directory Name";
            // 
            // textBoxSubdirectoryName
            // 
            textBoxSubdirectoryName.Location = new Point(3, 40);
            textBoxSubdirectoryName.Margin = new Padding(3, 4, 3, 4);
            textBoxSubdirectoryName.Name = "textBoxSubdirectoryName";
            textBoxSubdirectoryName.Size = new Size(321, 27);
            textBoxSubdirectoryName.TabIndex = 54;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(49, 36);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 0;
            label2.Text = "label2";
            // 
            // checkBoxCreateSubdirectory
            // 
            checkBoxCreateSubdirectory.AutoSize = true;
            checkBoxCreateSubdirectory.Location = new Point(7, 101);
            checkBoxCreateSubdirectory.Margin = new Padding(3, 4, 3, 4);
            checkBoxCreateSubdirectory.Name = "checkBoxCreateSubdirectory";
            checkBoxCreateSubdirectory.Size = new Size(162, 24);
            checkBoxCreateSubdirectory.TabIndex = 54;
            checkBoxCreateSubdirectory.Text = "Create Subdirectory";
            checkBoxCreateSubdirectory.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 25);
            label1.Name = "label1";
            label1.Size = new Size(117, 20);
            label1.TabIndex = 53;
            label1.Text = "Destination Path";
            // 
            // textBoxDestinationPath
            // 
            textBoxDestinationPath.Location = new Point(7, 49);
            textBoxDestinationPath.Margin = new Padding(3, 4, 3, 4);
            textBoxDestinationPath.Name = "textBoxDestinationPath";
            textBoxDestinationPath.Size = new Size(636, 27);
            textBoxDestinationPath.TabIndex = 0;
            // 
            // buttonSelectDestinationPath
            // 
            buttonSelectDestinationPath.Location = new Point(647, 47);
            buttonSelectDestinationPath.Margin = new Padding(3, 4, 3, 4);
            buttonSelectDestinationPath.Name = "buttonSelectDestinationPath";
            buttonSelectDestinationPath.Size = new Size(32, 35);
            buttonSelectDestinationPath.TabIndex = 52;
            buttonSelectDestinationPath.Text = "🔍";
            buttonSelectDestinationPath.UseVisualStyleBackColor = true;
            buttonSelectDestinationPath.Click += buttonSelectDestinationPath_Click;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(label8);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Margin = new Padding(3, 4, 3, 4);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(1416, 822);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Schedule Editor";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 90F);
            label8.Location = new Point(531, 273);
            label8.Name = "label8";
            label8.Size = new Size(351, 199);
            label8.TabIndex = 0;
            label8.Text = "N/A";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(1451, 907);
            Controls.Add(tabControl1);
            Controls.Add(menuStrip1);
            ForeColor = SystemColors.ControlDarkDark;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "MainForm";
            Text = "AutoBak 2 [0.0.1]";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            groupBoxProtocol.ResumeLayout(false);
            groupBoxProtocol.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem optionsToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private ToolStripMenuItem addInstanceToolStripMenuItem;
        private ToolStripMenuItem deleteInstanceToolStripMenuItem;
        private ToolStripMenuItem stopAllInstancesToolStripMenuItem;
        private ToolStripMenuItem importToolStripMenuItem;
        private ToolStripMenuItem exportToolStripMenuItem;
        private ToolStripMenuItem showHelpWindowToolStripMenuItem;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private ToolStripMenuItem visitWebsiteToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem openConfigfolderToolStripMenuItem;
        private TextBox textBoxDestinationPath;
        private Button buttonSelectDestinationPath;
        private ImageList imageListIcons;
        private ImageList imageListHighQualityIcons;
        private Button button1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label1;
        private Panel panel2;
        private CheckBox checkBoxCreateSubdirectory;
        private CheckBox checkBoxUseSourcedirectoryName;
        private Label label3;
        private TextBox textBoxSubdirectoryName;
        private Label label2;
        private Label label4;
        private TextBox textBoxSourcePath;
        private Button buttonSelectSourcePath;
        private Label label7;
        private Panel panel3;
        private Button button15;
        private Button button3;
        private Label label5;
        private TextBox textBoxExclusionPath;
        private Label label6;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button button4;
        private TabPage tabPage3;
        private Label label8;
        private Panel panel5;
        private Button buttonDeleteJob;
        private Button buttonEditJob;
        private Button buttonSaveJob;
        private Label label12;
        private ComboBox comboBoxJobSelection;
        private Button buttonOpenJobFolder;
        private Button buttonNewJob;
        private GroupBox groupBox3;
        private Panel panel4;
        private CheckBox checkBoxArchive;
        private Label label11;
        private TextBox textBoxJobName;
        private GroupBox groupBoxProtocol;
        private RadioButton radioButtonGz;
        private RadioButton radioButtonRar;
        private RadioButton radioButton7z;
        private RadioButton radioButtonZip;
        private Label label9;
        private GroupBox groupBox4;
        private ComboBox comboBox1;
        private RichTextBox richTextBoxJobDescription;
        private Label label10;
    }
}
