using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace BrickBreaker
{
    
    internal class PowerUp
    {
        public int ySpeed, xSpeed, x, y, width, height;
        public bool active; 
        public string color, type;

        Random rnd = new Random();

        public PowerUp (int _x, int _y, int _xSpeed, int _ySpeed, string _color, string _type, bool _active, int _width, int _height)
        {
            x = _x;
            y = _y;
            xSpeed = _xSpeed;
            ySpeed = _ySpeed;
            color = _color;
            type = _type;
            active = _active;  
            width = _width;
            height = _height;
        }


                     
        public void newBall(int brickX, int brickY, int brickWidth, int brickHeight, List<Lazer> l)
        {
            if (l.Count == 0)
            {
                y = brickY + brickHeight;
                x = brickX + brickWidth / 2;
                int rand = rnd.Next(0, 4);

                if (rand == 0)
                {
                    type = "longPaddle";
                    color = "white";
                }
                if (rand == 1)
                {
                    type = "slowBall";
                    color = "green";
                }
                if (rand == 2)
                {
                    type = "newLife";
                    color = "red";
                }
                if (rand == 3)
                {
                    type = "lazer";
                    color = "blue";
                }
            }
            else
            {
                y = brickY + brickHeight;
                x = brickX + brickWidth / 2;
                int rand = rnd.Next(0, 3);

                if (rand == 0)
                {
                    type = "longPaddle";
                    color = "white";
                }
                if (rand == 1)
                {
                    type = "slowBall";
                    color = "green";
                }
                if (rand == 2)
                {
                    type = "newLife";
                    color = "red";
                }
            }
        }

        public void move()
        {
            y += ySpeed;
        }

        public void Collision(List<Rectangle> playerRectangle)
        {
            
            Rectangle powerUp = new Rectangle(x, y, xSpeed, ySpeed);
            foreach (Rectangle r in playerRectangle)
            {
                if (r.IntersectsWith(powerUp) == true)
                {
                    active = false;
                }
            }
        }
    }
}
