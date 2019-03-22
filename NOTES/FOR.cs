using System;

namespace ToSa
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 108; i++)
            {
                if( (i%12) == 0 )
                {
                    Console.WriteLine(i);
                }
            }

            Console.WriteLine();

            string abc = "ABCDEF...Z";
            for (int i = 0; i < abc.Length; i++)
            {
                Console.WriteLine(abc[i]);
            }

            Console.ReadKey();
        }
    }
}
