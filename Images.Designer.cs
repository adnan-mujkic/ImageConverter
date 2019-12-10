namespace ImageConverterGUI
{
   partial class Images
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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Images));
         this.trackBar1 = new System.Windows.Forms.TrackBar();
         this.label1 = new System.Windows.Forms.Label();
         this.ApplyChangesButton = new System.Windows.Forms.Button();
         this.setBgcolorButton = new System.Windows.Forms.Button();
         this.label3 = new System.Windows.Forms.Label();
         this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
         ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
         this.SuspendLayout();
         // 
         // trackBar1
         // 
         this.trackBar1.Location = new System.Drawing.Point(12, 44);
         this.trackBar1.Maximum = 100;
         this.trackBar1.Name = "trackBar1";
         this.trackBar1.Size = new System.Drawing.Size(263, 45);
         this.trackBar1.TabIndex = 0;
         this.trackBar1.Value = 100;
         this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
         this.label1.Font = new System.Drawing.Font("Roboto Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(115)))), ((int)(((byte)(21)))));
         this.label1.Location = new System.Drawing.Point(22, 9);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(166, 23);
         this.label1.TabIndex = 1;
         this.label1.Text = "Select quality level:";
         // 
         // ApplyChangesButton
         // 
         this.ApplyChangesButton.BackColor = System.Drawing.Color.Transparent;
         this.ApplyChangesButton.Cursor = System.Windows.Forms.Cursors.Hand;
         this.ApplyChangesButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(115)))), ((int)(((byte)(21)))));
         this.ApplyChangesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.ApplyChangesButton.Font = new System.Drawing.Font("Roboto Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.ApplyChangesButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(115)))), ((int)(((byte)(21)))));
         this.ApplyChangesButton.Location = new System.Drawing.Point(75, 158);
         this.ApplyChangesButton.Name = "ApplyChangesButton";
         this.ApplyChangesButton.Size = new System.Drawing.Size(200, 50);
         this.ApplyChangesButton.TabIndex = 3;
         this.ApplyChangesButton.Text = "Ok";
         this.ApplyChangesButton.UseVisualStyleBackColor = false;
         this.ApplyChangesButton.Click += new System.EventHandler(this.ApplyChangesButton_Click);
         // 
         // setBgcolorButton
         // 
         this.setBgcolorButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
         this.setBgcolorButton.Cursor = System.Windows.Forms.Cursors.Hand;
         this.setBgcolorButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(115)))), ((int)(((byte)(21)))));
         this.setBgcolorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.setBgcolorButton.Font = new System.Drawing.Font("Roboto Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.setBgcolorButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(115)))), ((int)(((byte)(21)))));
         this.setBgcolorButton.Location = new System.Drawing.Point(25, 95);
         this.setBgcolorButton.Name = "setBgcolorButton";
         this.setBgcolorButton.Size = new System.Drawing.Size(250, 40);
         this.setBgcolorButton.TabIndex = 4;
         this.setBgcolorButton.Text = "Select background color";
         this.setBgcolorButton.UseVisualStyleBackColor = false;
         this.setBgcolorButton.Click += new System.EventHandler(this.setBgcolorButton_Click);
         // 
         // label3
         // 
         this.label3.BackColor = System.Drawing.Color.White;
         this.label3.Location = new System.Drawing.Point(282, 95);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(48, 40);
         this.label3.TabIndex = 5;
         // 
         // numericUpDown1
         // 
         this.numericUpDown1.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.numericUpDown1.Location = new System.Drawing.Point(282, 44);
         this.numericUpDown1.Name = "numericUpDown1";
         this.numericUpDown1.Size = new System.Drawing.Size(48, 23);
         this.numericUpDown1.TabIndex = 6;
         this.numericUpDown1.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
         this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
         // 
         // Images
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
         this.ClientSize = new System.Drawing.Size(342, 220);
         this.Controls.Add(this.numericUpDown1);
         this.Controls.Add(this.label3);
         this.Controls.Add(this.setBgcolorButton);
         this.Controls.Add(this.ApplyChangesButton);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.trackBar1);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
         this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
         this.Name = "Images";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "Jpg options";
         ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.TrackBar trackBar1;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Button ApplyChangesButton;
      private System.Windows.Forms.Button setBgcolorButton;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.NumericUpDown numericUpDown1;
   }
}