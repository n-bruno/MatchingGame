/**
 * Project :        Matching Game
 * Class :          InternalBoard
 * Author :         Chris Kane and Nick Bruno
 * Description :    An internal representation of the card pile
 */

using System;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    class VirtualPile
    {
        private int[,] internalPile;
        private int numberOfCardsLeft;

        public VirtualPile(int width, int height)
        {
            numberOfCardsLeft = width * height;

            internalPile = new int[width, height];
            int[] RNGarray = RNGGenerate(width, height);

            int k = 0;
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                    internalPile[i, j] = RNGarray[k++];
            }
        }

        public bool checkMatch(int firstCardX, int firstCardY, int secondCardX, int secondCardY)
        {
            bool pass = internalPile[firstCardX, firstCardY] == internalPile[secondCardX, secondCardY];
            if (pass)
                MessageBox.Show("We have a match!");
            return pass;
        }

        private int[] RNGGenerate(int cardWidth, int cardHeight)
        {
            Random rnd = new Random();
            int possibleNumbers = (cardWidth * cardHeight / 2);
            int[] array = new int[cardWidth * cardHeight];

            //loop for each possible number
            for (int i = 0; i <= possibleNumbers; i++)
            {
                for (int j = 0; j < 2; j++) //add two instances of a number
                {
                    //randomly generated index
                    int random = rnd.Next(1, cardWidth * cardHeight);
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

        public bool MatchFoundIsGameOver()
        {
            numberOfCardsLeft -= 2;
            return (numberOfCardsLeft < 1);
        }

        public int getValue(int x, int y)
        { return internalPile[x, y]; }
    }
}
