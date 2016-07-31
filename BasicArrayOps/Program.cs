using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicArrayOps
{
    class Program
    {
        static void Main(string[] args)
        {
            string monday = "Monday";

            // type[] - declare array, not simple type
            string[] daysOfWeek =
            {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"
            };

            //Console.WriteLine("Type in index of day to look up> ");
            //int day = int.Parse(Console.ReadLine());
            //Console.WriteLine(daysOfWeek[day]);
            daysOfWeek[5] = "PartyDay";
            foreach (string day in daysOfWeek)
            {
                Console.WriteLine(day);
            }
        }
    }
}
