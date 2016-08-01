using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count
{
    class Program
    {
        static void Main(string[] args)
        {
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
            ICollection<string> collection = (ICollection<string>)daysOfWeek;

            // Can still replace elements even though ICollection<T>.IsReadOnly
            // Only blocks use of ICollection<T> methods, such as Add
            (collection as string[])[5] = "SlaveDay";
            if (!collection.IsReadOnly)
                collection.Add("SlaveDay");
            else
                Console.WriteLine("Collection is read-only");

            foreach (string day in collection)
            {
                Console.WriteLine(day);
            }

            //Console.WriteLine("Count() = " + collection.Count());
            //// returns a cached variable, much faster than the extension method
            //Console.WriteLine("Count = " + collection.Count);
            //Console.WriteLine("Length = " + daysOfWeek.Length);
        }
    }
}
