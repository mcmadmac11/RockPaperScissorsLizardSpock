using System;

namespace RockPaperScissorsLizardSpock
{
    public class Paper : IDisplay
    {
        public Paper()
        {
            PaperValue = 2;
        }

        IDisplay displayWin()
        {
            Console.WriteLine("Paper Wins");
            return displayWin();
        }
        public int PaperValue { get; private set; }

        public void DisplayWin()
        {
            Console.WriteLine("Paper Wins! :] ");
        }

        public void DisplayLoss()
        {
            Console.WriteLine("Paper Loses :[ ");
        }

    }
}