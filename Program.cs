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
            playerFactory.setPlayerName(player1);
            playerFactory.SetPlayerSelection(player1);
            Player player2 = new Player();
            playerFactory.setPlayerName(player2);
            playerFactory.SetPlayerSelection(player2);
            Game game = new Game();
            game.DetermineWinner(player1,player2);

            Console.ReadLine();

            MyFileWriter fileWriter = new MyFileWriter("Rock_Paper_Scissors.txt");
            fileWriter.WriteToFile(player1);
            fileWriter.WriteToFile(player2);

            //Player player2 = new Player();
            //player1.Name = playerFactory.setPlayerName();




            #region MainRegion

            //UserInput player1UserInput = new UserInput();
            //UserInput player2UserInput = new UserInput();
            //player1UserInput.setPlayerName();
            //player2UserInput.setPlayerName();
            //player1UserInput.SetPlayerSelection();
            //player2UserInput.SetPlayerSelection();
            //Player player1 = new Player();
            //Player player2 = new Player();
            //player1.playerName = player1UserInput.PlayerName;
            //player2.playerName = player2UserInput.PlayerName;
            //player1.playerSelection = player1UserInput.PlayerSelection;
            //player2.playerSelection = player2UserInput.PlayerSelection;
            #endregion








            //UserInput Player1input = new UserInput();
            //UserInput Player2input = new UserInput();
            //Player player1 = new Player(Player1input.PlayerName,0,highScoreList,0,0) ;
            //Player player2 = new Player(Player2input.PlayerName,0,highScoreList,0,0);

            //Player1input.setPlayerName();
            //Player2input.setPlayerName();

            //#region region

            //player1.playerName = Player1input.PlayerName;
            //Player1input.SetPlayerSelection();
            //player1.playerSelection = Player1input.PlayerSelection;
            //player2.playerName = Player2input.PlayerName;
            //player2.playerSelection = Player2input.PlayerSelection;
            //Player2input.SetPlayerSelection();

            //#endregion

            //Game game = new Game();
            //game.ScoreRound(player1, player2);
            //game.DetermineWinner(player1, player2);



        }
    }
}

