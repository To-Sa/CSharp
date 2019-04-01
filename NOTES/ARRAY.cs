using System;

namespace ToSa
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];  // REF. TYPE

            foreach (var item in array)
            {
                Console.WriteLine(item);    //NULL
            }

            Random r = new Random();
            for (int i = 0; i < array.Length; ++i)
            {
                array[i] = r.Next(0, 100);
            }
            foreach (int item in array)
            {
                Console.WriteLine(item);
            }

            char[] charArray = new char[] { 'b', 'd', 'A', 'c' };
            foreach (char item in charArray)
            {
                Console.WriteLine(item);
            }

            Array.Sort(charArray);
            foreach (char item in charArray)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }   
    }
}
