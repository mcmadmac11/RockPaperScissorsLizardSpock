using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace RockPaperScissorsLizardSpock
{

    public class MyFileWriter
    {
        string path;
        public MyFileWriter(string path)
        {
            this.path = path;

        }
        TextWriter textWriter;
        public void TextWriter()
        {

            textWriter.Write("Rock_Paper_Scissors.txt", true);
        }

        public void WriteToFile(Player player)
        {

            File.AppendAllText(this.path, string.Format(@"
Player: {0}
score: {1} 
highScore: {2}
wins: {3}
losses: {4}
ties: {5}
", player.Name, player.score, player.highScore[0].ToString(), player.wins, player.losses, player.Ties));


        }

    }

}
