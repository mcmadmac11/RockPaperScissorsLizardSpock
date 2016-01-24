using System;

namespace RockPaperScissorsLizardSpock
{
    public class Rock : IDisplay
    {
        public int RockValue = 1;

        public Rock()
        {
            int rockValue = RockValue;
        }

        public void DisplayLoss()
        {
            Console.WriteLine("Rock Wins!");
        }

        public void DisplayWin()
        {
            Console.WriteLine("Rock Loses :(");
        }
    }
}