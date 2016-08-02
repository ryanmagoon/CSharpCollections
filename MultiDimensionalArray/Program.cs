using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiDimensionalArray
{
    class Program
    {
        static void Main(string[] args)
        {
            float[,] tempsGrid = new float[4, 3];

            for (int x = 0; x < 4; x++)
            {
                for (int y = 0; y < 3; y++)
                {
                    tempsGrid[x, y] = x + 10 * y;
                }
            }

            foreach (float temperature in tempsGrid)
            {
                Console.WriteLine(temperature);
            }

            for (int x = 0; x < 4; x++)
            {
                for (int y = 0; y < 3; y++)
                {
                    Console.WriteLine($"{tempsGrid[x,y]}, ");
                }
                Console.WriteLine();
            }
        }
    }
}
