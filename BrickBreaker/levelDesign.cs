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

        bool hpSelect = false;
        int hp;
        bool leftArrowDown;
        bool rightArrowDown;
        bool upArrowDown;
        bool downArrowDown;

        bool moveRight;
        bool moveLeft;
        bool moveUp;
        bool moveDown;

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

                Block newBlock = new Block(brick.X, brick.Y, hp, textbox.BackColor);
                blocks.Add(newBlock);


                for (int i = 0; i < bricks.Count - 1; i++)
                {
                    if (brick.IntersectsWith(bricks[i]))
                    {
                        bricks.RemoveAt(i);
                        textBoxes.RemoveAt(i);
                    }
                }

                Cursor.Position = new Point(Cursor.Position.X + 60, Cursor.Position.Y);

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
/*
        public void saveLevel()
        {
            XmlWriter writer = XmlWriter.Create("Resources/LevelDesignXML.xml", null);

            writer.WriteStartElement("Bricks");

            foreach (Block b in blocks)
            {
                {
                    writer.WriteStartElement("Brick");

                    writer.WriteElementString("x", Convert.ToString(b.x));
                    writer.WriteElementString("y", Convert.ToString(b.y));
                    writer.WriteElementString("hp", Convert.ToString(b.hp));
                    writer.WriteElementString("colour", Convert.ToString(b.colour));

                    writer.WriteEndElement();
                }
                writer.WriteEndElement();
                writer.Close();
            }
        }
*/
        private void saveButton_Click(object sender, EventArgs e)
        {
        //    saveLevel();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //return to MenuScreen
            MenuScreen ms = new MenuScreen();
            Form form = this.FindForm();

            form.Controls.Add(ms);
            form.Controls.Remove(this);

            ms.Location = new Point((form.Width - ms.Width) / 2, (form.Height - ms.Height) / 2);
        }
    }
}
