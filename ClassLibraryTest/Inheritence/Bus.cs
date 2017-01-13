using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTest.Inheritence
{
    public class Bus : Vehicle
    {
        public Bus(string NumberPlate) : base()
        {
            this.id=5;
            this.type = "Bus";
        }

        public void Size()
        {
            Console.WriteLine("Size is big");
        }
    }

    public class Car : Vehicle
    {

        public Car(string NumberPlate) :base(NumberPlate)
        {
            this.id = 6;
            this.type = "Car";
        }
        public void Size()
        {
            Console.WriteLine("Size is small");
        }
    }

    public class Bike
    {

    }

    public class BiCycle :Vehicle
    {
        public BiCycle()
        {

        }
    }
}
