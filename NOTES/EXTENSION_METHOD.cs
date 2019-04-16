using System;

namespace ToSa
{
    static public class StringHelper
    {
        static public void Print(this string s)
        {
            Console.WriteLine(s);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //EXTENSION METHOD
            string s = "stringAndSting";
            s.Print();

            //or use this way
            StringHelper.Print(s);

            Console.ReadKey();
        }   
    }
}
