using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayCopy
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] squares = { 1, 4, 9, 16 };

            int[] copy = squares.ToArray();

            //int[] copy = new int[8];
            //squares.CopyTo(copy, 2);

            // Array.copy is more flexible than copyTo
            // but the .ToArray() extension method is more readable still,
            // but less flexible than copyTo or copy

            foreach (int value in copy)
            {
                Console.WriteLine(value);
            }
            Console.WriteLine(string.Format("squares == copy? {0}", squares == copy));
        }
    }
}
