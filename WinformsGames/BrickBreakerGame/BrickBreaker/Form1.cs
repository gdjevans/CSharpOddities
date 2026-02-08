using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace BrickBreaker
{
    public partial class frmArkanoid : Form
    {
        List<Brick> bricks;
        const int NumOfBricks = 20;
        Paddle paddle;
        Ball ball;

        public frmArkanoid()
        {
            InitializeComponent();
            bricks = new List<Brick>();
            paddle = new Paddle(this);
            ball = new Ball(this, picBall, paddle);
            DoubleBuffered = true;
        }

        private void frmArkanoid_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < NumOfBricks; i++)
            {
                bricks.Add(new Brick(this));
                Thread.Sleep(10);
            }
        }

        private void Key_Down(object sender, KeyEventArgs e)
        {
            paddle.PaddleMove(e);
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (Score.GameOver)
            {
                timer.Enabled = false;
                return;
            }

            ball.MoveBall();
            if (Score.GetScore >= 20)
            {
                ball.IncreasedSpeed = 7;
                paddle.Speed = 7;
            }
            else if (Score.GetScore >= 15)
            {
                ball.IncreasedSpeed = 5;
                paddle.Speed = 6;
            }
            else if (Score.GetScore >= 10)
            {
                ball.IncreasedSpeed = 3;
            }
            else if (Score.GetScore >= 5)
            {
                ball.IncreasedSpeed = 1;
            }
        }
    }
}
