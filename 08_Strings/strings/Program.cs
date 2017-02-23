using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strings
{
    class Program
    {
        static void Main(string[] args)
        {
            //string myString = "Go to your C:\\ Drive";

            //string myString = "My \"so called\" life

            //string myString = "Give me a new line \n right here";

            //string myString = string.Format("{0}!!", "Bazinga");

            //string myString = string.Format("Make:{0}  Model:{1}", "Mexidis", "Valve");

            //string myString = string.Format("Bitch better have my {0:C}", 1000000.60);
            //string myString = string.Format("I want {0:P}", 1.01);

            //string myString = string.Format("Phone Number: {0:(#####) ###-###}", 01934833441);


            /*
            string myString = "";
            for (int i=0; i<101; i++)
            {
                //myString = myString + "--> " + i.ToString();
                myString += "--> " + i.ToString();
            }
            */

            /*
            StringBuilder myString = new StringBuilder();
            for (int count = 0; count < 101; count++)
            {
                myString.Append("--> ");
                myString.Append(count);
            }
            */

            string myString = "Was the summer of 04, we thought we'd never get old yeah! ";
            //myString = myString.Substring(4, 12);
            //myString = myString.ToUpper();
            //myString = myString.Replace("w", "TT");

            myString = string.Format("Length before: {0}  Length after: {1}",
                myString.Length,
                myString.Trim().Length);

            Console.WriteLine(myString);
            Console.ReadLine();
        }
    }
}
