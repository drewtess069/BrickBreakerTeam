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

        
        }
    }
}
