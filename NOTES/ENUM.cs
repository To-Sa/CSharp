using System;

namespace ToSa
{
    class Program
    {
        enum Day {Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday};
        enum Animal {Cat = 1, Dog = 5, Tiger, Wolf };

        static void Main(string[] args)
        {
            Day today = Day.Wednesday;
            byte dayNumber = (byte)today;

            Animal wolf = Animal.Wolf;
            int wolfNumber = (int)wolf;

            Console.WriteLine(today);
            Console.WriteLine(dayNumber);

            Console.WriteLine(wolf);
            Console.WriteLine(wolfNumber);

            //Enum.TryParse Method
            string animalNumber = "6";
            string animalName = "Dog";
            Animal animalNameIfExist1, animalNameIfExist2;
            Enum.TryParse(animalNumber, true, out animalNameIfExist1);
            Enum.TryParse(animalName, true, out animalNameIfExist2);
            Console.WriteLine(animalNameIfExist1);
            Console.WriteLine(animalNameIfExist2);

            Console.ReadKey();
        }
    }
}
// Output:
//Wednesday
//3
//Wolf
//7
//Tiger
//Dog
