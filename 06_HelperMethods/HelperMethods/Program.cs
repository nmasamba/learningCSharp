using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelperMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            string myValue = superSecretFormula("coder!");
            Console.WriteLine(myValue);
            Console.ReadLine();
        }

        private static string superSecretFormula(string name)
        {
            //insert cool stuff here
            return String.Format("Hello, {0}!", name);
        }

        //Overloading
        private static string superSecretFormula()
        {
            //insert cool stuff again
            return "Hello World";
        }


    }
}
