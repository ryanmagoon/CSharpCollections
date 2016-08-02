using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayCovariance
{
    class Program
    {
        static void Main(string[] args)
        {
            object[] objArr = new object[3];
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

            objArr[0] = 3;
            Console.WriteLine("objArr[0] = " + objArr[0]);


            // completely different types
            // you can always implicitly cast an array of a derived type to a base type
            // This is known as array covariance
            object[] objArr2 = daysOfWeek;
            objArr2[0] = 3;
            // BOOM! ArrayTypeMismatchException
            Console.WriteLine("objArr2[0] = " + objArr2[0]);

            //foreach (object obj in objArr2)
            //{
            //    Console.WriteLine(obj);
            //}

            // Array covariance turns compile-time errors into run-time errors
            // Array covariance is broken, and we shouldn't use it.

            // Covariance for IEnumerable<T> and IEnumerator<T> is not broken. No other collection type
            // supports covariance.
        }
    }
}
