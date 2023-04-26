﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrickBreaker
{
    public partial class EndScreen : UserControl
    {
        string nickname;
        //List<HighScore> leaderboard = new List<HighScore>();

        public EndScreen()
        {
            InitializeComponent();
            endLabel.Text = "Your High Score: ";
            LoadScore();
        }

        private void LoadScore()
        {
            endLabel.Text += $"{GameScreen.score}";
        }

        private void submitNameLabel_TextChanged(object sender, EventArgs e) //remove 
        {

        }

        private void playButton_Click(object sender, EventArgs e)
        {
            Form1.ChangeScreen(this, new MenuScreen());
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            
        }
    }
}
