using System;

namespace ToSa
{
    class Program
    {
        class Person
        {
            string name;

            public Person(string _name)
            {
                this.name = _name;
                this.NameAutoProperty = name;
            }

            public string Name
            {
                get { return this.name; }
                set { this.name = value; }
            }

            public string NameGetPrivate
            {
                private get { return this.name; } //WORKS
                set { this.name = value; }
            }

            public string NameSetPrivate
            {
                get { return this.name; }
                private set { this.name = value; }//NOT WORKS
            }

            public string NameGetOnly // ONLY GET
            {
                get { return "Mr. " + this.name; } //can modify the value
            }

            public string NameAutoProperty //Auto-implemented properties
            {
                get; 
                set; 
            }
        }
        static void Main(string[] args)
        {
            //PROPERTY
            Person p = new Person("Peter");
            Console.WriteLine(p.Name);

            Person p2 = new Person("Peter");
            string name = p2.Name = "Joe"; //value == "Joe"
            Console.WriteLine(name);

            Person p3 = new Person("Peter");
            p3.NameGetPrivate = "Tom"; //WORKS
            Console.WriteLine(p3.Name);

            Person p4 = new Person("Lee");
            //p4.NameSetPrivate = "Vi"; //NOT WORKS
            Console.WriteLine(p4.Name);

            Person p5 = new Person("T");
            Console.WriteLine(p5.NameGetOnly);

            Person p6 = new Person("Jack");
            Console.WriteLine(p6.NameAutoProperty);

            Console.ReadKey();
        }   
    }
}
