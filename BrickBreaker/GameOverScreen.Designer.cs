namespace BrickBreaker
{
    partial class GameOverScreen
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
            this.label2 = new System.Windows.Forms.Label();
            this.resultsLabel = new System.Windows.Forms.Label();
            this.playAgainButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.menuButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Magneto", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Plum;
            this.label2.Location = new System.Drawing.Point(0, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1067, 138);
            this.label2.TabIndex = 4;
            this.label2.Text = "GAME OVER!";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // resultsLabel
            // 
            this.resultsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultsLabel.ForeColor = System.Drawing.Color.White;
            this.resultsLabel.Location = new System.Drawing.Point(292, 224);
            this.resultsLabel.Name = "resultsLabel";
            this.resultsLabel.Size = new System.Drawing.Size(492, 124);
            this.resultsLabel.TabIndex = 5;
            this.resultsLabel.Text = "YOU MADE IT TO LEVEL:\r\n\r\nYOUR SCORE:";
            this.resultsLabel.Click += new System.EventHandler(this.resultsLabel_Click);
            // 
            // playAgainButton
            // 
            this.playAgainButton.BackColor = System.Drawing.Color.Tomato;
            this.playAgainButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.playAgainButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.playAgainButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.playAgainButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playAgainButton.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playAgainButton.Location = new System.Drawing.Point(279, 383);
            this.playAgainButton.Margin = new System.Windows.Forms.Padding(4);
            this.playAgainButton.Name = "playAgainButton";
            this.playAgainButton.Size = new System.Drawing.Size(242, 96);
            this.playAgainButton.TabIndex = 7;
            this.playAgainButton.Text = "Play Again";
            this.playAgainButton.UseVisualStyleBackColor = false;
            this.playAgainButton.Click += new System.EventHandler(this.playAgainButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.exitButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(400, 487);
            this.exitButton.Margin = new System.Windows.Forms.Padding(4);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(242, 96);
            this.exitButton.TabIndex = 8;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // menuButton
            // 
            this.menuButton.BackColor = System.Drawing.Color.SpringGreen;
            this.menuButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.menuButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.menuButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.menuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuButton.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuButton.Location = new System.Drawing.Point(529, 383);
            this.menuButton.Margin = new System.Windows.Forms.Padding(4);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(242, 96);
            this.menuButton.TabIndex = 9;
            this.menuButton.Text = "Menu";
            this.menuButton.UseVisualStyleBackColor = false;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // GameOverScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.menuButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.playAgainButton);
            this.Controls.Add(this.resultsLabel);
            this.Controls.Add(this.label2);
            this.Name = "GameOverScreen";
            this.Size = new System.Drawing.Size(1067, 677);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label resultsLabel;
        private System.Windows.Forms.Button playAgainButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button menuButton;
    }
}
