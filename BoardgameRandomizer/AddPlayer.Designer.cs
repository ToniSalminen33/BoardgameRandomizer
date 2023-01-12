namespace BoardgameRandomizer
{
    partial class AddPlayer
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
            this.label3 = new System.Windows.Forms.Label();
            this.FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.AddPlayerButton = new System.Windows.Forms.Button();
            this.CloseAddPlayerForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(172, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 38);
            this.label3.TabIndex = 10;
            this.label3.Text = "Add player:";
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNameTextBox.Location = new System.Drawing.Point(19, 100);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(513, 53);
            this.FirstNameTextBox.TabIndex = 11;
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNameTextBox.Location = new System.Drawing.Point(19, 226);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(513, 53);
            this.LastNameTextBox.TabIndex = 12;
            // 
            // AddPlayerButton
            // 
            this.AddPlayerButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(152)))), ((int)(((byte)(218)))));
            this.AddPlayerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddPlayerButton.Location = new System.Drawing.Point(281, 423);
            this.AddPlayerButton.Name = "AddPlayerButton";
            this.AddPlayerButton.Size = new System.Drawing.Size(251, 161);
            this.AddPlayerButton.TabIndex = 13;
            this.AddPlayerButton.Text = "Add player";
            this.AddPlayerButton.UseVisualStyleBackColor = false;
            this.AddPlayerButton.Click += new System.EventHandler(this.AddPlayerButton_Click);
            // 
            // CloseAddPlayerForm
            // 
            this.CloseAddPlayerForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(152)))), ((int)(((byte)(218)))));
            this.CloseAddPlayerForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.CloseAddPlayerForm.Location = new System.Drawing.Point(19, 423);
            this.CloseAddPlayerForm.Name = "CloseAddPlayerForm";
            this.CloseAddPlayerForm.Size = new System.Drawing.Size(226, 161);
            this.CloseAddPlayerForm.TabIndex = 14;
            this.CloseAddPlayerForm.Text = "Close";
            this.CloseAddPlayerForm.UseVisualStyleBackColor = false;
            this.CloseAddPlayerForm.Click += new System.EventHandler(this.CloseAddPlayerForm_Click);
            // 
            // AddPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(103)))), ((int)(((byte)(214)))));
            this.ClientSize = new System.Drawing.Size(544, 596);
            this.Controls.Add(this.CloseAddPlayerForm);
            this.Controls.Add(this.AddPlayerButton);
            this.Controls.Add(this.LastNameTextBox);
            this.Controls.Add(this.FirstNameTextBox);
            this.Controls.Add(this.label3);
            this.Name = "AddPlayer";
            this.Text = "AddPlayer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox FirstNameTextBox;
        private System.Windows.Forms.TextBox LastNameTextBox;
        private System.Windows.Forms.Button AddPlayerButton;
        private System.Windows.Forms.Button CloseAddPlayerForm;
    }
}