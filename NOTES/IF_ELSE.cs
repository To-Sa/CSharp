using System;

namespace ToSa
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, select a number 1-5.");
            string number = Console.ReadLine();
            
            if(Convert.ToInt32(number) == 1)
            {
                Console.WriteLine("Selected number is the one.");
            }
            else if(Convert.ToInt32(number) == 2)
            {
                Console.WriteLine("Selected number is the two.");
            }
            else if (Convert.ToInt32(number) == 3)
            {
                Console.WriteLine("Selected number is the three.");
            }
            else
            {
                if (Convert.ToInt32(number) == 4)
                {
                    Console.WriteLine("Selected number is the four.");
                }
                else if (Convert.ToInt32(number) == 5)
                {
                    Console.WriteLine("Selected number is the five.");
                }
                else
                {
                    Console.WriteLine("Selected number is another number.");
                } 
            }

            Console.ReadKey();
        }
    }
}
