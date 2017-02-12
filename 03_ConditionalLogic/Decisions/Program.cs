using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decisions
{
    class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine("Please type something and press the Enter key");
            //string userValue;
            //userValue = Console.ReadLine();
            //Console.WriteLine("You typed: " + userValue);
            //Console.ReadLine();


            //Console.WriteLine("The choice is yours Neo. Door 1, 2 or 3?");
            //string userValue = Console.ReadLine();

            //string outMsg = "";

            //if (userValue == "1")
            //{
            //    outMsg = "You chose the easy way out! Coward!";
            //}
            //else if (userValue == "2")
            //    outMsg = "Not bad. The middle is a safe choice.";
            //else if (userValue == "3")
            //    outMsg = "Risk taker! Me likey!";
            //else
            //    outMsg = "Ungraded. You lose. Meet your maker!";

            //Console.WriteLine(outMsg);
            //Console.ReadLine();


            // BELOW: The C# switch statement
            Console.WriteLine("Which door would you prefer from 1 to infinity?");
            string userValue = Console.ReadLine();
            string message = (userValue == "1") ? "boat" : "strand of hair";
            Console.WriteLine("Your reward is {0}", message);
            Console.ReadLine();

        }
    }
}
