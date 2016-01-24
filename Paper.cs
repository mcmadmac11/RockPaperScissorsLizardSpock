using System;

namespace RockPaperScissorsLizardSpock
{
    public class Paper : IDisplay
    {
        public int PaperValue = 3;

        public Paper()
        {
            int paperValue = PaperValue;
        }

        public void DisplayLoss()
        {
            Console.WriteLine("Paper Wins!");
        }

        public void DisplayWin()
        {
            Console.WriteLine("Paper Loses :(");
        }
    }
}