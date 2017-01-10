using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTest.Computer
{
    public class Stack
    {
        private int[] _container;
        private int count = 0;


        public Stack(int Size)
        {
            _container = new int[Size];
        }
        public int Count { get { return count; } }

        public void Push(int a)
        {
            if (count<_container.Length)
            {
                _container[count] = a;
                count++;
            }

        }

        public int Pop()
        {
            int ret = 0;
            if (count>=0)
            {
                ret = _container[count-1];
                _container[count-1] = 0;
                count--;
            }

            return ret;
        }


        public string DisplayAll()
        {
            int[] dest = new int[count];
            Array.Copy(_container, dest, count);
            string str = string.Join(",", dest);
            return str;
        }
    }

    public class CustomStack
    {
        private int[] _container=new int[0];

        public int Count { get { return _container.Length; } }
        public void Push(int a)
        {
            Array.Resize(ref _container, _container.Length + 1);
            _container[_container.Length - 1] = a;
        }

        public int Pop()
        {
            int ret=0;
            if (_container.Length>=0)
            {
                ret = _container[_container.Length - 1];
                Array.Resize(ref _container, _container.Length - 1);
            }

            return ret;
        }

        public string DisplayAll()
        {
            string str = string.Join(",", _container);
            return str;
        }
    }

    public class GenericStack<T>
    {
        private T[] _container = new T[0];

        public int Count { get { return _container.Length; } }
        public void Push(T a)
        {
            Array.Resize(ref _container, _container.Length + 1);
            _container[_container.Length - 1] = a;
        }
        T ret;
        public T Pop()
        {

            if (_container.Length >= 0)
            {
                 ret = _container[_container.Length - 1];
                Array.Resize(ref _container, _container.Length - 1);
            }

            return ret;
        }

        public string DisplayAll()
        {
            string str = string.Join(",", _container);
            return str;
        }


    }


    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Roll { get; set; }


        public override string ToString()
        {
            string str = $"Id : {this.Id} Roll : {this.Roll} Name : {this.Name}";
            return str;
        }

    }

    public class Queuefirst
    {
        private int[] _container = new int[10];
        private int count = 0;
        public int Count { get { return count; } }
        public void Enqueue(int a)
        {
            if (count<10 && count>=0)
            {
                for (int i = count;  i > 0 ;  i--)
                {
                    _container[i] = _container[i - 1];
                }
                _container[0] = a;
                count++;
            }
        }


        public int Dequque()
        {
            int ret = 0;
            if (count>0)
            {
                ret=_container[count - 1];
                _container[count - 1] = 0;
                count--;
            }

            return ret;
        }

        public string DisplayAll()
        {

            int[] dest = new int[count];
            Array.Copy(_container, dest, count);
            string str = string.Join(",", dest);
            return str;
        }
    }


    }
