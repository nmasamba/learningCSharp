using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace understanding_scope
{
    class Program
    {
        //KEY LESSON MESSAGE: variables have a lifetime depending on the code block in which they're defined

        //this declaration creates a child of the Program class
        // we made it a static declaration so that we can access it in all instances of the class
        //accessibility modifiers facilitate for encapsulation
        //private methods act as black boxes, they are only usable by methods in the same class
        private static string k = ""; //the word 'private' is called an accessibility modifier, along with 'public'


        static void Main(string[] args)
        {
           
            for (int i = 0; i < 10; i++)
            {
                //this inner code block has access to k because k is declared globally
                k = i.ToString();

                //the variable i only exists within the SCOPE of this for loop
                Console.WriteLine(i);
            
            }

            Console.WriteLine("We're in k: " + k);
            Console.ReadLine();
        }
    
    }
}
