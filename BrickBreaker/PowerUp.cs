using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrickBreaker
{
    
    internal class PowerUp
    {
        public int yspeed, xspeed, x, y;
        string color, type; 

        Random rnd = new Random();

        public PowerUp (int _x, int _y, int _xspeed, int _yspeed, string _color, string _type)
        {
            x = _x;
            y = _y;
            xspeed = _xspeed;
            yspeed = _yspeed;
            color = _color;
            type = _type;
        }


        public void newBall(int brickX, int brickY, int brickWidth, int brickHeight)
        {
            y = brickY + brickHeight;
            x = brickX + brickWidth / 2;
            int rand = rnd.Next(0, 4); 

            if (rand == 0)
            {
                type = "longPaddle"; 
            }
            if (rand == 1)
            {
               // type = ""
            }
        }
    }
}
