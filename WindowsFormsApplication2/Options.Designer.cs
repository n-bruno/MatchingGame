namespace matchingGame
{
    partial class Options
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Options));
            this.textBox_player_names = new System.Windows.Forms.TextBox();
            this.label_player_name = new System.Windows.Forms.Label();
            this.label_cardsize = new System.Windows.Forms.Label();
            this.textBox_cardx = new System.Windows.Forms.TextBox();
            this.textBox_cardy = new System.Windows.Forms.TextBox();
            this.label_x = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label_title = new System.Windows.Forms.Label();
            this.button_music_on = new System.Windows.Forms.Button();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.label_seperate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_player_names
            // 
            this.textBox_player_names.Location = new System.Drawing.Point(113, 78);
            this.textBox_player_names.Name = "textBox_player_names";
            this.textBox_player_names.Size = new System.Drawing.Size(138, 20);
            this.textBox_player_names.TabIndex = 0;
            this.textBox_player_names.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_player_names_KeyPress);
            // 
            // label_player_name
            // 
            this.label_player_name.AutoSize = true;
            this.label_player_name.BackColor = System.Drawing.Color.Transparent;
            this.label_player_name.ForeColor = System.Drawing.Color.White;
            this.label_player_name.Location = new System.Drawing.Point(34, 78);
            this.label_player_name.Name = "label_player_name";
            this.label_player_name.Size = new System.Drawing.Size(73, 13);
            this.label_player_name.TabIndex = 1;
            this.label_player_name.Text = "Player names:";
            // 
            // label_cardsize
            // 
            this.label_cardsize.AutoSize = true;
            this.label_cardsize.BackColor = System.Drawing.Color.Transparent;
            this.label_cardsize.ForeColor = System.Drawing.Color.White;
            this.label_cardsize.Location = new System.Drawing.Point(51, 124);
            this.label_cardsize.Name = "label_cardsize";
            this.label_cardsize.Size = new System.Drawing.Size(56, 13);
            this.label_cardsize.TabIndex = 3;
            this.label_cardsize.Text = "Card size: ";
            // 
            // textBox_cardx
            // 
            this.textBox_cardx.Location = new System.Drawing.Point(113, 121);
            this.textBox_cardx.MaxLength = 1;
            this.textBox_cardx.Name = "textBox_cardx";
            this.textBox_cardx.Size = new System.Drawing.Size(32, 20);
            this.textBox_cardx.TabIndex = 2;
            this.textBox_cardx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_cardx_KeyPress);
            // 
            // textBox_cardy
            // 
            this.textBox_cardy.Location = new System.Drawing.Point(169, 121);
            this.textBox_cardy.MaxLength = 1;
            this.textBox_cardy.Name = "textBox_cardy";
            this.textBox_cardy.Size = new System.Drawing.Size(32, 20);
            this.textBox_cardy.TabIndex = 4;
            this.textBox_cardy.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_cardy_KeyPress);
            // 
            // label_x
            // 
            this.label_x.AutoSize = true;
            this.label_x.BackColor = System.Drawing.Color.Transparent;
            this.label_x.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_x.ForeColor = System.Drawing.Color.White;
            this.label_x.Location = new System.Drawing.Point(145, 121);
            this.label_x.Name = "label_x";
            this.label_x.Size = new System.Drawing.Size(24, 25);
            this.label_x.TabIndex = 5;
            this.label_x.Text = "×";
            this.label_x.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(113, 208);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Go!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.go_button_Click);
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.BackColor = System.Drawing.Color.Transparent;
            this.label_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_title.ForeColor = System.Drawing.Color.White;
            this.label_title.Location = new System.Drawing.Point(24, 21);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(227, 33);
            this.label_title.TabIndex = 7;
            this.label_title.Text = "Matching game";
            // 
            // button_music_on
            // 
            this.button_music_on.Location = new System.Drawing.Point(113, 164);
            this.button_music_on.Name = "button_music_on";
            this.button_music_on.Size = new System.Drawing.Size(75, 23);
            this.button_music_on.TabIndex = 8;
            this.button_music_on.Text = "Music On";
            this.button_music_on.UseVisualStyleBackColor = true;
            this.button_music_on.Click += new System.EventHandler(this.button2_Click);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(237, 208);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(44, 41);
            this.axWindowsMediaPlayer1.TabIndex = 9;
            this.axWindowsMediaPlayer1.Visible = false;
            // 
            // label_seperate
            // 
            this.label_seperate.AutoSize = true;
            this.label_seperate.BackColor = System.Drawing.Color.Transparent;
            this.label_seperate.ForeColor = System.Drawing.Color.White;
            this.label_seperate.Location = new System.Drawing.Point(13, 91);
            this.label_seperate.Name = "label_seperate";
            this.label_seperate.Size = new System.Drawing.Size(94, 13);
            this.label_seperate.TabIndex = 10;
            this.label_seperate.Text = "(Space seperated)";
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::WindowsFormsApplication2.Properties.Resources.trees;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label_seperate);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.button_music_on);
            this.Controls.Add(this.label_title);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label_x);
            this.Controls.Add(this.textBox_cardy);
            this.Controls.Add(this.label_cardsize);
            this.Controls.Add(this.textBox_cardx);
            this.Controls.Add(this.label_player_name);
            this.Controls.Add(this.textBox_player_names);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Options";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Options";
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_player_names;
        private System.Windows.Forms.Label label_player_name;
        private System.Windows.Forms.Label label_cardsize;
        private System.Windows.Forms.TextBox textBox_cardx;
        private System.Windows.Forms.TextBox textBox_cardy;
        private System.Windows.Forms.Label label_x;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.Button button_music_on;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Label label_seperate;
    }
}

