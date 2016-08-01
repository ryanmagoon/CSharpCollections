﻿using System;
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
            Console.WriteLine("Count() = " + collection.Count());
            // returns a cached variable, much faster than the extension method
            Console.WriteLine("Count = " + collection.Count);
            Console.WriteLine("Length = " + daysOfWeek.Length);
        }
    }
}
