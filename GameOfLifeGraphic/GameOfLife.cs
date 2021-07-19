using System;


namespace GameOfLife
{
    class Field
    {
        private readonly byte Alive = 1;
        private readonly byte Dead = 0;
        private readonly int Height;
        private readonly int Width;
        private readonly byte[,] FieldNow;
        private readonly byte[,] FieldNext;

        public byte[,] FieldCurrent
        {
            get => FieldNow;
        }

        public Field() : this(10, 10)
        {
        }
        public Field(int height, int width)
        {
            Height = height;
            Width = width;
            FieldNow = new byte[height, width];
            FieldNext = new byte[height, width];
        }

        public byte[,] FillRandom(float fillPercent)
        {
            Random rnd = new();

            for (int i = 0; i < Height; i++)
            {
                for (int j = 0; j < Width; j++)
                {
                    FieldNow[i, j] = rnd.NextDouble() <= fillPercent ? Alive : Dead;
                }
            }
            return FieldNow;
        }

        public void UpdateField()
        {
            for (int i = 1; i < Height - 1; i++)
            {
                for (int j = 1; j < Width - 1; j++)
                {
                    bool isAlive = FieldNow[i, j] == 1;

                    byte numNeigbours =
                        (byte)
                        (FieldNow[i - 1, j] +
                        FieldNow[i - 1, j - 1] +
                        FieldNow[i - 1, j + 1] +
                        FieldNow[i, j - 1] +
                        FieldNow[i + 1, j] +
                        FieldNow[i + 1, j + 1] +
                        FieldNow[i + 1, j - 1] +
                        FieldNow[i, j + 1]);

                    bool stayAlive = isAlive && (numNeigbours == 2 || numNeigbours == 3);
                    bool born = !isAlive && numNeigbours == 3;

                    FieldNext[i, j] = stayAlive | born ? Alive : Dead;

                }
            }
            for (int i = 0; i < Height; i++)
            {
                for (int j = 0; j < Width; j++)
                {
                    FieldNow[i, j] = FieldNext[i, j];
                }
            }
        }

    }

}
