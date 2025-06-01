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
        BallXY ballXY;

        struct BallXY
        {
            public int x;
            public int y;
        }

        public frmPong()
        {
            InitializeComponent();
            pPaddleSpeed = 5;
            cPaddleSpeed = 15;
            pScore = 0;
            cScore = 0;
            rand = new Random();
            ballXY.x = 10;
            ballXY.y = 10;
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
            picBall.Left = (ClientSize.Width / 2) + 20;
            picBall.Top = (ClientSize.Height - picBall.Height) / 2;
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
            picBall.Top -= ballXY.y;
            picBall.Left -= ballXY.x;
            picComputer.Top -= cPaddleSpeed;

            if (picComputer.Top < 0 || picComputer.Top > ClientSize.Height - picComputer.Height)
            {
                cPaddleSpeed = -cPaddleSpeed;
            }

            //computer scores
            if (picBall.Left < 0)
            {
                picBall.Left = ((ClientSize.Width - picBall.Width) / 2) - 200;
                picBall.Top = rand.Next(ClientSize.Height);
                ballXY.x *= -1; // changes ball direction
                cScore++;
            }

            if (picBall.Left + picBall.Width > ClientSize.Width)
            {
                picBall.Left = ((ClientSize.Width - picBall.Width) / 2) + 200;
                picBall.Top = rand.Next(ClientSize.Height);
                ballXY.x *= -1; // changes ball direction
                pScore++;
            }

            if (picBall.Top < 0 || picBall.Top + picBall.Height > ClientSize.Height)
            {
                ballXY.y *= -1; // bounces ball in the other direction
            }

            if (picBall.Bounds.IntersectsWith(picPlayer.Bounds) || picBall.Bounds.IntersectsWith(picComputer.Bounds))
            {
                ballXY.x *= -1;
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
                MessageBox.Show("You Win!!");
            }

            if (cScore >= 10)
            {
                timer.Stop();
                MessageBox.Show("Computer is Winner!!! Hooray for our ROBOT Overlords!!!");
            }
        }
    }
}
