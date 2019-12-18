namespace ImageConverterGUI
{
   partial class Form1
   {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose(bool disposing) {
         if(disposing && (components != null)) {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Windows Form Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent() {
         this.components = new System.ComponentModel.Container();
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
         this.ConvertButton = new System.Windows.Forms.Button();
         this.checkUnityMetaFilesRename = new System.Windows.Forms.CheckBox();
         this.checkBoxReplaceFiles = new System.Windows.Forms.CheckBox();
         this.label4 = new System.Windows.Forms.Label();
         this.label5 = new System.Windows.Forms.Label();
         this.convertJpg = new System.Windows.Forms.Button();
         this.convertPng = new System.Windows.Forms.Button();
         this.progressBar1 = new System.Windows.Forms.ProgressBar();
         this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
         this.listView1 = new System.Windows.Forms.ListView();
         this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
         this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
         this.optionsGroup = new System.Windows.Forms.GroupBox();
         this.groupBox1 = new System.Windows.Forms.GroupBox();
         this.convertSettingsButton = new System.Windows.Forms.Button();
         this.tabControl1 = new System.Windows.Forms.TabControl();
         this.tabPage1 = new System.Windows.Forms.TabPage();
         this.selectFile = new System.Windows.Forms.Button();
         this.deleteItem = new System.Windows.Forms.Button();
         this.selectFolder = new System.Windows.Forms.Button();
         this.tabPage2 = new System.Windows.Forms.TabPage();
         this.groupBox2 = new System.Windows.Forms.GroupBox();
         this.selectFolderToSave = new System.Windows.Forms.Button();
         this.saveFolderTextbox = new System.Windows.Forms.TextBox();
         this.radioButton2 = new System.Windows.Forms.RadioButton();
         this.radioButton1 = new System.Windows.Forms.RadioButton();
         this.ConversionProgress = new System.Windows.Forms.Label();
         this.checkUnityMetaFilesRename_ToolTip = new System.Windows.Forms.ToolTip(this.components);
         this.optionsGroup.SuspendLayout();
         this.groupBox1.SuspendLayout();
         this.tabControl1.SuspendLayout();
         this.tabPage1.SuspendLayout();
         this.tabPage2.SuspendLayout();
         this.groupBox2.SuspendLayout();
         this.SuspendLayout();
         // 
         // ConvertButton
         // 
         this.ConvertButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
         this.ConvertButton.BackColor = System.Drawing.Color.Transparent;
         this.ConvertButton.Cursor = System.Windows.Forms.Cursors.Hand;
         this.ConvertButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(115)))), ((int)(((byte)(21)))));
         this.ConvertButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.ConvertButton.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
         this.ConvertButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(115)))), ((int)(((byte)(21)))));
         this.ConvertButton.Location = new System.Drawing.Point(494, 458);
         this.ConvertButton.Name = "ConvertButton";
         this.ConvertButton.Size = new System.Drawing.Size(86, 23);
         this.ConvertButton.TabIndex = 1;
         this.ConvertButton.Text = "Convert";
         this.ConvertButton.UseVisualStyleBackColor = false;
         this.ConvertButton.Click += new System.EventHandler(this.ConvertButton_Click);
         // 
         // checkUnityMetaFilesRename
         // 
         this.checkUnityMetaFilesRename.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.checkUnityMetaFilesRename.Cursor = System.Windows.Forms.Cursors.Hand;
         this.checkUnityMetaFilesRename.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(244)))), ((int)(((byte)(153)))));
         this.checkUnityMetaFilesRename.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.checkUnityMetaFilesRename.Font = new System.Drawing.Font("Roboto Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.checkUnityMetaFilesRename.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(115)))), ((int)(((byte)(21)))));
         this.checkUnityMetaFilesRename.Location = new System.Drawing.Point(6, 23);
         this.checkUnityMetaFilesRename.Name = "checkUnityMetaFilesRename";
         this.checkUnityMetaFilesRename.Size = new System.Drawing.Size(244, 31);
         this.checkUnityMetaFilesRename.TabIndex = 2;
         this.checkUnityMetaFilesRename.Text = "Rename Unity Meta Files?";
         this.checkUnityMetaFilesRename_ToolTip.SetToolTip(this.checkUnityMetaFilesRename, "If you\'re working with Unity texture files it\'s wise to check this option on so U" +
        "nity won\'t generate new meta files");
         this.checkUnityMetaFilesRename.UseVisualStyleBackColor = true;
         // 
         // checkBoxReplaceFiles
         // 
         this.checkBoxReplaceFiles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.checkBoxReplaceFiles.Cursor = System.Windows.Forms.Cursors.Hand;
         this.checkBoxReplaceFiles.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(244)))), ((int)(((byte)(153)))));
         this.checkBoxReplaceFiles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.checkBoxReplaceFiles.Font = new System.Drawing.Font("Roboto Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.checkBoxReplaceFiles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(115)))), ((int)(((byte)(21)))));
         this.checkBoxReplaceFiles.Location = new System.Drawing.Point(135, 23);
         this.checkBoxReplaceFiles.Name = "checkBoxReplaceFiles";
         this.checkBoxReplaceFiles.Size = new System.Drawing.Size(244, 31);
         this.checkBoxReplaceFiles.TabIndex = 3;
         this.checkBoxReplaceFiles.Text = "Replace";
         this.checkBoxReplaceFiles.UseVisualStyleBackColor = true;
         // 
         // label4
         // 
         this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.label4.BackColor = System.Drawing.Color.Transparent;
         this.label4.Font = new System.Drawing.Font("Roboto Thin", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(115)))), ((int)(((byte)(21)))));
         this.label4.Location = new System.Drawing.Point(10, 5);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(583, 50);
         this.label4.TabIndex = 12;
         this.label4.Text = "TGA Image Converter";
         this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         // 
         // label5
         // 
         this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
         this.label5.Font = new System.Drawing.Font("Roboto Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(115)))), ((int)(((byte)(21)))));
         this.label5.Location = new System.Drawing.Point(6, 33);
         this.label5.Name = "label5";
         this.label5.Size = new System.Drawing.Size(88, 50);
         this.label5.TabIndex = 13;
         this.label5.Text = "Convert to:";
         this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         // 
         // convertJpg
         // 
         this.convertJpg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
         this.convertJpg.BackColor = System.Drawing.Color.Transparent;
         this.convertJpg.Cursor = System.Windows.Forms.Cursors.Hand;
         this.convertJpg.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(115)))), ((int)(((byte)(21)))));
         this.convertJpg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.convertJpg.Font = new System.Drawing.Font("Roboto Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.convertJpg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(115)))), ((int)(((byte)(21)))));
         this.convertJpg.Image = global::ImageConverterGUI.Properties.Resources.jpg;
         this.convertJpg.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
         this.convertJpg.Location = new System.Drawing.Point(100, 23);
         this.convertJpg.Name = "convertJpg";
         this.convertJpg.Size = new System.Drawing.Size(50, 64);
         this.convertJpg.TabIndex = 14;
         this.convertJpg.Text = "Jpg";
         this.convertJpg.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
         this.convertJpg.UseVisualStyleBackColor = false;
         this.convertJpg.Click += new System.EventHandler(this.convertJpg_Click);
         // 
         // convertPng
         // 
         this.convertPng.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
         this.convertPng.BackColor = System.Drawing.Color.Transparent;
         this.convertPng.Cursor = System.Windows.Forms.Cursors.Hand;
         this.convertPng.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(115)))), ((int)(((byte)(21)))));
         this.convertPng.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.convertPng.Font = new System.Drawing.Font("Roboto Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.convertPng.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(115)))), ((int)(((byte)(21)))));
         this.convertPng.Image = global::ImageConverterGUI.Properties.Resources.png;
         this.convertPng.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
         this.convertPng.Location = new System.Drawing.Point(156, 23);
         this.convertPng.Name = "convertPng";
         this.convertPng.Size = new System.Drawing.Size(50, 64);
         this.convertPng.TabIndex = 15;
         this.convertPng.Text = "Png";
         this.convertPng.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
         this.convertPng.UseVisualStyleBackColor = false;
         this.convertPng.Click += new System.EventHandler(this.convertPng_Click);
         // 
         // progressBar1
         // 
         this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.progressBar1.Location = new System.Drawing.Point(17, 458);
         this.progressBar1.Name = "progressBar1";
         this.progressBar1.Size = new System.Drawing.Size(318, 23);
         this.progressBar1.TabIndex = 16;
         // 
         // listView1
         // 
         this.listView1.Activation = System.Windows.Forms.ItemActivation.OneClick;
         this.listView1.AllowDrop = true;
         this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.listView1.BackColor = System.Drawing.Color.White;
         this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
         this.listView1.Font = new System.Drawing.Font("Roboto Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.listView1.FullRowSelect = true;
         this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
         this.listView1.HideSelection = false;
         this.listView1.Location = new System.Drawing.Point(6, 6);
         this.listView1.Name = "listView1";
         this.listView1.ShowItemToolTips = true;
         this.listView1.Size = new System.Drawing.Size(547, 322);
         this.listView1.TabIndex = 18;
         this.listView1.UseCompatibleStateImageBehavior = false;
         this.listView1.View = System.Windows.Forms.View.Details;
         // 
         // columnHeader1
         // 
         this.columnHeader1.Text = "ID";
         this.columnHeader1.Width = 50;
         // 
         // columnHeader2
         // 
         this.columnHeader2.Text = "Path";
         this.columnHeader2.Width = 472;
         // 
         // optionsGroup
         // 
         this.optionsGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.optionsGroup.BackColor = System.Drawing.Color.Transparent;
         this.optionsGroup.Controls.Add(this.checkUnityMetaFilesRename);
         this.optionsGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.optionsGroup.Font = new System.Drawing.Font("Roboto Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.optionsGroup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(115)))), ((int)(((byte)(21)))));
         this.optionsGroup.Location = new System.Drawing.Point(6, 230);
         this.optionsGroup.Name = "optionsGroup";
         this.optionsGroup.Size = new System.Drawing.Size(256, 122);
         this.optionsGroup.TabIndex = 20;
         this.optionsGroup.TabStop = false;
         this.optionsGroup.Text = "Options";
         // 
         // groupBox1
         // 
         this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.groupBox1.Controls.Add(this.convertSettingsButton);
         this.groupBox1.Controls.Add(this.label5);
         this.groupBox1.Controls.Add(this.convertJpg);
         this.groupBox1.Controls.Add(this.convertPng);
         this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(115)))), ((int)(((byte)(21)))));
         this.groupBox1.Location = new System.Drawing.Point(6, 6);
         this.groupBox1.Name = "groupBox1";
         this.groupBox1.Size = new System.Drawing.Size(547, 103);
         this.groupBox1.TabIndex = 21;
         this.groupBox1.TabStop = false;
         this.groupBox1.Text = "Format";
         // 
         // convertSettingsButton
         // 
         this.convertSettingsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
         this.convertSettingsButton.BackColor = System.Drawing.Color.Transparent;
         this.convertSettingsButton.Cursor = System.Windows.Forms.Cursors.Hand;
         this.convertSettingsButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(115)))), ((int)(((byte)(21)))));
         this.convertSettingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.convertSettingsButton.Font = new System.Drawing.Font("Roboto Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.convertSettingsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(115)))), ((int)(((byte)(21)))));
         this.convertSettingsButton.Image = global::ImageConverterGUI.Properties.Resources.settings;
         this.convertSettingsButton.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
         this.convertSettingsButton.Location = new System.Drawing.Point(222, 42);
         this.convertSettingsButton.Name = "convertSettingsButton";
         this.convertSettingsButton.Padding = new System.Windows.Forms.Padding(1);
         this.convertSettingsButton.Size = new System.Drawing.Size(82, 32);
         this.convertSettingsButton.TabIndex = 16;
         this.convertSettingsButton.Text = "Settings";
         this.convertSettingsButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
         this.convertSettingsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
         this.convertSettingsButton.UseVisualStyleBackColor = false;
         this.convertSettingsButton.Click += new System.EventHandler(this.convertSettingsButton_Click);
         // 
         // tabControl1
         // 
         this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.tabControl1.Controls.Add(this.tabPage1);
         this.tabControl1.Controls.Add(this.tabPage2);
         this.tabControl1.Font = new System.Drawing.Font("Roboto Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.tabControl1.Location = new System.Drawing.Point(17, 58);
         this.tabControl1.Name = "tabControl1";
         this.tabControl1.SelectedIndex = 0;
         this.tabControl1.Size = new System.Drawing.Size(567, 394);
         this.tabControl1.TabIndex = 22;
         // 
         // tabPage1
         // 
         this.tabPage1.BackColor = System.Drawing.Color.White;
         this.tabPage1.Controls.Add(this.listView1);
         this.tabPage1.Controls.Add(this.selectFile);
         this.tabPage1.Controls.Add(this.deleteItem);
         this.tabPage1.Controls.Add(this.selectFolder);
         this.tabPage1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(115)))), ((int)(((byte)(21)))));
         this.tabPage1.Location = new System.Drawing.Point(4, 24);
         this.tabPage1.Name = "tabPage1";
         this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
         this.tabPage1.Size = new System.Drawing.Size(559, 366);
         this.tabPage1.TabIndex = 0;
         this.tabPage1.Text = "Input";
         // 
         // selectFile
         // 
         this.selectFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
         this.selectFile.BackColor = System.Drawing.Color.Transparent;
         this.selectFile.Cursor = System.Windows.Forms.Cursors.Hand;
         this.selectFile.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(115)))), ((int)(((byte)(21)))));
         this.selectFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.selectFile.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
         this.selectFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(115)))), ((int)(((byte)(21)))));
         this.selectFile.Image = ((System.Drawing.Image)(resources.GetObject("selectFile.Image")));
         this.selectFile.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
         this.selectFile.Location = new System.Drawing.Point(6, 331);
         this.selectFile.Margin = new System.Windows.Forms.Padding(0);
         this.selectFile.Name = "selectFile";
         this.selectFile.Padding = new System.Windows.Forms.Padding(1);
         this.selectFile.Size = new System.Drawing.Size(95, 32);
         this.selectFile.TabIndex = 10;
         this.selectFile.Text = "Add Files...";
         this.selectFile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
         this.selectFile.UseCompatibleTextRendering = true;
         this.selectFile.UseVisualStyleBackColor = false;
         this.selectFile.Click += new System.EventHandler(this.button1_Click);
         // 
         // deleteItem
         // 
         this.deleteItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
         this.deleteItem.BackColor = System.Drawing.Color.Transparent;
         this.deleteItem.Cursor = System.Windows.Forms.Cursors.Hand;
         this.deleteItem.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(115)))), ((int)(((byte)(21)))));
         this.deleteItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.deleteItem.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
         this.deleteItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(115)))), ((int)(((byte)(21)))));
         this.deleteItem.Image = global::ImageConverterGUI.Properties.Resources.DeleteImageNormal;
         this.deleteItem.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
         this.deleteItem.Location = new System.Drawing.Point(221, 331);
         this.deleteItem.Name = "deleteItem";
         this.deleteItem.Padding = new System.Windows.Forms.Padding(1);
         this.deleteItem.Size = new System.Drawing.Size(71, 32);
         this.deleteItem.TabIndex = 19;
         this.deleteItem.Text = "Delete";
         this.deleteItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
         this.deleteItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
         this.deleteItem.UseCompatibleTextRendering = true;
         this.deleteItem.UseVisualStyleBackColor = false;
         this.deleteItem.Click += new System.EventHandler(this.deleteItem_Click);
         // 
         // selectFolder
         // 
         this.selectFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
         this.selectFolder.BackColor = System.Drawing.Color.Transparent;
         this.selectFolder.Cursor = System.Windows.Forms.Cursors.Hand;
         this.selectFolder.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(115)))), ((int)(((byte)(21)))));
         this.selectFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.selectFolder.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
         this.selectFolder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(115)))), ((int)(((byte)(21)))));
         this.selectFolder.Image = global::ImageConverterGUI.Properties.Resources.AddFolderNormal;
         this.selectFolder.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
         this.selectFolder.Location = new System.Drawing.Point(104, 331);
         this.selectFolder.Name = "selectFolder";
         this.selectFolder.Padding = new System.Windows.Forms.Padding(1);
         this.selectFolder.Size = new System.Drawing.Size(111, 32);
         this.selectFolder.TabIndex = 7;
         this.selectFolder.Text = "Add Folder...";
         this.selectFolder.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
         this.selectFolder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
         this.selectFolder.UseCompatibleTextRendering = true;
         this.selectFolder.UseVisualStyleBackColor = false;
         this.selectFolder.Click += new System.EventHandler(this.selectFolder_Click);
         // 
         // tabPage2
         // 
         this.tabPage2.BackColor = System.Drawing.Color.White;
         this.tabPage2.Controls.Add(this.groupBox2);
         this.tabPage2.Controls.Add(this.groupBox1);
         this.tabPage2.Controls.Add(this.optionsGroup);
         this.tabPage2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(115)))), ((int)(((byte)(21)))));
         this.tabPage2.Location = new System.Drawing.Point(4, 24);
         this.tabPage2.Name = "tabPage2";
         this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
         this.tabPage2.Size = new System.Drawing.Size(559, 366);
         this.tabPage2.TabIndex = 1;
         this.tabPage2.Text = "Output";
         // 
         // groupBox2
         // 
         this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.groupBox2.Controls.Add(this.selectFolderToSave);
         this.groupBox2.Controls.Add(this.checkBoxReplaceFiles);
         this.groupBox2.Controls.Add(this.saveFolderTextbox);
         this.groupBox2.Controls.Add(this.radioButton2);
         this.groupBox2.Controls.Add(this.radioButton1);
         this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(115)))), ((int)(((byte)(21)))));
         this.groupBox2.Location = new System.Drawing.Point(6, 115);
         this.groupBox2.Name = "groupBox2";
         this.groupBox2.Size = new System.Drawing.Size(547, 109);
         this.groupBox2.TabIndex = 22;
         this.groupBox2.TabStop = false;
         this.groupBox2.Text = "Save";
         // 
         // selectFolderToSave
         // 
         this.selectFolderToSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
         this.selectFolderToSave.BackColor = System.Drawing.Color.Transparent;
         this.selectFolderToSave.Cursor = System.Windows.Forms.Cursors.Hand;
         this.selectFolderToSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(115)))), ((int)(((byte)(21)))));
         this.selectFolderToSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.selectFolderToSave.Font = new System.Drawing.Font("Roboto Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.selectFolderToSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(115)))), ((int)(((byte)(21)))));
         this.selectFolderToSave.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
         this.selectFolderToSave.Location = new System.Drawing.Point(508, 62);
         this.selectFolderToSave.Name = "selectFolderToSave";
         this.selectFolderToSave.Size = new System.Drawing.Size(29, 24);
         this.selectFolderToSave.TabIndex = 17;
         this.selectFolderToSave.Text = "...";
         this.selectFolderToSave.TextAlign = System.Drawing.ContentAlignment.TopCenter;
         this.selectFolderToSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
         this.selectFolderToSave.UseVisualStyleBackColor = false;
         this.selectFolderToSave.Click += new System.EventHandler(this.selectFolderToSave_Click);
         // 
         // saveFolderTextbox
         // 
         this.saveFolderTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.saveFolderTextbox.BackColor = System.Drawing.Color.White;
         this.saveFolderTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(115)))), ((int)(((byte)(21)))));
         this.saveFolderTextbox.Location = new System.Drawing.Point(81, 62);
         this.saveFolderTextbox.Name = "saveFolderTextbox";
         this.saveFolderTextbox.Size = new System.Drawing.Size(418, 24);
         this.saveFolderTextbox.TabIndex = 2;
         this.saveFolderTextbox.TextChanged += new System.EventHandler(this.saveFolderTextbox_TextChanged);
         // 
         // radioButton2
         // 
         this.radioButton2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.radioButton2.AutoSize = true;
         this.radioButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.radioButton2.Location = new System.Drawing.Point(9, 62);
         this.radioButton2.Name = "radioButton2";
         this.radioButton2.Size = new System.Drawing.Size(64, 21);
         this.radioButton2.TabIndex = 1;
         this.radioButton2.TabStop = true;
         this.radioButton2.Text = "Folder";
         this.radioButton2.UseVisualStyleBackColor = true;
         this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
         // 
         // radioButton1
         // 
         this.radioButton1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.radioButton1.AutoSize = true;
         this.radioButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.radioButton1.Location = new System.Drawing.Point(9, 28);
         this.radioButton1.Name = "radioButton1";
         this.radioButton1.Size = new System.Drawing.Size(110, 21);
         this.radioButton1.TabIndex = 0;
         this.radioButton1.TabStop = true;
         this.radioButton1.Text = "Source Folder";
         this.radioButton1.UseVisualStyleBackColor = true;
         this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
         // 
         // ConversionProgress
         // 
         this.ConversionProgress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
         this.ConversionProgress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(115)))), ((int)(((byte)(21)))));
         this.ConversionProgress.Location = new System.Drawing.Point(341, 458);
         this.ConversionProgress.Name = "ConversionProgress";
         this.ConversionProgress.Size = new System.Drawing.Size(147, 23);
         this.ConversionProgress.TabIndex = 23;
         this.ConversionProgress.Text = "Click to start ->";
         this.ConversionProgress.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
         // 
         // checkUnityMetaFilesRename_ToolTip
         // 
         this.checkUnityMetaFilesRename_ToolTip.AutoPopDelay = 10000;
         this.checkUnityMetaFilesRename_ToolTip.BackColor = System.Drawing.Color.White;
         this.checkUnityMetaFilesRename_ToolTip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(115)))), ((int)(((byte)(21)))));
         this.checkUnityMetaFilesRename_ToolTip.InitialDelay = 500;
         this.checkUnityMetaFilesRename_ToolTip.ReshowDelay = 100;
         this.checkUnityMetaFilesRename_ToolTip.Popup += new System.Windows.Forms.PopupEventHandler(this.checkUnityMetaFilesRename_ToolTip_Popup);
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.White;
         this.ClientSize = new System.Drawing.Size(596, 493);
         this.Controls.Add(this.ConversionProgress);
         this.Controls.Add(this.tabControl1);
         this.Controls.Add(this.progressBar1);
         this.Controls.Add(this.label4);
         this.Controls.Add(this.ConvertButton);
         this.Font = new System.Drawing.Font("Roboto Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
         this.MaximizeBox = false;
         this.MinimumSize = new System.Drawing.Size(612, 532);
         this.Name = "Form1";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "Image Conversion";
         this.Load += new System.EventHandler(this.Form1_Load);
         this.optionsGroup.ResumeLayout(false);
         this.groupBox1.ResumeLayout(false);
         this.tabControl1.ResumeLayout(false);
         this.tabPage1.ResumeLayout(false);
         this.tabPage2.ResumeLayout(false);
         this.groupBox2.ResumeLayout(false);
         this.groupBox2.PerformLayout();
         this.ResumeLayout(false);

      }

      #endregion
      private System.Windows.Forms.Button ConvertButton;
      private System.Windows.Forms.CheckBox checkUnityMetaFilesRename;
      private System.Windows.Forms.CheckBox checkBoxReplaceFiles;
      private System.Windows.Forms.Button selectFolder;
      private System.Windows.Forms.Button selectFile;
      private System.Windows.Forms.Label label4;
      private System.Windows.Forms.Label label5;
      private System.Windows.Forms.Button convertJpg;
      private System.Windows.Forms.Button convertPng;
        private System.Windows.Forms.ProgressBar progressBar1;
      private System.ComponentModel.BackgroundWorker backgroundWorker1;
      private System.Windows.Forms.ListView listView1;
      private System.Windows.Forms.ColumnHeader columnHeader1;
      private System.Windows.Forms.ColumnHeader columnHeader2;
      private System.Windows.Forms.Button deleteItem;
        private System.Windows.Forms.GroupBox optionsGroup;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button convertSettingsButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TextBox saveFolderTextbox;
        private System.Windows.Forms.Button selectFolderToSave;
      private System.Windows.Forms.Label ConversionProgress;
        private System.Windows.Forms.ToolTip checkUnityMetaFilesRename_ToolTip;
    }
}

