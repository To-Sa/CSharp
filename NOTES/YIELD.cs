using System;
using System.Collections;

namespace ToSa
{
    class Program
    {
        static public IEnumerable Enumerable_Method(int max)
        {
            for (int i = 0; i < max; i++)
            {
                yield return i;
            }
        }

        //The function returns an object that implements the IEnumerable interface. 
        //If a calling function starts foreach-ing over this object the function is called again until it "yields".

        static public IEnumerable Integers()
        {
            yield return 543345;
            yield return 86787;
            yield return 574;
            yield return 8;
            yield return 1276;
            yield return 999999;
        }

        static void Main(string[] args)
        {
            foreach (var item in Enumerable_Method(8))
            {
                Console.WriteLine(item);
            }

            foreach (int i in Integers())
            {
                Console.WriteLine(i.ToString());
            }

            Console.ReadKey();
        }
    }
}
