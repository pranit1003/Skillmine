using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skillmine.practiceExam
{
    public class MyGeneric<T>
    {
        private T data;

        public void Add(T data)
        {
            this.data = data;
        }

        public T Print()
        {
            return data;
        }
    }
    public class Program1
    {
        /*static void Main(string[] args)
        {
            MyGeneric<int> obj1 = new MyGeneric<int>();
            obj1.Add(100);

            Console.WriteLine(obj1.Print());


            
        }*/

    }
    public class Program2
    {
        static void Swap<T>(T a, T b)
        {
            T temp;
            temp = a;
            a = b;
            b = temp;
            Console.WriteLine(a);
            Console.WriteLine(b);
        }
        /*static void Main(string[] args)
        {
            MyGeneric<int> obj1 = new MyGeneric<int>();
            obj1.Add(100);

            Console.WriteLine(obj1.Print());


            
            Swap<int>(10, 20);
            Swap<double>(12.56, 67.33);
            Swap<string>("Hello", "Hi");

           
        }*/

    }
    public class Program3
    {
        /*static void Main(string[] args)
        {
            HashSet<int> list = new HashSet<int>();
            list.Add(10);
            list.Add(20);
            list.Add(30);
            list.Add(40);
            list.Add(50);
            //list.Add(30);

            list.Remove(50);
             //list.Clear();
            foreach (int item in list)
            {
                Console.WriteLine(item);
            }

        }*/
    }
}
