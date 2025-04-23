using System.Xml;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;

namespace BubbleBreakerGame
{
    public partial class frmBubbleBreaker : Form
    {
        enum Colors
        {
            None,
            Red,
            Green,
            Yellow,
            Blue,
            Purple
        };

        const int NUM_BUBBLES = 10;
        const int BUBBLE_SIZE = 50;
        Colors[,] colors;
        Random rand;
        int score;
        bool[,] isSelected;
        int numOfSelectedBubbles;

        public frmBubbleBreaker()
        {
            InitializeComponent();
            rand = new Random();
            numOfSelectedBubbles = 0;
            score = 0;
            colors = new Colors[NUM_BUBBLES, NUM_BUBBLES];
            isSelected = new bool[NUM_BUBBLES, NUM_BUBBLES];
            lblInfo.BackColor = Color.White;
        }

        private void frmBubbleBreaker_Load(object sender, EventArgs e)
        {
            SetClientSizeCore(NUM_BUBBLES * BUBBLE_SIZE, NUM_BUBBLES * BUBBLE_SIZE);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            BackColor = Color.Black;
            Start();
        }

        private void Start()
        {
            for (int row = 0; row < NUM_BUBBLES; row++)
            {
                for (int col = 0; col < NUM_BUBBLES; col++)
                {
                    colors[row, col] = (Colors)rand.Next(1, 6);
                }
            }

            this.Text = score + " points";
        }

        private void Form_Paint(object sender, PaintEventArgs e)
        {
            for (int row = 0; row < NUM_BUBBLES; row++)
            {
                for (int col = 0; col < NUM_BUBBLES; col++)
                {
                    Color bubbleColor = Color.Empty;
                    var xPos = col;
                    var yPos = row;

                    switch (colors[row, col])
                    {
                        case Colors.Red:
                            bubbleColor = Color.Red;
                            break;
                        case Colors.Yellow:
                            bubbleColor = Color.Yellow;
                            break;
                        case Colors.Green:
                            bubbleColor = Color.Green;
                            break;
                        case Colors.Blue:
                            bubbleColor = Color.Blue;
                            break;
                        case Colors.Purple:
                            bubbleColor = Color.Purple;
                            break;
                    }

                    e.Graphics.FillEllipse(new LinearGradientBrush(new Point(row * BUBBLE_SIZE, col * BUBBLE_SIZE),
                                                                   new Point(row * BUBBLE_SIZE + BUBBLE_SIZE, col * BUBBLE_SIZE + BUBBLE_SIZE), Color.White, bubbleColor),
                                                                   xPos * BUBBLE_SIZE, yPos * BUBBLE_SIZE, BUBBLE_SIZE, BUBBLE_SIZE);
                }
            }
        }

        private void Form_MouseDown(object sender, MouseEventArgs e)
        {
            var x = Convert.ToInt32(e.X / BUBBLE_SIZE);
            var y = Convert.ToInt32(e.Y / BUBBLE_SIZE);
            var row = y;
            var col = x;

            if (isSelected[row, col] && numOfSelectedBubbles > 1)
            {
                score += Convert.ToInt32(lblInfo.Text);
                this.Text = score + " points";
                RemoveBubbles();
                ClearSelected();
                MoveBubblesDown();
                MoveBubblesRight();

                if (!HasMoreMoves())
                {
                    MessageBox.Show("Game Over!!!");
                }

            }
            else
            {
                ClearSelected();

                if (colors[row, col] > Colors.None)
                {
                    HighlightNeighbours(row, col);

                    if (numOfSelectedBubbles > 1)
                    {
                        SetLabel(numOfSelectedBubbles, x, y);
                    }
                }
            }
        }

        private void RemoveBubbles()
        {
            for (int row = 0; row < NUM_BUBBLES; row++)
            {
                for(int col = 0; col < NUM_BUBBLES; col++)
                {
                    if (isSelected[row, col])
                    {
                        colors[row, col] = Colors.None;
                    }
                }
            }

            this.Invalidate();
            Application.DoEvents();
        }

        private void ClearSelected()
        {
            for (int row = 0; row < NUM_BUBBLES; row++)
            {
                for (int col = 0; col < NUM_BUBBLES; col++)
                {
                    isSelected[row, col] = false;
                }
            }
            
            numOfSelectedBubbles = 0;
            lblInfo.Visible = false;
        }

        private bool HasMoreMoves()
        {
            for (int row = 0; row < NUM_BUBBLES; row++)
            {
                for (int col = 0; col < NUM_BUBBLES; col++)
                {
                    if (colors[row, col] > Colors.None)
                    {
                        if (col < NUM_BUBBLES - 1 && colors[row, col] == colors[row, col + 1])
                        {
                            return true;
                        }

                        if (col < NUM_BUBBLES - 1 && colors[row, col] == colors[row + 1, col])
                        {
                            return true;
                        }

                    }
                }
            }

            return false;
        }

        private void SetLabel(int numOfBubbles, int x, int y)
        {
            var value = numOfBubbles * (numOfBubbles - 1);
            lblInfo.Text = value.ToString();

            lblInfo.Left = x * BUBBLE_SIZE + BUBBLE_SIZE;
            lblInfo.Top = y * BUBBLE_SIZE + BUBBLE_SIZE;

            if(lblInfo.Left > this.ClientSize.Width / 2)
                lblInfo.Left -= BUBBLE_SIZE;

            if (lblInfo.Top > this.ClientSize.Height / 2)
                lblInfo.Top -= BUBBLE_SIZE;

            lblInfo.Visible = true;
        }
    }
}
