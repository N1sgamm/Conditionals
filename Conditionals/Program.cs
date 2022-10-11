using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Conditionals");
            Console.WriteLine();

            int score;
            string gamertag;

            score = 0;
            gamertag = "N1sgamm"; //pretend
            if(gamertag == "N1sgamm")
            {
                score = 1000000; //cheating
            }
            Console.WriteLine("Score: " + score);

            Console.ReadKey(true);
        }
    }
}
