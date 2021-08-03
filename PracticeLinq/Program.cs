using System;
using System.Collections.Generic;
using System.Linq;

namespace PracticeLinq
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> games = new List<string>() {"Call of Duty", "Jump Force", "Dragonballz", "NBA21", "Destiny" };
           var sortedGames = games.Where(name=> name.Length >1).OrderBy(name =>name.Length);
          
            foreach(var title in sortedGames)
            {
                Console.WriteLine($"{title}");
            }

        }
    }
}
