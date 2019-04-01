using System;

namespace ToSa
{
    public class Class1 : IFormatProvider
    {
        public object GetFormat(Type t)
        {
            if (t.Equals(this.GetType()))
                return this;
            return null;
        }
    }

    public class Class2 : Class1
    {
        public int Value { get; set; }
    }

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

            var cl1 = new Class1();
            Console.WriteLine(cl1 is IFormatProvider);
            Console.WriteLine(cl1 is Object);
            Console.WriteLine(cl1 is Class1);
            Console.WriteLine(cl1 is Class2);
            Console.WriteLine();

            var cl2 = new Class2();
            Console.WriteLine(cl2 is IFormatProvider);
            Console.WriteLine(cl2 is Class2);
            Console.WriteLine(cl2 is Class1);
            Console.WriteLine();

            Class1 cl = cl2;
            Console.WriteLine(cl is Class1);
            Console.WriteLine(cl is Class2);

            Console.ReadKey();
        }   
    }
}
