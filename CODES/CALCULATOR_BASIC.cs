using System;

namespace ToSa
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            char op;
            if (args.Length == 0)
            {
                Console.WriteLine("The first number:");
                x = int.Parse(Console.ReadLine());
                Console.WriteLine("The second number:");
                y = int.Parse(Console.ReadLine());
                Console.WriteLine("The operation sign(+, -, *, /):");
                op = Convert.ToChar(Console.Read());
            }
            else
            {
                if (args.Length != 3)
                {
                    Console.WriteLine("Some parameters are missing.");
                    Console.ReadKey();
                    return;
                }
                else
                {
                    x = int.Parse(args[0]);
                    y = int.Parse(args[1]);
                    op = Convert.ToChar(args[2]);
                }
            }

            int result = 0;
            switch (op)
            {
                case '+':
                    result = x + y;
                    break;
                case '-':
                    result = x - y;
                    break;
                case '*':
                    result = x * y;
                    break;
                case '/':
                    result = x / y;
                    break;
            }

            Console.WriteLine("Result: {0}", result);

            Console.ReadKey();
        }   
    }
}
