using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    public class GameSymbols : IEnumerable
    {
        public GameSymbols()
        {
            this.SymbolValuesList = SymbolValuesList;
        }

        public Rock rock = new Rock();
        public Paper paper = new Paper();
        public Scissors scissors = new Scissors();

        public List<int> SymbolValuesList { get; set; }

        public IEnumerator GetEnumerator()
        {

            return ((IEnumerable)SymbolValuesList).GetEnumerator();
        }
    }
}
