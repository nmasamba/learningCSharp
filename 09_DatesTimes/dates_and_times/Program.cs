using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dates_and_times
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            DateTime myValue = DateTime.Now;

            //Console.WriteLine(myValue.ToString());
            //Console.WriteLine(myValue.ToShortTimeString());
            //Console.WriteLine(myValue.ToLongDateString());

            //Console.WriteLine(myValue.AddDays(3).ToLongDateString());
            //Console.WriteLine(myValue.AddHours(-5.5).ToShortTimeString());

            //Console.WriteLine(myValue.DayOfYear.ToString());
            */

            /*
            DateTime myBday = new DateTime(1988, 5, 22);
            Console.WriteLine(myBday.DayOfWeek.ToString());
            */

            DateTime myBday = DateTime.Parse("22/5/1988");
            TimeSpan myAge = DateTime.Now.Subtract(myBday);
            Console.Write(myAge.TotalDays);

            Console.ReadLine();
        }
    }
}
