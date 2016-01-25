using System;
namespace RockPaperScissorsLizardSpock
{
    public class Lizard
    {
        public int LizardValue { get; private set; }
        public string SymbolName { get; set; }
        public Lizard()
        {
            SymbolName = "Lizard";
            LizardValue = 4;
        }



        public void DisplayWin()
        {

            Console.WriteLine("Lizard Wins! :] ");
        }

        public void DisplayLoss()
        {
            Console.WriteLine("Lizard Loses :[ ");
        }
    }
}