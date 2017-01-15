using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTest.math
{
    public abstract class Shape
    {
        public abstract void GetInput();
        public abstract int Area();


        public abstract int Perimeter();

    }

    public class RectangleClass : Shape
    {
        int length = 0;
        int breadth = 0;
        public override int Area()
        {
            return length * breadth;
        }

        public override void GetInput()
        {
            Console.WriteLine("Length");
            length = int.Parse(Console.ReadLine());
            Console.WriteLine("Breadth");

            breadth = int.Parse(Console.ReadLine());
        }

        public override int Perimeter()
        {
            return (2 * (length + breadth));
        }
    }

    public class Circle : Shape
    {
        int Radius = 0;
        const int pi= 22 / 7;

        public override int  Area()
        {
            return (pi * (Radius ^ 2));
        }

        public override void GetInput()
        {
            Console.WriteLine("Radius");

            Radius = int.Parse(Console.ReadLine());
        }

        public override int Perimeter()
        {
            return (2 * pi * Radius);
        }
    }


    public class square : Shape
    {
        int Length = 0;
        public override int Area()
        {
            return Length ^ 2;
        }

        public override void GetInput()
        {
            Console.WriteLine("Length :");
            Length = int.Parse(Console.ReadLine());
        }

        public override int Perimeter()
        {
            return 4 * Length;
        }
    }

}
