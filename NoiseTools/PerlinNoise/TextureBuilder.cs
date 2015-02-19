using System;
using System.Drawing;

namespace NoiseTools.PerlinNoise
{
    public enum Direction
    {
        North,
        East,
        South,
        West
    }

    public class TextureBuilder
    {

        public TextureBuilder(Random rand)
        {
            _noise = new PerlinNoise3D(rand);
            _perlinTexture = new PerlinNoiseTexture(_noise);
        }

        private double _offsetX;
        private double _offsetY;

        public double OffsetX
        {
            get { return _offsetX; }
            set { _offsetX = value; }
        }

        public double OffsetY
        {
            get { return _offsetY; }
            set { _offsetY = value; }
        }

        double step = 0.002;

        public double Step
        {
            get { return step; }
            set { step = value; }
        }

        PerlinNoise3D _noise;

        public PerlinNoise3D Noise
        {
            get { return _noise; }
            set { _noise = value; }
        }

        PerlinNoiseTexture _perlinTexture;

        public PerlinNoiseTexture PerlinTexture
        {
            get { return _perlinTexture; }
            set { _perlinTexture = value; }
        }

        public void RenderSquare(RoBitmap bitmap, PerlinOptions options, int w, int h)
        {
            var data = PerlinTexture.FillRectangle(w, h,OffsetX,OffsetY ,options);

            for (int x = 0; x < data.Length; x++)
            {
                for (int y = 0; y < data[x].Length; y++)
                {
                    bitmap.SetPixel(x, y, data[x][y]);
                }
            }

            OffsetX += step * w;
            OffsetY += step * h;
        }


        public void RenderCircle(RoBitmap bitmap, PerlinOptions options, int radius)
        {
            var data = PerlinTexture.FillCircle(radius, OffsetX, OffsetY, options);

            for (int x = 0; x < data.Length; x++)
            {
                for (int y = 0; y < data[x].Length; y++)
                {
                    bitmap.SetPixel(x, y, data[x][y]);
                }
            }

            OffsetX += step * radius;
            OffsetY += step * radius;
        }

        public void Reset()
        {
            OffsetX = 0;
            OffsetY = 0;
        }
    }
}
