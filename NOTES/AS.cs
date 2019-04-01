using System;

namespace ToSa
{
    class ClassA { }
    class ClassB { }

    class Program
    {
        static void Main(string[] args)
        {
            /*You can use the as operator to perform certain types of conversions 
             * between compatible reference types or nullable types. */
            object a = "123";
            object b = "Hello";
            object c = 10;

            string aa = a as string;
            Console.WriteLine(aa == null ? "NULL" : aa); // 123

            string bb = b as string;
            Console.WriteLine(bb == null ? "NULL" : bb); // Hello

            string cc = c as string;
            Console.WriteLine(cc == null ? "NULL" : cc); // NULL

            /*As the example shows, you need to compare the result of the as 
             * expression with null to check if a conversion is successful. */

            object[] objArray = new object[6];
            objArray[0] = new ClassA();
            objArray[1] = new ClassB();
            objArray[2] = "hello";
            objArray[3] = 123;
            objArray[4] = 123.4;
            objArray[5] = null;

            for (int i = 0; i < objArray.Length; ++i)
            {
                string s = objArray[i] as string;
                Console.Write("{0}:", i);
                if (s != null)
                {
                    Console.WriteLine("'" + s + "'");
                }
                else
                {
                    Console.WriteLine("not a string");
                }
            }

            Console.ReadKey();
        }   
    }
}
