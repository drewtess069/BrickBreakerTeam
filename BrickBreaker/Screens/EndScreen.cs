using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace BrickBreaker
{
    public partial class EndScreen : UserControl
    {
        List<HighScore> leaderboard = new List<HighScore>();


        public EndScreen()
        {
            InitializeComponent();
            showPlayerScore();
        }

        private void showPlayerScore()
        {
            endLabel.Text = "Your High Score: ";
            endLabel.Text += $"{GameScreen.score}";
            LoadScores();
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            Form1.ChangeScreen(this, new MenuScreen());
        }

        private void submitButton_Click(object sender, EventArgs e)
        {

            //LoadScores();

            string nickname = submitNameLabel.Text;
            int score = GameScreen.score;


            HighScore myScore = new HighScore(nickname, score);
            leaderboard.Add(myScore);
            //leaderboard.Sort();

            /// lambda expression: find by score then sort by score and name.
            leaderboardLabel.Text = "Name / Score"; //clear label
            leaderboard = leaderboard.OrderBy(x => x.score).Reverse().ToList();
            foreach (HighScore h in leaderboard)
            {
                leaderboardLabel.Text += $"\n {h.nickname} / {h.score}";
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
            string nickname;
            int score;

            XmlReader reader = XmlReader.Create("Resources/leaderboard.xml");

            while (reader.Read())
            {
                if (reader.NodeType == XmlNodeType.Text)
                {
                    nickname = reader.ReadString();

                    reader.ReadToNextSibling("score");
                    score = reader.ReadElementContentAsInt();

                    HighScore newScore = new HighScore(nickname, score);
                    leaderboard.Add(newScore);
                }
            }
            leaderboard = leaderboard.OrderBy(x => x.score).ThenBy(x => x.nickname).ToList();
            foreach (HighScore h in leaderboard)
            {
                leaderboardLabel.Text += $"\n {h.nickname} / {h.score}";
            }
            reader.Close();
        }
    }
}
