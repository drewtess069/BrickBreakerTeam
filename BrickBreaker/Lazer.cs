using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing; 

namespace BrickBreaker
{
    internal class Lazer
    {
        public  int x, y, width, height, uses;
        public  bool recharged; 

        public Lazer (int _x, int _y, int _width, int _height, int _uses, bool _recharged)
        {
            x = _x;
            y = _y;
            width = _width;
            height = _height;
            uses = _uses;
            recharged = _recharged;
        }

        public void move(List<Rectangle> paddle)
        {
            int index = 1;
            Rectangle p = new Rectangle(paddle[index].X, paddle[index].Y, paddle[index].Width, paddle[index].Width); 

            x = p.X + p.Width/2 - width/2;
            y = p.Y; 
        }

        public void fire(List<Block> b, List<Rectangle> p)
        {
            y = 0;
            x = p[1].X;
            recharged = false; 
        }
    }
}
