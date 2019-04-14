using System;

namespace ToSa
{
    class Program
    {
        class Test
        {
            public void Method(string param)
            {
                Console.WriteLine("Parameter: {0}", param);
            }

            public void Swap(int x, int y)
            {
                int tmp = x;
                x = y;
                y = tmp;
            }
        }

        class TestRef
        {
            public void Method(string param)
            {
                Console.WriteLine("Parameter: {0}", param);
            }

            public void Swap(ref int x, ref int y)
            {
                int tmp = x;
                x = y;
                y = tmp;
            }
        }

        class InitOut
        {
            public void TestInit(out TestOut t)
            {
                t = new TestOut() { s = "Hello!" };
            }
        }
        class TestOut
        {
            public string s = null;
        }

        class TestArray
        {
            public void PrintElements(string end, params object[] list)
            {
                foreach (var item in list)
                {
                    Console.WriteLine(item);
                }

                Console.WriteLine(end);
            }
        }

        static void Main(string[] args)
        {
            Test t = new Test();
            t.Method("Parameter");

            //The parameters are passed by value.
            int x = 10;
            int y = 20;
            t.Swap(x, y);
            Console.WriteLine("x = {0}, y = {1}", x, y);

            //The parameters are passed by reference.
            int dx = 10;
            int dy = 20;
            TestRef dt = new TestRef();
            dt.Swap(ref dx, ref dy);
            Console.WriteLine("x = {0}, y = {1}", dx, dy);

            //The out keyword causes arguments to be passed by reference.
            TestOut ot = null;
            InitOut oi = new InitOut();
            oi.TestInit(out ot);
            Console.WriteLine(ot.s); // Hello!

            /*By using the params keyword, you can specify a method parameter 
             * that takes a variable number of arguments.*/
            object[] list = new object[] {"one", "two", 4, 1, "ten" };
            TestArray ta = new TestArray();
            ta.PrintElements("END",list);

            Console.ReadKey();
        }   
    }
}
