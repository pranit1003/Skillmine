using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skillmine.StringStudy
{
    class StringSplitMethod
    {
        public void SplitMethod(string []a)
        {
           
            for(int i= 0; i< a.Length;i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.WriteLine(a[i]);
                }
                
            }
            Console.WriteLine();
        }
        /*static void Main(string[] args)
        {
            //string s = "I like India Country";

            //string[] str = s.Split();

            StringSplitMethod m = new StringSplitMethod();
            //m.SplitMethod(str);
            Console.WriteLine("Enter the string");
            string st = Console.ReadLine();
        }*/
    }
}
