using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using c1=ClassLibraryTest.Computer;
using ClassLibraryTest.Inheritence;
using ClassLibraryTest.math;
using c2 = ClassLibraryTest.MultipleInheritence;
namespace Consoleapp
{
    class Program
    {
        static void Main(string[] args)
        {
            //ClassLibraryTest.math.Rectangle r1 = new ClassLibraryTest.math.Rectangle(10, 12);
            //Console.WriteLine($"Area : {r1.Area}\nPerimeter : {r1.Perimeter}");

            //r1.Length = 12;
            //Console.WriteLine($"Area : {r1.Area}\nPerimeter : {r1.Perimeter}");

            //ClassLibraryTest.math.Rectangle1 r1 = new ClassLibraryTest.math.Rectangle1();
            //Console.WriteLine($"Area : {r1.Area}\nPerimeter : {r1.Perimeter}");

            //r1.Length = 10;
            //Console.WriteLine($"Area : {r1.Area}\nPerimeter : {r1.Perimeter}");

            //r1.Breadth = 12;
            //Console.WriteLine($"Area : {r1.Area}\nPerimeter : {r1.Perimeter}");

            //c1.CustomStack stack = new c1.CustomStack();

            //Console.WriteLine($"Number of items : {stack.Count}, TotalItems : {stack.DisplayAll()}");

            //stack.Push(1);
            //Console.WriteLine($"Number of items : {stack.Count}, TotalItems : {stack.DisplayAll()}");
            //stack.Push(10);
            //Console.WriteLine($"Number of items : {stack.Count}, TotalItems : {stack.DisplayAll()}");
            //stack.Push(14);
            //stack.Push(3);
            //stack.Push(2);
            //stack.Push(1);
            //Console.WriteLine($"Number of items : {stack.Count}, TotalItems : {stack.DisplayAll()}");
            //stack.Pop();
            //Console.WriteLine($"Number of items : {stack.Count}, TotalItems : {stack.DisplayAll()}");



            ////testing with generic stack
            //c1.GenericStack<int> s1 = new c1.GenericStack<int>();
            //Console.WriteLine($"Number of items : {s1.Count}, TotalItems : {s1.DisplayAll()}");

            //s1.Push(1);
            //Console.WriteLine($"Number of items : {s1.Count}, TotalItems : {s1.DisplayAll()}");
            //s1.Push(10);
            //Console.WriteLine($"Number of items : {s1.Count}, TotalItems : {s1.DisplayAll()}");
            //s1.Push(14);
            //s1.Push(3);
            //s1.Push(2);
            //s1.Push(1);
            //Console.WriteLine($"Number of items : {s1.Count}, TotalItems : {s1.DisplayAll()}");
            //s1.Pop();
            //Console.WriteLine($"Number of items : {s1.Count}, TotalItems : {s1.DisplayAll()}");


            //c1.GenericStack<string> s2  = new c1.GenericStack<string>();
            //Console.WriteLine($"Number of items : {s2.Count}, TotalItems : {s2.DisplayAll()}");

            //s2.Push("a");
            //Console.WriteLine($"Number of items : {s2.Count}, TotalItems : {s2.DisplayAll()}");
            //s2.Push("b");
            //Console.WriteLine($"Number of items : {s2.Count}, TotalItems : {s2.DisplayAll()}");
            //s2.Push("c");
            //s2.Push("d");
            //s2.Push("e");
            //s2.Push("f");
            //Console.WriteLine($"Number of items : {s2.Count}, TotalItems : {s2.DisplayAll()}");
            //s2.Pop();
            //Console.WriteLine($"Number of items : {s2.Count}, TotalItems : {s2.DisplayAll()}");

            //c1.GenericStack<c1.Student> s3 = new c1.GenericStack<c1.Student>();
            //Console.WriteLine($"Number of items : {s3.Count}, TotalItems : {s3.DisplayAll()}");

            //s3.Push(new c1.Student() { Id = 1, Name = "a", Roll = "a1" });
            //Console.WriteLine($"Number of items : {s3.Count}, TotalItems : {s3.DisplayAll()}");
            //s3.Push(new c1.Student() { Id = 2, Name = "b", Roll = "b2" });
            //Console.WriteLine($"Number of items : {s3.Count}, TotalItems : {s3.DisplayAll()}");
            //s3.Push(new c1.Student() { Id = 3, Name = "c", Roll = "c3" });
            //s3.Push(new c1.Student() { Id = 4, Name = "d", Roll = "d4" });
            //s3.Push(new c1.Student() { Id = 5, Name = "e", Roll = "e5" });
            //s3.Push(new c1.Student() { Id = 6, Name = "f", Roll = "f6" });
            //Console.WriteLine($"Number of items : {s3.Count}, TotalItems : {s3.DisplayAll()}");
            //s3.Pop();
            //Console.WriteLine($"Number of items : {s3.Count}, TotalItems : {s3.DisplayAll()}");

            ////Static non-static implementation
            //Console.WriteLine(c1.Student.Count);

            //c1.Student.Count = 10;
            //Console.WriteLine(c1.Student.Count);

            //c1.Student.Count = 5;
            //Console.WriteLine(c1.Student.Count);

            //c1.Student.AssignCount(100);
            //Console.WriteLine(c1.Student.Count);

            ////queue implemented
            //c1.Queuefirst s1 = new ClassLibraryTest.Computer.Queuefirst();
            //Console.WriteLine($"Number of items : {s1.Count}, TotalItems : {s1.DisplayAll()}");

            //s1.Enqueue(1);
            //Console.WriteLine($"Number of items : {s1.Count}, TotalItems : {s1.DisplayAll()}");
            //s1.Enqueue(10);
            //Console.WriteLine($"Number of items : {s1.Count}, TotalItems : {s1.DisplayAll()}");
            //s1.Enqueue(14);
            //s1.Enqueue(3);
            //s1.Enqueue(2);
            //s1.Enqueue(1);
            //Console.WriteLine($"Number of items : {s1.Count}, TotalItems : {s1.DisplayAll()}");
            //s1.Dequque();
            //Console.WriteLine($"Number of items : {s1.Count}, TotalItems : {s1.DisplayAll()}");



            ////Inheritence implemented
            //Vehicle v1 = new Vehicle("");

            //Bus b1 = new Bus("Ba 1 Kha 2222");

            //Car c1 = new Car("Ba 1 Cha 2222");

            //v1.Run();
            //b1.Run();
            //c1.Run();
            //v1.Stop();
            //b1.Stop();
            //c1.Stop();

            //b1.Size();
            //c1.Size();


            ////polymorphism implemented here
            //Vehicle v1 = new Vehicle("Vehicle");
            //Vehicle _bus = new Bus("vehicle bus");
            //Bus b1 = new Bus("abc bus");
            ////Vehicle _car = new Car("test car");

            //v1.Run();

            //_bus.Run();
            ////_bus.Stop();

            //b1.Run();
            ////b1.Stop();

            ////factory pattern implemented here
            //Shape s;
            //Console.WriteLine("Choose option :\n1. Rectangle\n2. Circle");
            //var input = Console.ReadLine();
            //int choice = Convert.ToInt32(input);
            //switch (choice)
            //{
            //    case 1:
            //        s = new RectangleClass();
            //        break;
            //    case 2:
            //        s = new Circle();
            //        break;
            //    case 3:
            //        s = new square();
            //        break;
            //    default:
            //        s = new RectangleClass();
            //        break;
            //}

            //s.GetInput();

            //Console.WriteLine($"Area is {s.Area()}");
            //Console.WriteLine($"Perimeter is {s.Perimeter()}");



            //Interface
            c2.Circle _circle = new ClassLibraryTest.MultipleInheritence.Circle();
            c2.Rectangle _rectangle = new c2.Rectangle();

            c2.test.testing(_circle);
            c2.test.testing(_rectangle);

            c2.test.Testperimeter(_circle);
            c2.test.Testperimeter(_rectangle);

            c2.test _test = new c2.test();
            _test.Dispose();

            Console.ReadLine();
        }
    }
}
