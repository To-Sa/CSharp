using System;

namespace ToSa
{
    class Program
    {
        class Dog
        {
            string name;
            int age;
            public Dog(string name, int age)
            {
                this.name = name;
                this.age = age;
            }
            public void Eat()
            {
                Console.WriteLine("Eating...");
            }
            public void Sleep()
            {
                Console.WriteLine("Sleeping...");
            }
        }

        class NewString1 //"real class"
        {
            private string aString;
            public NewString1(string s)
            {
                this.aString = s;
            }
            public void PrintUpper()
            {
                Console.WriteLine(this.aString.ToUpper());
            }
        }
        class NewString2 //only a block, not contains constructors, parameters, etc.
        {
            public void PrintUpper(string s)
            {
                Console.WriteLine(s.ToUpper());
            }
        }

        static void Main(string[] args)
        {
            Dog d = new Dog("Rex", 4);
            d.Eat();
            d.Sleep();

            //METHOD
            NewString1 ns1 = new NewString1("apple");
            ns1.PrintUpper();
            
            //FUNCTION or PROCEDURE
            NewString2 ns2 = new NewString2();
            ns2.PrintUpper("apple");

            Console.ReadKey();
        }   
    }
}
