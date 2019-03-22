using System;

namespace ToSa
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            do
            {
                if ((i % 12) == 0)
                {
                    Console.WriteLine(i);
                }
                i++;
            } while (i < 108);

            Console.WriteLine();

            int j = 0;
            do
            {
                Console.WriteLine(j);
                j++;
            } while (j < 0);

            Console.ReadKey();
        }
    }
}
