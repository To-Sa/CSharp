using System;

namespace ToSa
{
    class Program
    {
        static void Main(string[] args)
        {
            //C# 2.0 introduced nullable types that allow you to assign null to value type variables.
            int? x = null;

            Console.WriteLine(x);

            int y = 10;
            Console.WriteLine(y);

            // IMPLICIT CONVERSION
            int? z = y; 
            Console.WriteLine(z);

            // EXPLICIT CONVERSION
            y = (int)z;
            Console.WriteLine(y);

            Console.ReadKey();
        }
    }
}
// Output:
//  -> (0)
//10
//10
//10
