using System;

namespace NoiseTools.PerlinNoise
{
    public class PerlinOptions
    {
        private Random _randomColor = new Random(0);
        private Random _randomNoise = new Random(0);

        private int _width = 500;
        private int _height = 500;


        private int _seedRandomNoise = 0;
        private int _seedRandomColor = 0;

        private double _perlinNoiseStep = 0.0015;

        private bool _reverseRed = true;
        private bool _useCosineOnRed = false;
        private int _minRed = 25;
        private int _maxRed = 25;
        private float _factorRed = 100.0f;

        private bool _reverseGreen = true;
        private bool _useCosineOnGreen = false;
        private int _minGreen = 100;
        private int _maxGreen = 100;
        private float _factorGreen = 100.0f;

        private bool _reverseBlue = true;
        private bool _useCosineOnBlue = false;
        private int _minBlue = 255;
        private int _maxBlue = 255;
        private float _factorBlue = 100.0f;

        private int _octaves = 8;
        private double _lacunarity = 2.85;
        private double _gain = 0.45;
        private double _offset = 1.0;

        public int Width
        {
            get { return _width; }
            set { _width = value; }
        }

        public int Height
        {
            get { return _height; }
            set { _height = value; }
        }

        public int SeedRandomColor
        {
            get { return _seedRandomColor; }
            set { _seedRandomColor = value; }
        }

        public int SeedRandomNoise
        {
            get { return _seedRandomNoise; }
            set { _seedRandomNoise = value; }
        }

        public bool ReverseGreen
        {
            get { return _reverseGreen; }
            set { _reverseGreen = value; }
        }

        public bool ReverseRed
        {
            get { return _reverseRed; }
            set { _reverseRed = value; }
        }

        public bool ReverseBlue
        {
            get { return _reverseBlue; }
            set { _reverseBlue = value; }
        }

        public int Octaves
        {
            get { return _octaves; }
            set { _octaves = value; }
        }

        public double Lacunarity
        {
            get { return _lacunarity; }
            set { _lacunarity = value; }
        }

        public double Gain
        {
            get { return _gain; }
            set { _gain = value; }
        }

        public double Offset
        {
            get { return _offset; }
            set { _offset = value; }
        }

        public bool UseCosineOnRed
        {
            get { return _useCosineOnRed; }
            set { _useCosineOnRed = value; }
        }

        public bool UseCosineOnGreen
        {
            get { return _useCosineOnGreen; }
            set { _useCosineOnGreen = value; }
        }

        public bool UseCosineOnBlue
        {
            get { return _useCosineOnBlue; }
            set { _useCosineOnBlue = value; }
        }


        public Random RandomColor
        {
            get { return _randomColor; }
            set { _randomColor = value; }
        }

        public Random RandomNoise
        {
            get { return _randomNoise; }
            set { _randomNoise = value; }
        }

        public int MinRed
        {
            get { return _minRed; }
            set { _minRed = value; }
        }

        public int MaxRed
        {
            get { return _maxRed; }
            set { _maxRed = value; }
        }

        public float FactorRed
        {
            get { return _factorRed; }
            set { _factorRed = value; }
        }

        public int MinGreen
        {
            get { return _minGreen; }
            set { _minGreen = value; }
        }

        public int MaxGreen
        {
            get { return _maxGreen; }
            set { _maxGreen = value; }
        }

        public float FactorGreen
        {
            get { return _factorGreen; }
            set { _factorGreen = value; }
        }

        public int MinBlue
        {
            get { return _minBlue; }
            set { _minBlue = value; }
        }

        public int MaxBlue
        {
            get { return _maxBlue; }
            set { _maxBlue = value; }
        }

        public float FactorBlue
        {
            get { return _factorBlue; }
            set { _factorBlue = value; }
        }

        public double PerlinNoiseStep
        {
            get { return _perlinNoiseStep; }
            set { _perlinNoiseStep = value; }
        }
    }
}
