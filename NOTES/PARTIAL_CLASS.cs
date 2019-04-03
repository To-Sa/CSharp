using System;

namespace ToSa
{
    partial class PClass
    {
        public void Do()
        {
            Console.WriteLine("HELLO ");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            PClass p = new PClass();
            p.Do();
            p.Something();        

            Console.ReadKey();
        }   
    }

    // creates another .cs file
    partial class PClass
    {
        public void Something()
        {
            Console.WriteLine("WORLD!");
        }
    }
}
