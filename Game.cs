using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    public class Game : PlayerFactory
    {

        Player player1 = new Player();
        Player player2 = new Player();
        
        public string PlayerName;
        public int PlayerSelection;
        public int Winner;
        int roundsToPlay;


        public bool PlayAgain { get; set; }


        public SymbolList<Rock, Paper, Scissors, Lizard, Spock> symbolList =
            new SymbolList<Rock, Paper, Scissors, Lizard, Spock>();
        PlayerFactory playerFactory = new PlayerFactory();

        public int RoundsToPlay
        {
            get { return 0; }
            set
            {
                Console.WriteLine("How many rounds would you like to play?");
                roundsToPlay = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i <= roundsToPlay; i++)
                {
                    PlayAgain = true;
                    if (i <= roundsToPlay) continue;
                    PlayAgain = false;
                    Console.WriteLine("Thanks for Playing!");
                    break;
                }
            }
        }

        public void GameIntro()
        {
            Console.WriteLine(
    "Welcome to Rock, Paper, Scissors, Lizard, Spock!\n\n\nThe Rules Are Simple:\n\nScissors cuts paper,\n\npaper covers rock,\n\nrock crushes lizard,\n\nlizard poisons Spock,\n\nSpock smashes scissors\n\nscissors decapitate lizard,\n\nlizard eats paper, \n\npaper disproves Spock,\n\nSpock vaporizes rock.\n\nAnd as it always has, rock crushes scissors.\n\n\n");
        }
        public void DetermineWinner()
        {

            List<int> playerChoices = new List<int>();

            playerChoices.Add(player1.Selection);
            playerChoices.Add(player2.Selection);
            Winner = (5 + player1.Selection - player2.Selection) % 5;

        }

    }
}












