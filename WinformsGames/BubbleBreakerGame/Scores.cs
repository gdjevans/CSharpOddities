using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleBreakerGame
{
    public class Scores
    {
        private string _fileName;
        const string CURRENT_PLAYER = "YOU";

        public int Score {  get; set; }
        public int NumOfBubbles { get; set; }
        public Dictionary<string, int> AllScores { get; set; }

        public Scores(int score, int numOfBubbles)
        {
            Score = score;
            NumOfBubbles = numOfBubbles;
            AllScores = new Dictionary<string, int>();
            SetAllScores();
        }

        private void SetAllScores()
        {
            _fileName = "score_" + NumOfBubbles.ToString() + "txt";
            if (File.Exists(_fileName))
            {
                try
                {
                    string[] allLines = File.ReadAllLines(_fileName);
                    foreach (var line in allLines)
                    {
                        AllScores.Add(line.Split(',')[0], Convert.ToInt32(line.Split(',')[1]));
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error reading file\n" + ex.Message);
                }
            }
            else
            {
                var file = File.Create(_fileName);
                file.Close();
            }
        } 
        public string GetTopThreeScores()
        {
            AllScores.Add(CURRENT_PLAYER, Score);
            var items = (from pair in AllScores
                         orderby pair.Value descending
                         select pair).Take(3);
            var score = "";
            foreach (var i in items)
            {
                score += i.Key + ", " + i.Value + " points\n";
            }
            return score;
        }

        private int GetPositionOfPlayerScore()
        {
            var items = from v in AllScores
                        orderby v.Value descending
                        select v.Value;

            var position = 0;
            foreach (var i in items)
            {
                position++;
                if (i == Score)
                    return position;
            }

            return 0;
        }

        public string GetScoreMessage()
        {
            return "Congratulations, your " + Score + " points is now the #" + GetPositionOfPlayerScore() + " score for " + NumOfBubbles +
                " bubbles game board size!";
        }
    }
}

   
