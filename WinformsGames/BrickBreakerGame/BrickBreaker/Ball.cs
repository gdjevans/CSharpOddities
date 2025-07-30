using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrickBreaker
{
    public class Ball
    {
        public int SpeedX { get; set; }
        public int SpeedY { get; set; }
        public int IncreasedSpeed {  get; set; }
        private PictureBox ball;
        private frmArkanoid form;
        private Paddle paddle;
        private int lostBalls;

        public Ball(frmArkanoid form, PictureBox pic, Paddle paddle)
        {
            this.form = form;
            IncreasedSpeed = 0;
            SpeedX = 5;
            SpeedY = 5;
            this.paddle = paddle;
            lostBalls = 0;
            this.ball = new PictureBox()
            {
                Width = pic.Width,
                Height = pic.Height,
                Visible = true,
                Image = pic.Image,
                Left = (form.ClientSize.Width - pic.Width) / 2,
                Top = (form.ClientSize.Height - pic.Height) / 2,
                BackColor = Color.Transparent
            };
            form.Controls.Add(ball);
        }

        public void MoveBall() 
        {
            //if (form.Controls.OfType<PictureBox>().Where(t => t.Tag == "Brick").Count() == 0)
            //{
            //    Score.GameOver = true;
            //    MessageBox.Show("Congratulations winner... What next huh?");
            //    return;
            //}

            var counter = 0;
            foreach (var item in form.Controls.OfType<PictureBox>())
            {
                if (item.Tag == "Brick")
                    counter++;
            }

            if (counter == 0)
            {
                Score.GameOver = true;
                MessageBox.Show("Congratulations winner... What next huh?");
                return;
            }

            if (SpeedX < 0)
                ball.Left += SpeedX - IncreasedSpeed;
            else if (SpeedX > 0)
                ball.Left += SpeedX + IncreasedSpeed;

            if (SpeedY < 0)
                ball.Top += SpeedY - IncreasedSpeed;
            else if (SpeedY > 0)
                ball.Top += SpeedY + IncreasedSpeed;

            foreach (var item in form.Controls.OfType<PictureBox>().Where(t => t.Tag == "Brick"))
                {
                    if (ball.Bounds.IntersectsWith(item.Bounds))
                    {
                        Score.CalculateScore(item, form);
                        form.Controls.Remove(item);
                        SpeedY *= -1;
                    }
                }

            if (ball.Bounds.IntersectsWith(paddle.PlayerPaddles[0].Bounds))
            {
                SpeedY = -SpeedY;
                if (SpeedX == 0)
                    SpeedX = -5 - IncreasedSpeed;
                else
                    SpeedX = Math.Abs(SpeedX) * -1;
            }
            else if (ball.Bounds.IntersectsWith(paddle.PlayerPaddles[2].Bounds))
            {
                SpeedY = -SpeedY;
                if (SpeedX == 0)
                    SpeedX = 5 + IncreasedSpeed;
                else
                    SpeedX = Math.Abs(SpeedX);
            }
            else if (ball.Bounds.IntersectsWith(paddle.PlayerPaddles[1].Bounds))
            {
                SpeedY = -SpeedY;
                SpeedX = 0;
            }
            else if (ball.Bottom >= form.ClientSize.Height)
            {
                lostBalls += 1;
                if (lostBalls == 3)
                {
                    Score.GameOver = true;
                    MessageBox.Show("Game Over, Loser");
                    return;
                }

                ball.Left = (form.ClientSize.Width - ball.Width) / 2;
                ball.Top = (form.ClientSize.Height - ball.Height) / 2;
            }
            else if (ball.Top <= 0)
                SpeedY *= -1;
            else if (ball.Left <= 0 || ball.Right >= form.ClientSize.Width)
                SpeedX *= -1;            
        }
    }
}
