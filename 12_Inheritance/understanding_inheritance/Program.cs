using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace understanding_inheritance
{
    class Program
    {
        static void Main(string[] args)
        {

            Car myCar = new Car();
            myCar.Make = "DeLorean";
            myCar.Model = "Timer";
            myCar.Year = 2050;
            myCar.Colour = "Futuristic Silver";

            /*printCarDetails(myCar);*/ //after receiving formatted string, printCarDetails is called from Main method
            printVehicleDetails(myCar);
            // below we implement SPECIALIZATION i.e.
            // we INHERIT some features from the Car class, then we add key features that are unique to the truck
            Truck myTruck = new Truck();
            myTruck.Make = "Zimba";
            myTruck.Model = "Heatwave";
            myTruck.Year = 2000;
            myTruck.Colour = "Big Bird Blue";
            myTruck.TowingCapacity = 1500;

            //any method accessible to the Car class will now also be accessible to the Truck class
            //how is this possible? only because Truck is a type of Car. Car = base class, Truck = derived class
            //or Car = parent class, Truck = child class
            //or Car = superclass and Truck = subclass
            /*printCarDetails(myTruck);*/
            printVehicleDetails(myTruck); 

            Console.ReadLine();
            
        }

        private static void printVehicleDetails(Vehicle vehicle) //helper method to receive formatted data from FormatMe
        {
            //inside the helper method initially called printCarDetails (Car car)
            Console.WriteLine("Here are the vehicle's details: {0}", vehicle.FormatMe());
            
        }
    }

    abstract class Vehicle //abstract, higher level class, which creates a blueprint for later implementation
    {
        //inside an abstract class i.e. a class we cannot create a new instance of - it simply exists as a concept
        //need to create concrete non-abstract objects to inherit from and work with this class
        //Car and Truck both inherit from this abstract class, which makes them sibling classes
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Colour { get; set; }

        //for abstract method below,we have to specialize a child method if we want it to be derived from this one
        public abstract string FormatMe(); //(abstract) FormatMe method within Vehicle class to format input
    }


    class Car : Vehicle
    {
        
        /*
        public virtual string FormatMe()  //(virtual) FormatMe method within Car class to format input
        {
        //inside virtual method, meaning we have the choice whether to derive another method or not from this method
            return string.Format("{0} - {1} - {2} - {3}",
                this.Make,
                this.Model,
                this.Year,
                this.Colour);
        }
        */

        public override string FormatMe() //child method inheriting from the abstract one (note the override)
        {
            //inside abstract method,we have to specialize a child method if we want it to be derived from this one
            return string.Format("{0} - {1} - {2} - {3}",
                this.Make,
                this.Model,
                this.Year,
                this.Colour);
        }
    }


    class Truck : Vehicle //this means the Truck class is inheriting from the Car one
    {
        public int TowingCapacity { get; set; }

        public override string FormatMe()
        //FormatMe method within Truck overrides the virtual Car one
        //FormatMe method within Truck overrides the abstract Vehicle one
        {
            //now inside SPECIALIZED FormatMe method
            return string.Format("{0} - {1} - {2} Tow Units",
                this.Make,
                this.Model,
                this.TowingCapacity);
        }

    }

    /*
    sealed class SemiTruck : Vehicle
    {
        //properties of SemiTruck, which you may declare without wanting the inheritance to keep continuing
        //so you create a sealed class - nothing at all can inherit from it
        // sealed class is literally the opposite of an abstract class
        //.NET class library has many sealed and abstract base classes built into it
    }
    */
}
