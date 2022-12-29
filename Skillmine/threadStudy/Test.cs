using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Skillmine.threadStudy
{
    class Test
    {
        public void M1()
        {
            lock(this) // this --> refers to the current thread

            {
                for (int i = 0; i <= 10; i++)
                {
                    Console.WriteLine(i);
                }

            }
            
        }
        public void M2()
        {
            for(int i= 11;i<=15; i++)
            {
                Console.WriteLine(i);
            }
        }

    }
    public class Program
    {
        /*static void Main(string[] args)
        {
            Test obj = new Test();
            Thread T1 = new Thread(new ThreadStart(obj.M1));
            Thread T2 = new Thread(new ThreadStart(obj.M2));
            Thread T3 = new Thread(new ThreadStart(obj.M1));


            T1.Start();
          // T2.Start();
            //T3.Start();
            T1.Join();
            // T1.Priority = ThreadPriority.Lowest;
            // T2.Priority = ThreadPriority.Highest;
        }*/
    }
}
