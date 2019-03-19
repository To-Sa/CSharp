using System;

namespace ToSa
{
    class Program
    {
        static void Main(string[] args)
        {
            dynamic x = 10;
            Console.WriteLine(x); // x is int
            x = "myName";
            Console.WriteLine(x); // x is string

            Console.ReadKey();
            /*Don't use the "dynamic" if we can.
             Advantage of it supports the dynamic typing language, for example: 
             Python, Ruby, PHP and so on.*/
        }
    }
}
// Output:
//10
//myName
