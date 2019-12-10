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
         this.label6 = new System.Windows.Forms.Label();
         this.listView1 = new System.Windows.Forms.ListView();
         this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
         this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
         this.deleteItem = new System.Windows.Forms.Button();
         this.selectFile = new System.Windows.Forms.Button();
         this.selectFolder = new System.Windows.Forms.Button();
         this.SuspendLayout();
         // 
         // ConvertButton
         // 
         this.ConvertButton.BackColor = System.Drawing.Color.Transparent;
         this.ConvertButton.Cursor = System.Windows.Forms.Cursors.Hand;
         this.ConvertButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(115)))), ((int)(((byte)(21)))));
         this.ConvertButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.ConvertButton.Font = new System.Drawing.Font("Roboto Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.ConvertButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(115)))), ((int)(((byte)(21)))));
         this.ConvertButton.Location = new System.Drawing.Point(100, 477);
         this.ConvertButton.Name = "ConvertButton";
         this.ConvertButton.Size = new System.Drawing.Size(200, 50);
         this.ConvertButton.TabIndex = 1;
         this.ConvertButton.Text = "Convert";
         this.ConvertButton.UseVisualStyleBackColor = false;
         this.ConvertButton.Click += new System.EventHandler(this.ConvertButton_Click);
         // 
         // checkUnityMetaFilesRename
         // 
         this.checkUnityMetaFilesRename.Cursor = System.Windows.Forms.Cursors.Hand;
         this.checkUnityMetaFilesRename.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(244)))), ((int)(((byte)(153)))));
         this.checkUnityMetaFilesRename.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.checkUnityMetaFilesRename.Font = new System.Drawing.Font("Roboto Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.checkUnityMetaFilesRename.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(115)))), ((int)(((byte)(21)))));
         this.checkUnityMetaFilesRename.Location = new System.Drawing.Point(15, 396);
         this.checkUnityMetaFilesRename.Name = "checkUnityMetaFilesRename";
         this.checkUnityMetaFilesRename.Size = new System.Drawing.Size(200, 31);
         this.checkUnityMetaFilesRename.TabIndex = 2;
         this.checkUnityMetaFilesRename.Text = "Rename Unity Meta Files?";
         this.checkUnityMetaFilesRename.UseVisualStyleBackColor = true;
         // 
         // checkBoxReplaceFiles
         // 
         this.checkBoxReplaceFiles.Cursor = System.Windows.Forms.Cursors.Hand;
         this.checkBoxReplaceFiles.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(244)))), ((int)(((byte)(153)))));
         this.checkBoxReplaceFiles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.checkBoxReplaceFiles.Font = new System.Drawing.Font("Roboto Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.checkBoxReplaceFiles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(115)))), ((int)(((byte)(21)))));
         this.checkBoxReplaceFiles.Location = new System.Drawing.Point(15, 433);
         this.checkBoxReplaceFiles.Name = "checkBoxReplaceFiles";
         this.checkBoxReplaceFiles.Size = new System.Drawing.Size(200, 31);
         this.checkBoxReplaceFiles.TabIndex = 3;
         this.checkBoxReplaceFiles.Text = "Replace old textures ?";
         this.checkBoxReplaceFiles.UseVisualStyleBackColor = true;
         // 
         // label4
         // 
         this.label4.Font = new System.Drawing.Font("Roboto Thin", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(115)))), ((int)(((byte)(21)))));
         this.label4.Location = new System.Drawing.Point(10, 5);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(380, 50);
         this.label4.TabIndex = 12;
         this.label4.Text = "TGA Image Converter";
         this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         // 
         // label5
         // 
         this.label5.Font = new System.Drawing.Font("Roboto Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(115)))), ((int)(((byte)(21)))));
         this.label5.Location = new System.Drawing.Point(9, 329);
         this.label5.Name = "label5";
         this.label5.Size = new System.Drawing.Size(88, 50);
         this.label5.TabIndex = 13;
         this.label5.Text = "Convert to:";
         this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         // 
         // convertJpg
         // 
         this.convertJpg.BackColor = System.Drawing.Color.Transparent;
         this.convertJpg.Cursor = System.Windows.Forms.Cursors.Hand;
         this.convertJpg.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(115)))), ((int)(((byte)(21)))));
         this.convertJpg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.convertJpg.Font = new System.Drawing.Font("Roboto Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.convertJpg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(115)))), ((int)(((byte)(21)))));
         this.convertJpg.Location = new System.Drawing.Point(115, 329);
         this.convertJpg.Name = "convertJpg";
         this.convertJpg.Size = new System.Drawing.Size(100, 50);
         this.convertJpg.TabIndex = 14;
         this.convertJpg.Text = ".jpg";
         this.convertJpg.UseVisualStyleBackColor = false;
         this.convertJpg.Click += new System.EventHandler(this.convertJpg_Click);
         // 
         // convertPng
         // 
         this.convertPng.BackColor = System.Drawing.Color.Transparent;
         this.convertPng.Cursor = System.Windows.Forms.Cursors.Hand;
         this.convertPng.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(115)))), ((int)(((byte)(21)))));
         this.convertPng.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.convertPng.Font = new System.Drawing.Font("Roboto Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.convertPng.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(115)))), ((int)(((byte)(21)))));
         this.convertPng.Location = new System.Drawing.Point(226, 329);
         this.convertPng.Name = "convertPng";
         this.convertPng.Size = new System.Drawing.Size(100, 50);
         this.convertPng.TabIndex = 15;
         this.convertPng.Text = ".png";
         this.convertPng.UseVisualStyleBackColor = false;
         this.convertPng.Click += new System.EventHandler(this.convertPng_Click);
         // 
         // progressBar1
         // 
         this.progressBar1.Location = new System.Drawing.Point(7, 544);
         this.progressBar1.Name = "progressBar1";
         this.progressBar1.Size = new System.Drawing.Size(374, 23);
         this.progressBar1.TabIndex = 16;
         this.progressBar1.UseWaitCursor = true;
         // 
         // label6
         // 
         this.label6.Location = new System.Drawing.Point(7, 570);
         this.label6.Name = "label6";
         this.label6.Size = new System.Drawing.Size(374, 32);
         this.label6.TabIndex = 17;
         this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         // 
         // listView1
         // 
         this.listView1.Activation = System.Windows.Forms.ItemActivation.OneClick;
         this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
         this.listView1.Font = new System.Drawing.Font("Roboto Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.listView1.FullRowSelect = true;
         this.listView1.GridLines = true;
         this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
         this.listView1.HideSelection = false;
         this.listView1.Location = new System.Drawing.Point(54, 82);
         this.listView1.Name = "listView1";
         this.listView1.ShowItemToolTips = true;
         this.listView1.Size = new System.Drawing.Size(320, 230);
         this.listView1.TabIndex = 18;
         this.listView1.UseCompatibleStateImageBehavior = false;
         this.listView1.View = System.Windows.Forms.View.Details;
         // 
         // columnHeader1
         // 
         this.columnHeader1.Text = "ID";
         this.columnHeader1.Width = 30;
         // 
         // columnHeader2
         // 
         this.columnHeader2.Text = "Path";
         this.columnHeader2.Width = 290;
         // 
         // deleteItem
         // 
         this.deleteItem.Cursor = System.Windows.Forms.Cursors.Hand;
         this.deleteItem.FlatAppearance.BorderSize = 0;
         this.deleteItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.deleteItem.ForeColor = System.Drawing.Color.Transparent;
         this.deleteItem.Image = global::ImageConverterGUI.Properties.Resources.DeleteImageNormal;
         this.deleteItem.Location = new System.Drawing.Point(15, 164);
         this.deleteItem.Name = "deleteItem";
         this.deleteItem.Size = new System.Drawing.Size(35, 35);
         this.deleteItem.TabIndex = 19;
         this.deleteItem.UseVisualStyleBackColor = true;
         this.deleteItem.Click += new System.EventHandler(this.deleteItem_Click);
         // 
         // selectFile
         // 
         this.selectFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
         this.selectFile.Cursor = System.Windows.Forms.Cursors.Hand;
         this.selectFile.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(115)))), ((int)(((byte)(21)))));
         this.selectFile.FlatAppearance.BorderSize = 0;
         this.selectFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.selectFile.Font = new System.Drawing.Font("Bahnschrift Light", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.selectFile.ForeColor = System.Drawing.Color.Transparent;
         this.selectFile.Image = global::ImageConverterGUI.Properties.Resources.AddImageNormal;
         this.selectFile.Location = new System.Drawing.Point(15, 82);
         this.selectFile.Name = "selectFile";
         this.selectFile.Size = new System.Drawing.Size(35, 35);
         this.selectFile.TabIndex = 10;
         this.selectFile.TextAlign = System.Drawing.ContentAlignment.TopCenter;
         this.selectFile.UseVisualStyleBackColor = false;
         this.selectFile.Click += new System.EventHandler(this.button1_Click);
         // 
         // selectFolder
         // 
         this.selectFolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
         this.selectFolder.Cursor = System.Windows.Forms.Cursors.Hand;
         this.selectFolder.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(115)))), ((int)(((byte)(21)))));
         this.selectFolder.FlatAppearance.BorderSize = 0;
         this.selectFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.selectFolder.Font = new System.Drawing.Font("Bahnschrift Light", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.selectFolder.ForeColor = System.Drawing.Color.Transparent;
         this.selectFolder.Image = global::ImageConverterGUI.Properties.Resources.AddFolderNormal;
         this.selectFolder.Location = new System.Drawing.Point(15, 123);
         this.selectFolder.Name = "selectFolder";
         this.selectFolder.Size = new System.Drawing.Size(35, 35);
         this.selectFolder.TabIndex = 7;
         this.selectFolder.TextAlign = System.Drawing.ContentAlignment.TopCenter;
         this.selectFolder.UseVisualStyleBackColor = false;
         this.selectFolder.Click += new System.EventHandler(this.selectFolder_Click);
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
         this.ClientSize = new System.Drawing.Size(384, 541);
         this.Controls.Add(this.deleteItem);
         this.Controls.Add(this.listView1);
         this.Controls.Add(this.label6);
         this.Controls.Add(this.progressBar1);
         this.Controls.Add(this.convertPng);
         this.Controls.Add(this.convertJpg);
         this.Controls.Add(this.label5);
         this.Controls.Add(this.label4);
         this.Controls.Add(this.selectFile);
         this.Controls.Add(this.selectFolder);
         this.Controls.Add(this.checkBoxReplaceFiles);
         this.Controls.Add(this.checkUnityMetaFilesRename);
         this.Controls.Add(this.ConvertButton);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
         this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
         this.MaximizeBox = false;
         this.Name = "Form1";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "Image Conversion";
         this.Load += new System.EventHandler(this.Form1_Load);
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
      private System.Windows.Forms.Label label6;
      private System.Windows.Forms.ListView listView1;
      private System.Windows.Forms.ColumnHeader columnHeader1;
      private System.Windows.Forms.ColumnHeader columnHeader2;
      private System.Windows.Forms.Button deleteItem;
   }
}

