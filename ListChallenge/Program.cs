using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string> { "Will 1", "Will 2", "Ethan" , "Ashton", "Ben", "Thomas", "Henry", "Cormac", "Adam"};

            List<string> score = new List<string> { "100", "99", "98", "97", "96", "95", "94", "93", "92"};

            for (int n = 0; n < 9; n++)
            {
                Console.WriteLine(names[n] + " = " + score[n]);
            }
        }
    }
}
