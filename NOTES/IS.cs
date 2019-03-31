using System;

namespace ToSa
{
    class Program
    {
        static void Main(string[] args)
        {
            /*The is keyword evaluates type compatibility at runtime. 
             * It determines whether an object instance or the result of 
             * an expression can be converted to a specified type.*/

            int x = 10;

            if(x is int)
            {
                Console.WriteLine("X is int.");
            }

            if (x is string)
            {
                Console.WriteLine("X is int.");
            }
            else
            {
                Console.WriteLine("X is not int.");
            }

            Console.ReadKey();
        }   
    }
}
