using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    public class PlayerFactory
    {
        List<Player> MatchupList;
        public int Winner;
        public PlayerFactory()
        {
            this.MatchupList = matchupList;   
        }
        GameFactory gf = new GameFactory();
        
       
        List<Player> matchupList = new List<Player>();
        Player player1 = new Player();
        Player player2 = new Player();
        SymbolList<Rock,Paper,Scissors,Lizard,Spock> symbolList = new SymbolList<Rock, Paper, Scissors, Lizard, Spock>();


//This method should be in a different class
        public List<Player> SetPlayerData(Player Player1,Player player2)
        {
            List<Player> matchupList = new List<Player>();
            Console.WriteLine("Please enter the first players name");
            Player1.Name = Console.ReadLine();
            Console.WriteLine("Please enter the second players name");
            player2.Name = Console.ReadLine();
            Console.WriteLine(string.Format("{0}'s Turn: Please make a selection \n [1] = {1} \n [2] = {2} \n [3] = {3} \n [4] = {4} \n [5] = {5}", Player1.Name, symbolList.rock.SymbolName, symbolList.paper.SymbolName,symbolList.scissors.SymbolName,symbolList.lizard.SymbolName,symbolList.spock.SymbolName));
            Player1.Selection = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0}'s Turn: Please make a selection \n [1] = Rock \n [2] = Paper \n [3] = Scissors \n [4] = Lizard \n [5] = Spock", player2.Name);
            player2.Selection = Convert.ToInt32(Console.ReadLine());

            matchupList.Add(Player1);
            matchupList.Add(player2);
            Winner = (5 + Player1.Selection - player2.Selection) % 5;
            if (Winner == 1)
            {
                Player1.wins++;
                player2.losses++;
                Console.WriteLine("{0} Wins!", Player1.Name);
                return matchupList;
            }
            else if (Winner == 3)
            {
                Player1.wins++;
                player2.losses++;
                Console.WriteLine("{0} Wins!", Player1.Name);
                return matchupList;
            }
            else if (Winner == 2)
            {
                player2.wins++;
                Player1.losses++;
                Console.WriteLine("{0} Wins!", player2.Name);
                return matchupList;
            }
            else if (Winner == 4)
            {
                player2.wins++;
                Player1.losses++;
                Console.WriteLine("{0} Wins!", player2.Name);
                return matchupList;
            }
            else
            {
                Console.WriteLine("You Tied");
                return matchupList;
            }




        }



        //}

        //    if (player1 != null && player2 != null)
        //    {
        //        Console.WriteLine("New Round:");
        //    }
        //    else if (player1 == null && player2 == null)
        //    {
        //        player1.Name = player.Name;
        //        return player1;
        //    }
        //    else
        //    {
        //        player2.Name = player.Name;
        //    }
        //    return player2;
        //}

    }
}
