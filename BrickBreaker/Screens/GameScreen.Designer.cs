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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameScreen));
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.testLabel = new System.Windows.Forms.Label();
            this.lazerLabel = new System.Windows.Forms.Label();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.scoreOutput = new System.Windows.Forms.Label();
            this.livesLabel = new System.Windows.Forms.Label();
            this.pauseButton = new System.Windows.Forms.PictureBox();
            this.pauseMenuLabel = new System.Windows.Forms.Label();
            this.menuButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.life1 = new System.Windows.Forms.PictureBox();
            this.life5 = new System.Windows.Forms.PictureBox();
            this.life4 = new System.Windows.Forms.PictureBox();
            this.life3 = new System.Windows.Forms.PictureBox();
            this.life2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pauseButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.life1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.life5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.life4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.life3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.life2)).BeginInit();
            this.SuspendLayout();
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 1;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // testLabel
            // 
            this.testLabel.AutoSize = true;
            this.testLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.testLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.testLabel.Location = new System.Drawing.Point(816, 181);
            this.testLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.testLabel.Name = "testLabel";
            this.testLabel.Size = new System.Drawing.Size(51, 20);
            this.testLabel.TabIndex = 0;
            this.testLabel.Text = "label1";
            // 
            // lazerLabel
            // 
            this.lazerLabel.AutoSize = true;
            this.lazerLabel.Location = new System.Drawing.Point(754, 484);
            this.lazerLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lazerLabel.Name = "lazerLabel";
            this.lazerLabel.Size = new System.Drawing.Size(0, 20);
            this.lazerLabel.TabIndex = 1;
            // 
            // scoreLabel
            // 
            this.scoreLabel.BackColor = System.Drawing.Color.Black;
            this.scoreLabel.Font = new System.Drawing.Font("Courier New", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLabel.ForeColor = System.Drawing.Color.White;
            this.scoreLabel.Location = new System.Drawing.Point(862, 757);
            this.scoreLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(94, 30);
            this.scoreLabel.TabIndex = 1;
            this.scoreLabel.Text = "SCORE:";
            this.scoreLabel.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // scoreOutput
            // 
            this.scoreOutput.BackColor = System.Drawing.Color.Black;
            this.scoreOutput.Font = new System.Drawing.Font("Courier New", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreOutput.ForeColor = System.Drawing.Color.White;
            this.scoreOutput.Location = new System.Drawing.Point(960, 757);
            this.scoreOutput.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.scoreOutput.Name = "scoreOutput";
            this.scoreOutput.Size = new System.Drawing.Size(94, 38);
            this.scoreOutput.TabIndex = 9;
            this.scoreOutput.Text = "0000";
            this.scoreOutput.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // livesLabel
            // 
            this.livesLabel.AutoSize = true;
            this.livesLabel.BackColor = System.Drawing.Color.Transparent;
            this.livesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.livesLabel.ForeColor = System.Drawing.Color.White;
            this.livesLabel.Location = new System.Drawing.Point(996, 12);
            this.livesLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.livesLabel.Name = "livesLabel";
            this.livesLabel.Size = new System.Drawing.Size(58, 24);
            this.livesLabel.TabIndex = 1;
            this.livesLabel.Text = "Lives:";
            this.livesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pauseButton
            // 
            this.pauseButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pauseButton.BackgroundImage")));
            this.pauseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pauseButton.Location = new System.Drawing.Point(532, 757);
            this.pauseButton.Name = "pauseButton";
            this.pauseButton.Size = new System.Drawing.Size(50, 40);
            this.pauseButton.TabIndex = 11;
            this.pauseButton.TabStop = false;
            this.pauseButton.Click += new System.EventHandler(this.pauseButton_Click);
            // 
            // pauseMenuLabel
            // 
            this.pauseMenuLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pauseMenuLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pauseMenuLabel.ForeColor = System.Drawing.Color.White;
            this.pauseMenuLabel.Location = new System.Drawing.Point(345, 181);
            this.pauseMenuLabel.Name = "pauseMenuLabel";
            this.pauseMenuLabel.Size = new System.Drawing.Size(340, 326);
            this.pauseMenuLabel.TabIndex = 12;
            this.pauseMenuLabel.Text = "Game Paused";
            this.pauseMenuLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.pauseMenuLabel.Visible = false;
            // 
            // menuButton
            // 
            this.menuButton.Enabled = false;
            this.menuButton.Location = new System.Drawing.Point(361, 429);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(113, 57);
            this.menuButton.TabIndex = 13;
            this.menuButton.Text = "Continue";
            this.menuButton.UseVisualStyleBackColor = true;
            this.menuButton.Visible = false;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Enabled = false;
            this.exitButton.Location = new System.Drawing.Point(565, 428);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(104, 58);
            this.exitButton.TabIndex = 14;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Visible = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(0, 747);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1067, 53);
            this.label1.TabIndex = 15;
            this.label1.Text = "label1";
            // 
            // life1
            // 
            this.life1.BackgroundImage = global::BrickBreaker.Properties.Resources.heart__2_;
            this.life1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.life1.Location = new System.Drawing.Point(3, 757);
            this.life1.Name = "life1";
            this.life1.Size = new System.Drawing.Size(45, 40);
            this.life1.TabIndex = 16;
            this.life1.TabStop = false;
            // 
            // life5
            // 
            this.life5.BackgroundImage = global::BrickBreaker.Properties.Resources.heart__2_;
            this.life5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.life5.Location = new System.Drawing.Point(207, 757);
            this.life5.Name = "life5";
            this.life5.Size = new System.Drawing.Size(40, 40);
            this.life5.TabIndex = 17;
            this.life5.TabStop = false;
            // 
            // life4
            // 
            this.life4.BackgroundImage = global::BrickBreaker.Properties.Resources.heart__2_;
            this.life4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.life4.Location = new System.Drawing.Point(156, 757);
            this.life4.Name = "life4";
            this.life4.Size = new System.Drawing.Size(45, 40);
            this.life4.TabIndex = 18;
            this.life4.TabStop = false;
            // 
            // life3
            // 
            this.life3.BackgroundImage = global::BrickBreaker.Properties.Resources.heart__2_;
            this.life3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.life3.Location = new System.Drawing.Point(105, 757);
            this.life3.Name = "life3";
            this.life3.Size = new System.Drawing.Size(45, 40);
            this.life3.TabIndex = 19;
            this.life3.TabStop = false;
            // 
            // life2
            // 
            this.life2.BackgroundImage = global::BrickBreaker.Properties.Resources.heart__2_;
            this.life2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.life2.Location = new System.Drawing.Point(54, 757);
            this.life2.Name = "life2";
            this.life2.Size = new System.Drawing.Size(45, 40);
            this.life2.TabIndex = 20;
            this.life2.TabStop = false;
            // 
            // GameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.life2);
            this.Controls.Add(this.life3);
            this.Controls.Add(this.life4);
            this.Controls.Add(this.life5);
            this.Controls.Add(this.life1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.menuButton);
            this.Controls.Add(this.pauseMenuLabel);
            this.Controls.Add(this.pauseButton);
            this.Controls.Add(this.lazerLabel);
            this.Controls.Add(this.testLabel);
            this.Controls.Add(this.scoreOutput);
            this.Controls.Add(this.livesLabel);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "GameScreen";
            this.Size = new System.Drawing.Size(1067, 800);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.GameScreen_Paint);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GameScreen_KeyUp);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.GameScreen_PreviewKeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pauseButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.life1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.life5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.life4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.life3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.life2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer gameTimer;
 
        private System.Windows.Forms.Label testLabel;
        private System.Windows.Forms.Label lazerLabel;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Label scoreOutput;
        private System.Windows.Forms.Label livesLabel;
        private System.Windows.Forms.PictureBox pauseButton;
        private System.Windows.Forms.Label pauseMenuLabel;
        private System.Windows.Forms.Button menuButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox life1;
        private System.Windows.Forms.PictureBox life5;
        private System.Windows.Forms.PictureBox life4;
        private System.Windows.Forms.PictureBox life3;
        private System.Windows.Forms.PictureBox life2;
    }
}
