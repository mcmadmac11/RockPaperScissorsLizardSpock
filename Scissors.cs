using System;

namespace RockPaperScissorsLizardSpock
{
    public class Scissors
    {
        public int ScissorsValue { get; private set; }
        public string SymbolName { get; set; }

        public Scissors()
        {
            SymbolName = "Scissors";
            ScissorsValue = 3;
        }
        IDisplay displayWin()
        {
            Console.WriteLine("Scissors Wins");
            return displayWin();
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