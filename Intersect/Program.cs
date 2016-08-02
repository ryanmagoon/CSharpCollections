using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intersect
{
    class Program
    {
        static void Main(string[] args)
        {
            var bigCities = new HashSet<string>
            {
                "New York",
                "Manchester",
                "Sheffield",
                "Paris"
            };

            string[] citiesInUk =
            {
                "Sheffield",
                "Ripon",
                "Truro",
                "Manchester"
            };

            // The LINQ Intersect method doesn't change the original HashSet
            // It returns a new enumerable
            var newCities = bigCities.Intersect(citiesInUk);
            foreach (string city in newCities)
            {
                Console.WriteLine(city);
            }

            //bigCities.IntersectWith(citiesInUk);
            //foreach (string city in bigCities)
            //{
            //    Console.WriteLine(city);
            //}
        }
    }
}
