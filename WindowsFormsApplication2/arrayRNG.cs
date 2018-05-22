using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matchingGame
{
    class arrayRNG
    {
        private int[] array;
        public int[] create(int cardWidth, int cardHeight)
        {
            Random rnd = new Random();
            int possibleNumbers = (cardWidth * cardHeight / 2);
            array = new int[cardWidth * cardHeight];

            for (int i = 0; i <= possibleNumbers; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    int random = rnd.Next(1, possibleNumbers);
                    bool pass = false;

                    while (!pass)
                    {
                        if (array[random] == 0)
                        {
                            array[random] = i;
                            pass = true;
                        }
                        else if (random < array.Length - 1)
                            random++;
                        else
                            random = 0;
                    }
                    
                }
            }
            return array;
        }
    }
}
