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
    public partial class Form1 : Form
    {

        int points = 0;
        int level = 1;
        int lives = 3;

        public Form1()
        {
            InitializeComponent();
            AimenPoints();

        }

        public void AimenPoints()
        {
            // when level complete: level++;
            // when block is hit: points++ (stronger bricks give more points)
            // when ball goes off screen: lives--;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            // Start the program centred on the Menu Screen
            MenuScreen ms = new MenuScreen();
            this.Controls.Add(ms);

            ms.Location = new Point((this.Width - ms.Width) / 2, (this.Height - ms.Height) / 2);
        }
    }
}
