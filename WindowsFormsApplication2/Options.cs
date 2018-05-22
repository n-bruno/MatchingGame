using System;
using System.IO;
using System.Windows.Forms;
using WMPLib;

namespace matchingGame
{
    public partial class Options : Form
    {
        bool[] enable = new bool[3];

        bool musicOn = false;

        player play = new player();

        public Options()
        {
            InitializeComponent();
        }

        private void textBox_player_names_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar);
        }

        private void textBox_cardx_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox_cardy_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void go_button_Click(object sender, EventArgs e)
        {

            if (textBox_player_names.Text != "")
            {
                if (textBox_cardx.Text != "" && textBox_cardy.Text != "")
                {
                    int x = int.Parse(textBox_cardx.Text);
                    int y = int.Parse(textBox_cardx.Text);


                    if (x > 2 && y > 2)
                    {
                        if (x % 2 == 0 || y % 2 == 0)
                        {
                            textBox_player_names.Text = textBox_player_names.Text.Replace("  ", " ");

                            String[] players = textBox_player_names.Text.Split(' ');

                            bool pass = true;

                                int i = 0;
                                while (pass && i < players.Length)
                                {
                                    int j = 0;
                                    while (pass && j < players.Length)
                                    {
                                        if (i != j && players[i] == players[j])
                                            pass = !pass;
                                        j++;
                                    }
                                    i++;
                                }
                            
                            if (pass){
                                Form_Game frm = new Form_Game(x, y, players);
                                frm.FormClosed += new FormClosedEventHandler(Options_FormClosed);

                                frm.Show();
                                this.Visible = false;
                            } else
                                MessageBox.Show("Two players can't have the same names.", "Error");
                        }
                        else
                            MessageBox.Show("Both numbers can't be odd.", "Error");
                    }
                    else
                        MessageBox.Show("Dimensions must be greater than 2.", "Error");

                }
                else
                    MessageBox.Show("Dimensions fields cannot be blank.", "Error");
            }
            else
                MessageBox.Show("You need to have at least one player to play.", "Error");
        }

        //source: http://stackoverflow.com/questions/1669318/override-standard-close-x-button-in-a-windows-form

        private void Options_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (e.CloseReason == CloseReason.WindowsShutDown)
                return;

            // Confirm user wants to close
            switch (MessageBox.Show(this, "Are you sure you want to close?", "Closing", MessageBoxButtons.YesNo))
            {
                case DialogResult.No:
                    e.Cancel = true;
                    break;
                default:
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (musicOn)
            {
                play.stop();

                button_music_on.Text = "Music On";
            }

            else
            {
                play.play();
                button_music_on.Text = "Music Off";
            }
            musicOn = !musicOn;
        }
    }

    class player
    {
        WindowsMediaPlayer song = new WindowsMediaPlayer();

        public void play()
        {
            String st = Directory.GetCurrentDirectory();

            st = st.Substring(0, st.IndexOf("\\bin\\"));

            song.URL = st + "\\Resources\\Music.mp3";
            song.controls.play();
        }
        public void stop()
        {
            song.controls.stop();
        }
    }
}
