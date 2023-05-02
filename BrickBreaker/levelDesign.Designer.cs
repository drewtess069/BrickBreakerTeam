namespace BrickBreaker
{
    partial class levelDesign
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
            this.hpInput = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.loadButton = new System.Windows.Forms.Button();
            this.level1Button = new System.Windows.Forms.Button();
            this.level5Button = new System.Windows.Forms.Button();
            this.level4Button = new System.Windows.Forms.Button();
            this.level3Button = new System.Windows.Forms.Button();
            this.level2Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // hpInput
            // 
            this.hpInput.Location = new System.Drawing.Point(387, 506);
            this.hpInput.Margin = new System.Windows.Forms.Padding(2);
            this.hpInput.Name = "hpInput";
            this.hpInput.Size = new System.Drawing.Size(73, 20);
            this.hpInput.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(360, 530);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 73);
            this.button1.TabIndex = 1;
            this.button1.Text = "Select HP";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.SystemColors.Control;
            this.saveButton.Location = new System.Drawing.Point(699, 530);
            this.saveButton.Margin = new System.Windows.Forms.Padding(2);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(127, 73);
            this.saveButton.TabIndex = 2;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // loadButton
            // 
            this.loadButton.BackColor = System.Drawing.SystemColors.Control;
            this.loadButton.Location = new System.Drawing.Point(27, 530);
            this.loadButton.Margin = new System.Windows.Forms.Padding(2);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(127, 73);
            this.loadButton.TabIndex = 3;
            this.loadButton.Text = "Load Previous";
            this.loadButton.UseVisualStyleBackColor = false;
            // 
            // level1Button
            // 
            this.level1Button.Location = new System.Drawing.Point(27, 441);
            this.level1Button.Name = "level1Button";
            this.level1Button.Size = new System.Drawing.Size(87, 29);
            this.level1Button.TabIndex = 4;
            this.level1Button.Text = "Level 1";
            this.level1Button.UseVisualStyleBackColor = true;
            this.level1Button.Click += new System.EventHandler(this.level1Button_Click);
            // 
            // level5Button
            // 
            this.level5Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.level5Button.Location = new System.Drawing.Point(739, 441);
            this.level5Button.Name = "level5Button";
            this.level5Button.Size = new System.Drawing.Size(87, 29);
            this.level5Button.TabIndex = 5;
            this.level5Button.Text = "Level 5";
            this.level5Button.UseVisualStyleBackColor = true;
            this.level5Button.Click += new System.EventHandler(this.level5Button_Click);
            // 
            // level4Button
            // 
            this.level4Button.Location = new System.Drawing.Point(549, 441);
            this.level4Button.Name = "level4Button";
            this.level4Button.Size = new System.Drawing.Size(87, 29);
            this.level4Button.TabIndex = 6;
            this.level4Button.Text = "Level 4";
            this.level4Button.UseVisualStyleBackColor = true;
            this.level4Button.Click += new System.EventHandler(this.level4Button_Click);
            // 
            // level3Button
            // 
            this.level3Button.Location = new System.Drawing.Point(380, 441);
            this.level3Button.Name = "level3Button";
            this.level3Button.Size = new System.Drawing.Size(87, 29);
            this.level3Button.TabIndex = 7;
            this.level3Button.Text = "Level 3";
            this.level3Button.UseVisualStyleBackColor = true;
            this.level3Button.Click += new System.EventHandler(this.level3Button_Click);
            // 
            // level2Button
            // 
            this.level2Button.Location = new System.Drawing.Point(199, 441);
            this.level2Button.Name = "level2Button";
            this.level2Button.Size = new System.Drawing.Size(87, 29);
            this.level2Button.TabIndex = 8;
            this.level2Button.Text = "Level 2";
            this.level2Button.UseVisualStyleBackColor = true;
            this.level2Button.Click += new System.EventHandler(this.level2Button_Click);
            // 
            // levelDesign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.level2Button);
            this.Controls.Add(this.level3Button);
            this.Controls.Add(this.level4Button);
            this.Controls.Add(this.level5Button);
            this.Controls.Add(this.level1Button);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.hpInput);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "levelDesign";
            this.Size = new System.Drawing.Size(854, 640);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.levelDesign_MouseClick);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.levelDesign_PreviewKeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox hpInput;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.Button level1Button;
        private System.Windows.Forms.Button level5Button;
        private System.Windows.Forms.Button level4Button;
        private System.Windows.Forms.Button level3Button;
        private System.Windows.Forms.Button level2Button;
    }
}
