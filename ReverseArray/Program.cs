using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] daysOfWeek = {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"
            };

            // The extension method doesn't work in-place
            // LINQ methods also often return IEnumerable, NOT Array!
            var reversed = daysOfWeek.Reverse().ToArray();

            // Array.Reverse() works in place, which means it doesn't create a new array.
            Array.Reverse(daysOfWeek);

            foreach (string day in daysOfWeek)
            {
                Console.WriteLine(day);
            }

            foreach (string day in reversed)
            {
                Console.WriteLine(day);
            }
        }
    }
}
