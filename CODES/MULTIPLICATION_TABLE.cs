using System;

namespace ToSa
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            int menuIndex = 0;

            Console.WriteLine("1) Select a number.");
            Console.WriteLine("2) Use the random number generator.");
            Console.WriteLine();
            Console.WriteLine("Select 1 or 2.");

            menuIndex = Convert.ToInt32(Console.ReadLine());

            switch (menuIndex)
            {
                case 1:
                    Console.WriteLine("Select 1 - 10.");
                    number = Convert.ToInt32(Console.ReadLine());
                    if (0 < number && number <= 10)
                    {
                        ForMethod(number);
                    }
                    else { goto default; }
                    break;

                case 2:
                    RandomMethod();
                    break;

                default: Console.WriteLine("The number is out of range.");
                    break;
            }

            Console.ReadKey();
        }

        static void RandomMethod()
        {
            int number;
            Random r = new Random();
            number = r.Next(1,11);
            ForMethod(number);
        }

        static void ForMethod(int number)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("{0} x {1} = {2}", i, number, i * number);
            }
        }   
    }
}
