/*  Created by: 
 *  Project: Brick Breaker
 *  Date: May 03
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using System.Xml;
using BrickBreaker.BrickBreaker;
using System.Threading;

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
        public static string state;

        Image paddleImage;

        // Paddle and Ball objects

        Ball ball;
        //bool ballMove = true;

        // list of all blocks for current level
        List<Block> blocks = new List<Block>();

        // Brushes
        SolidBrush paddleBrush = new SolidBrush(Color.White);
        SolidBrush ballBrush = new SolidBrush(Color.White);
        SolidBrush blockBrush = new SolidBrush(Color.Red);
        SolidBrush alphaBrush = new SolidBrush(Color.Blue);
        SolidBrush greenBrush = new SolidBrush(Color.Green);

        // random
        Random rnd = new Random();

        public Paddle paddle;
        public Rectangle midPaddle;
        public Rectangle leftSideRec;
        public Rectangle rightSideRec;

        List<PowerUp> powerUpList = new List<PowerUp>();
        List<Lazer> lazerList = new List<Lazer>();
        List<Rectangle> paddleRectangles = new List<Rectangle>();

        int alpha = 0;
        int alpha2 = 150;

        bool reset = false;
        // lists
        //List<PowerUp> powerUpList = new List<PowerUp>();
        //List<Lazer> lazerList = new List<Lazer> ();
        //List<Rectangle> paddleRectangles = new List<Rectangle> ();


        //public Paddle paddle;
        //public Rectangle midPaddle;
        //public Rectangle leftSideRec;
        //public Rectangle rightSideRec;


        int valu = 0;

        int xSpeed;
        int ySpeed;

        int timeOne;
        int timeTwo;

        bool ballDown = false;
        bool longPaddle = false;
        bool inUse;
        bool toggle = false;
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
            state = "level 1";
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
            midPaddle = new Rectangle(paddle.x - 3, paddle.y, paddle.width + 3, paddle.height);

            midPaddle = new Rectangle(paddle.x, paddle.y, paddle.width, paddle.height);
            leftSideRec = new Rectangle(paddle.x - 3, paddle.y, 3, paddle.height);
            rightSideRec = new Rectangle(paddle.x + paddle.width + 3, paddle.y, 3, paddle.height);

            paddleRectangles.Add(leftSideRec);
            paddleRectangles.Add(midPaddle);
            paddleRectangles.Add(rightSideRec);

            // setup starting ball values
            int ballX = this.Width / 2 - 10;
            int ballY = this.Height - paddle.height - 80;

            // Creates a new ball
            xSpeed = 5;
            ySpeed = -5;
            int ballSize = 20;
            ball = new Ball(ballX, ballY, xSpeed, ySpeed, ballSize);

            this.BackgroundImage = Properties.Resources.gaBackground2;

            paddleImage = Properties.Resources.gapaddle2;



            loadLevel("level2XML");
            //ColourBricks(Color.LightCoral,Color.Pink,Color.Red,Color.Orange,Color.Yellow);
            //#region Creates blocks for generic level. Need to replace with code that loads levels.

            ////TODO - replace all the code in this region eventually with code that loads levels from xml files

            //blocks.Clear();
            //int x = 10;

            //while (blocks.Count < 12)
            //{
            //    x += 57;
            //    Block b1 = new Block(x, 10, 1, Color.White);
            //    blocks.Add(b1);
            //}

            //#endregion


            // start the game engine loop
            gameTimer.Enabled = true;
        }

        public void NextLevel()
        {
            if (state == "level 1")
            {
                state = "level 2";
                loadLevel("level4XML");
                this.BackgroundImage = Properties.Resources.pmBack;
                paddleImage = Properties.Resources.pmpaddle2;

                loadLevel("level1XML");
                this.BackgroundImage = Properties.Resources.donkeykong;
                paddleImage = Properties.Resources.dkpaddle2;
            }
            else if (state == "level 2")
            {
                state = "level 3";
                loadLevel("level4XML");
                this.BackgroundImage = Properties.Resources.pmBack;
                paddleImage = Properties.Resources.pmpaddle2;
            }
            else if (state == "level 3")
            {
                state = "level 4";
                loadLevel("level5XML");
                this.BackgroundImage = Properties.Resources.zlbackground_1078__800_at__3__0_;
                paddleImage = Properties.Resources.zlpaddle;
            }
            else if (state == "level 4")
            {
                state = "level 5";
                loadLevel("level3XML");
                this.BackgroundImage = Properties.Resources.tetris;
                paddleImage = Properties.Resources.tspaddle2;
            }
            else if (state == "level 5")
            {
                state = "over";
            }

            //set all button presses to false.
            leftArrowDown = rightArrowDown = false;

            // setup starting paddle values and create paddle object
            int paddleWidth = 80;
            int paddleHeight = 20;
            int paddleX = ((this.Width / 2) - (paddleWidth / 2));
            int paddleY = (this.Height - paddleHeight) - 60;
            int paddleSpeed = 8;

            paddle = new Paddle(paddleX, paddleY, paddleWidth, paddleHeight, paddleSpeed, Color.White);

            midPaddle = new Rectangle(paddle.x, paddle.y, paddle.width, paddle.height);
            leftSideRec = new Rectangle(paddle.x - 3, paddle.y, 3, paddle.height);
            rightSideRec = new Rectangle(paddle.x + paddle.width + 3, paddle.y, 3, paddle.height);

            paddleRectangles.Add(leftSideRec);
            paddleRectangles.Add(midPaddle);
            paddleRectangles.Add(rightSideRec);

            // setup starting ball values
            int ballX = this.Width / 2 - 10;
            int ballY = this.Height - paddle.height - 80;

            // Creates a new ball
            xSpeed = 5;
            ySpeed = -5;
            int ballSize = 20;
            ball = new Ball(ballX, ballY, xSpeed, ySpeed, ballSize);


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
                    if (gameTimer.Enabled == false)
                    {
                        gameTimer.Enabled = true;
                    }
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
                case Keys.Escape:
                    EventArgs f = new EventArgs();
                    pauseButton_Click(sender, f);
                    break;
                default:
                    break;
            }
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {

            //very start of engine
            Rectangle newPaddle = new Rectangle(paddle.x, paddle.y, paddle.width, paddle.height);

            if (reset == true)
            {
                if (spaceDown == true)
                {
                    reset = false;
                    ball.xSpeed = 6;
                    ball.ySpeed = 6;
                }
            }

            if (ball.ySpeed > 0)
            {
                ballDown = true;
            }
            else
            {
                ballDown = false;
            }

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

            // Check for collision with top and side walls
            ball.WallCollision(this);

            // Check for ball hitting bottom of screen
            if (ball.BottomCollision(this))
            {
                lives--;
                score -= 200;
                ScoreAndLives(); //display updated lives count

                #region pausing game and playing again with spacebar

                if (lives != 0)
                {
                    reset = true;
                    ball.x = paddle.x + (paddle.width / 2) - (ball.size / 2);
                    ball.y = paddle.y - ball.size - 3;

                    xSpeed = 0;
                    ySpeed = 0;
                }

                // Check for ball hitting bottom of screen


                if (lives == 0)
                {
                    gameTimer.Enabled = false;
                    OnEnd();
                }

                this.Focus();
            }

            // Check for collision of ball with paddle, (incl. paddle movement)
            //if (ySpeed > 0)
            //{
            if (ball.PaddleCollision(paddle))
            {
                ball.y = paddle.y - ball.size - 1;
            }
            // }

            // Check if ball has collided with any blocks
            foreach (Block b in blocks)
            {
                if (ball.BlockCollision(b))
                {
                    if (b.hp == 1)
                    {
                        blocks.Remove(b);

                        valu = rnd.Next(0, 3);
                        if (valu == 2)
                        {
                            PowerUp newPowerUp = new PowerUp(0, 0, 0, 3, null, null, true, 12, 12);
                            newPowerUp.newBall(b.x, b.y, b.width, b.height, lazerList);
                            powerUpList.Add(newPowerUp);
                        }
                    }
                    else
                    {
                        b.hp--;

                        BrickColorChange(b);
                    }
                    //score++;
                    ScoreAndLives(); // display updated score

                    score += 100;

                    break;
                }
            }

            if (blocks.Count == 0)
            {
                gameTimer.Enabled = false;
                OnEnd();
                NextLevel();
            }

            //powerup collision, movement and consequence

            //powerup collision, movement and consequence
            foreach (PowerUp p in powerUpList)
            {
                p.move();

                p.Collision(newPaddle);

                if (p.active == false)
                {

                    if (p.type == "longPaddle")
                    {
                        longPaddle = true;
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

                        midPaddle = new Rectangle(paddle.x - 3, paddle.y, paddle.width + 3, paddle.height);
                    }
                    else if (p.type == "slowBall")
                    {
                        ball.xSpeed /= 1.2f;
                        ball.ySpeed /= 1.2f;
                    }
                    else if (p.type == "newLife")
                    {
                        lives++;
                    }
                    else if (p.type == "lazer")
                    {
                        Lazer newLazer = new Lazer(newPaddle.X + 10, newPaddle.Y, newPaddle.Width - 20, 0, 3, false);
                        lazerList.Add(newLazer);
                    }

                    powerUpList.Remove(p);
                    break;
                }

                if (p.y >= this.Height)
                {
                    powerUpList.Remove(p);
                    break;
                }
            }

            //lazer mechanics
            foreach (Lazer l in lazerList)
            {

                if (inUse == true && alpha != 0)
                {
                    alpha -= 15;
                    if (l.uses <= 0)
                    {
                        lazerList.Remove(l);
                        break;
                    }
                }
                else if (inUse == true && alpha == 0)
                {
                    inUse = false;
                }

                if (alpha < 255 && inUse == false)
                {
                    alpha += 1;
                    l.x = paddle.x + 10;
                    l.width = paddle.width - 20;
                    l.move(newPaddle);
                }
                else if (alpha == 255 && inUse == false)
                {
                    l.recharged = true;
                    l.move(newPaddle);
                }

                if (spaceDown == true && l.recharged == true && l.y >= 720)
                {
                    if (l.uses > 0)
                    {
                        l.fire(blocks, newPaddle);
                        inUse = true;
                        l.uses--;
                    }
                }
            }

            //long paddle color change
            if (alpha2 == 200)
            {
                toggle = false;
            }
            else if (alpha2 == 100)
            {
                toggle = true;
            }

            if (toggle == true)
            {
                alpha2++;
            }
            else if (toggle == false)
            {
                alpha2--;
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

        private void pauseButton_Click(object sender, EventArgs e)
        {
            //pause the game
            gameTimer.Enabled = false;

            menuButton.Visible = true;
            pauseMenuLabel.Visible = true;
            exitButton.Visible = true;

            menuButton.Enabled = true;
            exitButton.Enabled = true;

            pauseMenuLabel.Text = $"\nGAME PAUSED\n\n{state}\n{lives} lives Remaining";
            Refresh();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            //pause the game
            gameTimer.Enabled = true;

            menuButton.Visible = false;
            pauseMenuLabel.Visible = false;
            exitButton.Visible = false;

            menuButton.Enabled = false;
            exitButton.Enabled = false;

            pauseMenuLabel.Text = $"\nGAME PAUSED\n\nLevel [level]\n{lives} lives left\n\n\n\nCLICK TO RETURN";
            this.Focus();
            Refresh();
        }

        public void ColourBricks(Color colour1, Color colour2, Color colour3, Color colour4, Color colour5)
        {
            foreach (Block b in blocks)
            {
                if (b.hp == 1)
                {
                    b.colour = colour1;
                }
                else if (b.hp == 3)
                {
                    b.colour = colour3;
                }
                else if (b.hp == 4)
                {
                    b.colour = colour4;
                }
                else if (b.hp == 5)
                {
                    b.colour = colour5;
                }
            }
        }

        public void OnEnd()
        {
            if (lives != 0)
            {
                resetPowers();
            }
            else
            {
                resetPowers();
                Form1.ChangeScreen(this, new GameOverScreen());
            }

            // // Goes to the game over screen
            // Form form = this.FindForm();
            // GameOverScreen gos = new GameOverScreen();

            // gos.Location = new Point((form.Width - gos.Width) / 2, (form.Height - gos.Height) / 2);

            // form.Controls.Add(gos);
            // form.Controls.Remove(this);
            //// Form1.ChangeScreen(this, new EndScreen());
        }

        public void loadLevel(string xml)
        {
            string x, y, hp, colourString;

            XmlReader reader = XmlReader.Create($"Resources/{xml}.xml");

            while (reader.Read())
            {
                if (reader.NodeType == XmlNodeType.Text)
                {
                    x = reader.ReadString();
                    reader.ReadToNextSibling("y");
                    y = reader.ReadString();

                    reader.ReadToNextSibling("hp");
                    hp = reader.ReadString();

                    reader.ReadToNextSibling("colour");
                    colourString = reader.ReadString();

                    Color colour = Color.FromName(colourString);

                    //Align bricks with image
                    if (this.BackgroundImage == Properties.Resources.donkeykong)
                    {
                        Block newBlock = new Block(Convert.ToInt16(x), Convert.ToInt16(y) + 20, Convert.ToInt16(hp), colour);
                        blocks.Add(newBlock);
                    }
                    else if (this.BackgroundImage == Properties.Resources.gaBackground2)
                    {
                        Block newBlock = new Block(Convert.ToInt16(x), Convert.ToInt16(y) - 6, Convert.ToInt16(hp), colour);
                        blocks.Add(newBlock);
                    }
                    else
                    {
                        Block newBlock = new Block(Convert.ToInt16(x), Convert.ToInt16(y) + 5, Convert.ToInt16(hp), colour);
                        blocks.Add(newBlock);
                    }

                }
            }
            reader.Close();

            Graphics g = this.CreateGraphics();

            Pen blackPen = new Pen(Color.Black);

            foreach (Block b in blocks)
            {
                Rectangle rectangle = new Rectangle(b.x, b.y, 50, 25);

                Color blockColour = b.colour;

                SolidBrush blockBrush = new SolidBrush(blockColour);

                g.DrawRectangle(blackPen, rectangle);
                g.FillRectangle(blockBrush, rectangle);
            }
        }
        public void GameScreen_Paint(object sender, PaintEventArgs e)
        {
            // Draws paddle
            //paddleBrush.Color = Color.White;
            //e.Graphics.FillRectangle(paddleBrush, paddle.x, paddle.y, paddle.width, paddle.height);


            e.Graphics.DrawImage(paddleImage, paddle.x + paddle.width / 2 - 40, paddle.y);

            // Draws blocks
            foreach (Block b in blocks)
            {
                Color blockColour = b.colour;

                SolidBrush blockBrush = new SolidBrush(blockColour);

                e.Graphics.FillRectangle(blockBrush, b.x, b.y, b.width, b.height);
            }

            // Draws ball
            e.Graphics.FillRectangle(ballBrush, ball.x, ball.y, ball.size, ball.size);



            //draws powerUps
            foreach (PowerUp p in powerUpList)
            {
                SolidBrush powerBrush = new SolidBrush(Color.White);
                if (p.color == "blue")
                {
                    powerBrush = new SolidBrush(Color.Blue);
                }
                else if (p.color == "green")
                {
                    powerBrush = new SolidBrush(Color.Green);
                }
                else if (p.color == "red")
                {
                    powerBrush = new SolidBrush(Color.Red);
                }
                else
                {
                    powerBrush = new SolidBrush(Color.White);
                }

                e.Graphics.FillRectangle(powerBrush, p.x, p.y, p.width, p.height);
            }

            Color a = Color.FromArgb(alpha, Color.Blue);
            alphaBrush.Color = a;
            foreach (Lazer l in lazerList)
            {
                e.Graphics.FillRectangle(alphaBrush, paddle.x, paddle.y, paddle.width, paddle.height);
                e.Graphics.FillRectangle(alphaBrush, l.x, l.y, l.width, l.height);
            }

            Color bl = Color.FromArgb(alpha2, Color.Green);
            alphaBrush.Color = bl;
            if (longPaddle == true)
            {
                e.Graphics.FillRectangle(alphaBrush, paddle.x, paddle.y, paddle.width, paddle.height);
            }

        }

        public void resetPowers()
        {
            //resets paddle dimensions =
            paddle.width = 80;
            paddle.height = 20;
            longPaddle = false;

            //removes lazer
            foreach (Lazer l in lazerList)
            {
                lazerList.Remove(l);
                break;
            }

            //resets ball speed 
            ball.xSpeed = xSpeed;
            ball.ySpeed = ySpeed;
        }

        public static void BrickColorChange(Block b)
        {
            if (b.colour == Color.DeepPink)
            {
                b.colour = Color.LightCoral;
            }
            else if (b.colour == Color.Aqua)
            {
                b.colour = Color.LightBlue;
            }
            else if (b.colour == Color.DarkOrange)
            {
                b.colour = Color.Orange;
            }
            else if (b.colour == Color.Gold)
            {
                b.colour = Color.LightYellow;
            }
            else if (b.colour == Color.Red)
            {
                b.colour = Color.Salmon;
            }
            else if (b.colour == Color.Gray)
            {
                b.colour = Color.SlateGray;
            }
            else if (b.colour == Color.SlateGray)
            {
                b.colour = Color.DimGray;
            }
            else if (b.colour == Color.DimGray)
            {
                b.colour = Color.LightGray;
            }
            else if (b.colour == Color.LightGray)
            {
                b.colour = Color.White;
            }
            else if (b.colour == Color.DarkOrchid)
            {
                b.colour = Color.Orchid;
            }
            else if (b.colour == Color.Orchid)
            {
                b.colour = Color.Magenta;
            }
            else if (b.colour == Color.OrangeRed)
            {
                b.colour = Color.Orange;
            }
            else if (b.colour == Color.Orange)
            {
                b.colour = Color.Yellow;
            }
            else if (b.colour == Color.DarkGreen)
            {
                b.colour = Color.LightGreen;
            }
            else if (b.colour == Color.Pink)
            {
                b.colour = Color.White;
            }
           else  if (b.colour == Color.DarkRed)
            {
                b.colour = Color.Red;
            }
            else if(b.colour == Color.Red)
            {
                b.colour = Color.LightCoral;
            }
            else if(b.colour == Color.MediumBlue)
            {
                b.colour = Color.SkyBlue;
            }
            else if(b.colour == Color.White)
            {
                b.colour = Color.WhiteSmoke;
            }
            else
            {
                b.colour = Color.White;
            }
        }
        public void currentLevel()
        {
            if (this.BackgroundImage == Properties.Resources.gaBackground2)
            {
                state = "level 1";
            }
            else if (this.BackgroundImage == Properties.Resources.pmBack)
            {
                state = "level 2";
            }
            else if (this.BackgroundImage == Properties.Resources.pmBack)
            {
                state = "level 3";
            }
            else if (this.BackgroundImage == Properties.Resources.donkeykong)
            {
                state = "level 4";
            }
            else if (this.BackgroundImage == Properties.Resources.tetris)
            {
                state = "level 2";
            }
        }
    }
    #endregion
}



