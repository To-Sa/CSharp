using System;

namespace ToSa
{
    class OuterPrivate
    {
        class Inner
        {
            void Do()
            {
                Console.WriteLine("Hi");
            }
        }
    }

    class OuterPublic
    {
        public class Inner //use public keyword
        {
           public void Do()
           {
                Console.WriteLine("Hello");
           }
        }
    }

    class Outer
    {
        /*A nested type has access to all of the members that are accessible to 
         * its containing type. It can access private and protected members of 
         * the containing type, including any inherited protected members.*/

        private int value = 11;
        private Inner child;

        public Outer()
        {
            child = new Inner(this);
        }

        public void Do()
        {
            child.Do();
        }

        class Inner
        {
            Outer parent;
            public Inner(Outer o)
            {
                parent = o;
            }

            public void Do()
            {
                Console.WriteLine(parent.value);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            OuterPrivate priv = new OuterPrivate(); //!
            //! priv.Do();

            OuterPublic.Inner pub = new OuterPublic.Inner();
            pub.Do();

            Outer o = new Outer();
            o.Do();
            
            Console.ReadKey();
        }   
    }
}
