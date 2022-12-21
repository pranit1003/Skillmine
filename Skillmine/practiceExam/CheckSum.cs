using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skillmine.practiceExam
{
    class CheckSum
    {
        public void Finds(int[] a)
        {
            Console.WriteLine("enter the number");
            int num = 7;

            for (int i = 0; i < a.Length; i++)
            {
                for (int j = i; j < a.Length ; j++)
                {
                    if (num == a[i] + a[j])
                    {
                        Console.WriteLine($"({a[i]},{a[j]})");
                    }
                }

            }
        }
        /*static void Main(string[] args)
        {
            int[] arr = { 4, 5, 7, 9, 1, 5, 3, 2 };
            CheckSum b = new CheckSum();
            b.Finds(arr);
            Console.WriteLine();
        }*/
    }
    
}
