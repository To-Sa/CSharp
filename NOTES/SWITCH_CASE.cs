using System;

namespace ToSa
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, select a number 1-5.");
            int number = Convert.ToInt32(Console.ReadLine());
            
            switch(number)
            {
                case 1:
                    Console.WriteLine("Selected number is the one.");
                    break;

                case 2:
                    Console.WriteLine("Selected number is the two.");
                    break;

                case 3:
                    Console.WriteLine("Selected number is the three.");
                    break;

                case 4:
                    Console.WriteLine("Selected number is the four.");
                    break;

                case 5:
                    Console.WriteLine("Selected number is the five.");
                    break;

                default:
                    Console.WriteLine("Selected number is another.");
                    break;
            }
            Console.ReadKey();
        }
    }
}
