namespace BoardgameRandomizer
{
    partial class GameSession
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
            this.BoardgameLabel = new System.Windows.Forms.Label();
            this.BoardgameRollButton = new System.Windows.Forms.Button();
            this.PlayersWithTokenListBox = new System.Windows.Forms.ListBox();
            this.PlayerUseTokenButton = new System.Windows.Forms.Button();
            this.RerollBoardgameButton = new System.Windows.Forms.Button();
            this.QuitSessionButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BoardgameLabel
            // 
            this.BoardgameLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoardgameLabel.Location = new System.Drawing.Point(30, 24);
            this.BoardgameLabel.Name = "BoardgameLabel";
            this.BoardgameLabel.Size = new System.Drawing.Size(1188, 90);
            this.BoardgameLabel.TabIndex = 0;
            this.BoardgameLabel.Text = "Roll for your game!";
            this.BoardgameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BoardgameRollButton
            // 
            this.BoardgameRollButton.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoardgameRollButton.Location = new System.Drawing.Point(420, 159);
            this.BoardgameRollButton.Name = "BoardgameRollButton";
            this.BoardgameRollButton.Size = new System.Drawing.Size(397, 104);
            this.BoardgameRollButton.TabIndex = 1;
            this.BoardgameRollButton.Text = "Roll!";
            this.BoardgameRollButton.UseVisualStyleBackColor = true;
            this.BoardgameRollButton.Click += new System.EventHandler(this.BoardgameRollButton_Click);
            // 
            // PlayersWithTokenListBox
            // 
            this.PlayersWithTokenListBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.PlayersWithTokenListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayersWithTokenListBox.FormattingEnabled = true;
            this.PlayersWithTokenListBox.ItemHeight = 40;
            this.PlayersWithTokenListBox.Location = new System.Drawing.Point(38, 364);
            this.PlayersWithTokenListBox.Name = "PlayersWithTokenListBox";
            this.PlayersWithTokenListBox.Size = new System.Drawing.Size(521, 724);
            this.PlayersWithTokenListBox.TabIndex = 2;
            // 
            // PlayerUseTokenButton
            // 
            this.PlayerUseTokenButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerUseTokenButton.Location = new System.Drawing.Point(625, 724);
            this.PlayerUseTokenButton.Name = "PlayerUseTokenButton";
            this.PlayerUseTokenButton.Size = new System.Drawing.Size(208, 160);
            this.PlayerUseTokenButton.TabIndex = 3;
            this.PlayerUseTokenButton.Text = "Use Token";
            this.PlayerUseTokenButton.UseVisualStyleBackColor = true;
            // 
            // RerollBoardgameButton
            // 
            this.RerollBoardgameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RerollBoardgameButton.Location = new System.Drawing.Point(904, 724);
            this.RerollBoardgameButton.Name = "RerollBoardgameButton";
            this.RerollBoardgameButton.Size = new System.Drawing.Size(196, 160);
            this.RerollBoardgameButton.TabIndex = 4;
            this.RerollBoardgameButton.Text = "Reroll (beta)";
            this.RerollBoardgameButton.UseVisualStyleBackColor = true;
            // 
            // QuitSessionButton
            // 
            this.QuitSessionButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(177)))), ((int)(((byte)(194)))));
            this.QuitSessionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuitSessionButton.Location = new System.Drawing.Point(625, 935);
            this.QuitSessionButton.Name = "QuitSessionButton";
            this.QuitSessionButton.Size = new System.Drawing.Size(475, 153);
            this.QuitSessionButton.TabIndex = 5;
            this.QuitSessionButton.Text = "Quit";
            this.QuitSessionButton.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 309);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(350, 40);
            this.label1.TabIndex = 6;
            this.label1.Text = "Players with Token:";
            // 
            // GameSession
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(177)))), ((int)(((byte)(194)))));
            this.ClientSize = new System.Drawing.Size(1260, 1123);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.QuitSessionButton);
            this.Controls.Add(this.RerollBoardgameButton);
            this.Controls.Add(this.PlayerUseTokenButton);
            this.Controls.Add(this.PlayersWithTokenListBox);
            this.Controls.Add(this.BoardgameRollButton);
            this.Controls.Add(this.BoardgameLabel);
            this.Name = "GameSession";
            this.Text = "GameSession";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BoardgameLabel;
        private System.Windows.Forms.Button BoardgameRollButton;
        private System.Windows.Forms.ListBox PlayersWithTokenListBox;
        private System.Windows.Forms.Button PlayerUseTokenButton;
        private System.Windows.Forms.Button RerollBoardgameButton;
        private System.Windows.Forms.Button QuitSessionButton;
        private System.Windows.Forms.Label label1;
    }
}