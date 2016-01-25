using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    public class GameFactory
    {
        public GameSymbols ExtractSymbolValues { get; set; }
        public List<Player> MatchupList { get; set; }

        public GameFactory()
        {
            iLit = SetGameSymbols();

        }

        GameSymbols gameSymbols = new GameSymbols();

        public List<int> SetGameSymbols()
        {
            List<int> populatedGameSymbolList = new List<int>();
            gameSymbols.SymbolValuesList = new List<int>();
            gameSymbols.rock = new Rock();
            gameSymbols.paper = new Paper();
            gameSymbols.scissors = new Scissors();
            gameSymbols.lizard = new Lizard();
            gameSymbols.spock = new Spock();
            gameSymbols.SymbolValuesList.Add(gameSymbols.rock.RockValue);
            gameSymbols.SymbolValuesList.Add(gameSymbols.paper.PaperValue);
            gameSymbols.SymbolValuesList.Add(gameSymbols.scissors.ScissorsValue);
            gameSymbols.SymbolValuesList.Add(gameSymbols.lizard.LizardValue);
            gameSymbols.SymbolValuesList.Add(gameSymbols.spock.SpockValue);
            populatedGameSymbolList = gameSymbols.SymbolValuesList;
            return populatedGameSymbolList;

        }
        public List<int> iLit = new List<int>();
        


    }
}
