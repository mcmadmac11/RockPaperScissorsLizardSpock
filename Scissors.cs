using System;

namespace RockPaperScissorsLizardSpock
{
    public class Scissors
    {
        public int ScissorsValue = 2;
        
        public Scissors()
        {
            int scissorsValue = ScissorsValue;
        }

        public void DisplayLoss()
        {
            Console.WriteLine("Scissors Wins!");
        }

        public void DisplayWin()
        {
            Console.WriteLine("Scissors Loses :(");
        }
    }
}