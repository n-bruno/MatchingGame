/**
 * Project :        Matching Game
 * Class :          Options Form
 * Author :         Chris Kane and Nick Bruno
 * Description :    For the options form
 */
using System;
using System.IO;
using System.Windows.Forms;
using WMPLib;

namespace matchingGame
{
    public partial class Form_Options : Form
    {
        bool[] enable = new bool[3];
        bool musicOn = false;
        bool isCardAnimationOn = false;

        Form form;

        musicPlayer play = new musicPlayer();

        public Form_Options()
        { InitializeComponent(); }

        private void textBox_player_names_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar);
        }

        private void textBox_cardx_KeyPress(object sender, KeyPressEventArgs e)
        { e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar); }

        private void textBox_cardy_KeyPress(object sender, KeyPressEventArgs e)
        { e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar); }

        private void go_button_Click(object sender, EventArgs e)
        {
            if (textBox_player_names.Text != "")
                if (textBox_cardx.Text != "" && textBox_cardy.Text != "")
                {
                    int x = int.Parse(textBox_cardx.Text),
                        y = int.Parse(textBox_cardy.Text);

                    if ((x >= 2 && y >= 2) && (x <= 7 && y <= 7))

                        if ((x % 2 == 0 || y % 2 == 0) || (x % 2 == 0 && y % 2 == 0))
                        {
                            textBox_player_names.Text = textBox_player_names.Text.Replace("  ", " ");
                            string[] players = textBox_player_names.Text.Split(' ');
                            if (players.Length < 8)
                            {
                                bool pass = true;

                                for (int i = 0; pass && i < players.Length; i++)
                                    for (int j = 0; pass && j < players.Length; j++)
                                    {
                                        if (i != j && players[i] == players[j])
                                            pass = false;
                                        if (players[i].Equals("") || players[i].Equals(" "))
                                            pass = false;
                                    }

                                if (pass)
                                {
                                    Form_Game frm = new Form_Game(ref form, x, y, players, isCardAnimationOn);
                                    //frm.FormClosed += new FormClosedEventHandler(Options_FormClosed);

                                    frm.Show();
                                    Visible = false;
                                }
                                else MessageBox.Show("Two players can't have the same names. They also can't be blank.", "Error");
                            }
                            else MessageBox.Show("Whoa, you have too many players. 7 at max.", "Error");
                        }
                        else MessageBox.Show("Both numbers can't be odd.", "Error");
                    else MessageBox.Show("Dimensions must be greater than 1 and less than 8.", "Error");
                }
                else MessageBox.Show("Dimensions fields cannot be blank.", "Error");
            else MessageBox.Show("You need to have at least one player to play.", "Error");
        }

        //source: http://stackoverflow.com/questions/1669318/override-standard-close-x-button-in-a-windows-form

        private void checkBox_music_CheckedChanged(object sender, EventArgs e)
        {
            musicOn = !musicOn;
            if (musicOn)
                play.play();
            else play.stop();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            isCardAnimationOn = !isCardAnimationOn;

            if (isCardAnimationOn)
                MessageBox.Show("The card flipping animation" +
                                        "is fully functional on powerful machines, however, " +
                                        "on less powerful machines, the graphics will not referesh " +
                                        "properly.");
        }

        private void Form_Options_Load(object sender, EventArgs e)
        { form = (Form)sender; }

        private void Form_Close(object sender, EventArgs e)
        { form = (Form)sender; }

        /*
         * A class to play those rad tunes!
         */
        class musicPlayer
        {
            WindowsMediaPlayer song = new WindowsMediaPlayer();

            public void play()
            {
                string st = Directory.GetCurrentDirectory();

                st = st.Substring(0, st.IndexOf("\\bin\\"));

                song.URL = st + "\\Resources\\Music.mp3";
                song.settings.setMode("Loop", true);
                song.controls.play();
            }
            public void stop()
            { song.controls.stop(); }
        }
    }
}
