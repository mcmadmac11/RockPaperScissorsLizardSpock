using System;

namespace RockPaperScissorsLizardSpock
{
    public class Scissors
    {
        public int ScissorsValue { get; private set; }
        
        public Scissors()
        {
            ScissorsValue = 3;
        }

        public void DisplayWin()
        {
            Console.WriteLine("Scissors Wins! :] ");
        }

        public void DisplayLoss()
        {
            Console.WriteLine("Scissors Loses :[ ");
        }
    }
}