using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageConverterGUI
{
   public partial class Images: Form
   {
      int jpgQuality;
      Color bgColor;
      Form1 form1;
      public Images(Form1 form) {
         InitializeComponent();
         form1 = form;

         jpgQuality = 100;
         trackBar1.Value = jpgQuality;
         numericUpDown1.Value = jpgQuality;
         bgColor = Color.FromArgb(255, 255, 255);
         ApplyChangesButton.MouseEnter += Form1.OnMouseEnterButton;
         ApplyChangesButton.MouseLeave += Form1.OnMouseLeaveButton1;
      }

      private void trackBar1_Scroll(object sender, EventArgs e) {
         jpgQuality = trackBar1.Value;
         numericUpDown1.Value = jpgQuality;
      }

      private void numericUpDown1_ValueChanged(object sender, EventArgs e) {
         jpgQuality = (int)numericUpDown1.Value;
         trackBar1.Value = jpgQuality;
      }

      private void setBgcolorButton_Click(object sender, EventArgs e) {
         ColorDialog CD = new ColorDialog();
         if(CD.ShowDialog() == DialogResult.OK) {
            bgColor = CD.Color;
         }

      }

      private void ApplyChangesButton_Click(object sender, EventArgs e) {
         Form1.jpgQuality = jpgQuality;
         Form1.jpgBgColor = bgColor;
         Close();
      }
   }
}
