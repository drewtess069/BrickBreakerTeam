using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrickBreaker
{
    internal class HighScore
    {
        public string nickname;
        public int score;

        public HighScore(string _nickname, int _score)
        {
            nickname = _nickname;
            score = _score;
        }
    }
}
