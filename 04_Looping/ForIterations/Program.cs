﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForIterations
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i=0; i<10; i++)
            {
                Console.WriteLine(i.ToString());

                if (i==7)
                {
                    Console.WriteLine("Found seven!!");
                    break;
                }

                for (int myCounter = 0; myCounter < 100; myCounter++)
                {

                }
            }
            Console.ReadLine();
        }
    }
}
