using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace understanding_Enumerations
{
    class Program
    {
        //KEY MESSAGE: using the IDE and code snippets implementing ENUM to get away from literal strings
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;

            Console.WriteLine("Type in superhero name to see their nickname!");
            string userValue = Console.ReadLine();

            Superhero myValue;

            //this line attempts to convert input from the user into a match for the SUperhero enum
            //the sharp brackets around Superhero show that we're performing conversion on a data type
            if (Enum.TryParse<Superhero>(userValue, true, out myValue))

            {
                //we used the switch method in conjuction with the enumeration statement
                switch (myValue)
                {
                    case Superhero.Batman:
                        Console.WriteLine("Batmobile fan");
                        break;

                    case Superhero.Superman:
                        Console.WriteLine("Booth hogger");
                        break;

                    case Superhero.Gringo:
                        Console.WriteLine("Mbudziyadhura");
                        break;

                    default:
                        break;
                }
            }

            else
            {
                Console.WriteLine("Sorry, I reognise not this hero!");
            }


            Console.ReadLine();
        }
    }


    //enum is an enumeration, it helps with eliminating input errors
    //enum is a data type in its own right
    enum Superhero
    {
        Batman,
        Superman,
        Gringo
    }
   
}
