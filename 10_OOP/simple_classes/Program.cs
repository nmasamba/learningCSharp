using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simple_classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myNewCar = new Car(); //INSTANTIATION of a class using the 'new' opearator, otherwise called an OBJECT

            //the following code block uses the myNewCar instance/object (of the Car class) to access class properties
            myNewCar.Make = "Mexidis";
            myNewCar.Model = "Hondo";
            myNewCar.Year = 2015;
            myNewCar.Colour = "Yellow";

            
            Console.WriteLine("Make:{0}  Model:{1}  Year:{2}  Colour:{3}",
                myNewCar.Make,
                myNewCar.Model,
                myNewCar.Year,
                myNewCar.Colour);

            //double marketValue = determineMarketValue(myNewCar);//gets the returned carValue given myNewCar properties
            

            Console.WriteLine("Value of your new car is {0:C}", myNewCar.DetermineMarketValue());

            Console.ReadLine();

        }

        /*
        //the helper method below will allow us to pass in data from the Car type in order to get a valuation
        private static double determineMarketValue (Car car) //NOTE: A class is actually also a data type in .NET
        {
            double carValue = 100;

            //Write code here to look up car's value and trigger that into the carValue variable
            return carValue;
        }
        */
    }

    class Car //the CLASS, called Car, is the blueprint from which objects will be made.
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Colour { get; set; }

        public double DetermineMarketValue() //we just created a method within the Car class itself!
        {
            double carValue = 100;

            if (this.Year > 1990)
                carValue = 10000.0;

            else
                carValue = 2000.0;

            return carValue;
        }
    }


}
