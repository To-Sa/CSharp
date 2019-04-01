using System;

namespace ToSa
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Strings are immutable--the contents of a string object 
             * cannot be changed after the object is created.*/

            string s = "String is REF. TYPE.";
            Console.WriteLine(s + "\n");

            string t = "StRiNg";
            Console.WriteLine(t[2] + "\n"); // R
            foreach (var item in t)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            for (int i = t.Length - 1; i > -1; i--)
            {
                Console.WriteLine(t[i]);
            }

            Console.WriteLine("\n" + "SsTtRrIiNnGg"[10]); // G

            Console.ReadKey();
        }   
    }
}
