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
    public partial class levelDesign : UserControl
    {
        List<TextBox> textBoxes = new List<TextBox>();
        List<Rectangle> bricks = new List<Rectangle>();
        List<Block> blocks = new List<Block>();

        string levelState;

        bool DownDown = false;
        bool rightDown = false;
        bool upDown = false;
        bool leftDown = false;

        bool hpSelect = false;
        int hp;

        public levelDesign()
        {
            InitializeComponent();
        }

        private void levelDesign_MouseClick(object sender, MouseEventArgs e)
        {
            if (hpSelect == true)
            {
                TextBox textbox = new TextBox();
                textbox.Location = new Point(e.X, e.Y);
                textbox.Font = new Font("Arial", 9);
                textbox.ForeColor = Color.White;
                textbox.Width = 50;
                textbox.Height = 25;
                textbox.TextAlign = HorizontalAlignment.Center;
                textbox.Text = Convert.ToString(hp);

                if (hp == 1)
                {
                    textbox.BackColor = Color.Red;
                }
                else if (hp == 2)
                {
                    textbox.BackColor = Color.Goldenrod;
                }
                else if (hp == 3)
                {
                    textbox.BackColor = Color.Green;
                }
                else if (hp == 4)
                {
                    textbox.BackColor = Color.Blue;
                }
                else if (hp == 5)
                {
                    textbox.BackColor = Color.Magenta;
                }
                else if (hp == 6)
                {
                    textbox.BackColor = Color.Purple;
                }
                else
                {
                    textbox.BackColor = Color.DarkGray;
                }

                this.Controls.Add(textbox);
                textbox.Focus();
                textBoxes.Add(textbox);


                Rectangle brick = new Rectangle(e.X, e.Y, 50, 25);
                bricks.Add(brick);




                for (int i = 0; i < bricks.Count - 1; i++)
                {
                    if (brick.IntersectsWith(bricks[i]))
                    {
                        bricks.RemoveAt(i);
                        textBoxes.RemoveAt(i);
                    }
                }

                if (leftDown)
                {
                    Cursor.Position = new Point(Cursor.Position.X - 50, Cursor.Position.Y);
                }
                else if (upDown)
                {
                    Cursor.Position = new Point(Cursor.Position.X, Cursor.Position.Y - 25);
                }
                else if (DownDown)
                {
                    Cursor.Position = new Point(Cursor.Position.X, Cursor.Position.Y + 25);
                }
                else
                {
                    Cursor.Position = new Point(Cursor.Position.X + 50, Cursor.Position.Y);
                }

                this.Focus();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (hpInput != null)
            {
                try
                {
                    hp = Convert.ToInt32(hpInput.Text);
                    hpSelect = true;
                }
                catch
                {
                    hpInput.Text = "ERROR";
                }
            }
        }

        public void saveLevel(string xml)
        {
            XmlWriter writer = XmlWriter.Create($"Resources/{xml}.xml");

            writer.WriteStartElement("Level");

            foreach (TextBox t in textBoxes)
            {

                writer.WriteStartElement("Brick");

                writer.WriteElementString("x", Convert.ToString(t.Location.X));
                writer.WriteElementString("y", Convert.ToString(t.Location.Y));
                writer.WriteElementString("hp", Convert.ToString(t.Text));
                writer.WriteElementString("colour", Convert.ToString(t.BackColor));

                writer.WriteEndElement();
            }
            writer.Close();

            textBoxes.Clear();
            Form1.ChangeScreen(this, new MenuScreen());
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

                    Block newBlock = new Block(Convert.ToInt16(x), Convert.ToInt16(y), Convert.ToInt16(hp), colour);
                    blocks.Add(newBlock);
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

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (levelState == "level 1")
            {
                saveLevel("level1XML");
            }
            else if (levelState == "level 2")
            {
                saveLevel("level2XML");
            }
            else if (levelState == "level 3")
            {
                saveLevel("level3XML");
            }
            else if (levelState == "level 4")
            {
                saveLevel("level4XML");
            }
            else if (levelState == "level 5")
            {
                saveLevel("level5XML");
            }
        }

        private void levelDesign_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                DownDown = true;
                rightDown = false;
                upDown = false;
                leftDown = false;
            }
            else if (e.KeyCode == Keys.Up)
            {
                DownDown = false;
                rightDown = false;
                upDown = true;
                leftDown = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                DownDown = false;
                rightDown = true;
                upDown = false;
                leftDown = false;
            }
            if (e.KeyCode == Keys.Left)
            {
                DownDown = false;
                rightDown = false;
                upDown = false;
                leftDown = true;
            }
        }

        private void level1Button_Click(object sender, EventArgs e)
        {
            levelState = "level 1";
            this.BackgroundImage = Properties.Resources.donkeykong;
        }

        private void level2Button_Click(object sender, EventArgs e)
        {
            levelState = "level 2";
            this.BackgroundImage = Properties.Resources.tetris;
        }

        private void level3Button_Click(object sender, EventArgs e)
        {
            levelState = "level 3";
        }

        private void level4Button_Click(object sender, EventArgs e)
        {
            levelState = "level 4";
        }

        private void level5Button_Click(object sender, EventArgs e)
        {
            levelState = "level 5";
        }
    }
}
