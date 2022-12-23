using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skillmine.DelegateStudy
{
    //Declaration of delegate
    public delegate int Mydell(int n1, int n2);
    public delegate string Mydell2(string s);

    class Test
    {
        public int ME1(int a, int b)
        {
            return a + b;

        }
        public string ME2(String Name)
        {
            return Name.ToUpper();
        }

        public int ME3(int a, int b)
        {
            return a * b;

        }
        public int ME4(int a, int b)
        {
            return a - b;

        }

       

    }
    public class Program
    {
        /*static void Main(string[] args)
        {
            Test t1 = new Test();
            Mydell d1 = new Mydell(t1.ME1);
            d1 += new Mydell(t1.ME3);
            d1 += new Mydell(t1.ME4);
            Delegate[] list = d1.GetInvocationList();
            foreach (Delegate item in list)
            {
                Console.WriteLine(item.Method);
                Console.WriteLine(item.DynamicInvoke(12, 32));
            }
            Mydell2 d2 = new Mydell2(t1.ME2);


            string str = d2.Invoke("Pranit");
            Console.WriteLine(str);
        }
*/
    }
}
