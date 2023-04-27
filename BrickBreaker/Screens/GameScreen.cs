/*  Created by: 
 *  Project: Brick Breaker
 *  Date: 
 */ 
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace BrickBreaker
{
    public partial class GameScreen : UserControl
    {
        #region global values

        //player1 button control keys - DO NOT CHANGE
        Boolean leftArrowDown, rightArrowDown, spaceDown;


        // Game values
        int lives;
        public static int score = 0;
        string state;


        // Paddle and Ball objects
        Paddle paddle;
        Ball ball;
        //bool ballMove = true;

        // list of all blocks for current level
        List<Block> blocks = new List<Block>();

        // Brushes
        SolidBrush paddleBrush = new SolidBrush(Color.White);
        SolidBrush ballBrush = new SolidBrush(Color.White);
        SolidBrush blockBrush = new SolidBrush(Color.Red);

        // random
        Random rnd = new Random();

        // lists
        List<PowerUp> powerUpList = new List<PowerUp>();
        List<Lazer> lazerList = new List<Lazer> ();
        int valu = 0;

        int timeOne;
        int timeTwo;
        int alpha = 255;
        bool inUse;
        #endregion

        public GameScreen()
        {
            InitializeComponent();
            OnStart();
            ScoreAndLives();
        }

        public void ScoreAndLives()
        {
            livesLabel.Text = $"Lives: {lives}";
            scoreLabel.Text = $"Score: {score}";
        }

        public void OnStart()
        {
            state = "playing";
            //set life counter
            lives = 3;
            score = 0;

            //set all button presses to false.
            leftArrowDown = rightArrowDown = false;

            // setup starting paddle values and create paddle object
            int paddleWidth = 80;
            int paddleHeight = 20;
            int paddleX = ((this.Width / 2) - (paddleWidth / 2));
            int paddleY = (this.Height - paddleHeight) - 60;
            int paddleSpeed = 8;
            paddle = new Paddle(paddleX, paddleY, paddleWidth, paddleHeight, paddleSpeed, Color.White);

            // setup starting ball values
            int ballX = this.Width / 2 - 10;
            int ballY = this.Height - paddle.height - 80;

            // Creates a new ball
            int xSpeed = 6;
            int ySpeed = -6;
            int ballSize = 20;
            ball = new Ball(ballX, ballY, xSpeed, ySpeed, ballSize);

            #region Creates blocks for generic level. Need to replace with code that loads levels.
            
            //TODO - replace all the code in this region eventually with code that loads levels from xml files
            
            blocks.Clear();
            int x = 10;

            while (blocks.Count < 12)
            {
                x += 57;
                Block b1 = new Block(x, 10, 1, Color.White);
                blocks.Add(b1);
            }

            #endregion

            // start the game engine loop
            gameTimer.Enabled = true;
        }

        private void GameScreen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            //player 1 button presses
            switch (e.KeyCode)
            {
                case Keys.Left:
                    leftArrowDown = true;
                    break;
                case Keys.Right:
                    rightArrowDown = true;
                    break;
                case Keys.Space:

                    spaceDown = true;
                    break; 


                default:
                    break;
            }
        }

        private void GameScreen_KeyUp(object sender, KeyEventArgs e)
        {
            //player 1 button releases
            switch (e.KeyCode)
            {
                case Keys.Left:
                    leftArrowDown = false;
                    break;
                case Keys.Right:
                    rightArrowDown = false;
                    break;
                case Keys.Space:

                    spaceDown = false;
                    break;
                default:
                    break;
            }
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            // Move the paddle
            if (leftArrowDown && paddle.x > 0)
            {
                paddle.Move("left");
            }
            if (rightArrowDown && paddle.x < (this.Width - paddle.width))
            {
                paddle.Move("right");
            }

            // Move ball
            ball.Move();

            // Check for collision with top and side walls
            ball.WallCollision(this);

            // Check for ball hitting bottom of screen
            if (ball.BottomCollision(this))
            {
                lives--;
                score -= 200;
                ScoreAndLives(); //display updated lives count

                // Moves the ball back to origin
                ball.x = ((paddle.x - (ball.size / 2)) + (paddle.width / 2));
                ball.y = (this.Height - paddle.height) - 85;

                #region work in progres: pausing game and playing again with spacebar
                ////if (state == "startOff" && spacebarDown == true)
                ////{
                ////    state = "playing";
                ////}

                ////if (state == "playing")
                ////{
                ////    gameTimer.Enabled = true;
                ////}
                ////else if (state == "startOff")
                ////{
                ////    gameTimer.Enabled = false;
                ////}
                #endregion


                if (lives == 0)
                {
                    gameTimer.Enabled = false;
                    OnEnd();
                }
            }

            // Check for collision of ball with paddle, (incl. paddle movement)
            ball.PaddleCollision(paddle);

            // Check if ball has collided with any blocks
            foreach (Block b in blocks)
            {
                if (ball.BlockCollision(b))
                {
                    blocks.Remove(b);
                    score++;
                    ScoreAndLives(); // display updated score

                    score += 100;

                    if (blocks.Count == 0)
                    {
                        gameTimer.Enabled = false;
                        OnEnd();
                    }

                    valu = rnd.Next(0, 3); 
                    if (valu == 2)
                    {
                        PowerUp newPowerUp = new PowerUp(0, 0, 0, 3, null, null, true, 12, 12);
                        newPowerUp.newBall(b.x, b.y, b.width, b.height, lazerList);
                        powerUpList.Add(newPowerUp);    
                    }
                    break;
                }
            }
            testLabel.Text = $"{valu}"; 

            //powerup collision, movement and consequence
            foreach (PowerUp p in powerUpList)
            {
                p.move();
                p.Collision(paddleRectangles);

                if (p.active == false)
                {
                    if (p.type == "longPaddle")
                    {
                        int paddleLenght = 20;
                        if (paddle.x < 10)
                        {
                            paddle.x = 0 + paddleLenght / 2;
                        }
                        else if (paddle.x > this.Width - paddle.width - paddleLenght / 2)
                        {
                            paddle.x = this.Width - paddle.width - paddleLenght / 2;
                        }
                        paddle.width += paddleLenght;
                        paddle.x -= paddleLenght / 2;
                    }
                    else if (p.type == "slowBall")
                    {
                        ball.xSpeed /= 2;
                        ball.ySpeed /= 2;
                    }
                    else if (p.type == "newLife")
                    {
                        lives++;
                    }
                    else if (p.type == "lazer")
                    {
                        Lazer newLazer = new Lazer(paddleRectangles[1].X - 10, paddleRectangles[1].Y, 20, paddleRectangles[1].Height, 3, false);
                        lazerList.Add(newLazer);     
                    }
                }
            }

            //lazer mechanics
            foreach(Lazer l in lazerList)
            {
                if (inUse == true && alpha != 0)
                {
                    alpha -= 15;
                }
                else if (inUse == true && alpha == 0)
                {
                    inUse = false;
                }

                if (alpha <= 255 && inUse == false)
                {
                    alpha += 5;
                    l.move(paddleRectangles);
                }
                else if (alpha == 255 && inUse == false)
                {
                    l.recharged = true;
                    l.move(paddleRectangles);
                }

                if (spaceDown == true && l.recharged == true && l.y <= 0)
                {
                    l.fire(blocks, paddleRectangles);
                    inUse = true;
                }
            }


            //check and display lives
            if (lives > 4)
            {
                life5.Visible = true;
            }
            else
            {
                life5.Visible = false;
            }
            if (lives > 3)
            {
                life4.Visible = true;
            }
            else
            {
                life4.Visible = false;
            }
            if (lives > 2)
            {
                life3.Visible = true;
            }
            else
            {
                life3.Visible = false;
            }
            if (lives > 1)
            {
                life2.Visible = true;
            }
            else
            {
                life2.Visible = false;
            }
            if (lives > 0)
            {
                life1.Visible = true;
            }
            else
            {
                life1.Visible = false;
            }

            //check and display score
            scoreOutput.Text = $"{score}";


            //redraw the screen
            Refresh();
        }

        public void OnEnd()
        {
            // Goes to the game over screen
            Form form = this.FindForm();
            GameOverScreen gos = new GameOverScreen();

            gos.Location = new Point((form.Width - gos.Width) / 2, (form.Height - gos.Height) / 2);

            form.Controls.Add(gos);
            form.Controls.Remove(this);
           // Form1.ChangeScreen(this, new EndScreen());
        }

        public void GameScreen_Paint(object sender, PaintEventArgs e)
        {
            // Draws paddle
            paddleBrush.Color = paddle.colour;
            e.Graphics.FillRectangle(paddleBrush, paddle.x, paddle.y, paddle.width, paddle.height);

            // Draws blocks
            foreach (Block b in blocks)
            {
                e.Graphics.FillRectangle(blockBrush, b.x, b.y, b.width, b.height);
            }

            // Draws ball
            e.Graphics.FillRectangle(ballBrush, ball.x, ball.y, ball.size, ball.size);

            //draws powerUps
            foreach (PowerUp p in powerUpList)
            {
                e.Graphics.FillRectangle(ballBrush, p.x, p.y, p.width, p.height);
            }
        }
    }
}
