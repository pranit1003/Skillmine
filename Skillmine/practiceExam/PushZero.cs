using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skillmine.practiceExam
{
    class PushZero
    {
       public void PushZeroAtStart(int[] a)
        {

            for( int i =0; i<a.Length ; i++)
            {
                for(int j = i+1; j< a.Length; j++)
                {
                    if (a[j] == 0)
                    {
                        int temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }

                }
            }
            for (int i =0; i < a.Length ; i++)
                {
                Console.Write(a[i]+" ");
                }
        }

        public void ShiftZeroAtLast(int []a)
        {
            for( int i = a.Length-1; i>= 1; i--)
            {
                for( int j = i-1; j>= 0; j--)
                {
                    if(a[j] == 0 )
                    {
                        int temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                }
            }
             
        }
         
        /*public  static void Main (string[] args )
        {
            int[] a = new int[] { 2, 10, 0, 5, 14,0, 0, 2, 9, 8 };
            Console.WriteLine(string.Format(" ", a));

            PushZero p = new PushZero();

            p.PushZeroAtStart(a);
            Console.WriteLine("-------------------");
            p.ShiftZeroAtLast(a);
            
        }*/
       
    }
}
