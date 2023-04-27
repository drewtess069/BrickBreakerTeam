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
            this.testLabel = new System.Windows.Forms.Label();
            this.lazerLabel = new System.Windows.Forms.Label();
            this.life1 = new System.Windows.Forms.PictureBox();
            this.life2 = new System.Windows.Forms.PictureBox();
            this.life3 = new System.Windows.Forms.PictureBox();
            this.life5 = new System.Windows.Forms.PictureBox();
            this.life4 = new System.Windows.Forms.PictureBox();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.scoreOutput = new System.Windows.Forms.Label();
            this.UXLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.life1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.life2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.life3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.life5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.life4)).BeginInit();

            this.livesLabel = new System.Windows.Forms.Label();
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
            this.testLabel.Location = new System.Drawing.Point(865, 192);
            this.testLabel.Name = "testLabel";
            this.testLabel.Size = new System.Drawing.Size(64, 25);
            this.testLabel.TabIndex = 0;
            this.testLabel.Text = "label1";
            // 
            // lazerLabel
            // 
            this.lazerLabel.AutoSize = true;
            this.lazerLabel.Location = new System.Drawing.Point(942, 605);
            this.lazerLabel.Name = "lazerLabel";
            this.lazerLabel.Size = new System.Drawing.Size(0, 16);
            this.lazerLabel.TabIndex = 1;

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
            // scoreLabel
            // 
            this.scoreLabel.BackColor = System.Drawing.Color.Black;
            this.scoreLabel.Font = new System.Drawing.Font("Courier New", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLabel.ForeColor = System.Drawing.Color.White;
            this.scoreLabel.Location = new System.Drawing.Point(822, 753);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(118, 38);
            this.scoreLabel.TabIndex = 1;
            this.scoreLabel.Text = "SCORE:";
            this.scoreLabel.TextAlign = System.Drawing.ContentAlignment.BottomRight;
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
            this.UXLabel.Location = new System.Drawing.Point(-3, 740);
            this.UXLabel.Name = "UXLabel";
            this.UXLabel.Size = new System.Drawing.Size(1070, 60);
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
            // GameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;

            this.Controls.Add(this.lazerLabel);
            this.Controls.Add(this.testLabel);

            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.scoreOutput);
            this.Controls.Add(this.life4);
            this.Controls.Add(this.life5);
            this.Controls.Add(this.life3);
            this.Controls.Add(this.life2);
            this.Controls.Add(this.life1);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.UXLabel);

            this.Controls.Add(this.livesLabel);
            this.Controls.Add(this.scoreLabel);

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
 
        private System.Windows.Forms.Label testLabel;
        private System.Windows.Forms.Label lazerLabel;

        private System.Windows.Forms.PictureBox life1;
        private System.Windows.Forms.PictureBox life2;
        private System.Windows.Forms.PictureBox life3;
        private System.Windows.Forms.PictureBox life5;
        private System.Windows.Forms.PictureBox life4;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Label scoreOutput;
        private System.Windows.Forms.Label UXLabel;

       // private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Label livesLabel;

    }
}
