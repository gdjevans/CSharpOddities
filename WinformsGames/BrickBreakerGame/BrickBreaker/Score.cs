using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrickBreaker
{
    public static class Score
    {
        private static int TotalScore { get; set; }
        public static int GetScore { get { return TotalScore; } }
        public static bool GameOver { get; set; }

        public static void CalculateScore(PictureBox brick, frmArkanoid form)
        {
            if (brick.BackColor == Color.Blue)
                TotalScore += 1;
            else if (brick.BackColor == Color.Red)
                TotalScore += 2;
            else if (brick.BackColor == Color.Purple)
                TotalScore += 3;
            else if (brick.BackColor == Color.Yellow)
                TotalScore += 4;
            else if (brick.BackColor == Color.Green)
                TotalScore += 5;
            else  // black colour
                TotalScore += 6;

            form.Text = "Score: " + TotalScore; 
        }
    }
}
