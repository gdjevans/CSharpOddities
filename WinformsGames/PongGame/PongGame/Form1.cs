namespace PongGame
{
    public partial class frmPong : Form
    {
        bool goUp;
        bool goDown;
        int pPaddleSpeed;
        int cPaddleSpeed;
        int pScore;
        int cScore;
        Random rand;
        
        List<Ball> balls;

        public frmPong()
        {
            InitializeComponent();
            pPaddleSpeed = 5;
            cPaddleSpeed = 15;
            pScore = 0;
            cScore = 0;
            rand = new Random();
            balls = new List<Ball>();
        }

        private void frmPong_Load(object sender, EventArgs e)
        {
            this.Text = "Player: " + pScore + "  |  Computer: " + cScore;
            picPlayer.Left = 0;
            picPlayer.Top = (ClientSize.Height - picPlayer.Height) / 2;
            picComputer.Top = (ClientSize.Height - picComputer.Height) / 2;
            picComputer.Left = (ClientSize.Width - picComputer.Width);
            picDivider.Top = 0;
            picDivider.Height = ClientSize.Height;
            picDivider.Left = (ClientSize.Width - picDivider.Width) / 2;
            balls.Add(new Ball (this, picBall));
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }

        private void Pong_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                goUp = true;
            }

            if (e.KeyCode == Keys.Down)
            {
                goDown = true;
            }
        }

        private void Pong_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                goUp = false;
            }

            if (e.KeyCode == Keys.Down)
            {
                goDown = false;
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            this.Text = "Player: " + pScore + "  |  Computer: " + cScore;

            if (balls.Count == 0)
            {
                balls.Add(new Ball(this, picBall));
            }

            for (int i = 0; i < balls.Count; i++)
            {
                balls[i].ball.Top -= balls[i].BallY;
                balls[i].ball.Left -= balls[i].BallX;

                // player scores
                if (balls[i].ball.Left + balls[i].ball.Width > ClientSize.Width)
                {
                    balls[i].ball.Visible = false;
                    balls.RemoveAt(i);
                    pScore++;
                }

                // computer scores
                else if (balls[i].ball.Left < 0)
                {
                    balls[i].ball.Visible = false;
                    balls.RemoveAt(i);
                    cScore++;
                }
            }

            picComputer.Top -= cPaddleSpeed;

            if (picComputer.Top < 0 || picComputer.Top > ClientSize.Height - picComputer.Height)
            {
                cPaddleSpeed = -cPaddleSpeed;
            }

            for (int i = 0; i < balls.Count; i++)
            {
                if (balls[i].ball.Top < 0 || balls[i].ball.Top + balls[i].ball.Height > ClientSize.Height)
                {
                    balls[i].BallY *= -1; // bounces ball in the other direction
                }

                if (balls[i].ball.Bounds.IntersectsWith(picPlayer.Bounds))
                {
                    balls[i].BallX *= -1;
                }

                if (balls[i].ball.Bounds.IntersectsWith(picComputer.Bounds))
                {
                    balls[i].BallX *= -1;
                    balls.Add(new Ball(this, picBall));
                }
            }

            if (goUp && picPlayer.Top > 0)
            {
                picPlayer.Top -= pPaddleSpeed;
            }

            if (goDown && picPlayer.Top < ClientSize.Height - picPlayer.Height)
            {
                picPlayer.Top += pPaddleSpeed;
            }

            if (pScore >= 10)
            {
                timer.Stop();
                this.Text = "Player: " + pScore + "  |  Computer: " + cScore;
                MessageBox.Show("You Win!!");
            }

            if (cScore >= 10)
            {
                timer.Stop();
                this.Text = "Player: " + pScore + "  |  Computer: " + cScore;
                MessageBox.Show("Computer is Winner!!! Hooray for our ROBOT Overlords!!!");
            }
        }
    }
}
