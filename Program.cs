using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    public class Program
    {

        static void Main(string[] args)
        {
            //Game.MainMenu();
            //int userInput = Convert.ToInt32(Console.ReadLine());


            //switch (userInput)
            //{
            //    case 1:
            //    Console.WriteLine("This feature is coming soon!");
            //    break;
            //    case 2:
            //    Console.WriteLine("2 player mode selected");         
            //    break;
            //    case 3:
            //    game.PlayAgain = false;
            //    Console.WriteLine("GoodBye");
            //    Environment.Exit(userInput);
            //    break;
            //    default:
            //    Console.WriteLine("Please enter a valid selection");
            //    Game.MainMenu();
            //    break;

            //}

            //game.GameIntro();
            //game.PlayAgain = true;

            Game game = new Game();
           
            PlayerFactory playerFactory = new PlayerFactory();
            Player player1 = new Player();
            Player player2 = new Player();
            playerFactory.SetPlayerData(player1, player2);
            game.DetermineWinner();

            List<Player> matchList = new List<Player>();

            MyFileWriter fileWriter = new MyFileWriter("Rock_Paper_Scissors.txt");
            fileWriter.WriteToFile(player1);
            fileWriter.WriteToFile(player2);



            //SymbolList<Rock,Paper,Scissors,Lizard,Spock> symbolList = new SymbolList<Rock, Paper, Scissors, Lizard, Spock>();
            //PlayerFactory playerFactory = new PlayerFactory();
            //Game game = new Game();
            //PlayerFactory player1 = new PlayerFactory();
            //PlayerFactory player2 = new PlayerFactory();
            //player1.player1.Name = playerFactory.player1.setPlayerName();
            //player2.player2.Name = playerFactory.player2.setPlayerName();
            //PlayerFactory playerFactory = new PlayerFactory();
            //playerFactory.MakePlayer();
            //Console.WriteLine(playerFactory.MatchupList[0].Name);


            //    playerFactory.setPlayerName(player1);
            //    playerFactory.SetPlayerSelection(player1);
            //    Player player2 = new Player();
            //    playerFactory.setPlayerName(player2);
            //    playerFactory.SetPlayerSelection(player2);
            //    Game game = new Game();
            //    game.DetermineWinner(player1,player2);
        }
    }
}

