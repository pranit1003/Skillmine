using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skillmine.StaticStudy
{
    class Student
    {
        int id;
        string name;
        static string schoolname = "pune University";
        public Student(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
        public override string ToString()
        {
            return $"Student name is{name} Student Id is {id} School name is {schoolname}"; 
        }

       /* static void Main(string[] args)
        {
           Student s=  new Student(100, "Arun");
            Student s1 = new Student(101, "pranit");
            Student s2= new Student(102, "ajay");
            Console.WriteLine(s);
            Console.WriteLine(s1);
            Console.WriteLine(s2);
        }*/


    }
}
