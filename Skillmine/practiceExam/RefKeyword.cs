using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skillmine.practiceExam
{
    class RefKeyword
    {

        /*public  void Swap(ref int a, ref int b)
        {
            int temp;
            temp = a;
            a = b;   // b-> a
            b = temp;
        }*/
        
        /*static void Main(string[] args)
        {
            int a = 10, b = 20;
            Console.WriteLine($"Before call the method a={a} , b={b}");
            Swap(ref a, ref b); // referecne  / address
            Console.WriteLine($"after call the method a={a} , b={b}");
        }
*/

       /* public static void Calc(int a, int b,  out int sum, out int sub, out int multiply)
        {
            sum = a + b;
            sub = a - b;
            multiply = a * b;
        }*/

        /* public static void Main(string[] args)
         {
             int a = 44, b = 23, sum, sub, mul;
             Calc(a, b,  sum,  sub,  mul); // no values 
             Console.WriteLine(sum);
             Console.WriteLine(sub);
             Console.WriteLine(mul);
         }*/


        /*static void AcceptNames(params string[] names)
        {
            Console.WriteLine("Values to print " + names.Length);
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }
        }*/

        
        /*static void Add(params int[]c )
        {
            int sum = 0;
            for (int i = 0; i < c.Length; i++)
            {
                sum = sum + c[i];
                
            }
            Console.WriteLine("addition is " +sum);
        }
        static void Main(string[] args)
        {
            RefKeyword.Add(10, 20);
            RefKeyword.Add(10, 20, 30);
            RefKeyword.Add(10, 20, 40);
            RefKeyword.Add(10, 20, 50, 70);
            RefKeyword.Add(10, 20, 40, 50, 60);
        }*/

        /*static void Main(string[] args)
        {
            RefKeyword r = new RefKeyword();

            AcceptNames("Amol", "kishor");
            AcceptNames("Amol", "Kishor", "Ajay");
            AcceptNames("Amol", "Kishor", "Suraj", "Rohan");

        }*/

        /*public void add(params int []a)
        {
            int element;
            int sum = 0;
            for (int i = 0; i < length; i++)
            {

            }
            Console.WriteLine($"addition of {element} parameter is {sum}");
        }
        */
    }
}
