using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            /* int[] numbers = new int[5];

            numbers[0] = 3;
            numbers[1] = 7;
            numbers[2] = 9;
            numbers[3] = 10;
            numbers[4] = 12;
            */

            //int[] numbers = new int[] { 3; 7; 9; 10; 12 };
            //Console.WriteLine(numbers[3].ToString());


            /* string[] names = new string[] { "Nhamo", "Shupikai", "Nonsi", "Dhiya" };

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
            */

            string mandela = "It always seems impossible "+
                "until it is done";

            char[] charArray = mandela.ToCharArray();
            Array.Reverse(charArray);

            foreach (char tempmandela in charArray)
            Console.Write(tempmandela);

            Console.ReadLine();
        }
    }
}
