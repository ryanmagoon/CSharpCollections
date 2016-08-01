using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // initialized as 0 (int/value type)
            int x1;

            // initialized as null (reference type)
            int[] x2;

            int x3 = 5;

            int[] x4 = new int[5];

            // Array elements are always implicitly initialized, but directly declared variables are not.
            Console.WriteLine(x4[0]);

            // int[] x5 = new int[5] { 1, 4, 9, 16, 25 };
            // You can omit any redundant information and still successfully instantiate the array
            int[] x5 = { 1, 4, 9, 16, 25 };
        }
    }
}
