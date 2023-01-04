using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skillmine.ArrayPractice
{
    class SortExam
    {
        /*static void Main(string[] args)
        {
            int[] myNumbers = { 1, 2, 3, 4 ,5 ,6 ,7 ,8 ,9 ,10};
            Array.Sort(myNumbers);
            int result = int.substring(4, 1);
            foreach (int i in myNumbers)
            {
                Console.WriteLine(i);
            }
        }*/

        public static void Main()
        {
            int[] arr1 = { 1, 2, 9, 4, 8, 2, 6, 7, 4, 3 };
            
            int temp;
            int i, j;
            for (i = 2; i < 5; i++)
            {
                for (j = 2; j < i; j++)
                {
                    if (arr1[j]>(arr1[j + 1]))
                    {
                        temp = arr1[j];
                        arr1[j] = arr1[j + 1];
                        arr1[j + 1] = temp;
                    }
                }
            }
            //Console.WriteLine(String.Join(" ", arr1));
            /*for (i = 0; i < arr1.Length; i++)
            {
                Console.WriteLine(arr1[i] + " ");
            }*/
            Array.Sort(arr1, 1, 6);
            foreach (int s in arr1)
            {
                Console.Write(s + " ");
            }

        }
    }
}


