﻿using RockPaperScissorsLizardSpock;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    public class Player
    {
        public string Name { get; set; }
        public int Selection { get; set; }
        public int Ties { get; set; }
        public int[] Stats = new int[] { };
        public int score { get; set; }
        public int wins
        {
            get; set;
        }
        public int losses { get; set; }




        //UserInput input = new UserInput();
        //Rock rock = new Rock();
        //Paper paper = new Paper();
        //Scissors scissors = new Scissors();

        public List<int> highScore = new List<int>() { 0 };
        public int highScores;
        public Player()
        {


            //Stats[0] = score;
            //Stats[1] = highScores;
            //Stats[2] = wins;
            //Stats[3] = losses;


        }

        public Player(string name, int selection)
        { 
        }
    }
}