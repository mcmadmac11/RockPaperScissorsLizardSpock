﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    public class GameSymbols
    {      
        public List<int> SymbolValuesList { get; set; }

        public GameSymbols()
        {
        }

        public Rock rock = new Rock();
        public Paper paper = new Paper();
        public Scissors scissors = new Scissors();
        public Lizard lizard = new Lizard();
        public Spock spock = new Spock();
    }
}
