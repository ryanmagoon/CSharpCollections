using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddToList
{
    class Program
    {
        static void Main(string[] args)
        {
            var presidents = new List<string>(12)
            {
                "Jimmy Carter",
                "Ronald Reagan",
                "George HW Bush",
                "Bill Clinton",
                "George W Bush"
            };


            //Console.WriteLine("Before:");
            //Console.WriteLine("Count = " + presidents.Count);
            //Console.WriteLine("Capacity = " + presidents.Capacity + "\r\n");


            presidents.Add("Barack Obama");

            // !!
            //BadCode(presidents.AsReadOnly());
            BadCode(new ReadOnlyCollection<string>(presidents));

            //string firstElem = presidents[0];

            //presidents.Add("Bill Gates");
            //presidents.Add("Steven Speilberg");
            //presidents.Add("Aaron Skonnard");

            //presidents.Remove("Bill Gates");

            //Console.WriteLine("After:");
            //Console.WriteLine("Count = " + presidents.Count);
            //Console.WriteLine("Capacity = " + presidents.Capacity + "\r\n");

            foreach (string president in presidents)
            {
                Console.WriteLine(president);
            }
        }

        static void BadCode(IList<string> lst)
        {
            lst.RemoveAt(2);
        }
    }
}
