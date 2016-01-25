using System;
namespace RockPaperScissorsLizardSpock
{
    public class Spock : IDisplay
    {
        public int SpockValue { get; private set; }
        public string SymbolName { get; set; }
        public Spock()
        {
            SymbolName = "Spock";
            SpockValue = 5;
        }



        public void DisplayWin()
        {

            Console.WriteLine("Spock Wins! :] ");
        }

        public void DisplayLoss()
        {
            Console.WriteLine("Spock Loses :[ ");
        }
    }
}