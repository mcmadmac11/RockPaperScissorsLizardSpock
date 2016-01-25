using RockPaperScissorsLizardSpock;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    public class Player
    {
        //if time permits, work out way to make all set accessor's private
        public string Name { get; set; }
        public int Selection { get; set; }
        public int Ties { get; set; }
        public int score { get; set; }
        public int wins { get; set; }
        public int losses { get; set; }
        public List<int> HighScoreList { get; set; }
        //implement running high score count
        public List<int> highScore = new List<int>() { 0 };
        public int highScores;

        public Player()
        {
        }
    }
}
