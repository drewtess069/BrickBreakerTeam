namespace BrickBreaker
{
    partial class GameScreen
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
            this.components = new System.ComponentModel.Container();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.life1 = new System.Windows.Forms.PictureBox();
            this.life2 = new System.Windows.Forms.PictureBox();
            this.life3 = new System.Windows.Forms.PictureBox();
            this.life5 = new System.Windows.Forms.PictureBox();
            this.life4 = new System.Windows.Forms.PictureBox();
            this.scoreOutput = new System.Windows.Forms.Label();
            this.UXLabel = new System.Windows.Forms.Label();
            this.livesLabel = new System.Windows.Forms.Label();
            this.pauseButton = new System.Windows.Forms.Label();
            this.pauseMenuLabel = new System.Windows.Forms.Label();
            this.menuButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.life1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.life2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.life3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.life5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.life4)).BeginInit();
            this.SuspendLayout();
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 1;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // life1
            // 
            this.life1.BackColor = System.Drawing.Color.Black;
            this.life1.BackgroundImage = global::BrickBreaker.Properties.Resources.heart;
            this.life1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.life1.Location = new System.Drawing.Point(11, 743);
            this.life1.Name = "life1";
            this.life1.Size = new System.Drawing.Size(49, 55);
            this.life1.TabIndex = 4;
            this.life1.TabStop = false;
            this.life1.Visible = false;
            // 
            // life2
            // 
            this.life2.BackColor = System.Drawing.Color.Black;
            this.life2.BackgroundImage = global::BrickBreaker.Properties.Resources.heart;
            this.life2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.life2.Location = new System.Drawing.Point(55, 743);
            this.life2.Name = "life2";
            this.life2.Size = new System.Drawing.Size(49, 55);
            this.life2.TabIndex = 5;
            this.life2.TabStop = false;
            this.life2.Visible = false;
            // 
            // life3
            // 
            this.life3.BackColor = System.Drawing.Color.Black;
            this.life3.BackgroundImage = global::BrickBreaker.Properties.Resources.heart;
            this.life3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.life3.Location = new System.Drawing.Point(99, 743);
            this.life3.Name = "life3";
            this.life3.Size = new System.Drawing.Size(49, 55);
            this.life3.TabIndex = 6;
            this.life3.TabStop = false;
            this.life3.Visible = false;
            // 
            // life5
            // 
            this.life5.BackColor = System.Drawing.Color.Black;
            this.life5.BackgroundImage = global::BrickBreaker.Properties.Resources.heart;
            this.life5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.life5.Location = new System.Drawing.Point(188, 743);
            this.life5.Name = "life5";
            this.life5.Size = new System.Drawing.Size(49, 55);
            this.life5.TabIndex = 7;
            this.life5.TabStop = false;
            this.life5.Visible = false;
            // 
            // life4
            // 
            this.life4.BackColor = System.Drawing.Color.Black;
            this.life4.BackgroundImage = global::BrickBreaker.Properties.Resources.heart;
            this.life4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.life4.Location = new System.Drawing.Point(144, 743);
            this.life4.Name = "life4";
            this.life4.Size = new System.Drawing.Size(49, 55);
            this.life4.TabIndex = 8;
            this.life4.TabStop = false;
            this.life4.Visible = false;
            // 
            // scoreOutput
            // 
            this.scoreOutput.BackColor = System.Drawing.Color.Black;
            this.scoreOutput.Font = new System.Drawing.Font("Courier New", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreOutput.ForeColor = System.Drawing.Color.White;
            this.scoreOutput.Location = new System.Drawing.Point(946, 747);
            this.scoreOutput.Name = "scoreOutput";
            this.scoreOutput.Size = new System.Drawing.Size(118, 48);
            this.scoreOutput.TabIndex = 9;
            this.scoreOutput.Text = "0000";
            this.scoreOutput.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // UXLabel
            // 
            this.UXLabel.BackColor = System.Drawing.Color.Black;
            this.UXLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UXLabel.Location = new System.Drawing.Point(0, 740);
            this.UXLabel.Name = "UXLabel";
            this.UXLabel.Size = new System.Drawing.Size(1067, 60);
            this.UXLabel.TabIndex = 10;
            // 
            // livesLabel
            // 
            this.livesLabel.AutoSize = true;
            this.livesLabel.BackColor = System.Drawing.Color.Transparent;
            this.livesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.livesLabel.ForeColor = System.Drawing.Color.White;
            this.livesLabel.Location = new System.Drawing.Point(903, 50);
            this.livesLabel.Name = "livesLabel";
            this.livesLabel.Size = new System.Drawing.Size(75, 29);
            this.livesLabel.TabIndex = 1;
            this.livesLabel.Text = "Lives:";
            this.livesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pauseButton
            // 
            this.pauseButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pauseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pauseButton.ForeColor = System.Drawing.Color.White;
            this.pauseButton.Location = new System.Drawing.Point(506, 746);
            this.pauseButton.Name = "pauseButton";
            this.pauseButton.Size = new System.Drawing.Size(55, 48);
            this.pauseButton.TabIndex = 11;
            this.pauseButton.Text = "II";
            this.pauseButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.pauseButton.Click += new System.EventHandler(this.pauseButton_Click);
            // 
            // pauseMenuLabel
            // 
            this.pauseMenuLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pauseMenuLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pauseMenuLabel.ForeColor = System.Drawing.Color.White;
            this.pauseMenuLabel.Location = new System.Drawing.Point(245, 175);
            this.pauseMenuLabel.Name = "pauseMenuLabel";
            this.pauseMenuLabel.Size = new System.Drawing.Size(574, 460);
            this.pauseMenuLabel.TabIndex = 12;
            this.pauseMenuLabel.Text = "\r\nGAME PAUSED\r\n\r\nLevel [level]\r\n{lives} lives left\r\n\r\n\r\n\r\nCLICK TO RETURN\r\n";
            this.pauseMenuLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.pauseMenuLabel.Visible = false;
            this.pauseMenuLabel.Click += new System.EventHandler(this.pauseMenuLabel_Click);
            // 
            // menuButton
            // 
            this.menuButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.menuButton.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuButton.ForeColor = System.Drawing.Color.White;
            this.menuButton.Location = new System.Drawing.Point(347, 445);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(369, 61);
            this.menuButton.TabIndex = 13;
            this.menuButton.Text = "Return to Menu";
            this.menuButton.UseVisualStyleBackColor = false;
            this.menuButton.Visible = false;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // GameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.menuButton);
            this.Controls.Add(this.pauseMenuLabel);
            this.Controls.Add(this.pauseButton);
            this.Controls.Add(this.scoreOutput);
            this.Controls.Add(this.life4);
            this.Controls.Add(this.life5);
            this.Controls.Add(this.life3);
            this.Controls.Add(this.life2);
            this.Controls.Add(this.life1);
            this.Controls.Add(this.UXLabel);
            this.Controls.Add(this.livesLabel);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GameScreen";
            this.Size = new System.Drawing.Size(1067, 800);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.GameScreen_Paint);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GameScreen_KeyUp);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.GameScreen_PreviewKeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.life1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.life2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.life3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.life5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.life4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.PictureBox life1;
        private System.Windows.Forms.PictureBox life2;
        private System.Windows.Forms.PictureBox life3;
        private System.Windows.Forms.PictureBox life5;
        private System.Windows.Forms.PictureBox life4;
        //private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Label scoreOutput;
        private System.Windows.Forms.Label UXLabel;

        //private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Label livesLabel;
        private System.Windows.Forms.Label pauseButton;
        private System.Windows.Forms.Label pauseMenuLabel;
        private System.Windows.Forms.Button menuButton;
    }
}
