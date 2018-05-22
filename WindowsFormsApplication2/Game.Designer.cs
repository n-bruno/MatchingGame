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
            this.button_scores = new System.Windows.Forms.Button();
            this.label_currentPlayer = new System.Windows.Forms.Label();
            this.label_player = new System.Windows.Forms.Label();
            this.label_score2 = new System.Windows.Forms.Label();
            this.label_score = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_scores
            // 
            this.button_scores.Location = new System.Drawing.Point(197, 12);
            this.button_scores.Name = "button_scores";
            this.button_scores.Size = new System.Drawing.Size(75, 40);
            this.button_scores.TabIndex = 0;
            this.button_scores.Text = "Get all scores";
            this.button_scores.UseVisualStyleBackColor = true;
            this.button_scores.Click += new System.EventHandler(this.button_scores_Click);
            // 
            // label_currentPlayer
            // 
            this.label_currentPlayer.AutoSize = true;
            this.label_currentPlayer.BackColor = System.Drawing.Color.Transparent;
            this.label_currentPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_currentPlayer.ForeColor = System.Drawing.Color.White;
            this.label_currentPlayer.Location = new System.Drawing.Point(12, 12);
            this.label_currentPlayer.Name = "label_currentPlayer";
            this.label_currentPlayer.Size = new System.Drawing.Size(90, 13);
            this.label_currentPlayer.TabIndex = 1;
            this.label_currentPlayer.Text = "Current player:";
            // 
            // label_player
            // 
            this.label_player.AutoSize = true;
            this.label_player.BackColor = System.Drawing.Color.Transparent;
            this.label_player.ForeColor = System.Drawing.Color.White;
            this.label_player.Location = new System.Drawing.Point(12, 26);
            this.label_player.Name = "label_player";
            this.label_player.Size = new System.Drawing.Size(103, 13);
            this.label_player.TabIndex = 2;
            this.label_player.Text = "if you\'re reading this,";
            this.label_player.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_score2
            // 
            this.label_score2.AutoSize = true;
            this.label_score2.BackColor = System.Drawing.Color.Transparent;
            this.label_score2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_score2.ForeColor = System.Drawing.Color.White;
            this.label_score2.Location = new System.Drawing.Point(125, 12);
            this.label_score2.Name = "label_score2";
            this.label_score2.Size = new System.Drawing.Size(44, 13);
            this.label_score2.TabIndex = 3;
            this.label_score2.Text = "Score:";
            // 
            // label_score
            // 
            this.label_score.AutoSize = true;
            this.label_score.BackColor = System.Drawing.Color.Transparent;
            this.label_score.ForeColor = System.Drawing.Color.White;
            this.label_score.Location = new System.Drawing.Point(125, 25);
            this.label_score.Name = "label_score";
            this.label_score.Size = new System.Drawing.Size(47, 13);
            this.label_score.TabIndex = 4;
            this.label_score.Text = "get a life";
            this.label_score.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form_Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BackgroundImage = global::WindowsFormsApplication2.Properties.Resources.greenPoker;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.label_score);
            this.Controls.Add(this.label_score2);
            this.Controls.Add(this.label_player);
            this.Controls.Add(this.label_currentPlayer);
            this.Controls.Add(this.button_scores);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Name = "Form_Game";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game";
            this.Load += new System.EventHandler(this.Game_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_scores;
        private System.Windows.Forms.Label label_currentPlayer;
        private System.Windows.Forms.Label label_player;
        private System.Windows.Forms.Label label_score2;
        private System.Windows.Forms.Label label_score;
    }
}