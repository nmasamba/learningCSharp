using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace object_lifetime
{
    class Program
    {
        static void Main(string[] args)
        {
            //constructors give us control over the instation of classes and their objects in memory
            Car myCar = new Car(); // this is actually a REFERENCE to a CLASS, it is called a CONSTRUCTOR=ADDRESS IN MEMORY

            //you could set properties here

            Car myOtherCar = myCar; //we didnt set a new instance of Car, we just referenced it to the instance above

            Car myThirdCar = new Car("Indiana", "Cherokee", 2000, "Blue");//implementation of constructor overloading

            //ask .NET to remove references from memory (invoke garbage collector feature)
            myOtherCar = null;
            myCar = null;
        }
    }

    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Colour { get; set; }

        //whenever we reference a class, like below, we create a constructor which has memory implications
        public Car()
        {
            //You could get this from a configuration file, database etc
            //I'll just hard code it in this instance
            this.Make = "Infinitum";
        }

        /*
        //create an overloaded constructor that accepts parameters
        public Car(string make, string model, int year, string colour)
        {
            make = Make;
            model = Model;
            year = Year;
            colour = Colour;
        }
        */
    }
}
