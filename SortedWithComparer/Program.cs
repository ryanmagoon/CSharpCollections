using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedWithComparer
{
    class Program
    {
        static void Main(string[] args)
        {
            var primeMinisters = new SortedDictionary<string, PrimeMinister>
                (new UncasedStringComparer())
            {
                {"JC", new PrimeMinister("James Callaghan", 1976) },
                {"MT", new PrimeMinister("Margaret Thatcher", 1979) },
                {"TB", new PrimeMinister("Tony Blair", 1997) }
            };

            primeMinisters.Add("JM", new PrimeMinister("John Major", 1990));

            Console.WriteLine($"tony is {primeMinisters["tb"]}");
        }
    }

    class UncasedStringComparer : IComparer<string>
    {
        public int Compare(string x, string y)
        {
            return string.Compare(x, y, StringComparison.InvariantCultureIgnoreCase);
        }
    }
}
