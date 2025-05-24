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
            cPaddleSpeed = 5;
            pScore = 0;
            cScore = 0;
            rand = new Random();
            ballXY.x = 5;
            ballXY.y = 5;
        }

        private void frmPong_Load(object sender, EventArgs e)
        {
            this.Text = "Player: " + pScore + "  |  Computer: " + pScore;
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
    }
}
