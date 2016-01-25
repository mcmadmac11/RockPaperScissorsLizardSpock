using System;

namespace RockPaperScissorsLizardSpock
{
    public class Paper : IDisplay
    {
        public Paper()
        {
            SymbolName = "Paper";
            PaperValue = 2;
        }

        public int PaperValue { get; private set; }
        public string SymbolName { get; set; }

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