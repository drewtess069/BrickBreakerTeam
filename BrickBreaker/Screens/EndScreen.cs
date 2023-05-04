using System;
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


        List<HighScore> leaderboard = new List<HighScore>();


        //(new HighScore[] { 1, 99, 390, -500});


        public EndScreen()
        {
            InitializeComponent();
            endLabel.Text = "Your High Score: ";
            LoadScore();
        }

        private void LoadScore()
        {
            endLabel.Text += $"{GameScreen.score}";

            //HighScore a = new HighScore("aaa", 300);
            //leaderboard.Add(a);

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
            string nickname = submitNameLabel.Text;
            int score = GameScreen.score;


            HighScore newScore = new HighScore(nickname, score);
            leaderboard.Add(newScore);
            leaderboard.Sort();
            //old code //leaderboardLabel.Text = $"Name / Score\n {leaderboard}";

            /// lambda expression: find by score then sort by score and name.
            leaderboard = leaderboard.OrderBy(x => x.score).ThenBy(x => x.nickname).ToList();
            foreach (HighScore s in leaderboard)
            {
                leaderboardLabel.Text += s.nickname + "" + s.score + " \n";
            }

            /// put dummy scores into xml file and load them from there into the leaderboard label/code
            /// Keep 5 scores, sort new player score in, and discard the lowest one, keeping only 5 total
            /// display sorted leaderboard to label

            /// add xml write method and read method
        }
        private void WriteScore()
        {

        }
        private void LoadScores()
        {

        }
    }
}
