using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTest.Inheritence
{
    public class Vehicle
    {
        private string _numberPlate;

        public string NumberPlate
        {
            get { return _numberPlate; }
        }

        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }


        //public Vehicle()
        //{
        //    _numberPlate = "";
        //}
        public Vehicle(string NumberPlate)
        {
            _numberPlate = NumberPlate;
        }

        protected int id = 0;
        private int privatemember = 0;
        protected string type = "";
        public virtual void Run()
        {
            Console.WriteLine($"{this.type} Category {this.id} is running");
        }

        public void Stop()
        {
            Console.WriteLine("Vehicle is stopped");
        }


    }
}
