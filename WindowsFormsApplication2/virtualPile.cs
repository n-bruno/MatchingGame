using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matchingGame
{
    class virtualPile
    {
        private int[,] array;

        public virtualPile(int width, int height, int[] RNG)
        {
            array = new int[width, height];

            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    array[i, j] = RNG[i + (j * height)];
                }
            }
        }

        public int getValue(int x, int y) {
            return array[x, y];
        }
    }
}
