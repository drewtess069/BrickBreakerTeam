using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

//latest

namespace BrickBreaker
{
    public class Ball
    {
        public int x, y, size;
        public float xSpeed, ySpeed;
        public Color colour;
        public static Random rand = new Random();
        public bool canCollide = true;
        public int collisionTimer;

        public Ball(int _x, int _y, int _xSpeed, int _ySpeed, int _ballSize)
        {
            x = _x;
            y = _y;
            xSpeed = _xSpeed;
            ySpeed = _ySpeed;
            size = _ballSize;

        }

        public void Move()
        {
            x = x + Convert.ToInt32(xSpeed);
            y = y + Convert.ToInt32(ySpeed);
        }

        public bool BlockCollision(Block b)
        {
            Rectangle blockRec = new Rectangle(b.x, b.y, b.width, b.height);
            Rectangle ballRec = new Rectangle(x, y, size, size);

            if (ballRec.IntersectsWith(blockRec))
            {
                ySpeed *= -1;
            }

            return blockRec.IntersectsWith(ballRec);
        }

        public void PaddleCollision(Paddle p)
        {
            Rectangle ballRec = new Rectangle(x, y, size, size);
            List<Rectangle> paddleRectangles = new List<Rectangle>();
            Rectangle leftSideRec = new Rectangle(p.x - 3, p.y, 8, p.height);
            Rectangle rightSideRec = new Rectangle(p.x + p.width - 2, p.y, 8, p.height);

            paddleRectangles.Add(leftSideRec);
            paddleRectangles.Add(rightSideRec);

            Rectangle paddleRec = new Rectangle(p.x + 5, p.y, p.width - 10, p.height);

            #region Paddle side collision code
            //if (canCollide == true)
            //{
            if (ballRec.IntersectsWith(leftSideRec))
            {
                if (xSpeed > 0) 
                {
                    xSpeed *= -1.2f;
                    ySpeed *= 0.8f;
                }
                else
                {
                    ySpeed *= -1.4f;
                    xSpeed *= 0.8f;
                }
            }
            else if (ballRec.IntersectsWith(rightSideRec)) 
            {
                if (xSpeed < 0)
                {
                    xSpeed *= -1.2f;
                    ySpeed *= 0.8f;
                }
                else
                {
                    ySpeed *= -1.2f;
                    xSpeed *= 0.8f;
                }
            }
            else if (ballRec.IntersectsWith(paddleRec))
            {
                ySpeed *= -1;
                canCollide = false;
            }


            //foreach (Rectangle r in paddleRectangles)
            //    {
            //    if (ballRec.IntersectsWith(r))
            //    {
            //        xSpeed *= -1;
            //        canCollide = false;
            //    }
            //}
            //}
            //if (canCollide == false)
            //{
            //    collisionTimer++;
            //}
            //#endregion

            //#region Collision timer
            //if (collisionTimer >= 50)
            //{
            //    canCollide = true;
            //    collisionTimer = 0;
            //}
            #endregion
        }

        public void WallCollision(UserControl UC)
        {
            // Collision with left wall
            if (x <= 0)
            {
                xSpeed *= -1;
            }
            // Collision with right wall
            if (x >= (UC.Width - size))
            {
                xSpeed *= -1;
            }
            // Collision with top wall
            if (y <= 2)
            {
                ySpeed *= -1;
            }
        }

        public bool BottomCollision(UserControl UC)
        {
            Boolean didCollide = false;

            if (y >= UC.Height)
            {
                didCollide = true;
            }

            return didCollide;
        }

    }
}
