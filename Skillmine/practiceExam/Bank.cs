using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skillmine.practiceExam
{
    class Bank
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    public class Saving
    {
        public int CostumerId { get; set; }
        public string CostumerName { get; set; }
        public int AccoubtName { get; set; }
        public List<Saving> Banklist = new List<Saving>();
    }
    public class Current
    {
        public int CostumerId { get; set; }
        public string CostumerName { get; set; }
        public int AccoubtName { get; set; }

    }
    public class Loan
    {
        public int CostumerId { get; set; }
        public string CostumerName { get; set; }
        public int LoanAmount { get; set; }
    }

    public class Costumer
    {
        public int AcountNo { get; set; }
        public string Name { get; set; }
        public string TypeofLoan { get; set; }
        public List<Loan> Loanlist = new List<Loan>();
        public List<Current> CurrentAcc = new List<Current>();
        public List<Saving> SavingAcc = new List<Saving>();
    }

    public class Program11
    {
        /*static void Main(string[] args)
        {
           List<Costumer> Costumers = new List<Costumer>();

            new Costumer
            {
                AcountNo = 10234,
                Name = "Pranit",
                TypeofLoan = "Current"
            };

            foreach (Costumer c in Costumers)
            {
              
            }
        }*/
    }
}

    
