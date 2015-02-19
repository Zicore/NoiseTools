using System;

namespace NoiseTools.PerlinNoise
{
    public class PerlinNoise3D
    {
        //public Random rand = new Random(102);
        private int[] p = new int[512];
        public int Count = 0;

        public PerlinNoise3D(Random rand)
        {
            Init(rand);
        }

        public void Init(Random rand)
        {
            int nbVals = (1 << 8);
            int[] ms_perm = new int[nbVals];

            // set values as "unused"
            for (int i = 0; i < nbVals; i++)
            {
                ms_perm[i] = -1;
            }

            for (int i = 0; i < nbVals; i++)
            {
                // for each value, find an empty spot, and place it in it
                while (true)
                {
                    // generate rand # with max a nbvals
                    int p = rand.Next() % nbVals;
                    if (ms_perm[p] == -1)
                    {
                        ms_perm[p] = i;
                        break;
                    }
                }
            }

            // Assign the values in the temporary 256 array to the 512 permuation array.
            for (int i = 0; i < nbVals; i++)
                p[nbVals + i] = p[i] = ms_perm[i];
        }

        private static double _fade(double t)
        {
            return (t * t * t * (t * (t * 6 - 15) + 10));
        }

        private static double _lerp(double t, double a, double b)
        {
            return (a + t * (b - a));
        }

        static double grad(int hash, double x, double y, double z)
        {
            int h = hash & 15;
            double u = h < 8 ? x : y;
            double v = h < 4 ? y : h == 12 || h == 14 ? x : z;

            return ((h & 1) == 0 ? u : -u) + ((h & 2) == 0 ? v : -v);
        }

        static double grad(int hash, double x, double y, double z, double w)
        {
            int h = hash & 31; // CONVERT LO 5 BITS OF HASH TO 32 GRAD DIRECTIONS.
            double a = y, b = z, c = w;            // X,Y,Z
            switch (h >> 3)
            {          // OR, DEPENDING ON HIGH ORDER 2 BITS:
                case 1: a = w; b = x; c = y; break;     // W,X,Y
                case 2: a = z; b = w; c = x; break;     // Z,W,X
                case 3: a = y; b = z; c = w; break;     // Y,Z,W
            }
            return ((h & 4) == 0 ? -a : a) + ((h & 2) == 0 ? -b : b) + ((h & 1) == 0 ? -c : c);
        }

        public double noise(double x, double y, double z, double w)
        {
            int X = (int)Math.Floor(x) & 255,                  // FIND UNIT HYPERCUBE
                Y = (int)Math.Floor(y) & 255,                  // THAT CONTAINS POINT.
                Z = (int)Math.Floor(z) & 255,
                W = (int)Math.Floor(w) & 255;
            x -= Math.Floor(x);                                // FIND RELATIVE X,Y,Z,W
            y -= Math.Floor(y);                                // OF POINT IN CUBE.
            z -= Math.Floor(z);
            w -= Math.Floor(w);
            double a = fade(x),                                // COMPUTE FADE CURVES
                   b = fade(y),                                // FOR EACH OF X,Y,Z,W.
                   c = fade(z),
                   d = fade(w);
            int A = p[X] + Y, AA = p[A] + Z, AB = p[A + 1] + Z,      // HASH COORDINATES OF
                B = p[X + 1] + Y, BA = p[B] + Z, BB = p[B + 1] + Z,      // THE 16 CORNERS OF
                AAA = p[AA] + W, AAB = p[AA + 1] + W,                // THE HYPERCUBE.
                ABA = p[AB] + W, ABB = p[AB + 1] + W,
                BAA = p[BA] + W, BAB = p[BA + 1] + W,
                BBA = p[BB] + W, BBB = p[BB + 1] + W;

            return _lerp(d,                                     // INTERPOLATE DOWN.
                _lerp(c, _lerp(b, _lerp(a, grad(p[AAA], x, y, z, w),
                                     grad(p[BAA], x - 1, y, z, w)),
                              _lerp(a, grad(p[ABA], x, y - 1, z, w),
                                     grad(p[BBA], x - 1, y - 1, z, w))),

                       _lerp(b, _lerp(a, grad(p[AAB], x, y, z - 1, w),
                                     grad(p[BAB], x - 1, y, z - 1, w)),
                              _lerp(a, grad(p[ABB], x, y - 1, z - 1, w),
                                     grad(p[BBB], x - 1, y - 1, z - 1, w)))),

                _lerp(c, _lerp(b, _lerp(a, grad(p[AAA + 1], x, y, z, w - 1),
                                     grad(p[BAA + 1], x - 1, y, z, w - 1)),
                              _lerp(a, grad(p[ABA + 1], x, y - 1, z, w - 1),
                                     grad(p[BBA + 1], x - 1, y - 1, z, w - 1))),

                       _lerp(b, _lerp(a, grad(p[AAB + 1], x, y, z - 1, w - 1),
                                     grad(p[BAB + 1], x - 1, y, z - 1, w - 1)),
                              _lerp(a, grad(p[ABB + 1], x, y - 1, z - 1, w - 1),
                                     grad(p[BBB + 1], x - 1, y - 1, z - 1, w - 1)))));
        }

        static double fade(double t) { return t * t * t * (t * (t * 6 - 15) + 10); }

        private double noise(double x, double y, double z)
        {
            int X = (int)x & 255,
                Y = (int)y & 255,
                Z = (int)z & 255;

            x -= Math.Floor(x);
            y -= Math.Floor(y);
            z -= Math.Floor(z);

            double u = _fade(x);
            double v = _fade(y);
            double w = _fade(z);

            int A = p[X] + Y, AA = p[A] + Z, AB = p[A + 1] + Z;
            int B = p[X + 1] + Y, BA = p[B] + Z, BB = p[B + 1] + Z;

            return _lerp(w, _lerp(v, _lerp(u, grad(p[AA], x, y, z),
                                              grad(p[BA], x - 1, y, z)),
                                     _lerp(u, grad(p[AB], x, y - 1, z),
                                              grad(p[BB], x - 1, y - 1, z))),
                            _lerp(v, _lerp(u, grad(p[AA + 1], x, y, z - 1),
                                              grad(p[BA + 1], x - 1, y, z - 1)),
                                     _lerp(u, grad(p[AB + 1], x, y - 1, z - 1),
                                              grad(p[BB + 1], x - 1, y - 1, z - 1))));

        }

        public static double ridge(double h, double offset)
        {
            h = Math.Abs(h);
            h = offset - h;
            h = h * h;
            return h;
        }

        public double RidgedMF(double x, double y, double z, int octaves, double lacunarity, double gain, double offset)
        {
            double sum = 0;
            double amplitude = 0.5f;
            double frequency = 1.0f;
            double prev = 1.0f;

            for (int i = 0; i < octaves; i++)
            {
                double n = ridge(noise(x * frequency, y * frequency, z * frequency), offset);
                sum += n * amplitude * prev;
                prev = n;
                frequency *= lacunarity;
                amplitude *= gain;
            }

            return sum;
        }

        static double frequency = 1.0f;
        static double amplitude = 0.5f;
        static double sum = 0.0f;

        public double fBm(double x, double y, double z, int octaves, float lacunarity, float gain)
        {
            for (int i = 0; i < octaves; i++)
            {
                sum += noise(x * frequency, y * frequency, z * frequency) * amplitude;
                frequency *= lacunarity;
                amplitude *= gain;
            }
            return sum;
        }
    }
}