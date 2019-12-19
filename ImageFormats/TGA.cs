using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ImageConverterGUI.ImageFormats
{
   class TGA
   {
      [DllImport("DLLs\\TGAreader.dll", CallingConvention = CallingConvention.Cdecl)]
      public static extern int GetWidth(string path);

      [DllImport("DLLs\\TGAreader.dll", CallingConvention = CallingConvention.Cdecl)]
      public static extern int GetHeigth(string path);

      [DllImport("DLLs\\TGAreader.dll", CallingConvention = CallingConvention.Cdecl)]
      public static extern int GetPixelDepth(string path);

      [DllImport("DLLs\\TGAreader.dll", CallingConvention = CallingConvention.Cdecl)]
      public static extern IntPtr GetImageData(string path);

      //HeaderData
      public int ImageWidth;
      public int ImageHeigth;
      public int PixelDepth;
      public int size;
      public IntPtr dataPointer;
      public byte[] data;

      public TGA(string FilePath) {
         ImageWidth = GetWidth(FilePath);
         ImageHeigth = GetHeigth(FilePath);
         PixelDepth = GetPixelDepth(FilePath);
         size = PixelDepth / 8 * ImageHeigth * ImageWidth;
         dataPointer = GetImageData(FilePath);
         data = new byte[size];
         for(int i = 0; i < size; i++) {
            data[i] = Marshal.ReadByte(dataPointer,i);
         }
      }
   }
}
