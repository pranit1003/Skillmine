using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skillmine.VariousWaytoIntialiseInstanceVariable
{
    class Student1
    {
        private int rollno;
        private string name;
        private string address;
        private static int count=100;
        private static int countobject;

        /*public Student1(int rollno = 100, string name = "Pranit", string address = "Kolhapur")
        {
            this.rollno = rollno;
            this.name = name;
            *//*this.address = address;
        }*/

        public Student1( string name = "Pranit", string address = "Kolhapur")
        {
            countobject++;
            count++;
            rollno =count;
            this.name = name;
            this.address = address;
        }
        public int Countobject
        {
            get { return countobject; }
        }

        /*public int  Rollno
        {
            set { rollno = value; }
            get { return rollno; }
        }
        public string Name
        {
            set { name = value; }
            get { return name; }
        }*/

        /*public int Rollno { get; set; }
        public string Name { get; set; }*/


        public override string ToString()
         {
            return $"Student roll no is: {rollno} , Student name is: {name} ,Student address is:{address}";
        }
    }
}
