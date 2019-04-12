using System;

namespace ToSa
{
    class Program
    {
        class DisposableClass : IDisposable
        {
            private bool disposed = false;
            public void Dispose()
            {
                Dispose(true);
                GC.SuppressFinalize(this);
            }
            private void Dispose(bool disposing)
            {
                if (!disposed)
                {
                    if (disposing)
                    {
                        //free managed resources
                    }
                    //free unmanaged resources
                    disposed = true;
                }
            }
            ~DisposableClass()
            {
                Dispose(false);
            }
        }

        class DisposableClassUsing : IDisposable
        {
            public void Dispose()
            {
                Console.WriteLine("Clearing...");
                GC.SuppressFinalize(this);
            }
        }

        static void Main(string[] args)
        {
            DisposableClass dc = new DisposableClass();

            using (DisposableClassUsing dcu = new DisposableClassUsing())
            {
                //Provides a convenient syntax that ensures the correct use of IDisposable objects.
            }

            Console.ReadKey();
        }   
    }
}
