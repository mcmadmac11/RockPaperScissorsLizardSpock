using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    public class PlayerFactory : Player
    {
        public Player setPlayerName(Player player)
        {
            Console.WriteLine("Please enter your name");
            player.Name = Console.ReadLine();
            
            return player;
        }

        public Player SetPlayerSelection(Player player)
        {
            Console.WriteLine("{0}'s Turn: Please make a selection",Name);
            Console.WriteLine(" [1] = Rock \n [2] = Paper \n [3] = Scissors");
            player.Selection = Convert.ToInt32(Console.ReadLine());
            
            return player;

        }

        public Player MakePlayer()
        {
            this.Name = Name;
            this.Selection = Selection;
            this.score = score;
            return new Player(Name,Selection);           
        }
    }
}
