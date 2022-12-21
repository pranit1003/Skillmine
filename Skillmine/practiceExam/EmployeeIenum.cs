using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skillmine.practiceExam
{
    //public class EmployeeIenum : IComparable
   /* {*//*
        private string name;
        private int salary;
        public EmployeeIenum(string name, int salary)
        {
            this.name = name;
            this.salary = salary;
        }

        public int CompareTo(object obj)// obj=player4
        {

            Player p4 = (Player)obj;  // type casting
            // to access runs of palyer1 we use this
            // this--> point to the current object
            if (this.salary > p4.salary)
            {
                return 1;
            }
            else if (this.salary < p4.salary)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }

        public override string ToString()
        {
            return $"{name} -> {salary}";
        }
    }
    public class Team1 : IEnumerable
    {
        private EmployeeIenum[] employeeIenums;
        public Team1()
        {
            EmployeeIenum = new EmployeeIenum[5];
            EmployeeIenum[0] = new EmployeeIenum("Rohit", 45);
            EmployeeIenum[1] = new EmployeeIenum("Virat", 80);
            EmployeeIenum[2] = new EmployeeIenum("Ishan", 79);
            EmployeeIenum[3] = new EmployeeIenum("Ashwin", 33);
            EmployeeIenum[4] = new EmployeeIenum("Hardik", 88);
        }

        public IEnumerator GetEnumerator()
        {
            return players.GetEnumerator();
        }
    }

    public class Program12
    {

        static void Main(string[] args)
        {
            Team1 t = new Team1();
            foreach (EmployeeIenum p in t)
            {
                Console.WriteLine(p);
            }
            EmployeeIenum   e    = new EmployeeIenum ("Rohit", 45);
            EmployeeIenum  e1  = new EmployeeIenum   ("Virat", 80);
            EmployeeIenum  e2 = new EmployeeIenum    ("Ishan", 79);
            EmployeeIenum  e3  = new EmployeeIenum   ("Ashwin", 33);
            EmployeeIenum  e4 = new EmployeeIenum    ("Hardik", 88);


            int result = e2.CompareTo(e3);
            if (result == 1)
            {
                Console.WriteLine("rohit has more runs than ashwin");
            }
            else if (result == -1)
            {
                Console.WriteLine("rohit has less runs than ashwin");
            }
            else
            {
                Console.WriteLine("rohit & ashwin has same score");
            }
        }


    }



    public class Check : IComparer
    {
        public int Compare(object x, object y)
        {
             e1 = (EmployeeIenum)x;
            EmployeeIenum p4 = (EmployeeIenum)y;
            if (e1.salary > e4.salary)
            {
                return 1;
            }
            else if (p1.salary < p4.salary)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }

    }*/
    }


