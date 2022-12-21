using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skillmine.practiceExam
{
    public class Employee
    {
        protected int empid;
       protected string empname;
        protected  double basic, hra, da, pf, gross;
       
        public Employee(int empid ,string empname, double basic)
        {
            
            this.empid = empid;
            this.empname = empname;
            this.basic = basic;
        }
        public  void CalculateSalary()
        {
            hra = basic * 0.40;
            da = basic * 0.20;
            pf = basic * 0.12;
            gross = (basic + hra + da) - pf;
        }
       
        public override string ToString()
        {
            return $"Employee id {empid}, emp name {empname} & gross salary of emp {gross}";
        }

        public double GetGrossSalary()
        {
            return gross;
        }

     }

    public class SalesManager : Employee
    {
        private double bonus, comm;
        private double food;
        public SalesManager(int id, string name, double bs, double food, double bonus, double comm) : base( id,name, bs)
        {
            this.food = food;
            this.comm = comm;
            this.bonus = bonus;
        }
        public new void CalculateSalary()
        {
            hra = basic * 0.40;
            da = basic * 0.20;
            pf = basic * 0.12;
            comm = basic * 0.15;
            bonus = basic * 0.13;
            gross = (basic + hra + da + food+comm+bonus) - pf;
        }

        public override string ToString()
        {
            return $"Employee id {empid}, emp name {empname} & gross salary of Salesmanager {gross}";
        }

    }

    public class Manager : Employee
    {
        private double food;
        public Manager(int id, string name, double bs, double food) : base(id, name, bs)
        {
            this.food = food;
        }
        public new void CalculateSalary()
        {
            hra = basic * 0.40;
            da = basic * 0.20;
            pf = basic * 0.12;
            gross = (basic + hra + da + food) - pf;
        }

        public override string ToString()
        {
            return $"Employee id {empid}, emp name {empname} & gross salary of manager {gross}";
        }
    }




}
