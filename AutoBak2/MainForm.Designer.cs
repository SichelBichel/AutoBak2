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
            tabPage2 = new TabPage();
            textBox1 = new TextBox();
            imageListIcons = new ImageList(components);
            buttonSelectScheduleTask = new Button();
            imageListHighQualityIcons = new ImageList(components);
            button1 = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            label1 = new Label();
            checkBox1 = new CheckBox();
            panel2 = new Panel();
            label2 = new Label();
            label3 = new Label();
            textBox3 = new TextBox();
            checkBox2 = new CheckBox();
            label4 = new Label();
            textBox2 = new TextBox();
            button2 = new Button();
            panel3 = new Panel();
            label5 = new Label();
            textBox4 = new TextBox();
            label6 = new Label();
            button3 = new Button();
            label7 = new Label();
            button15 = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            button4 = new Button();
            tabPage3 = new TabPage();
            label8 = new Label();
            panel5 = new Panel();
            button8 = new Button();
            button10 = new Button();
            label12 = new Label();
            comboBoxFirewallPreset = new ComboBox();
            button6 = new Button();
            button5 = new Button();
            button7 = new Button();
            groupBox3 = new GroupBox();
            panel4 = new Panel();
            checkBox4 = new CheckBox();
            label11 = new Label();
            textBox6 = new TextBox();
            groupBoxProtocol = new GroupBox();
            radioButtonTCPandUDP = new RadioButton();
            radioButtonUDP = new RadioButton();
            radioButtonTCP = new RadioButton();
            radioButton1 = new RadioButton();
            label9 = new Label();
            groupBox4 = new GroupBox();
            comboBox1 = new ComboBox();
            label10 = new Label();
            richTextBox1 = new RichTextBox();
            menuStrip1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            tabPage3.SuspendLayout();
            panel5.SuspendLayout();
            groupBox3.SuspendLayout();
            panel4.SuspendLayout();
            groupBoxProtocol.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.ControlDarkDark;
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, optionsToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1270, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addInstanceToolStripMenuItem, deleteInstanceToolStripMenuItem, stopAllInstancesToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            fileToolStripMenuItem.Click += fileToolStripMenuItem_Click;
            // 
            // addInstanceToolStripMenuItem
            // 
            addInstanceToolStripMenuItem.Name = "addInstanceToolStripMenuItem";
            addInstanceToolStripMenuItem.Size = new Size(180, 22);
            addInstanceToolStripMenuItem.Text = "Add Instance";
            // 
            // deleteInstanceToolStripMenuItem
            // 
            deleteInstanceToolStripMenuItem.Name = "deleteInstanceToolStripMenuItem";
            deleteInstanceToolStripMenuItem.Size = new Size(180, 22);
            deleteInstanceToolStripMenuItem.Text = "Delete Instance";
            // 
            // stopAllInstancesToolStripMenuItem
            // 
            stopAllInstancesToolStripMenuItem.Name = "stopAllInstancesToolStripMenuItem";
            stopAllInstancesToolStripMenuItem.Size = new Size(180, 22);
            stopAllInstancesToolStripMenuItem.Text = "Stop All Instances";
            // 
            // optionsToolStripMenuItem
            // 
            optionsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { importToolStripMenuItem, exportToolStripMenuItem, openConfigfolderToolStripMenuItem });
            optionsToolStripMenuItem.ForeColor = SystemColors.ActiveCaptionText;
            optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            optionsToolStripMenuItem.Size = new Size(55, 20);
            optionsToolStripMenuItem.Text = "Config";
            optionsToolStripMenuItem.Click += optionsToolStripMenuItem_Click;
            // 
            // importToolStripMenuItem
            // 
            importToolStripMenuItem.Name = "importToolStripMenuItem";
            importToolStripMenuItem.Size = new Size(180, 22);
            importToolStripMenuItem.Text = "Import";
            // 
            // exportToolStripMenuItem
            // 
            exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            exportToolStripMenuItem.Size = new Size(180, 22);
            exportToolStripMenuItem.Text = "Export";
            // 
            // openConfigfolderToolStripMenuItem
            // 
            openConfigfolderToolStripMenuItem.Name = "openConfigfolderToolStripMenuItem";
            openConfigfolderToolStripMenuItem.Size = new Size(180, 22);
            openConfigfolderToolStripMenuItem.Text = "Open Configfolder";
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { showHelpWindowToolStripMenuItem, settingsToolStripMenuItem, visitWebsiteToolStripMenuItem, aboutToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(44, 20);
            helpToolStripMenuItem.Text = "Help";
            // 
            // showHelpWindowToolStripMenuItem
            // 
            showHelpWindowToolStripMenuItem.Name = "showHelpWindowToolStripMenuItem";
            showHelpWindowToolStripMenuItem.Size = new Size(180, 22);
            showHelpWindowToolStripMenuItem.Text = "Show Help Window";
            // 
            // settingsToolStripMenuItem
            // 
            settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            settingsToolStripMenuItem.Size = new Size(180, 22);
            settingsToolStripMenuItem.Text = "Settings";
            // 
            // visitWebsiteToolStripMenuItem
            // 
            visitWebsiteToolStripMenuItem.Name = "visitWebsiteToolStripMenuItem";
            visitWebsiteToolStripMenuItem.Size = new Size(180, 22);
            visitWebsiteToolStripMenuItem.Text = "Visit Website";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(180, 22);
            aboutToolStripMenuItem.Text = "About";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(12, 27);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1246, 641);
            tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.Silver;
            tabPage1.Controls.Add(groupBox4);
            tabPage1.ForeColor = SystemColors.ActiveCaptionText;
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1238, 613);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Control";
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
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1238, 613);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Job Editor";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(6, 37);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(557, 23);
            textBox1.TabIndex = 0;
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
            // buttonSelectScheduleTask
            // 
            buttonSelectScheduleTask.Location = new Point(566, 35);
            buttonSelectScheduleTask.Name = "buttonSelectScheduleTask";
            buttonSelectScheduleTask.Size = new Size(28, 26);
            buttonSelectScheduleTask.TabIndex = 52;
            buttonSelectScheduleTask.Text = "🔍";
            buttonSelectScheduleTask.UseVisualStyleBackColor = true;
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
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Segoe UI", 9F);
            button1.ImageAlign = ContentAlignment.TopCenter;
            button1.ImageKey = "icon_Start.png";
            button1.ImageList = imageListHighQualityIcons;
            button1.Location = new Point(30, 22);
            button1.Name = "button1";
            button1.Size = new Size(101, 50);
            button1.TabIndex = 1;
            button1.Text = "Start Job";
            button1.TextAlign = ContentAlignment.BottomCenter;
            button1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(panel2);
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(buttonSelectScheduleTask);
            groupBox1.Location = new Point(6, 426);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(600, 181);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Destination";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(panel3);
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(textBox2);
            groupBox2.Location = new Point(632, 6);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(600, 601);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Source";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 19);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 53;
            label1.Text = "Target Path";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(6, 76);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(130, 19);
            checkBox1.TabIndex = 54;
            checkBox1.Text = "Create Subdirectory";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(checkBox2);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(textBox3);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(4, 98);
            panel2.Name = "panel2";
            panel2.Size = new Size(590, 77);
            panel2.TabIndex = 55;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 27);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 0;
            label2.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 12);
            label3.Name = "label3";
            label3.Size = new Size(90, 15);
            label3.TabIndex = 55;
            label3.Text = "Directory Name";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(3, 30);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(281, 23);
            textBox3.TabIndex = 54;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(357, 32);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(166, 19);
            checkBox2.TabIndex = 56;
            checkBox2.Text = "Use Sourcedirectory Name";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 19);
            label4.Name = "label4";
            label4.Size = new Size(70, 15);
            label4.TabIndex = 56;
            label4.Text = "Source Path";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(6, 37);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(557, 23);
            textBox2.TabIndex = 54;
            // 
            // button2
            // 
            button2.Location = new Point(566, 35);
            button2.Name = "button2";
            button2.Size = new Size(28, 26);
            button2.TabIndex = 57;
            button2.Text = "🔍";
            button2.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(button4);
            panel3.Controls.Add(flowLayoutPanel1);
            panel3.Controls.Add(button15);
            panel3.Controls.Add(button3);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(textBox4);
            panel3.Controls.Add(label6);
            panel3.Location = new Point(4, 98);
            panel3.Name = "panel3";
            panel3.Size = new Size(590, 497);
            panel3.TabIndex = 58;
            panel3.Paint += this.panel3_Paint;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 21);
            label5.Name = "label5";
            label5.Size = new Size(90, 15);
            label5.TabIndex = 55;
            label5.Text = "Directory Name";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(3, 39);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(331, 23);
            textBox4.TabIndex = 54;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(43, 36);
            label6.Name = "label6";
            label6.Size = new Size(38, 15);
            label6.TabIndex = 0;
            label6.Text = "label6";
            // 
            // button3
            // 
            button3.Location = new Point(340, 37);
            button3.Name = "button3";
            button3.Size = new Size(28, 26);
            button3.TabIndex = 58;
            button3.Text = "🔍";
            button3.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(8, 80);
            label7.Name = "label7";
            label7.Size = new Size(62, 15);
            label7.TabIndex = 59;
            label7.Text = "Exclusions";
            // 
            // button15
            // 
            button15.Cursor = Cursors.Hand;
            button15.Font = new Font("Segoe UI", 9F);
            button15.ImageAlign = ContentAlignment.TopCenter;
            button15.ImageKey = "icon_create.png";
            button15.ImageList = imageListHighQualityIcons;
            button15.Location = new Point(374, 16);
            button15.Name = "button15";
            button15.Size = new Size(103, 47);
            button15.TabIndex = 59;
            button15.Text = "Create Exclusion";
            button15.TextAlign = ContentAlignment.BottomCenter;
            button15.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BorderStyle = BorderStyle.Fixed3D;
            flowLayoutPanel1.Location = new Point(3, 68);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(582, 424);
            flowLayoutPanel1.TabIndex = 60;
            // 
            // button4
            // 
            button4.Cursor = Cursors.Hand;
            button4.Font = new Font("Segoe UI", 9F);
            button4.ImageAlign = ContentAlignment.TopCenter;
            button4.ImageKey = "icon_delete.png";
            button4.ImageList = imageListHighQualityIcons;
            button4.Location = new Point(482, 16);
            button4.Name = "button4";
            button4.Size = new Size(103, 47);
            button4.TabIndex = 61;
            button4.Text = "Delete All";
            button4.TextAlign = ContentAlignment.BottomCenter;
            button4.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(label8);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(1238, 613);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Schedule Editor";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 90F);
            label8.Location = new Point(465, 205);
            label8.Name = "label8";
            label8.Size = new Size(281, 159);
            label8.TabIndex = 0;
            label8.Text = "N/A";
            // 
            // panel5
            // 
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(button7);
            panel5.Controls.Add(button5);
            panel5.Controls.Add(button6);
            panel5.Controls.Add(button8);
            panel5.Controls.Add(button10);
            panel5.Controls.Add(label12);
            panel5.Controls.Add(comboBoxFirewallPreset);
            panel5.Location = new Point(6, 15);
            panel5.Name = "panel5";
            panel5.Size = new Size(600, 111);
            panel5.TabIndex = 29;
            // 
            // button8
            // 
            button8.Cursor = Cursors.Hand;
            button8.Font = new Font("Segoe UI", 9F);
            button8.ImageAlign = ContentAlignment.TopCenter;
            button8.ImageIndex = 16;
            button8.ImageList = imageListIcons;
            button8.Location = new Point(245, 56);
            button8.Name = "button8";
            button8.Size = new Size(110, 43);
            button8.TabIndex = 4;
            button8.Text = "Edit Job";
            button8.TextAlign = ContentAlignment.BottomCenter;
            button8.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            button10.Cursor = Cursors.Hand;
            button10.ImageAlign = ContentAlignment.TopCenter;
            button10.ImageIndex = 15;
            button10.ImageList = imageListIcons;
            button10.Location = new Point(129, 56);
            button10.Name = "button10";
            button10.Size = new Size(110, 43);
            button10.TabIndex = 2;
            button10.Text = "Save Job";
            button10.TextAlign = ContentAlignment.BottomCenter;
            button10.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 10F);
            label12.Location = new Point(231, 0);
            label12.Name = "label12";
            label12.Size = new Size(89, 19);
            label12.TabIndex = 1;
            label12.Text = "Job Manager";
            // 
            // comboBoxFirewallPreset
            // 
            comboBoxFirewallPreset.FormattingEnabled = true;
            comboBoxFirewallPreset.Location = new Point(3, 27);
            comboBoxFirewallPreset.Name = "comboBoxFirewallPreset";
            comboBoxFirewallPreset.Size = new Size(592, 23);
            comboBoxFirewallPreset.TabIndex = 0;
            // 
            // button6
            // 
            button6.Cursor = Cursors.Hand;
            button6.Font = new Font("Segoe UI", 9F);
            button6.ImageAlign = ContentAlignment.TopCenter;
            button6.ImageIndex = 3;
            button6.ImageList = imageListIcons;
            button6.Location = new Point(361, 56);
            button6.Name = "button6";
            button6.Size = new Size(110, 43);
            button6.TabIndex = 5;
            button6.Text = "Delete Job";
            button6.TextAlign = ContentAlignment.BottomCenter;
            button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Cursor = Cursors.Hand;
            button5.ImageAlign = ContentAlignment.TopCenter;
            button5.ImageIndex = 6;
            button5.ImageList = imageListIcons;
            button5.Location = new Point(13, 56);
            button5.Name = "button5";
            button5.Size = new Size(110, 43);
            button5.TabIndex = 6;
            button5.Text = "New Job";
            button5.TextAlign = ContentAlignment.BottomCenter;
            button5.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Cursor = Cursors.Hand;
            button7.Font = new Font("Segoe UI", 9F);
            button7.ImageAlign = ContentAlignment.TopCenter;
            button7.ImageIndex = 13;
            button7.ImageList = imageListIcons;
            button7.Location = new Point(475, 56);
            button7.Name = "button7";
            button7.Size = new Size(110, 43);
            button7.TabIndex = 7;
            button7.Text = "Open Job Folder";
            button7.TextAlign = ContentAlignment.BottomCenter;
            button7.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(richTextBox1);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(panel4);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(textBox6);
            groupBox3.Location = new Point(6, 191);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(600, 229);
            groupBox3.TabIndex = 30;
            groupBox3.TabStop = false;
            groupBox3.Text = "General";
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(groupBoxProtocol);
            panel4.Controls.Add(checkBox4);
            panel4.Location = new Point(4, 146);
            panel4.Name = "panel4";
            panel4.Size = new Size(590, 77);
            panel4.TabIndex = 55;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(27, 27);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(66, 19);
            checkBox4.TabIndex = 54;
            checkBox4.Text = "Archive";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(6, 19);
            label11.Name = "label11";
            label11.Size = new Size(60, 15);
            label11.TabIndex = 53;
            label11.Text = "Job Name";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(6, 37);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(588, 23);
            textBox6.TabIndex = 0;
            // 
            // groupBoxProtocol
            // 
            groupBoxProtocol.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxProtocol.BackColor = Color.Silver;
            groupBoxProtocol.Controls.Add(radioButton1);
            groupBoxProtocol.Controls.Add(radioButtonTCPandUDP);
            groupBoxProtocol.Controls.Add(radioButtonUDP);
            groupBoxProtocol.Controls.Add(radioButtonTCP);
            groupBoxProtocol.FlatStyle = FlatStyle.Flat;
            groupBoxProtocol.Location = new Point(149, 5);
            groupBoxProtocol.Name = "groupBoxProtocol";
            groupBoxProtocol.Size = new Size(432, 57);
            groupBoxProtocol.TabIndex = 2;
            groupBoxProtocol.TabStop = false;
            groupBoxProtocol.Text = "Format";
            groupBoxProtocol.Enter += this.groupBoxProtocol_Enter;
            // 
            // radioButtonTCPandUDP
            // 
            radioButtonTCPandUDP.AutoSize = true;
            radioButtonTCPandUDP.Location = new Point(57, 22);
            radioButtonTCPandUDP.Name = "radioButtonTCPandUDP";
            radioButtonTCPandUDP.Size = new Size(42, 19);
            radioButtonTCPandUDP.TabIndex = 2;
            radioButtonTCPandUDP.TabStop = true;
            radioButtonTCPandUDP.Text = ".rar";
            radioButtonTCPandUDP.UseVisualStyleBackColor = true;
            // 
            // radioButtonUDP
            // 
            radioButtonUDP.AutoSize = true;
            radioButtonUDP.Location = new Point(105, 22);
            radioButtonUDP.Name = "radioButtonUDP";
            radioButtonUDP.Size = new Size(39, 19);
            radioButtonUDP.TabIndex = 1;
            radioButtonUDP.TabStop = true;
            radioButtonUDP.Text = ".7z";
            radioButtonUDP.UseVisualStyleBackColor = true;
            // 
            // radioButtonTCP
            // 
            radioButtonTCP.AutoSize = true;
            radioButtonTCP.Location = new Point(6, 22);
            radioButtonTCP.Name = "radioButtonTCP";
            radioButtonTCP.Size = new Size(43, 19);
            radioButtonTCP.TabIndex = 0;
            radioButtonTCP.TabStop = true;
            radioButtonTCP.Text = ".zip";
            radioButtonTCP.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(162, 21);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(40, 19);
            radioButton1.TabIndex = 3;
            radioButton1.TabStop = true;
            radioButton1.Text = ".gz";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 32F, FontStyle.Bold);
            label9.Location = new Point(150, 132);
            label9.Name = "label9";
            label9.Size = new Size(270, 59);
            label9.TabIndex = 31;
            label9.Text = "JOB EDITOR";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(comboBox1);
            groupBox4.Controls.Add(button1);
            groupBox4.Location = new Point(379, 301);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(437, 100);
            groupBox4.TabIndex = 1;
            groupBox4.TabStop = false;
            groupBox4.Text = "Single Copy";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(176, 24);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 2;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(6, 63);
            label10.Name = "label10";
            label10.Size = new Size(88, 15);
            label10.TabIndex = 57;
            label10.Text = "Job Description";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(6, 81);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(588, 59);
            richTextBox1.TabIndex = 58;
            richTextBox1.Text = "";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(1270, 680);
            Controls.Add(tabControl1);
            Controls.Add(menuStrip1);
            ForeColor = SystemColors.ControlDarkDark;
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "AutoBak 2 [0.0.1]";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            groupBoxProtocol.ResumeLayout(false);
            groupBoxProtocol.PerformLayout();
            groupBox4.ResumeLayout(false);
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
        private TextBox textBox1;
        private Button buttonSelectScheduleTask;
        private ImageList imageListIcons;
        private ImageList imageListHighQualityIcons;
        private Button button1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label1;
        private Panel panel2;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private Label label3;
        private TextBox textBox3;
        private Label label2;
        private Label label4;
        private TextBox textBox2;
        private Button button2;
        private Label label7;
        private Panel panel3;
        private Button button15;
        private Button button3;
        private Label label5;
        private TextBox textBox4;
        private Label label6;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button button4;
        private TabPage tabPage3;
        private Label label8;
        private Panel panel5;
        private Button button6;
        private Button button8;
        private Button button10;
        private Label label12;
        private ComboBox comboBoxFirewallPreset;
        private Button button7;
        private Button button5;
        private GroupBox groupBox3;
        private Panel panel4;
        private CheckBox checkBox4;
        private Label label11;
        private TextBox textBox6;
        private GroupBox groupBoxProtocol;
        private RadioButton radioButton1;
        private RadioButton radioButtonTCPandUDP;
        private RadioButton radioButtonUDP;
        private RadioButton radioButtonTCP;
        private Label label9;
        private GroupBox groupBox4;
        private ComboBox comboBox1;
        private RichTextBox richTextBox1;
        private Label label10;
    }
}
