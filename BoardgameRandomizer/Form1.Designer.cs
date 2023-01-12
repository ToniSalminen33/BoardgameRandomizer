namespace BoardgameRandomizer
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.PlayerListBox = new System.Windows.Forms.ListBox();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.SelectedPlayerListBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ResetButton = new System.Windows.Forms.Button();
            this.PlayButton = new System.Windows.Forms.Button();
            this.RemoveSelectedPlayerButton = new System.Windows.Forms.Button();
            this.CreatePlayerButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select players:";
            // 
            // PlayerListBox
            // 
            this.PlayerListBox.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerListBox.FormattingEnabled = true;
            this.PlayerListBox.ItemHeight = 45;
            this.PlayerListBox.Location = new System.Drawing.Point(20, 77);
            this.PlayerListBox.Name = "PlayerListBox";
            this.PlayerListBox.ScrollAlwaysVisible = true;
            this.PlayerListBox.Size = new System.Drawing.Size(479, 319);
            this.PlayerListBox.TabIndex = 1;
            this.PlayerListBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.PlayerListBox_MouseDoubleClick);
            // 
            // RefreshButton
            // 
            this.RefreshButton.BackColor = System.Drawing.Color.Olive;
            this.RefreshButton.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RefreshButton.Location = new System.Drawing.Point(570, 749);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(263, 161);
            this.RefreshButton.TabIndex = 2;
            this.RefreshButton.Text = "Refresh";
            this.RefreshButton.UseVisualStyleBackColor = false;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // SelectedPlayerListBox
            // 
            this.SelectedPlayerListBox.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectedPlayerListBox.FormattingEnabled = true;
            this.SelectedPlayerListBox.ItemHeight = 45;
            this.SelectedPlayerListBox.Location = new System.Drawing.Point(570, 77);
            this.SelectedPlayerListBox.Name = "SelectedPlayerListBox";
            this.SelectedPlayerListBox.ScrollAlwaysVisible = true;
            this.SelectedPlayerListBox.Size = new System.Drawing.Size(533, 319);
            this.SelectedPlayerListBox.TabIndex = 2;
            this.SelectedPlayerListBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.SelectedPlayerListBox_MouseDoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(562, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(270, 45);
            this.label2.TabIndex = 4;
            this.label2.Text = "Selected players:";
            // 
            // ResetButton
            // 
            this.ResetButton.BackColor = System.Drawing.Color.IndianRed;
            this.ResetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ResetButton.Location = new System.Drawing.Point(839, 749);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(263, 161);
            this.ResetButton.TabIndex = 5;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = false;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // PlayButton
            // 
            this.PlayButton.BackColor = System.Drawing.Color.ForestGreen;
            this.PlayButton.Font = new System.Drawing.Font("Microsoft YaHei", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayButton.Location = new System.Drawing.Point(570, 506);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(533, 199);
            this.PlayButton.TabIndex = 6;
            this.PlayButton.Text = "Let\'s play!";
            this.PlayButton.UseVisualStyleBackColor = false;
            this.PlayButton.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // RemoveSelectedPlayerButton
            // 
            this.RemoveSelectedPlayerButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.RemoveSelectedPlayerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveSelectedPlayerButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.RemoveSelectedPlayerButton.Location = new System.Drawing.Point(20, 749);
            this.RemoveSelectedPlayerButton.Name = "RemoveSelectedPlayerButton";
            this.RemoveSelectedPlayerButton.Size = new System.Drawing.Size(185, 161);
            this.RemoveSelectedPlayerButton.TabIndex = 14;
            this.RemoveSelectedPlayerButton.Text = "Remove selected player";
            this.RemoveSelectedPlayerButton.UseVisualStyleBackColor = false;
            this.RemoveSelectedPlayerButton.Click += new System.EventHandler(this.RemoveSelectedPlayerButton_Click);
            // 
            // CreatePlayerButton
            // 
            this.CreatePlayerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreatePlayerButton.Location = new System.Drawing.Point(264, 749);
            this.CreatePlayerButton.Name = "CreatePlayerButton";
            this.CreatePlayerButton.Size = new System.Drawing.Size(235, 161);
            this.CreatePlayerButton.TabIndex = 15;
            this.CreatePlayerButton.Text = "Create player";
            this.CreatePlayerButton.UseVisualStyleBackColor = true;
            this.CreatePlayerButton.Click += new System.EventHandler(this.CreatePlayerButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1134, 949);
            this.Controls.Add(this.CreatePlayerButton);
            this.Controls.Add(this.RemoveSelectedPlayerButton);
            this.Controls.Add(this.PlayButton);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SelectedPlayerListBox);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.PlayerListBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox PlayerListBox;
        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.ListBox SelectedPlayerListBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Button PlayButton;
        private System.Windows.Forms.Button RemoveSelectedPlayerButton;
        private System.Windows.Forms.Button CreatePlayerButton;
    }
}

