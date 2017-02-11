using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int x;
            int y;

            x = 7;
            y = x + 3;

            Console.WriteLine(y);
            
            var myName = "Nyasha Masamba - vamwe vanoti Pride";

            Console.WriteLine(myName);
            */

            
            int x = 7;
            // string y = "Nyasha";
            string y = "5";

            /*
            string myFirstTry = x.ToString() + y;

            Console.WriteLine(myFirstTry);
            */


            int mySecondTry = x + int.Parse(y);

            Console.WriteLine(mySecondTry);
            Console.ReadLine();

        }
    }
}
