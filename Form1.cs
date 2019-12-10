using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.IO;
using Pfim;
using System.Diagnostics;
using System.Linq;

namespace ImageConverterGUI
{
   public partial class Form1: Form
   {
      string filepath;
      string folderPath;
      bool jpgOrPng;
      int progressBarValue;

      public static int jpgQuality;
      public static Color jpgBgColor;
      public List<string> filesLoaded;
      public Form1() {
         InitializeComponent();
         backgroundWorker1.WorkerReportsProgress = true;
         jpgOrPng = false;
         progressBarValue = 0;
         ChangeJpgPngButtonColors();
         filesLoaded = new List<string>();
         ConvertButton.MouseEnter += OnMouseEnterButton;
         ConvertButton.MouseLeave += OnMouseLeaveButton1;

         selectFolder.Image = Properties.Resources.AddFolderNormal;
         selectFolder.MouseEnter += OnMouseEnterButtonImage;
         selectFolder.MouseLeave += OnMouseLeaveButtonImage;
         selectFile.Image = Properties.Resources.AddImageNormal;
         selectFile.MouseEnter += OnMouseEnterButtonImage;
         selectFile.MouseLeave += OnMouseLeaveButtonImage;
         deleteItem.Image = Properties.Resources.DeleteImageNormal;
         deleteItem.MouseEnter += OnMouseEnterButtonImage;
         deleteItem.MouseLeave += OnMouseLeaveButtonImage;

         convertJpg.MouseEnter += OnMouseEnterButton;
         convertJpg.MouseLeave += OnMouseLeaveButtonJpgPng;
         convertPng.MouseEnter += OnMouseEnterButton;
         convertPng.MouseLeave += OnMouseLeaveButtonJpgPng;
      }

      public static void OnMouseEnterButton(object sender, EventArgs e) {
         Button btn = sender as Button;
         btn.BackColor = Color.FromArgb(255, 255, 115, 21);
         btn.ForeColor = Color.FromArgb(255, 244, 244, 244);
      }
      public static void OnMouseEnterButtonImage(object sender, EventArgs e) {
         Button btn = sender as Button;
         btn.BackColor = Color.FromArgb(255, 255, 115, 21);
         btn.ForeColor = Color.FromArgb(255, 244, 244, 244);
         if(btn.Name == "selectFile")
            btn.Image = Properties.Resources.AddImageSelected;
         else if(btn.Name == "selectFolder")
            btn.Image = Properties.Resources.AddFolderSelected;
         else if(btn.Name == "deleteItem")
            btn.Image = Properties.Resources.DeleteImageSelected;
      }
      public static void OnMouseLeaveButtonImage(object sender, EventArgs e) {
         Button btn = sender as Button;
         btn.BackColor = Color.Transparent;
         btn.ForeColor = Color.FromArgb(255, 255, 115, 21);
         if(btn.Name == "selectFile")
            btn.Image = Properties.Resources.AddImageNormal;
         else if(btn.Name == "selectFolder")
            btn.Image = Properties.Resources.AddFolderNormal;
         else if(btn.Name == "deleteItem")
            btn.Image = Properties.Resources.DeleteImageNormal;
      }
      public static void OnMouseLeaveButton1(object sender, EventArgs e) {
         Button btn = sender as Button;
         btn.BackColor = Color.Transparent;
         btn.ForeColor = Color.FromArgb(255, 255, 115, 21);
      }
      private void OnMouseLeaveButtonJpgPng(object sender, EventArgs e) {
         ChangeJpgPngButtonColors();
      }

      private void Form1_Load(object sender, EventArgs e) {
         Timer timer = new Timer();
         timer.Interval = (500);
         timer.Tick += new EventHandler(UpdateUIelemnts);
         timer.Start();
      }
      private void UpdateUIelemnts(object sender, EventArgs e) {
         if(progressBarValue <= 100 && this.progressBar1.Value != progressBarValue)
            this.progressBar1.Value = progressBarValue;
      }

      private async void selectFolder_Click(object sender, EventArgs e) {
         FolderBrowserDialog fbd = new FolderBrowserDialog();
         fbd.RootFolder = Environment.SpecialFolder.Desktop;
         fbd.Description = "Select folder with textures";
         fbd.ShowNewFolderButton = false;
         if(fbd.ShowDialog() == DialogResult.OK) {
            folderPath = fbd.SelectedPath;
            GetTgaFilesFromFolder();
         }
      }
      private void GetTgaFilesFromFolder() {
         GetFilesFromFolders(folderPath);
      }
      private void GetFilesFromFolders(string _filePath) {
         var allFiles = Directory.GetFiles(_filePath);
         for(int i = 0; i < allFiles.Length; i++) {
            if(Path.GetExtension(allFiles[i]) == ".tga" || Path.GetExtension(allFiles[i]) == ".TGA") {
               filesLoaded.Add(allFiles[i]);
               ListViewItem item = new ListViewItem(filesLoaded.Count.ToString());
               item.SubItems.Add(allFiles[i]);
               listView1.Items.Add(item);
            }
         }
         var otherFolders = Directory.GetDirectories(_filePath);
         if(otherFolders != null) {
            for(int i = 0; i < otherFolders.Length; i++) {
               GetFilesFromFolders(otherFolders[i]);
            }
         }
      }
      private void button1_Click(object sender, EventArgs e) {
         OpenFileDialog fd = new OpenFileDialog();
         if(fd.ShowDialog() == DialogResult.OK) {
            filepath = fd.FileName;
            filesLoaded.Add(filepath);
            ListViewItem item = new ListViewItem(filesLoaded.Count.ToString());
            item.SubItems.Add(filepath);
            listView1.Items.Add(item);
         }
      }
      private void ConvertButton_Click(object sender, EventArgs e) {

         if(listView1.Items.Count == 0) {
            DialogResult message = MessageBox.Show("Please select file!","Motherfucker");
            return;
         }
         else if(jpgOrPng) {
            Form jpegOptions = new Images(this);
            jpegOptions.Show();
         }
         else if(!jpgOrPng){
            StartConversion();
         }
      }

      public async void ConvertFile(string path, bool Replace, bool UnityMeta, bool jpg) {
         using(var image = Pfim.Pfim.FromFile(path)) {
            PixelFormat format;
            // Convert from Pfim's backend agnostic image format into GDI+'s image format
            switch(image.Format) {
               case Pfim.ImageFormat.Rgba32:
                  format = PixelFormat.Format32bppArgb;
                  break;
               default:
                  // see the sample for more details
                  format = PixelFormat.Format24bppRgb;
                  break;
            }
            // Pin pfim's data array so that it doesn't get reaped by GC, unnecessary
            // in this snippet but useful technique if the data was going to be used in
            // control like a picture box
            var handle = GCHandle.Alloc(image.Data, GCHandleType.Pinned);
            try {
               var data = Marshal.UnsafeAddrOfPinnedArrayElement(image.Data, 0);
               var bitmap = new Bitmap(image.Width, image.Height, image.Stride, format, data);
               await AllocateMemoryAndSave(path, bitmap, jpg, Replace);

               //Rename Unity meta
               if(UnityMeta) {
                  if(File.Exists(path + ".meta")) {
                     string oldPath = path + ".meta";
                     string newPath = "";
                     if(jpg)
                        newPath = Path.ChangeExtension(path, ".jpg");
                     else
                        newPath = Path.ChangeExtension(path, ".png");
                     if(Replace)
                        System.IO.File.Copy(oldPath, newPath + ".meta");
                     else {
                        try {
                           System.IO.File.Move(oldPath, newPath + ".meta");
                        } catch(Exception ex) {
                           MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                     }
                  }
               }
            } finally {
               handle.Free();
            }
         }
      }
      public async Task AllocateMemoryAndSave(string path, Bitmap bitmap, bool jpg, bool replace) {
         string oldPath = path;
         string outputFileName = "";
         if(!jpg)
            outputFileName = Path.ChangeExtension(path, ".png");
         else
            outputFileName = Path.ChangeExtension(path, ".jpg");
         using(MemoryStream memory = new MemoryStream()) {
            using(FileStream fs = new FileStream(outputFileName, FileMode.Create, FileAccess.ReadWrite)) {
               if(!jpg) {
                  bitmap.Save(memory, System.Drawing.Imaging.ImageFormat.Png);
               }
               else {
                  ImageCodecInfo codec = ImageCodecInfo.GetImageEncoders().First(c=> c.FormatID == System.Drawing.Imaging.ImageFormat.Jpeg.Guid);
                  var encParams = new EncoderParameters(){
                     Param = new[]{
                        new EncoderParameter(Encoder.Quality, jpgQuality)
                     }
                  };
                  bitmap.Save(memory, codec, encParams);
               }
               byte[] bytes = memory.ToArray();
               await SaveToFile(fs, bytes);
            }
         }
         if(replace) {
            try {
               System.IO.File.Delete(oldPath);
            } catch(Exception ex) {
               MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
         }
      }
      private async Task SaveToFile(FileStream fs, byte[] bytes) {
         await fs.WriteAsync(bytes, 0, bytes.Length);
      }
      private void EnableInteractivity(Button button, bool enable) {
         button.Enabled = enable;
         if(enable)
            button.Cursor = Cursors.Hand;
         else
            button.Cursor = Cursors.WaitCursor;
      }
      private void ChangeJpgPngButtonColors() {
         if(jpgOrPng) {
            convertJpg.BackColor = Color.FromArgb(255, 255, 115, 21);
            convertJpg.ForeColor = Color.FromArgb(255, 244, 244, 244);
            convertPng.BackColor = Color.Transparent;
            convertPng.ForeColor = Color.FromArgb(255, 255, 115, 21);
         } else {
            convertJpg.BackColor = Color.Transparent;
            convertJpg.ForeColor = Color.FromArgb(255, 255, 115, 21);
            convertPng.BackColor = Color.FromArgb(255, 255, 115, 21);
            convertPng.ForeColor = Color.FromArgb(255, 244, 244, 244);
         }
      }
      private void convertJpg_Click(object sender, EventArgs e) {
         jpgOrPng = true;
         ChangeJpgPngButtonColors();
      }
      private void convertPng_Click(object sender, EventArgs e) {
         jpgOrPng = false;
         ChangeJpgPngButtonColors();
      }
      public async void StartConversion() {
         Size = new Size(400, 650);
         Stopwatch watch = new Stopwatch();
         watch.Start();
         //Disable Cursors
         {
            this.Cursor = Cursors.WaitCursor;
            checkUnityMetaFilesRename.Enabled = false;
            checkBoxReplaceFiles.Enabled = false;
            EnableInteractivity(this.ConvertButton, false);
            EnableInteractivity(this.convertJpg, false);
            EnableInteractivity(this.convertPng, false);
            EnableInteractivity(this.selectFile, false);
            EnableInteractivity(this.selectFolder, false);
         }
         for(int i = 0; i < filesLoaded.Count; i++) {
            await Task.Run(() => {ConvertFile(filesLoaded[i], checkBoxReplaceFiles.Checked, checkUnityMetaFilesRename.Checked, false); });
            this.progressBarValue = (int)(((float)(i / filesLoaded.Count)) * 100f);
         }
         this.progressBarValue = 100;
         watch.Stop();
         label6.Text = "Conversion done in " + (watch.ElapsedMilliseconds / 1000).ToString() + " seconds.";
         {
            this.Cursor = Cursors.Default;
            checkUnityMetaFilesRename.Enabled = true;
            checkBoxReplaceFiles.Enabled = true;
            EnableInteractivity(this.ConvertButton, true);
            EnableInteractivity(this.convertJpg, true);
            EnableInteractivity(this.convertPng, true);
            EnableInteractivity(this.selectFile, true);
            EnableInteractivity(this.selectFolder, true);
         }
         if(MessageBox.Show("Conversion Complete") == DialogResult.OK) {
            Application.Exit();
         }
      }
      public async void StartConversionJpeg() {
         Size = new Size(400, 650);
         Stopwatch watch = new Stopwatch();
         watch.Start();
         //Disable Cursors
         {
            this.Cursor = Cursors.WaitCursor;
            checkUnityMetaFilesRename.Enabled = false;
            checkBoxReplaceFiles.Enabled = false;
            EnableInteractivity(this.ConvertButton, false);
            EnableInteractivity(this.convertJpg, false);
            EnableInteractivity(this.convertPng, false);
            EnableInteractivity(this.selectFile, false);
            EnableInteractivity(this.selectFolder, false);
         }
         for(int i = 0; i < filesLoaded.Count; i++) {
            await Task.Run(() => { ConvertFile(filesLoaded[i], checkBoxReplaceFiles.Checked, checkUnityMetaFilesRename.Checked, true); });
            this.progressBarValue = (int)(((float)(i / filesLoaded.Count)) * 100f);
         }
         this.progressBarValue = 100;
         watch.Stop();
         label6.Text = "Conversion done in " + (watch.ElapsedMilliseconds / 1000).ToString() + " seconds.";
         {
            this.Cursor = Cursors.Default;
            checkUnityMetaFilesRename.Enabled = true;
            checkBoxReplaceFiles.Enabled = true;
            EnableInteractivity(this.ConvertButton, true);
            EnableInteractivity(this.convertJpg, true);
            EnableInteractivity(this.convertPng, true);
            EnableInteractivity(this.selectFile, true);
            EnableInteractivity(this.selectFolder, true);
         }
         if(MessageBox.Show("Conversion Complete") == DialogResult.OK) {
            Application.Exit();
         }
      }
      private void deleteItem_Click(object sender, EventArgs e) {
         if(listView1.SelectedItems.Count == 0) {
            var result = MessageBox.Show("Do you want to delete all items?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(result == DialogResult.Yes) {
               listView1.Items.Clear();
               filesLoaded.Clear();
            }
         } else {
            var result = MessageBox.Show("Do you want to delete this item?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(result == DialogResult.Yes) {
               for(int i = 0; i < listView1.SelectedItems.Count; i++) {
                  filesLoaded.Remove(listView1.SelectedItems[i].SubItems[1].Text);
                  listView1.Items.Remove(listView1.SelectedItems[i]);
               }
               listView1.SelectedItems.Clear();
               for(int i = 0; i < listView1.Items.Count; i++) {
                  listView1.Items[i].SubItems[0].Text = (i + 1).ToString();
               }
            }
         }
      }
   }
}