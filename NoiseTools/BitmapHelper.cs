using System;
using System.Collections;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

//using System.Windows.Forms;

namespace NoiseTools
{
     public class RoBitmap
    {
        private byte[] bildDaten;
        private Color[,] color;
        private int width;
        private int height;
        Bitmap Bild;
        Rectangle rect;
        int bytes;
        int stride;
        bool modified, indexed;
        Hashtable farbIndex = new Hashtable();
        System.Drawing.Imaging.PixelFormat pixelFormat;
        System.Drawing.Imaging.ColorPalette colorPalette;
        public RoBitmap(Bitmap bld)
        {
            Bild = bld;
            SetzeWerte();
        }
        public RoBitmap(string fileName)
        {
            if (File.Exists(fileName))
            {
                Bild = (Bitmap)System.Drawing.Image.FromFile(fileName);
                SetzeWerte();
            }
        }
        void SetzeWerte()
        {
            colorPalette = Bild.Palette;
            pixelFormat = Bild.PixelFormat;
            width = Bild.Width;
            height = Bild.Height;
            rect = new Rectangle(0, 0, width, height);
            System.Drawing.Imaging.BitmapData bmpData =
                Bild.LockBits(rect, System.Drawing.Imaging.ImageLockMode.ReadOnly,
                Bild.PixelFormat);
            IntPtr ptr = bmpData.Scan0;
            stride = bmpData.Stride;
            bytes = stride * height;
            bildDaten = new byte[bytes];
            System.Runtime.InteropServices.Marshal.Copy(ptr, bildDaten, 0, bytes);
            Bild.UnlockBits(bmpData);
            color = new Color[width, height];
            switch (pixelFormat)
            {
                case System.Drawing.Imaging.PixelFormat.Format32bppArgb:
                    Format32BppArgb();
                    break;
                case System.Drawing.Imaging.PixelFormat.Format24bppRgb:
                    Format24BppRgb();
                    break;
                case System.Drawing.Imaging.PixelFormat.Format8bppIndexed:
                    Format8BppIndexed();
                    indexed = true;
                    break;
                case System.Drawing.Imaging.PixelFormat.Format4bppIndexed:
                    Format4BppIndexed();
                    indexed = true;
                    break;
                case System.Drawing.Imaging.PixelFormat.Format1bppIndexed:
                    Format1BppIndexed();
                    indexed = true;
                    break;
            }
        }
        public Bitmap ConvertToGrayscale()
        {
            Bitmap tmpBitmap = new Bitmap(width, height, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
            System.Drawing.Imaging.BitmapData tmpBmpData =
               tmpBitmap.LockBits(rect, System.Drawing.Imaging.ImageLockMode.WriteOnly,
               tmpBitmap.PixelFormat);
            byte[] tmpBildDaten = new byte[height * tmpBmpData.Stride];
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Color c = color[x, y];
                    int luma = (int)(c.R * 0.3 + c.G * 0.59 + c.B * 0.11);
                    Color tmpColor = Color.FromArgb(luma, luma, luma);
                    tmpBildDaten[y * tmpBmpData.Stride + x * 3 + 2] = tmpColor.R;
                    tmpBildDaten[y * tmpBmpData.Stride + x * 3 + 1] = tmpColor.G;
                    tmpBildDaten[y * tmpBmpData.Stride + x * 3] = tmpColor.B;
                }
            }
            IntPtr ptr = tmpBmpData.Scan0;
            System.Runtime.InteropServices.Marshal.Copy(tmpBildDaten, 0, ptr, height * tmpBmpData.Stride);
            tmpBitmap.UnlockBits(tmpBmpData);
            return tmpBitmap;
        }
        void Format32BppArgb()
        {
            for (int y = 0; y < height; y++)
                for (int x = 0; x < width; x++)
                    color[x, y] = Color.FromArgb(bildDaten[y * stride + x * 4 + 3], bildDaten[y * stride + x * 4 + 2], bildDaten[y * stride + x * 4 + 1], bildDaten[y * stride + x * 4]);
        }
        void Format24BppRgb()
        {
            for (int y = 0; y < height; y++)
                for (int x = 0; x < width; x++)
                    color[x, y] = Color.FromArgb(bildDaten[y * stride + x * 3 + 2], bildDaten[y * stride + x * 3 + 1], bildDaten[y * stride + x * 3]);
        }
        Hashtable verwendeteFarben = new Hashtable();
        void Format8BppIndexed()
        {
            for (int y = 0; y < height; y++)
                for (int x = 0; x < width; x++)
                {
                    color[x, y] = colorPalette.Entries[bildDaten[y * stride + x]];
                    verwendeteFarben[color[x, y]] = true;
                }
            for (int i = 0; i < 256; i++)
                farbIndex[colorPalette.Entries[i].ToArgb()] = i;
        }
        void Format4BppIndexed()
        {
            for (int y = 0; y < height; y++)
                for (int x = 0; x < width; x++)
                    if (x % 2 == 0)
                        color[x, y] = colorPalette.Entries[LowByte(bildDaten[y * stride + x / 2])];
                    else
                        color[x, y] = colorPalette.Entries[HighByte(bildDaten[y * stride + x / 2])];
            for (byte i = 0; i < 16; i++)
                farbIndex[colorPalette.Entries[i].ToArgb()] = i;
        }
        void Format1BppIndexed()
        {
            int rest = width % 8;
            byte bits;
            int x, y;
            for (y = 0; y < height; y++)
            {
                for (x = 0; x < width - 8; x += 8)
                {
                    bits = bildDaten[y * stride + x / 8];
                    color[x, y] = colorPalette.Entries[(bits & 128) / 128];
                    color[x + 1, y] = colorPalette.Entries[(bits & 64) / 64];
                    color[x + 2, y] = colorPalette.Entries[(bits & 32) / 32];
                    color[x + 3, y] = colorPalette.Entries[(bits & 16) / 16];
                    color[x + 4, y] = colorPalette.Entries[(bits & 8) / 8];
                    color[x + 5, y] = colorPalette.Entries[(bits & 4) / 4];
                    color[x + 6, y] = colorPalette.Entries[(bits & 2) / 2];
                    color[x + 7, y] = colorPalette.Entries[bits & 1];
                }
                bits = bildDaten[y * stride + x / 8];
                int teiler = 128;
                for (int i = 0; i < rest; i++)
                {
                    color[x + i, y] = colorPalette.Entries[(bits & teiler) / teiler];
                    teiler /= 2;
                }
                for (int i = 0; i < 2; i++)
                    farbIndex[colorPalette.Entries[i].ToArgb()] = i;
            }
        }
        int HighByte(byte zahl)
        {
            return zahl >> 4;
        }
        int LowByte(byte zahl)
        {

            return zahl & 15;
        }
        public Color GetPixel(int x, int y)
        {
            return color[x, y];
        }
        public bool IndexErweitern = false;
        public void SetPixel(int x, int y, Color col)
        {
            if(indexed)
                if ( !farbIndex.ContainsKey(col.ToArgb()))
                        col = colorPalette.Entries[0];
                    //if(!IndexErweitern)
                    //else
                    //{
                    //    farbIndex[col.ToArgb()] = 4;
                    //    colorPalette.Entries[4] = col;
                    //}
            color[x, y] = col;
            modified = true;
        }
        public int Width
        {
            get { return width; }
        }
        public int Height
        {
            get { return height; }
        }
        public Bitmap Image
        {
            set
            {
                Bild = value;
                SetzeWerte();
            }
            get
            {
                if (!modified) return Bild;
                switch (pixelFormat)
                {
                    case System.Drawing.Imaging.PixelFormat.Format32bppArgb:
                        return ReturnFormat32BppArgb();
                    case System.Drawing.Imaging.PixelFormat.Format24bppRgb:
                        return ReturnFormat24BppRgb();
                    case System.Drawing.Imaging.PixelFormat.Format8bppIndexed:
                        return ReturnFormat8BppIndexed();
                    case System.Drawing.Imaging.PixelFormat.Format4bppIndexed:
                        return ReturnFormat4BppIndexed();
                    case System.Drawing.Imaging.PixelFormat.Format1bppIndexed:
                        return ReturnFormat1BppIndexed();
                }
                return Bild;
            }
        }
        Bitmap ReturnFormat24BppRgb()
        {
            for (int y = 0; y < height; y++)
                for (int x = 0; x < width; x++)
                {
                    bildDaten[y * stride + x * 3 + 2] = color[x, y].R;
                    bildDaten[y * stride + x * 3 + 1] = color[x, y].G;
                    bildDaten[y * stride + x * 3] = color[x, y].B;
                }
            System.Drawing.Imaging.BitmapData bmpData =
               Bild.LockBits(rect, System.Drawing.Imaging.ImageLockMode.WriteOnly,
               Bild.PixelFormat);
            IntPtr ptr = bmpData.Scan0;
            System.Runtime.InteropServices.Marshal.Copy(bildDaten, 0, ptr, bytes);
            Bild.UnlockBits(bmpData);
            modified = false;
            return Bild;
        }
        Bitmap ReturnFormat32BppArgb()
        {
            for (int y = 0; y < height; y++)
                for (int x = 0; x < width; x++)
                {
                    bildDaten[y * stride + x * 4 + 3] = color[x, y].A;
                    bildDaten[y * stride + x * 4 + 2] = color[x, y].R;
                    bildDaten[y * stride + x * 4 + 1] = color[x, y].G;
                    bildDaten[y * stride + x * 4] = color[x, y].B;
                }
            System.Drawing.Imaging.BitmapData bmpData =
               Bild.LockBits(rect, System.Drawing.Imaging.ImageLockMode.WriteOnly,
               Bild.PixelFormat);
            IntPtr ptr = bmpData.Scan0;
            System.Runtime.InteropServices.Marshal.Copy(bildDaten, 0, ptr, bytes);
            Bild.UnlockBits(bmpData);
            modified = false;
            return Bild;
        }
        Bitmap ReturnFormat1BppIndexed()
        {
            byte rest = (byte)(width % 8);
            byte bit = 0;
            int offset = 0;
            int x = 0;
            for (int y = 0; y < height; y++)
            {
                for (x = 0; x < width - 8; x += 8)
                {
                    bit = 0;
                    offset = (y * stride) + (x >> 3);
                    bit |= (byte)((int)farbIndex[color[x, y].ToArgb()] << 7);
                    bit |= (byte)((int)farbIndex[color[x + 1, y].ToArgb()] << 6);
                    bit |= (byte)((int)farbIndex[color[x + 2, y].ToArgb()] << 5);
                    bit |= (byte)((int)farbIndex[color[x + 3, y].ToArgb()] << 4);
                    bit |= (byte)((int)farbIndex[color[x + 4, y].ToArgb()] << 3);
                    bit |= (byte)((int)farbIndex[color[x + 5, y].ToArgb()] << 2);
                    bit |= (byte)((int)farbIndex[color[x + 6, y].ToArgb()] << 1);
                    bit |= (byte)((int)farbIndex[color[x + 7, y].ToArgb()]);
                    bildDaten[offset] = bit;
                }
                if (rest > 0)
                {
                    bit = 0;
                    offset = (y * stride) + (x >> 3);
                    for (int i = 0; i < rest; i++)
                    {
                        bit |= (byte)((int)farbIndex[color[x + i, y].ToArgb()] << 7 - i);
                    }
                    bildDaten[offset] = bit;
                }
            }
            System.Drawing.Imaging.BitmapData bmpData =
               Bild.LockBits(rect, System.Drawing.Imaging.ImageLockMode.WriteOnly,
               Bild.PixelFormat);
            IntPtr ptr = bmpData.Scan0;
            System.Runtime.InteropServices.Marshal.Copy(bildDaten, 0, ptr, bytes);
            Bild.UnlockBits(bmpData);
            modified = false;
            return Bild;
        }
        Bitmap ReturnFormat4BppIndexed()
        {
            for (int y = 0; y < height; y++)
                for (int x = 0; x < width; x += 2)
                {
                    int offset = (y * stride) + (x >> 1);
                    byte highBit = (byte)((byte)farbIndex[color[x, y].ToArgb()] << 4);
                    byte lowBit = 0;
                    if (x + 1 < width)
                        lowBit = (byte)farbIndex[color[x + 1, y].ToArgb()];
                    bildDaten[offset] = (byte)(lowBit + highBit);
                }
            System.Drawing.Imaging.BitmapData bmpData =
               Bild.LockBits(rect, System.Drawing.Imaging.ImageLockMode.WriteOnly,
               Bild.PixelFormat);
            IntPtr ptr = bmpData.Scan0;
            System.Runtime.InteropServices.Marshal.Copy(bildDaten, 0, ptr, bytes);
            Bild.UnlockBits(bmpData);
            modified = false;
            return Bild;
        }
        Bitmap ReturnFormat8BppIndexed()
        {
            for (int y = 0; y < height; y++)
                for (int x = 0; x < width; x += 2)
                {
                    int offset = (y * stride) + x ;
                    byte bit = (byte)((int)farbIndex[color[x, y].ToArgb()] );
                    if (bit == 255)
                    {
                        
                    }
                    bildDaten[offset] = bit;
                }
            System.Drawing.Imaging.BitmapData bmpData =
               Bild.LockBits(rect, System.Drawing.Imaging.ImageLockMode.WriteOnly,
               Bild.PixelFormat);
            IntPtr ptr = bmpData.Scan0;
            System.Runtime.InteropServices.Marshal.Copy(bildDaten, 0, ptr, bytes);
            Bild.UnlockBits(bmpData);
            modified = false;
            return Bild;
        }
        public Bitmap GetTransparent(Color transparentColor)
        {
            return GetTransparent(transparentColor, 0);
        }
        public Bitmap GetTransparent(Color transparentColor, byte tranparenz)
        {
            Bitmap tmpBitmap;
            int newStride=0;
            if (pixelFormat == System.Drawing.Imaging.PixelFormat.Format24bppRgb)
                newStride = stride / 3 * 4;
            else if (pixelFormat == System.Drawing.Imaging.PixelFormat.Format32bppArgb)
                newStride = stride;
            else
            {
                tmpBitmap = (Bitmap)Bild.Clone();
                System.Drawing.Imaging.ColorPalette tmpColorPalette =tmpBitmap.Palette;
                for (int i = 0; i < colorPalette.Entries.Length; i++)
                    if (colorPalette.Entries[i].ToArgb() == transparentColor.ToArgb())
                    {
                        Color col = Color.FromArgb(tranparenz, tmpBitmap.Palette.Entries[i].R,
                            tmpBitmap.Palette.Entries[i].G, tmpBitmap.Palette.Entries[i].B);
                        tmpColorPalette.Entries[i] = col;
                    }
                tmpBitmap.Palette = tmpColorPalette;
                return tmpBitmap;
            }

            tmpBitmap = new Bitmap(width, height, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
            byte[] tmpBildDaten = new byte[height * newStride];
            for (int y = 0; y < height; y++)
                for (int x = 0; x < width; x++)
                {
                    if (color[x, y].ToArgb() != transparentColor.ToArgb())
                        tmpBildDaten[y * width * 4 + x * 4 + 3] = color[x, y].A;
                    else
                        tmpBildDaten[y * width * 4 + x * 4 + 3] = tranparenz;
                    tmpBildDaten[y * width * 4 + x * 4 + 2] = color[x, y].R;
                    tmpBildDaten[y * width * 4 + x * 4 + 1] = color[x, y].G;
                    tmpBildDaten[y * width * 4 + x * 4] = color[x, y].B;
                }
            System.Drawing.Imaging.BitmapData tmpBmpData =
               tmpBitmap.LockBits(rect, System.Drawing.Imaging.ImageLockMode.WriteOnly,
               tmpBitmap.PixelFormat);
            IntPtr ptr = tmpBmpData.Scan0;
            System.Runtime.InteropServices.Marshal.Copy(tmpBildDaten, 0, ptr, height * newStride);
            tmpBitmap.UnlockBits(tmpBmpData);
            return tmpBitmap;
        }
        public Bitmap GetFormat1BppIndexed()
        {
            return GetFormat1BppIndexed(0.5f, Color.Black, Color.White);
        }
        public Bitmap GetFormat1BppIndexed(float brightness)
        {
            return GetFormat1BppIndexed(brightness, Color.Black, Color.White);
        }
        public Bitmap GetFormat1BppIndexed(float brightness, Color _color1, Color _color2)
        {
            Bitmap tmpBitmap = new Bitmap(width, height, System.Drawing.Imaging.PixelFormat.Format1bppIndexed);
            ColorPalette tmpColPal = tmpBitmap.Palette;
            tmpColPal.Entries[0] = _color1;
            tmpColPal.Entries[1] = _color2;
            tmpBitmap.Palette = tmpColPal;
            System.Drawing.Imaging.BitmapData tmpBmpData = tmpBitmap.LockBits(new Rectangle(0, 0, tmpBitmap.Width, tmpBitmap.Height), System.Drawing.Imaging.ImageLockMode.ReadWrite, System.Drawing.Imaging.PixelFormat.Format1bppIndexed);
            IntPtr ptr = tmpBmpData.Scan0;
            int tmpStride = tmpBmpData.Stride;
            int tmpBytes = tmpBmpData.Stride * height;
            byte[] tmpBildDaten = new byte[tmpBytes];
            System.Runtime.InteropServices.Marshal.Copy(ptr, tmpBildDaten, 0, tmpBytes);

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    if (color[x, y].GetBrightness() > brightness)
                    {
                        int index = y * tmpStride + (x >> 3);
                        tmpBildDaten[index] |= (byte)(0x80 >> (x & 0x7));
                    }
                }
            }
            System.Runtime.InteropServices.Marshal.Copy(tmpBildDaten, 0, ptr, tmpBytes);
            tmpBitmap.UnlockBits(tmpBmpData);
            return tmpBitmap;
        }
    }
}

