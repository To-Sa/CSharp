using System;

namespace ToSa
{
    class Program
    {
        class Person
        {
            public Person(string firstName, string lastName, string job = "N/A")
            {
                FirstName = firstName;
                LastName = lastName;
                Job = job;
            }
            public string FirstName { get; private set; }
            public string LastName { get; private set; }
            public string Job { get; private set; }

            public void Print()
            {
                Console.WriteLine(FirstName + " " + LastName + " - " + Job);
            }
        }

        static void Main(string[] args)
        {
            //optional parameter
            Person p1 = new Person("Tom", "Code");
            Person p2 = new Person("Tom", "Code", "artist");
            p1.Print();
            p2.Print();

            //named parameter
            Person p = new Person(firstName: "Tom", lastName: "Code");
            Person _p = new Person(lastName: "Code", firstName: "Tom");
            p.Print();
            _p.Print();

            Console.ReadKey();
        }   
    }
}
