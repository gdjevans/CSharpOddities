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
    public partial class frmArkanoid : Form
    {
        List<Brick> bricks;
        const int NumOfBricks = 20;
        Paddle paddle;

        public frmArkanoid()
        {
            InitializeComponent();
            bricks = new List<Brick>();
            paddle = new Paddle(this);
        }

        private void frmArkanoid_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < NumOfBricks; i++)
            {
                bricks.Add(new Brick(this));
            }
        }

        private void Key_Down(object sender, KeyEventArgs e)
        {
            paddle.PaddleMove(e);
        }
    }
}
