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

            for (int x = 0; x < tempsGrid.GetLength(0); x++)
            {
                for (int y = 0; y < tempsGrid.GetLength(1); y++)
                {
                    tempsGrid[x, y] = x + 10 * y;
                }
            }

            Console.WriteLine($"Length is {tempsGrid.Length}");
            Console.WriteLine($"Rank is {tempsGrid.Rank}");

            for (int x = 0; x < tempsGrid.GetLength(0); x++)
            {
                for (int y = 0; y < tempsGrid.GetLength(1); y++)
                {
                    Console.Write($"{tempsGrid[x,y]}, ");
                }
                Console.WriteLine();
            }
        }
    }
}
