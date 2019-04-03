using System;

namespace ToSa
{
    /*It is possible to split the definition of a class, a struct, 
     * an interface or a method over two or more source files. 
     * Each source file contains a section of the type or method definition, 
     * and all parts are combined when the application is compiled.*/

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
