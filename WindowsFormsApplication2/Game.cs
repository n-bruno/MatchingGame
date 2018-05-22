/**
 * Project :        Matching Game
 * Class :          Game Form
 * Author :         Chris Kane and Nick Bruno
 * Description :    For the game form
 */

using System;
using System.Drawing;
using System.IO;
using System.Media;
using System.Threading;
using System.Windows.Forms;
using WindowsFormsApplication2;

namespace matchingGame
{
    public partial class Form_Game : Form
    {
        private PlayerList playerList = null;
        private int pilex = 0, piley = 0;

        private VirtualPile board = null;

        private Button[] buttonArray = new Button[2];
        private int card1Value;
        private bool isCardAnimationOn;

        private Form form;
        private ImageList deckOfCards = new ImageList();

        public Form_Game(ref Form form, int x, int y, String[] players, bool isCardAnimationOn)
        {
            this.isCardAnimationOn = isCardAnimationOn;
            playerList = new PlayerList();

            for (int i = 0; i <= players.Length - 1; i++)
                playerList.addNewPlayer(players[i]);

            this.pilex = x;
            this.piley = y;

            board = new VirtualPile(x, y);
            setUpImageList();

            InitializeComponent();
            this.AutoSize = true;
            this.form = form;

            queueUpdate();
        }

        private void queueUpdate()
        {
            label_current_players.Text = playerList.printCurrent();
            label_all_score_display.Text = playerList.printAll(false);
        }

        private void button_create_cards_Click(object sender, EventArgs e)
        {
            button_create_cards.Visible = button_create_cards.Enabled = false;

            MessageBox.Show("Going to create the cards. In the case you have a less powerful machine and/or are " +
                "requesting a lot of cards, the form may buffer or freeze momentarily.");

            createCard();
        }

        private void createCard()
        {
            //code for a sound effect 
            String st = Directory.GetCurrentDirectory();
            st = st.Substring(0, st.IndexOf("\\bin\\"));
            SoundPlayer file = new SoundPlayer(st + "\\Resources\\card_appear.wav");
            object lockObject = new object();

            int cardDimension = pilex * piley, padding = 20;
            int cardButtonWidth = WindowsFormsApplication2.Properties.Resources.cardbackred.Width;
            int cardButtonHeight = WindowsFormsApplication2.Properties.Resources.cardbackred.Height;

            Size size = new Size(cardButtonWidth, cardButtonHeight);
            Point loc = new Point(0, 0);
            int topMargin = 60;
            int xx = pilex, yy = piley;
            Button[,] newButton = new Button[pilex, piley];

            for (int row = 0; row < pilex; row++)
            {
                loc.Y = topMargin + row * (size.Height + padding);
                int extraLeftPadding = 100;
                for (int col = 0; col < piley; col++)
                {
                    newButton[row, col] = new Button();
                    newButton[row, col].Location = new Point(extraLeftPadding + col * (size.Width + padding), loc.Y);
                    newButton[row, col].Size = size;
                    newButton[row, col].Enabled = true;
                    newButton[row, col].Name = "btn" + row.ToString() + col.ToString();
                    newButton[row, col].Click += new EventHandler(Button_Click);
                    newButton[row, col].BackgroundImage = WindowsFormsApplication2.Properties.Resources.cardbackred;
                    newButton[row, col].BackgroundImageLayout = ImageLayout.Stretch;

                    //System.Threading.Thread.Sleep(100);

                    //source: stack overflow: pausing a method for set # of milliseconds
                    //this adds a delay when the cards a laid down
                    lock (lockObject)
                    {
                        Controls.Add(newButton[row, col]);
                        Monitor.Wait(lockObject, 200);
                    }

                    xx += cardButtonWidth + padding;

                    file.Play(); //play the sound effect for setting down the cards
                    CenterToScreen();
                }
                yy = yy + cardButtonHeight + padding;
            }
        }

        private void setUpImageList()
        {
            for (int i = 0; i < 50; i++)
            {
                Image image = Image.FromFile(i + ".png");
                deckOfCards.Images.Add(i.ToString(), image);
            }
            deckOfCards.ImageSize = new Size(112, 112);
        }

        /*
         * Handles the animation for flipping the card over.
         */
        private Button Button_flip(object sender, EventArgs e, int xx, ref Button card, int speed, int initialWidth)
        {
            if (isCardAnimationOn)
            {
                xx -= speed;
                Image imageVar = card.BackgroundImage;

                object lockObject = new object();
                while (xx >= Math.Abs(speed) && xx <= initialWidth)
                {
                    lock (lockObject)
                    {
                        card.Size = new Size(xx, card.Height);
                        card.BackgroundImage = new Bitmap(imageVar, new Size(card.Width, card.Height));
                        card.Location = new Point(card.Location.X + speed / 2, card.Location.Y);
                        Monitor.Wait(lockObject, 20);
                        xx -= speed;
                    }
                }
            }
            else
            {
                Image imageVar = card.BackgroundImage;
                card.BackgroundImage = new Bitmap(imageVar, new Size(card.Width, card.Height));
            }
            return card;
        }

        private void button_flip(object sender, EventArgs e, ref Button card, int speed, int initialWidth, int x, int y)
        {
            Button button = ((Button)sender);
            button.Enabled = false;
            int xx = ((Button)sender).Width;

            Image imageVar = card.BackgroundImage;

            if (isCardAnimationOn)
                Button_flip(sender, e, button.Width, ref button, speed, initialWidth);

            button.BackgroundImage = deckOfCards.Images[board.getValue(x, y)];

            if (isCardAnimationOn)
                Button_flip(sender, e, button.Width, ref button, -speed, initialWidth);
        }

        private void Button_Click(object sender, EventArgs e)
        {
            int speed = 4, initialWidth = ((Button)sender).Width;

            int x = Convert.ToInt32(((Button)sender).Name[3].ToString()),
                y = Convert.ToInt32(((Button)sender).Name[4].ToString());

            int cardValue = board.getValue(x, y);

            if (buttonArray[0] == null)
            {
                buttonArray[0] = ((Button)sender);
                button_flip(sender, e, ref buttonArray[0], speed, buttonArray[0].Width, x, y);
                card1Value = board.getValue(x, y);
            }
            else if (buttonArray[1] == null)
            {
                buttonArray[1] = ((Button)sender);
                button_flip(sender, e, ref buttonArray[1], speed, buttonArray[1].Width, x, y);

                if (card1Value == board.getValue(x, y))
                {
                    String st = Directory.GetCurrentDirectory();
                    st = st.Substring(0, st.IndexOf("\\bin\\"));
                    SoundPlayer file = new SoundPlayer(st + "\\Resources\\card_remove.wav");
                    file.Play();

                    playerList.incrementPlayerScore();

                    if (!playerList.getNextPlayer().Equals(playerList.getCurrentPlayer()))
                        MessageBox.Show(playerList.getCurrentPlayer().getPlayerName() + " has scored 1 point!\n");
                    else
                        MessageBox.Show("It's a match.");

                    queueUpdate();

                    for (int i = 0; i < 2; i++)
                    {
                        Button_flip(buttonArray[i], e, buttonArray[i].Width, ref buttonArray[i], speed, initialWidth);

                        buttonArray[i].Visible = false;
                        buttonArray[i] = null;
                    }

                    //playerList.getNextPlayer();

                    if (board.MatchFoundIsGameOver())
                    {
                        if (!playerList.getNextPlayer().Equals(playerList.getCurrentPlayer()))
                        { //check if not one player game
                            Winner getWinner = new Winner(playerList);
                            getWinner.determineWinner();
                            MessageBox.Show("Thanks for playing! Here is a list of everyone's scores!\n" +
                            playerList.printAll(true), "Scores");
                        }
                        else
                            MessageBox.Show("Have fun playing solo?");

                        switch (MessageBox.Show(this, "Do you want to play another game", "Closing", MessageBoxButtons.YesNo))
                        {
                            case DialogResult.No:
                                form.Close();
                                break;
                            default:
                                Close();
                                break;
                        }
                    }
                    else
                    {
                        if (!playerList.getNextPlayer().Equals(playerList.getCurrentPlayer())) //check if not one player game
                            MessageBox.Show(playerList.getPlayerName() + " gets to go again.");
                    }
                }
                else
                {
                    MessageBox.Show("No match.", "Scores");

                    for (int i = 0; i < 2; i++)
                    {

                        Button_flip(buttonArray[i], e, buttonArray[i].Width, ref buttonArray[i], speed, initialWidth);
                        buttonArray[i].BackgroundImage = WindowsFormsApplication2.Properties.Resources.cardbackred;
                        Button_flip(buttonArray[i], e, buttonArray[i].Width, ref buttonArray[i], -speed, initialWidth);

                        buttonArray[i].Enabled = true;
                        buttonArray[i] = null;
                    }

                    playerList.setNextPlayer();
                    queueUpdate();
                }
            }
        }

        private void Form_Game_FormClosed(object sender, FormClosedEventArgs e)
        { form.Visible = true; }
    }
}
