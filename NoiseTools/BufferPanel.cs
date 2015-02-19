using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Text;
using System.Windows.Forms;
using NoiseTools.PerlinNoise;

namespace NoiseTools
{
    public sealed class BufferPanel : Panel
    {
        public BufferPanel()
        {
            textureBuilder = new TextureBuilder(PerlinOptions.RandomNoise);
            this.DoubleBuffered = true;
        }

        private TextureBuilder textureBuilder;

        private List<Bitmap> _imageBuffer = new List<Bitmap>();

        PerlinOptions _perlinOptions = new PerlinOptions();

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public PerlinOptions PerlinOptions
        {
            get { return _perlinOptions; }
            set { _perlinOptions = value; }
        }

        public void Reset()
        {
            textureBuilder.Reset();
        }

        public void RenderPlanet()
        {
            _imageBuffer.Clear();

            var bitmap = new Bitmap(PerlinOptions.Width, PerlinOptions.Width);
            var ro = new RoBitmap(bitmap);
            textureBuilder.RenderCircle(ro, PerlinOptions, PerlinOptions.Width);
            _imageBuffer.Add(ro.Image);
            Invalidate();
        }

        public void RenderSquare()
        {
            _imageBuffer.Clear();

            var bitmap = new Bitmap(PerlinOptions.Width, PerlinOptions.Height);
            var ro = new RoBitmap(bitmap);
            textureBuilder.RenderSquare(ro, PerlinOptions, PerlinOptions.Width, PerlinOptions.Height);
            _imageBuffer.Add(ro.Image); // The idea was to pre generate a few maps
            Invalidate();
        }

        public void Save(String path)
        {
            if (_imageBuffer.Count > 0)
            {
                FileStream myFileOut = new FileStream(path, FileMode.Create);
                _imageBuffer[0].Save(myFileOut, ImageFormat.Png);
                myFileOut.Close();
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            foreach (var bitmap in _imageBuffer)
            {
                g.DrawImage(bitmap, (Width / 2) - bitmap.Width / 2, (Height / 2) - bitmap.Height / 2);
            }

            base.OnPaint(e);
        }
    }
}
