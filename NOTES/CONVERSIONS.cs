using System;

namespace ToSa
{
    class Program
    {
        static void Main(string[] args)
        {
            //IMPLICIT CONVERSIONS
            int x = 10;
            long y = x; 
            Console.WriteLine(x);
            Console.WriteLine(y);
            /*These conversions are performed by C# in a type-safe manner. 
             * For example, are conversions from smaller to larger integral types 
             * and conversions from derived classes to base classes.*/

            //EXPLICIT CONVERSIONS
            int a = 300;
            byte b = (byte)a; //Cast int to byte.
            /*These conversions are done explicitly by users using the pre-defined functions. 
             * Explicit conversions require a cast operator.*/
            Console.WriteLine(a);
            Console.WriteLine(b);


            /*The checked keyword is used to explicitly enable overflow checking for 
             * integral-type arithmetic operations and conversions.*/
            checked
            {
                int c = 300;
                //byte d = (byte)c;
                Console.WriteLine(c);
                //Console.WriteLine(d);
            }

            int g = 300;
            //byte h = checked((byte)g);
            Console.WriteLine(g);
            //Console.WriteLine(h);

            /*The unchecked keyword is used to suppress overflow-checking for 
             * integral-type arithmetic operations and conversions.*/
            int e = 300;
            byte f = unchecked((byte)e);
            Console.WriteLine(e);
            Console.WriteLine(f);

            Console.ReadKey();
        }   
    }
}
