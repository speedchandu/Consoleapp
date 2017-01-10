using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using c1=ClassLibraryTest.Computer;

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

            //c1.GenericStack<c1.Student> s3  = new c1.GenericStack<c1.Student>();
            //Console.WriteLine($"Number of items : {s3.Count}, TotalItems : {s3.DisplayAll()}");

            //s3.Push(new c1.Student() {  Id=1, Name="a", Roll="a1"});
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



            //queue implemented
            c1.Queuefirst s1 = new ClassLibraryTest.Computer.Queuefirst();
            Console.WriteLine($"Number of items : {s1.Count}, TotalItems : {s1.DisplayAll()}");

            s1.Enqueue(1);
            Console.WriteLine($"Number of items : {s1.Count}, TotalItems : {s1.DisplayAll()}");
            s1.Enqueue(10);
            Console.WriteLine($"Number of items : {s1.Count}, TotalItems : {s1.DisplayAll()}");
            s1.Enqueue(14);
            s1.Enqueue(3);
            s1.Enqueue(2);
            s1.Enqueue(1);
            Console.WriteLine($"Number of items : {s1.Count}, TotalItems : {s1.DisplayAll()}");
            s1.Dequque();
            Console.WriteLine($"Number of items : {s1.Count}, TotalItems : {s1.DisplayAll()}");

            Console.ReadLine();
        }
    }
}
