using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeMinistersDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            var primeMinisters = new Dictionary<string, PrimeMinister>
            {
                {"JC", new PrimeMinister("James Callaghan", 1976) },
                {"MT", new PrimeMinister("Margaret Thatcher", 1979) },
                {"TB", new PrimeMinister("Tony Blair", 1997) }
            };

            primeMinisters.Remove("JC");
            primeMinisters["JC"] = new PrimeMinister("Jim Callaghan", 1976);
            primeMinisters["JM"] = new PrimeMinister("John Major", 1990);
            primeMinisters.Add("GB", new PrimeMinister("Gordon Brown", 2007));

            foreach (var pm in primeMinisters)
            {
                Console.WriteLine(pm);
            }


            //PrimeMinister pm = primeMinisters["TB"];

            //PrimeMinister pm;
            //bool found = primeMinisters.TryGetValue("DC", out pm);
            //if (found)
            //    Console.WriteLine($"value is: {pm.ToString()} \r\n");
            //else
            //    Console.WriteLine("value was not in the dictionary");



            //foreach (var pm in primeMinisters)
            //{
            //    Console.WriteLine($"{pm.Key} , {pm.Value}");
            //}
        }
    }
}
