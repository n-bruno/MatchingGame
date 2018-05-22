using System;
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
            //add players
            playerList = new PlayerList();

            int i = 0;
            while (i <= players.Length - 1)
            {
                playerList.addNewPlayer(players[i]);
                i++;
            }
            this.x = x;
            this.y = y;

            arrayRNG nn = new arrayRNG(); //create an RNG object
            int[] RNG = nn.create(x, y);

            //create a pile object with the contents of RNG
            pile = new virtualPile(x, y, RNG); 

            InitializeComponent();
            createCard();

            label_player.Text = playerList.getPlayerName().ToString();
            label_score.Text = playerList.getPlayerScore().ToString();
        }

        private void createCard()
        {
            //dynamically creates buttons

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

        private void Resize_Window(
            int widthOfcard,
            int heightOfcard,
            int cardXDimension,
            int cardYDimension,
            int cardSpacing,
            int xOfcard,
            int yOfCard)
        {
            //insert code here
        }

        private void  Button_Click(object sender, EventArgs e)
        {
                int x = Convert.ToInt32(((Button)sender).Name.Substring(3, 1));
                int y = Convert.ToInt32(((Button)sender).Name.Substring(4, 1));

            /*
             * Modify a button's background image
             * newButton[row, col].BackgroundImage = WindowsFormsApplication2.Properties.Resources.cardbackred;
             * 
             * 
             * Variables that will help you:
             * 
             * private int int_firstCard;
             * private Button obj_firstCard;
             * 
             * private int int_secondCard;
             * private Button obj_secondCard;
             * 
             * These variables will store attributes of the first
             * and second cards. Use these to compares
             */
        }



        private void button_scores_Click(object sender, EventArgs e)
        {
            MessageBox.Show(playerList.printAll(), "Scores");
        }
    }
}
