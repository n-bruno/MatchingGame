/**
* Class :          arrayRNG
* Author :         Chris Kane and Nick Bruno
* Description :    Fill an array with random number pairs
*/

using System;

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

            //loop for each possible number
            for (int i = 0; i <= possibleNumbers; i++) 
            {
                for (int j = 0; j < 2; j++) //add two instances of a number
                {
                    //randomly generated index
                    int random = rnd.Next(1, possibleNumbers);
                    bool pass = false;

                    while (!pass) //check if number has been inserted
                    {
                        if (array[random] == 0)
                        {
                            array[random] = i; //add number
                            pass = true;
                        }
                        //if index has a value, move to the next index
                        else if (random < array.Length - 1)
                            random++;
                        else
                            random = 0;
                        //if reached end of array, go to index 0
                        //this prevents you going out of bounds
                    } 
                }
            }
            return array;
        }
    }
}
