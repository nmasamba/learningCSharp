using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace using_Switch
{
    class Program
    {

        //KEY MESSAGE: The Switch statement can be used to replace If, given a long list of conditions
        static void Main(string[] args)
        {
            Console.WriteLine("Type in superhero name. Their nickname will appear as if by magic!");

            string userValue = Console.ReadLine();

            switch(userValue.ToUpper())
            {
                case "BATMAN":
                    Console.WriteLine("Batmobile fan");
                    break;

                case "SUPERMAN":
                    Console.WriteLine("Booth hogger");
                    break;

                case "GRINGO":
                    Console.WriteLine("Mbudziyadhura");
                    break;

                default:
                    Console.WriteLine("Sorry, I do not recognise this hero.");
                    break;


            }

        }
    }
}
