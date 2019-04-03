using System;

namespace ToSa
{
    /*You can use object initializers to initialize type objects in a declarative 
     * manner without explicitly invoking a constructor for the type.*/

    class Person
    {
        public Person()
        {

        }

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person()
            {
                Name = "Tom"
            };

            Console.WriteLine(p.Name);

            Console.ReadKey();
        }   
    }
}
