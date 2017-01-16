using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTest.MultipleInheritence
{
    public interface IArea
    {
        int Area();
    }
    public interface IPerimeter
    {
        int Perimeter();
    }

    public class Circle : IArea,IPerimeter
    {
        int radius = 0;
        const double pi = 22 / 7;
        public int Area()
        {
            Console.WriteLine("From Circle Calling Area");

            return Convert.ToInt32(pi * (radius^2));
        }
        public int Perimeter()
        {
            Console.WriteLine("From Circle Calling Area");

            return Convert.ToInt32(2 *  pi * radius);
        }
    }

    public class Rectangle : IArea, IPerimeter
    {
        public int Area()
        {
            InternalFunction();
            Console.WriteLine("From Rectanlge Calling Area");
            return 0;
        }

        private int InternalFunction()
        {
            return 1;
        }

        public int Perimeter()
        {
            Console.WriteLine("From Rectanblge Calling Perimeter");
            return 1;
        }
    }

    public class test : IDisposable
    {
        IArea _iarea;
        IPerimeter _peri;
        public static void testing(IArea _area)
        {
            _area.Area();

        }

        public static void Testperimeter(IPerimeter _iperi)
        {
            _iperi.Perimeter();
        }

        #region IDisposable Support
        private bool disposedValue = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects).
                    _iarea = null;
                    _peri = null;
                }

                // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                // TODO: set large fields to null.

                disposedValue = true;
            }
        }

        // TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
        // ~test() {
        //   // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
        //   Dispose(false);
        // }

        // This code added to correctly implement the disposable pattern.
        public void Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
            // TODO: uncomment the following line if the finalizer is overridden above.
            // GC.SuppressFinalize(this);
        }
        #endregion


    }
}
