using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    public class Game : Player
    {
        public string PlayerName;
        public int PlayerSelection;
        public int Winner;
        public List<int> playerChoices = new List<int>() { };

        public Player player;

        public void DetermineWinner(Player p1, Player p2)
        {
            playerChoices.Add(p1.Selection);
            playerChoices.Add(p2.Selection);          
            Winner = (3 + playerChoices[0] - playerChoices[1]) % 3;

            if (Winner == 1)
            {
                Console.WriteLine("{0} Wins!", p1.Name);
                p1.wins++;
                p2.losses++;
            }
            else if (Winner == 2)
            {
                Console.WriteLine("{0} Wins!",p2.Name);
                p2.wins++;
                p1.losses++;
            }
            else
            {
                Console.WriteLine("You tied!");
                p1.Ties++;
                p2.Ties++;
            }
        }
    }
}
