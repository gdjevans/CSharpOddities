using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PongGame
{
    public class Ball
    {
        public int BallX { get; set; }
        public int BallY { get; set; }

        frmPong form;
        private Random rand;
        public readonly PictureBox ball;

        public Ball(frmPong form, PictureBox picture)
        {
            this.form = form;
            rand = new Random();
            BallX = 5;
            BallY = 5;
            ball = new PictureBox
            {
                Image = picture.Image,
                Size = picture.Size,
                Visible = true,
                Left = form.ClientSize.Width / 2,
                Top = rand.Next(form.ClientSize.Height)
            };

            form.Controls.Add(ball);
        }
    }
}
