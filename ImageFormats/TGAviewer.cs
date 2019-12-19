using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageConverterGUI.ImageFormats
{
   public partial class TGAviewer: Form
   {
      Bitmap imageToDisplay;
      public TGAviewer(Bitmap _ImageToDisplay) {
         InitializeComponent();
         imageToDisplay = _ImageToDisplay;
         pictureBox1.Paint+=new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
      }

      private void pictureBox1_Paint(object sender, PaintEventArgs e) {
         Graphics g = e.Graphics;
         g.DrawImage(imageToDisplay,0,50);
      }

      private void TGAviewer_Load(object sender, EventArgs e) {
         
      }
   }
}
