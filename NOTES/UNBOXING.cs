using System;

namespace ToSa
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 123;
            object obj = i;  // implicit boxing

            try
            {
                int j = (int)obj;  // attempt to unbox

                System.Console.WriteLine("Unboxing OK.");
            }
            catch (System.InvalidCastException e)
            {
                System.Console.WriteLine("{0} Error: Incorrect unboxing.", e.Message);
            }

            Console.ReadKey();
        }
    }
}
