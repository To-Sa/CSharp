using System;

namespace ToSa
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            while(i < 108)
            {
                if( (i%12) == 0 )
                {
                    Console.WriteLine(i);
                }
                i++;
            }

            Console.WriteLine();

            string abc = "ABCDEF...Z";
            int j = 0;
            while(j < abc.Length)
            {
                Console.WriteLine(abc[j]);
                j++;
            }

            Console.ReadKey();
        }
    }
}
