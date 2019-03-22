using System;

namespace ToSa
{
    class Program
    {
        static void Main(string[] args)
        {
            string abc = "abcdefghijklm...z";

            foreach (var item in abc)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
