using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skillmine.practiceExam
{
    class VarKeyword
    {

        /*public void Num()
        {
            Console.WriteLine("I am Num method");
            
        }*/
        int studentid;
        dynamic a = 20;
        
        public dynamic Studentid
        {
            set { studentid = value; }
            get { return studentid; }
        }
        public void Sub()
        {
            dynamic c = 40;
        }
        public dynamic Value()
        {
            return 10;

        }
        
        
/*
        static void Main(string[] args)
        {*/
            /*var v = new VarKeyword();
            v.Num();
            
            int a = 12 ; int b = 13; double c = 10.00;
            int d;
            d = a + b;
            *//*float sum = a + b +c;*//*
           
            var g = a + b +c;*/
            /*
                        int a = 30;
                        int b = 20;
                        var c = a + b;*/

           /* VarKeyword v = new VarKeyword();
            int s = v.Value();
            Console.WriteLine(  s);
*/

        }
    }

