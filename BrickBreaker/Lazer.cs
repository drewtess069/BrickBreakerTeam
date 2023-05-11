using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
//lazer.cs


namespace BrickBreaker
{
    internal class Lazer
    {
        public int x, y, width, height, uses;
        public bool recharged;

        public Lazer(int _x, int _y, int _width, int _height, int _uses, bool _recharged)
        {
            x = _x;
            y = _y;
            width = _width;
            height = _height;
            uses = _uses;
            recharged = _recharged;
        }

        public void move(Rectangle paddle)
        {
            int index = 1;
            Rectangle p = new Rectangle(paddle.X, paddle.Y, paddle.Width, paddle.Width);

            x = p.X + p.Width / 2 - width / 2;
            y = p.Y;
        }

        public void fire(List<Block> b, Rectangle p)
        {
            List<int> index = new List<int>();
            y = 0;
            x = p.X + 5;
            width = p.Width - 10;
            height = p.Y;
            recharged = false;

            Rectangle lazerRec = new Rectangle(x, y, width, height);
            foreach (Block block in b)
            {
                Rectangle blockRec = new Rectangle(block.x, block.y, block.width, block.height);
                if (lazerRec.IntersectsWith(blockRec))
                {
                    block.hp--;
                    GameScreen.BrickColorChange(block);
                }
                if (block.hp == 0)
                {
                    int newint = b.IndexOf(block);
                    index.Add(newint);
                }
            }

            int num = 0;
            foreach (int i in index)
            {
                b.RemoveAt(i - num);
                num++;
            }

        }
    }
}