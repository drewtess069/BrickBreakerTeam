namespace BrickBreaker
{
    partial class EndScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuButton = new System.Windows.Forms.Button();
            this.submitButton = new System.Windows.Forms.Button();
            this.endLabel = new System.Windows.Forms.Label();
            this.submitNameLabel = new System.Windows.Forms.TextBox();
            this.leaderboardLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // menuButton
            // 
            this.menuButton.BackColor = System.Drawing.Color.White;
            this.menuButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.menuButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.menuButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.menuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuButton.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuButton.Location = new System.Drawing.Point(406, 522);
            this.menuButton.Margin = new System.Windows.Forms.Padding(4);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(242, 96);
            this.menuButton.TabIndex = 1;
            this.menuButton.Text = "Menu";
            this.menuButton.UseVisualStyleBackColor = false;
            this.menuButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // submitButton
            // 
            this.submitButton.BackColor = System.Drawing.Color.White;
            this.submitButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.submitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.submitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.submitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submitButton.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.submitButton.Location = new System.Drawing.Point(551, 166);
            this.submitButton.Margin = new System.Windows.Forms.Padding(4);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(264, 32);
            this.submitButton.TabIndex = 2;
            this.submitButton.Text = "Submit to Leaderboard";
            this.submitButton.UseVisualStyleBackColor = false;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // endLabel
            // 
            this.endLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endLabel.ForeColor = System.Drawing.Color.LightSalmon;
            this.endLabel.Location = new System.Drawing.Point(0, 24);
            this.endLabel.Name = "endLabel";
            this.endLabel.Size = new System.Drawing.Size(1067, 138);
            this.endLabel.TabIndex = 3;
            this.endLabel.Text = "Your High Score: ";
            this.endLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // submitNameLabel
            // 
            this.submitNameLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitNameLabel.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.submitNameLabel.Location = new System.Drawing.Point(189, 166);
            this.submitNameLabel.Name = "submitNameLabel";
            this.submitNameLabel.Size = new System.Drawing.Size(295, 32);
            this.submitNameLabel.TabIndex = 4;
            this.submitNameLabel.Text = "Type your name here...";
            this.submitNameLabel.TextChanged += new System.EventHandler(this.submitNameLabel_TextChanged);
            // 
            // leaderboardLabel
            // 
            this.leaderboardLabel.BackColor = System.Drawing.Color.Transparent;
            this.leaderboardLabel.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leaderboardLabel.ForeColor = System.Drawing.Color.White;
            this.leaderboardLabel.Location = new System.Drawing.Point(299, 223);
            this.leaderboardLabel.Name = "leaderboardLabel";
            this.leaderboardLabel.Size = new System.Drawing.Size(466, 295);
            this.leaderboardLabel.TabIndex = 5;
            this.leaderboardLabel.Text = "Name / Score";
            this.leaderboardLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // EndScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.leaderboardLabel);
            this.Controls.Add(this.submitNameLabel);
            this.Controls.Add(this.endLabel);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.menuButton);
            this.Name = "EndScreen";
            this.Size = new System.Drawing.Size(1067, 677);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button menuButton;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Label endLabel;
        private System.Windows.Forms.TextBox submitNameLabel;
        private System.Windows.Forms.Label leaderboardLabel;
    }
}
