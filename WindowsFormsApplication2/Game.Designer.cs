namespace matchingGame
{
    partial class Form_Game
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
            this.components = new System.ComponentModel.Container();
            this.label_current_players = new System.Windows.Forms.Label();
            this.button_create_cards = new System.Windows.Forms.Button();
            this.label_all_scores = new System.Windows.Forms.Label();
            this.label_all_score_display = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.label_author = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_current_players
            // 
            this.label_current_players.AutoSize = true;
            this.label_current_players.BackColor = System.Drawing.Color.Transparent;
            this.label_current_players.ForeColor = System.Drawing.Color.Red;
            this.label_current_players.Location = new System.Drawing.Point(12, 22);
            this.label_current_players.Name = "label_current_players";
            this.label_current_players.Size = new System.Drawing.Size(103, 13);
            this.label_current_players.TabIndex = 2;
            this.label_current_players.Text = "if you\'re reading this,";
            this.label_current_players.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_create_cards
            // 
            this.button_create_cards.Location = new System.Drawing.Point(154, 149);
            this.button_create_cards.Name = "button_create_cards";
            this.button_create_cards.Size = new System.Drawing.Size(75, 40);
            this.button_create_cards.TabIndex = 5;
            this.button_create_cards.Text = "Create cards";
            this.button_create_cards.UseVisualStyleBackColor = true;
            this.button_create_cards.Click += new System.EventHandler(this.button_create_cards_Click);
            // 
            // label_all_scores
            // 
            this.label_all_scores.AutoSize = true;
            this.label_all_scores.BackColor = System.Drawing.Color.Transparent;
            this.label_all_scores.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_all_scores.ForeColor = System.Drawing.Color.White;
            this.label_all_scores.Location = new System.Drawing.Point(12, 9);
            this.label_all_scores.Name = "label_all_scores";
            this.label_all_scores.Size = new System.Drawing.Size(68, 13);
            this.label_all_scores.TabIndex = 6;
            this.label_all_scores.Text = "All Scores:";
            // 
            // label_all_score_display
            // 
            this.label_all_score_display.AutoSize = true;
            this.label_all_score_display.BackColor = System.Drawing.Color.Transparent;
            this.label_all_score_display.ForeColor = System.Drawing.Color.White;
            this.label_all_score_display.Location = new System.Drawing.Point(12, 35);
            this.label_all_score_display.Name = "label_all_score_display";
            this.label_all_score_display.Size = new System.Drawing.Size(43, 13);
            this.label_all_score_display.TabIndex = 7;
            this.label_all_score_display.Text = "BEARS";
            this.label_all_score_display.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label_author
            // 
            this.label_author.AutoSize = true;
            this.label_author.BackColor = System.Drawing.Color.Transparent;
            this.label_author.ForeColor = System.Drawing.Color.White;
            this.label_author.Location = new System.Drawing.Point(151, 9);
            this.label_author.Name = "label_author";
            this.label_author.Size = new System.Drawing.Size(135, 13);
            this.label_author.TabIndex = 13;
            this.label_author.Text = "Nick Bruno and Chris Kane";
            // 
            // Form_Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BackgroundImage = global::WindowsFormsApplication2.Properties.Resources.greenPoker;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.label_author);
            this.Controls.Add(this.label_all_score_display);
            this.Controls.Add(this.label_all_scores);
            this.Controls.Add(this.button_create_cards);
            this.Controls.Add(this.label_current_players);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Game";
            this.Opacity = 0.95D;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_Game_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_current_players;
        private System.Windows.Forms.Button button_create_cards;
        private System.Windows.Forms.Label label_all_scores;
        private System.Windows.Forms.Label label_all_score_display;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.Label label_author;
    }
}