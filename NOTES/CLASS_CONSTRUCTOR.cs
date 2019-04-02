using System;

namespace ToSa
{
    /*A constructor is a method whose name is the same as the name of its type. 
     * Its method signature includes only the method name and its parameter list; 
     * it does not include a return type.*/

    class Dog
    {
        //Classes and structs have members that represent their data and behavior.
        //You can use the "const" and "readonly" keywords.
        private const string animal = "dog";
        private readonly string color;
        private string name = "Rex";
        private int age = 10;

        public Dog(string name, int age)    //constructor + parameter list
        {
            this.name = name;   //use "this" keyword 
            this.age = age;     
            Console.WriteLine(name + ": " + age);
        }

        public Dog() //constructor + without parameter list
        {
            Console.WriteLine(name + ": " + age);
        }

        public Dog(string name, string color) //constructor + parameter list
        {
            this.name = name;
            this.color = color;
            Console.WriteLine(name + ": " + age + ", L. is a " + animal +  ".");
            Console.WriteLine(name + ": " + age + ", L. is a " + color + " " + animal + ".");
            //sets the readonly parameter, when uses the constructor
        }

        // Copy constructor.
        public Dog(Dog otherDog):this(otherDog.name, otherDog.age)
        {

        }    
    }

    class Program
    {
        static void Main(string[] args)
        {
            Dog a = new Dog();                  //Rex: 10
            Dog b = new Dog("Snoopy", 2);       //Snoopy: 2
            Dog c = new Dog("Lassie", "brown"); //Lassie: 10

            Dog d = new Dog("Tom", 2); ;
            Dog e = new Dog(d);

            Console.ReadKey();
        }   
    }
}
