using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    public class PlayGame : PlayerFactory
    {
        public int Winner;
        public int NumberOfRounds { get; set; }
        public List<int> playerChoices = new List<int>();
        PlayerFactory playerFactory = new PlayerFactory();
        public void DetermineWinner(Player player1,Player player2, Game game)
        {
            playerChoices.Add(player1.Selection);
            playerChoices.Add(player2.Selection);
            Winner = (3 + playerChoices[0] - playerChoices[1]) % 3;

            if (Winner == 1)
            {
                Console.WriteLine();
                Console.WriteLine("{0} Wins!", player1.Name);
                player1.wins++;
                player2.losses++;
            }
            else if (Winner == 2)
            {
                Console.WriteLine("{0} Wins!", player2.Name);
                player2.wins++;
                player1.losses++;
            }
            else
            {
                Console.WriteLine("You tied!");
                player1.Ties++;
                player2.Ties++;
            }
        }



    }
}
