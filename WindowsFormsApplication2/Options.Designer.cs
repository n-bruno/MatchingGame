namespace matchingGame
{
    partial class Form_Options
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Options));
            this.textBox_player_names = new System.Windows.Forms.TextBox();
            this.label_player_name = new System.Windows.Forms.Label();
            this.label_cardsize = new System.Windows.Forms.Label();
            this.textBox_cardx = new System.Windows.Forms.TextBox();
            this.textBox_cardy = new System.Windows.Forms.TextBox();
            this.label_x = new System.Windows.Forms.Label();
            this.button_go = new System.Windows.Forms.Button();
            this.label_title = new System.Windows.Forms.Label();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.label_seperate = new System.Windows.Forms.Label();
            this.label_author = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox_music = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_player_names
            // 
            this.textBox_player_names.AccessibleDescription = "";
            this.textBox_player_names.Location = new System.Drawing.Point(120, 54);
            this.textBox_player_names.Name = "textBox_player_names";
            this.textBox_player_names.ShortcutsEnabled = false;
            this.textBox_player_names.Size = new System.Drawing.Size(138, 20);
            this.textBox_player_names.TabIndex = 0;
            this.textBox_player_names.Tag = "";
            this.textBox_player_names.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_player_names_KeyPress);
            // 
            // label_player_name
            // 
            this.label_player_name.AutoSize = true;
            this.label_player_name.BackColor = System.Drawing.Color.Transparent;
            this.label_player_name.ForeColor = System.Drawing.Color.White;
            this.label_player_name.Location = new System.Drawing.Point(41, 54);
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
            this.label_cardsize.Location = new System.Drawing.Point(58, 91);
            this.label_cardsize.Name = "label_cardsize";
            this.label_cardsize.Size = new System.Drawing.Size(56, 13);
            this.label_cardsize.TabIndex = 3;
            this.label_cardsize.Text = "Card size: ";
            // 
            // textBox_cardx
            // 
            this.textBox_cardx.Location = new System.Drawing.Point(120, 88);
            this.textBox_cardx.MaxLength = 1;
            this.textBox_cardx.Name = "textBox_cardx";
            this.textBox_cardx.ShortcutsEnabled = false;
            this.textBox_cardx.Size = new System.Drawing.Size(32, 20);
            this.textBox_cardx.TabIndex = 2;
            this.textBox_cardx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_cardx_KeyPress);
            // 
            // textBox_cardy
            // 
            this.textBox_cardy.Location = new System.Drawing.Point(176, 88);
            this.textBox_cardy.MaxLength = 1;
            this.textBox_cardy.Name = "textBox_cardy";
            this.textBox_cardy.ShortcutsEnabled = false;
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
            this.label_x.Location = new System.Drawing.Point(152, 88);
            this.label_x.Name = "label_x";
            this.label_x.Size = new System.Drawing.Size(24, 25);
            this.label_x.TabIndex = 5;
            this.label_x.Text = "×";
            this.label_x.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_go
            // 
            this.button_go.Location = new System.Drawing.Point(113, 208);
            this.button_go.Name = "button_go";
            this.button_go.Size = new System.Drawing.Size(75, 23);
            this.button_go.TabIndex = 6;
            this.button_go.Text = "Go!";
            this.button_go.UseVisualStyleBackColor = true;
            this.button_go.Click += new System.EventHandler(this.go_button_Click);
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.BackColor = System.Drawing.Color.Transparent;
            this.label_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_title.ForeColor = System.Drawing.Color.White;
            this.label_title.Location = new System.Drawing.Point(31, 9);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(227, 33);
            this.label_title.TabIndex = 7;
            this.label_title.Text = "Matching game";
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
            this.label_seperate.Location = new System.Drawing.Point(20, 67);
            this.label_seperate.Name = "label_seperate";
            this.label_seperate.Size = new System.Drawing.Size(94, 13);
            this.label_seperate.TabIndex = 10;
            this.label_seperate.Text = "(Space seperated)";
            // 
            // label_author
            // 
            this.label_author.AutoSize = true;
            this.label_author.BackColor = System.Drawing.Color.Transparent;
            this.label_author.ForeColor = System.Drawing.Color.White;
            this.label_author.Location = new System.Drawing.Point(12, 236);
            this.label_author.Name = "label_author";
            this.label_author.Size = new System.Drawing.Size(135, 13);
            this.label_author.TabIndex = 12;
            this.label_author.Text = "Nick Bruno and Chris Kane";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.ForeColor = System.Drawing.Color.White;
            this.checkBox1.Location = new System.Drawing.Point(113, 127);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(112, 17);
            this.checkBox1.TabIndex = 13;
            this.checkBox1.Text = "Card Animation on";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox_music
            // 
            this.checkBox_music.AutoSize = true;
            this.checkBox_music.BackColor = System.Drawing.Color.Transparent;
            this.checkBox_music.ForeColor = System.Drawing.Color.White;
            this.checkBox_music.Location = new System.Drawing.Point(113, 150);
            this.checkBox_music.Name = "checkBox_music";
            this.checkBox_music.Size = new System.Drawing.Size(69, 17);
            this.checkBox_music.TabIndex = 14;
            this.checkBox_music.Text = "Music on";
            this.checkBox_music.UseVisualStyleBackColor = false;
            this.checkBox_music.CheckedChanged += new System.EventHandler(this.checkBox_music_CheckedChanged);
            // 
            // Form_Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::WindowsFormsApplication2.Properties.Resources.trees;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.checkBox_music);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label_author);
            this.Controls.Add(this.label_seperate);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.label_title);
            this.Controls.Add(this.button_go);
            this.Controls.Add(this.label_x);
            this.Controls.Add(this.textBox_cardy);
            this.Controls.Add(this.label_cardsize);
            this.Controls.Add(this.textBox_cardx);
            this.Controls.Add(this.label_player_name);
            this.Controls.Add(this.textBox_player_names);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Options";
            this.Opacity = 0.96D;
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Options";
            this.Load += new System.EventHandler(this.Form_Options_Load);
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
        private System.Windows.Forms.Button button_go;
        private System.Windows.Forms.Label label_title;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Label label_seperate;
        private System.Windows.Forms.Label label_author;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox_music;
    }
}

