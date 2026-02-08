namespace SnakeGame
{
    public partial class frmSnake : Form
    {
        Random rand;
        enum GameBoardFields
        {
            Free,
            Snake,
            Bonus
        };

        enum Directions
        {
            Up,
            Down,
            Left,
            Right
        };

        struct SnakeCoordinates
        {
            public int x;
            public int y;
        }

        GameBoardFields[,] gameBoardField;
        SnakeCoordinates[] snakeXY;
        int snakeLength;
        Directions direction;
        Graphics g;

        public frmSnake()
        {
            InitializeComponent();
            gameBoardField = new GameBoardFields[11, 11];
            snakeXY = new SnakeCoordinates[100];
            rand = new Random();
        }

        private void frmSnake_Load(object sender, EventArgs e)
        {
            picGameBoard.Image = new Bitmap(420, 420);
            g = Graphics.FromImage(picGameBoard.Image);
            g.Clear(Color.White);

            for (int i = 0; i <= 10; i++)
            {
                // top and bottom walls
                g.DrawImage(imgList.Images[6], i * 35, 0);
                g.DrawImage(imgList.Images[6], i * 35, 385);
            }

            for (int i = 0; i <= 11; i++)
            {
                // left and right walls
                g.DrawImage(imgList.Images[6], 0, i * 35);
                g.DrawImage(imgList.Images[6], 385, i * 35);
            }

            //inital snake body and head
            snakeXY[0].x = 5; // head
            snakeXY[0].y = 5;
            snakeXY[1].x = 5; // first body part
            snakeXY[1].y = 6;
            snakeXY[2].x = 5; // second body part
            snakeXY[2].y = 7;

            g.DrawImage(imgList.Images[5], 5 * 35, 5 * 35); // draw head 
            g.DrawImage(imgList.Images[4], 5 * 35, 6 * 35); // draw first body part 
            g.DrawImage(imgList.Images[4], 5 * 35, 7 * 35); // draw second body part 

            gameBoardField[5, 5] = GameBoardFields.Snake;
            gameBoardField[5, 6] = GameBoardFields.Snake;
            gameBoardField[5, 7] = GameBoardFields.Snake;

            direction = Directions.Up;
            snakeLength = 3;

            for (int i = 0; i < 4; i++)
            {
                Bonus();
            }
        }

        private void Bonus()
        {
            int x, y;
            var imgIndex = rand.Next(0, 4);

            do
            {
                x = rand.Next(1, 10);
                y = rand.Next(1, 10);
            }
            while (gameBoardField[x, y] != GameBoardFields.Free);

            gameBoardField[x, y] = GameBoardFields.Bonus;
            g.DrawImage(imgList.Images[imgIndex], x * 35, y * 35);
        }

        private void frmSnake_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                    direction = Directions.Up;
                    break;
                case Keys.Down:
                    direction = Directions.Down;
                    break;
                case Keys.Left:
                    direction = Directions.Left;
                    break;
                case Keys.Right:
                    direction = Directions.Right;
                    break;
            }
        }

        private void GameOver()
        {
            timer.Enabled = false;
            MessageBox.Show("GAME OVER!");
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            g.FillRectangle(Brushes.White, snakeXY[snakeLength - 1].x * 35, snakeXY[snakeLength - 1].y * 35, 35, 35);
            gameBoardField[snakeXY[snakeLength - 1].x, snakeXY[snakeLength - 1].y] = GameBoardFields.Free;

            // Move snake field on the position of the previous one
            for (int i = snakeLength; i >= 1; i--)
            {
                snakeXY[i].x = snakeXY[i - 1].x;
                snakeXY[i].y = snakeXY[i - 1].y;
            }

            g.DrawImage(imgList.Images[4], snakeXY[0].x * 35, snakeXY[0].y * 35);

            //change direction of the head
            switch (direction)
            {
                case Directions.Up:
                    snakeXY[0].y = snakeXY[0].y - 1;
                    break;
                case Directions.Down:
                    snakeXY[0].y = snakeXY[0].y + 1;
                    break;
                case Directions.Left:
                    snakeXY[0].x = snakeXY[0].x - 1;
                    break;
                case Directions.Right:
                    snakeXY[0].x = snakeXY[0].x + 1;
                    break;
            }

            // check if snake hit the wall
            if (snakeXY[0].x < 1 || snakeXY[0].y > 10 || snakeXY[0].y < 1 || snakeXY[0].y > 10)
            {
                GameOver();
                picGameBoard.Refresh();
                return;
            }

            //Check if snake hit its own body
            if (gameBoardField[snakeXY[0].x, snakeXY[0].y] == GameBoardFields.Snake)
            {
                GameOver();
                picGameBoard.Refresh();
                return;
            }

            //Check if snake ate a bonus
            if (gameBoardField[snakeXY[0].x, snakeXY[0].y] == GameBoardFields.Bonus)
            {
                g.DrawImage(imgList.Images[4], snakeXY[snakeLength].x * 35, snakeXY[snakeLength].y * 35);
                gameBoardField[snakeXY[snakeLength].x, snakeXY[snakeLength].y] = GameBoardFields.Snake;
                snakeLength++;

                if (snakeLength < 96)
                    Bonus();

                this.Text = "Snake - score: " + snakeLength;
            }

            // Draw snake head
            g.DrawImage(imgList.Images[5], snakeXY[0].x * 35, snakeXY[0].y * 35);
            gameBoardField[snakeXY[0].x, snakeXY[0].y] = GameBoardFields.Snake;

            picGameBoard.Refresh();
        }
    }
}
