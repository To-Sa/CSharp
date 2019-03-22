using System;

namespace ToSa
{
    class Program
    {
        enum Animal { TIGER, WOLF, CAT, DOG };

        static void Main(string[] args)
        {
            Animal _animal = Animal.TIGER;
            
            switch(_animal)
            {
                case Animal.TIGER:
                    Console.WriteLine("This is a tiger.");
                    goto default;

                case Animal.CAT:
                    Console.WriteLine("This is a cat.");
                    break;

                default:
                    Console.WriteLine("This is an animal.");
                    goto case Animal.CAT;
            }
            Console.ReadKey();
        }
    }
}
