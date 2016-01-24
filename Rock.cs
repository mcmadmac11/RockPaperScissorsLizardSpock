using System;

namespace RockPaperScissorsLizardSpock
{
    public class Rock : IDisplay
    {
        public int RockValue { get; private set; }

        public Rock()
        {
            RockValue = 1;
        }

        public void DisplayWin()
        {
            Console.WriteLine("Rock Wins! :] ");
        }

        public void DisplayLoss()
        {
            Console.WriteLine("Rock Loses :[ ");
        }
    }
}