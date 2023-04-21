using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrickBreaker
{
    public partial class levelDesign : UserControl
    {
        List<Block> blocks = new List<Block>();
        List<TextBox> blockBox = new List<TextBox>();

        public levelDesign()
        {
            InitializeComponent();
        }

        private void levelDesign_MouseClick(object sender, MouseEventArgs e)
        {
            int x = e.X;
            int y = e.Y;

            Block newBlock = new Block(x, y, 2, Color.Red);
            blocks.Add(newBlock);
            Refresh();
        }

        private void levelDesign_Paint(object sender, PaintEventArgs e)
        {
            foreach (Block b in blocks) 
            {
            Rectangle currentBlock = new Rectangle(b.x,b.y,b.width,b.height);
            e.Graphics.FillRectangle(Brushes.Red, currentBlock);
            }
        }
    }
}
