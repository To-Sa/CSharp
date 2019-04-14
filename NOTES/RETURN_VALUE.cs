using System;

namespace ToSa
{
    class Program
    {
        class Test
        {
            public int Add(int x, int y)
            {
                return x + y; //return value
            }

            public int AddFalse(int x, int y)
            {
                if (x != 0 && y != 0)
                {
                    //ERROR
                    return x + y; // not all code paths return a value

                }

                //return x + y;
            }

            public int AddByte(int x, int y)
            {
                return (byte)(x + y); //it works but doesn't make sense
            }

           public int AddLong(int x, int y)
           {
                return (long)(x + y); //not works: cannot implicity convert type...
           }
        }

        static void Main(string[] args)
        {
            Test t = new Test();
            int result = t.Add(10, 11);
            Console.WriteLine(result);

            Console.ReadKey();
        }   
    }
}
