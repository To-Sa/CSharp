using System;

namespace ToSa
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[3, 3];
            foreach (var item in matrix)
            {
                Console.WriteLine(item);
            }

            matrix = new int[,]
            {
                {1000, 2, 12},
                {25, 5, 10},
                {19, 8, 10000}
            };
            foreach (var item in matrix)
            {
                Console.WriteLine(item);
            }

            matrix = new int[3, 3];
            Random r = new Random();
            for (int i = 0; i < matrix.GetLength(0); ++i) // row
            {
                for (int j = 0; j < matrix.GetLength(1); ++j) // column
                {
                    matrix[i, j] = r.Next(0, 100);
                }
            }
            foreach (var item in matrix)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }   
    }
}
