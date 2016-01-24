using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    class Program
    {
        static void Main(string[] args)
        {
            PlayerFactory playerFactory = new PlayerFactory();
            Player player1 = new Player();
            PlayGame playGame = new PlayGame();
            playGame.NumberOfRounds = playGame.NumberOfRounds;
            playerFactory.setPlayerName(player1);
            playerFactory.SetPlayerSelection(player1);
            Player player2 = new Player();
            playerFactory.setPlayerName(player2);
            playerFactory.SetPlayerSelection(player2);
            Game game = new Game();
            game.DetermineWinner(player1,player2);
            game.SetGameSymbols();
            game.gameSymbols.SymbolValuesList.Equals(player1.Selection);
            Console.ReadLine();
            MyFileWriter fileWriter = new MyFileWriter("Rock_Paper_Scissors.txt");
            fileWriter.WriteToFile(player1);
            fileWriter.WriteToFile(player2);
        }
    }
}

