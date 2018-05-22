using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace matchingGame
{
    public partial class Form_Game : Form
    {
        private PlayerList playerList;
        private int x = 0;
        private int y = 0;
        private virtualPile pile;
        private Button[,] newButton;

        private int int_firstCard;
        private Button obj_firstCard;

        private int int_secondCard;
        private Button obj_secondCard;

        public Form_Game(int x, int y, String[] players)
        {
            playerList = new PlayerList();

            int i = 0;
            while (i <= players.Length - 1)
            {
                playerList.addNewPlayer(players[i]);
                i++;
            }
            this.x = x;
            this.y = y;

            arrayRNG nn = new arrayRNG();
            int[] RNG = nn.create(x, y);

            pile = new virtualPile(x, y, RNG);

            InitializeComponent();
            createCard();

            label_player.Text = playerList.getPlayerName().ToString();
            label_score.Text = playerList.getPlayerScore().ToString();
        }

        private void Game_Load(object sender, EventArgs e)
        {
            
            
        }

        private void createCard()
        {
            int cardDimension = x * y;
            int cardButtonWidth = 40; //WindowsFormsApplication2.Properties.Resources.cardbackred.Width;
            int cardButtonHeight = 55;//WindowsFormsApplication2.Properties.Resources.cardbackred.Height;
            int padding = 20;
            Size size = new Size(cardButtonWidth, cardButtonHeight);
            Point loc = new Point(0, 0);
            int topMargin = 60;
            int xx = x;
            int yy = y;
            newButton = new Button[x, y];

            char[] bingoLetters = new char[cardDimension - 1];

            for (int row = 0; row < x; row++)
            {
                loc.Y = topMargin + row * (size.Height + padding);
                int extraLeftPadding = 50;
                for (int col = 0; col < y; col++)
                {
                    newButton[row, col] = new Button();
                    newButton[row, col].Location = new Point(extraLeftPadding + col * (size.Width + padding), loc.Y);
                    newButton[row, col].Size = size;
                    newButton[row, col].Font = new Font("Arial", 24, FontStyle.Bold);
                    newButton[row, col].Font = new Font("Arial", 24, FontStyle.Bold);
                    newButton[row, col].Enabled = true;
                    newButton[row, col].Name = "btn" + row.ToString() + col.ToString();
                    newButton[row, col].Click += new EventHandler(Button_Click);
                    newButton[row, col].BackgroundImage = WindowsFormsApplication2.Properties.Resources.cardbackred;
                    newButton[row, col].BackgroundImageLayout = ImageLayout.Stretch;

                    Controls.Add(newButton[row, col]);
                    xx += cardButtonWidth + padding;
                }
                yy = yy + cardButtonHeight + padding;
            }
        }

        private void  Button_Click(object sender, EventArgs e)
        {
                int x = Convert.ToInt32(((Button)sender).Name.Substring(3, 1));
                int y = Convert.ToInt32(((Button)sender).Name.Substring(4, 1));

                int cardValue = pile.getValue(x, y);

                if (cardValue == 1)
                    ((Button)sender).BackgroundImage = WindowsFormsApplication2.Properties.Resources.card1;
                else if (cardValue == 2)
                    ((Button)sender).BackgroundImage = WindowsFormsApplication2.Properties.Resources.card2;
                else if (cardValue == 3)
                    ((Button)sender).BackgroundImage = WindowsFormsApplication2.Properties.Resources.card3;
                else if (cardValue == 4)
                    ((Button)sender).BackgroundImage = WindowsFormsApplication2.Properties.Resources.card4;
                else if (cardValue == 5)
                    ((Button)sender).BackgroundImage = WindowsFormsApplication2.Properties.Resources.card5;
                else if (cardValue == 6)
                    ((Button)sender).BackgroundImage = WindowsFormsApplication2.Properties.Resources.card6;
                else if (cardValue == 7)
                    ((Button)sender).BackgroundImage = WindowsFormsApplication2.Properties.Resources.card7;
                else if (cardValue == 8)
                    ((Button)sender).BackgroundImage = WindowsFormsApplication2.Properties.Resources.card8;
                else if (cardValue == 9)
                    ((Button)sender).BackgroundImage = WindowsFormsApplication2.Properties.Resources.card9;
                else
                    ((Button)sender).BackgroundImage = WindowsFormsApplication2.Properties.Resources.cardx;

                if (obj_firstCard == null)
                {
                    obj_firstCard = (Button)sender;
                    int_firstCard = pile.getValue(x, y);
                }
                else
                {
                    obj_secondCard = (Button)sender;
                    int_secondCard = pile.getValue(x, y);

                    if (int_secondCard == int_firstCard)
                    {
                        MessageBox.Show("Match", "Match");

                        obj_firstCard = null;
                        int_firstCard = 0;

                        obj_secondCard = null;
                        int_secondCard = 0;

                    }
                    else
                    {
                        MessageBox.Show("No Match", "No Match");

                        obj_firstCard.BackgroundImage = WindowsFormsApplication2.Properties.Resources.cardbackred;

                        obj_secondCard.BackgroundImage = WindowsFormsApplication2.Properties.Resources.cardbackred;

                        obj_firstCard = null;
                        int_firstCard = 0;

                        obj_secondCard = null;
                        int_secondCard = 0;
                    }

            }




        }



        private void button_scores_Click(object sender, EventArgs e)
        {
            MessageBox.Show(playerList.printAll(), "Scores");
        }
    }
}
