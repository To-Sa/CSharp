using System;

namespace ToSa
{
    class Program
    {
        class DestructableClass
        {
            public DestructableClass()
            {
                Console.WriteLine("Constructor");
            }

            ~DestructableClass() // use the tilde sign"~"
            {
                Console.WriteLine("Destructor");
            }
        }

        static void Main(string[] args)
        {
            Gc();

            DestructableClass dc = new DestructableClass();

            //STRONG REFERENCES
            /*The garbage collector cannot collect an object in use by an application 
             * while the application's code can reach that object. The application is 
             * said to have a strong reference to the object.*/

            //WEAK REFERENCES
            /*Represents a weak reference, which references an object while still 
             * allowing that object to be reclaimed by garbage collection.*/
            int[][] array = new int[10][];
            for (int i = 0; i < 10; ++i)
            {
                array[i] = new int[1000];
            }
            WeakReference wr = new WeakReference(array);
            array = null;

            Console.ReadKey();
        } 
        
        static void Gc()
        {
            Console.WriteLine("Memory usage: {0}", GC.GetTotalMemory(false));

            for (int i = 0; i < 10; ++i)
            {
                int[] x = new int[1000];
            }

            Console.WriteLine("Memory usage: {0}", GC.GetTotalMemory(false));

            GC.Collect(); // garbage collector

            Console.WriteLine("Memory usage: {0}", GC.GetTotalMemory(false));
        }
    }
}
