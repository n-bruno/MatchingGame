/**
 * Project :        Matching Game
 * Class :          Winner
 * Author :         Chris Kane and Nick Bruno
 * Description :    A class to determine the winner
 */
using matchingGame;
using System.Collections;
using System.Windows.Forms;
namespace WindowsFormsApplication2
{
    class Winner
    {
        private int numOfPlayers;
        private PlayerList playerList;
        private Stack stackOfWinners = new Stack();

        public Winner(PlayerList playerList)
        {
            numOfPlayers = playerList.getPlayerNum();
            this.playerList = playerList;
        }

        public void determineWinner()
        {
            /*
             * This method finds the winners and stores then in a stack.
             * WARNING: Relatively complex logic ahead
             */

            //The highestScore counter keeps track of the highest score found
            int highestScore = -1;
            /*
             * set the highest score to -1
             * this will result in the first player in the list being inserted into the stack
            */
            int size = 0;
            for (int i = 0; i < numOfPlayers; i++)
            {
                if (!(playerList.getPlayerScore() >= highestScore))
                {
                    if (playerList.getPlayerScore() > highestScore) //greater than highest score?
                    {
                        //get rid of the previous found highest score player(s)
                        //this person has a highest score now
                        size = 0;
                        highestScore = playerList.getPlayerScore();
                        stackOfWinners = new Stack();
                    } //if not, then insert the tied person
                    stackOfWinners.Push(playerList.getPlayerName());
                    size++;
                    //insert the individual into the stack
                }
                playerList.setNextPlayer();
            }
            printWinners(stackOfWinners, size, highestScore);
        }

        /*
         * print the winners and display them in a message box
         */
        private void printWinners(Stack stackOfWinners, int size, int highestScore)
        {
            string winners = "Here's a list of our winner(s):\n";
            for (int i = 0; i < size; i++)
                winners += stackOfWinners.Pop() + " with " + highestScore + " pairs.\n";
            MessageBox.Show(winners, "The Winners");
        }
    }
}