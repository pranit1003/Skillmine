using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skillmine.DelegateStudy
{
    public delegate void MyDel();

    class Stud
    {
      
        public event MyDel Pass; // declaration of event
        public event MyDel Fail;
        public void Accept(int marks)
        {
            if (marks >= 40)
            {
                Pass(); //raise an event
            }
            else
            {
                Fail();
            }
        }
    }
    public static class Message
    {
        public static void PassMessage()
        {
            Console.WriteLine("Great ! you are pass");
        }
        public static void FailMessage()
        {
            Console.WriteLine("Sorry ! you are Fail");
        }
    }
    public class Program22
    {

        /*static void Main(string[] args)
        {
            Stud s1 = new Stud();

            s1.Pass += new MyDel(Message.PassMessage); // bind event with delegate
            s1.Fail += new MyDel(Message.FailMessage);

            s1.Accept(38);
            Console.WriteLine("---------------");
            s1.Accept(44);
        }*/


    }
}

