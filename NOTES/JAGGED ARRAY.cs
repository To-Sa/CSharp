using System;

namespace ToSa
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] jarray = new int[3][];
            Random r = new Random();
            for (int i = 0; i < 3; ++i)
            {
                jarray[i] = new int[r.Next(1, 9)];
                for (int j = 0; j < jarray[i].Length; ++j)
                {
                    jarray[i][j] = i + j;
                    Console.Write("{0}, ", jarray[i][j]);
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            jarray = new int[][]    //initialize
            {
                new int[]{ 1, 2, 3, 4, 5 },
                new int[]{ 1, 2, 3 },
                new int[]{ 1 },
                new int[]{ 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 }
            };
            for (int i = 0; i < jarray.Length; ++i)
            {
                for (int j = 0; j < jarray[i].Length; ++j)
                {
                    Console.Write("{0}, ", jarray[i][j]);
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }   
    }
}
