using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Windows.Forms.VisualStyles;

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

        public void stasis()
        {
            xSpeed = 0;
            ySpeed = 0;
            GameScreen.state = "startoff";

        }

        public bool BlockCollision(Block b)
        {
            Rectangle blockRec = new Rectangle(b.x, b.y, b.width, b.height);

            Rectangle leftBlock = new Rectangle(b.x, b.y + 5, 13, 15);
            Rectangle rightBlock = new Rectangle(b.x + b.width - 10, b.y + 5, 13, 15);
            Rectangle topBlock = new Rectangle(b.x + 15, b.y, 20, 15);
            Rectangle bottomBlock = new Rectangle(b.x + 15, b.y + b.height - 15, 20, 15);

            Rectangle ballRec = new Rectangle(x, y, size, size);

            if (ballRec.IntersectsWith(leftBlock) || ballRec.IntersectsWith(rightBlock))
            {
                xSpeed *= -1;
                return true;
            }
            else if (ballRec.IntersectsWith(topBlock) || ballRec.IntersectsWith(bottomBlock))
            {
                ySpeed *= -1;
                return true;
            }

            return false;
        }

        public bool PaddleCollision(Paddle p)
        {
            Rectangle ballRec = new Rectangle(x, y, size, size);

            Rectangle playerRec = new Rectangle(p.x, p.y, p.width, p.height);
            Rectangle leftSide = new Rectangle(p.x, p.y, 20, p.height);
            Rectangle rightSide = new Rectangle(p.x + p.width - 20, p.y, 20, p.height);
           // Rectangle middleRec = new Rectangle(p.x + 15, p.y, p.width - 30, p.height);

            if (ballRec.IntersectsWith(playerRec))
            {
                if (ballRec.IntersectsWith(leftSide))
                {
                    // ySpeed *= -1;
                    if (xSpeed > 0)
                    {
                        xSpeed *= -0.8f;
                        ySpeed *= -1.1f;
                    }
                    else
                    {
                        xSpeed *= 1.1f;
                        ySpeed *= -0.9f;
                    }
                }
                else if (ballRec.IntersectsWith(rightSide))
                {
                    if (xSpeed < 0)
                    {
                        xSpeed *= -0.8f;
                        ySpeed *= -1.1f;
                    }
                    else
                    {
                        xSpeed *= 1.1f;
                        ySpeed *= -0.9f;
                    }
                }
                else
                {
                    ySpeed *= -1;
                }

                if (xSpeed > 7)
                {
                    if (xSpeed > 0)
                    {
                        xSpeed = 6.5f;
                    }
                    else
                    {
                        xSpeed = -6.5f;
                    }
                }
                if (ySpeed > Math.Abs(7))
                {
                    if (ySpeed > 0)
                    {
                        ySpeed = 6.5f;
                    }
                    else
                    {
                        ySpeed = -6.5f;
                    }
                }
                return true;
            }
            //if (xSpeed == Math.Round(xSpeed, 0))
            //{
            //    xSpeed = 4;
            //}
            //if (ySpeed == Math.Round(xSpeed, 0))
            //{
            //    ySpeed = 4;
            //}

                return false;
            

            //    List<Rectangle> paddleRectangles = new List<Rectangle>();
            //    Rectangle leftSideRec = new Rectangle(p.x - 3, p.y, 3, p.height);
            //    Rectangle rightSideRec = new Rectangle(p.x + p.width + 3, p.y, 3, p.height);

            //    paddleRectangles.Add(leftSideRec);
            //    paddleRectangles.Add(rightSideRec);

            //    Rectangle paddleRec = new Rectangle(p.x, p.y, p.width, p.height);

            //    #region Paddle side collision code
            //    if (canCollide == true)
            //    {
            //        if (ballRec.IntersectsWith(paddleRec))
            //        {
            //            ySpeed *= -1;
            //            canCollide = false;
            //        }
            //        foreach (Rectangle r in paddleRectangles)
            //        {
            //            if (ballRec.IntersectsWith(r))
            //            {
            //                xSpeed *= -1;
            //                canCollide = false;
            //            }
            //        }
            //    }
            //    if (canCollide == false)
            //    {
            //        collisionTimer++;
            //    }
            //    #endregion

            //    #region Collision timer
            //    if (collisionTimer >= 50)
            //    {
            //        canCollide = true;
            //        collisionTimer = 0;
            //    }
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
    //#endregion
}
