using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetComparisons
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

            var ukCities = new HashSet<string>
            {
                "Sheffield",
                "Ripon",
                "Truro",
                "Manchester"
            };

            var bigCitiesArr = new HashSet<string>
            {
                "New York",
                "Manchester",
                "Sheffield",
                "Paris"
            };

            // bool ukIsSubset = ukCities.IsSubsetOf(bigCitiesArr);
            bool ukIsSubset = bigCitiesArr.IsSupersetOf(ukCities);
            Console.WriteLine($"UK cities subset of big cities?");
        }
    }
}
