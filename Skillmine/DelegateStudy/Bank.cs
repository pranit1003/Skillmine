using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skillmine.DelegateStudy.DelegateStudy
{ 
    public delegate void MyDelegate();
     
        public class Bank
        {
            public event MyDelegate Insufficient;
            public event MyDelegate Zero;
            private double balance;

            public Bank(double balance)
            {
                this.balance = balance;
            }
            public void credit(double creditamount)
            {
                balance = balance + creditamount;
            }
            public void Debit(double debitamount)
            {
                if (debitamount > balance)
                {
                    Insufficient();
                }
                else
                {
                    balance = balance - debitamount;
                    if (balance == 0)
                    {
                        Zero();
                    }
                }
            }

            public override string ToString()
            {
                return $"Current balance is {balance}";
            }

        }
        public static class Message
        {
            public static void InsufficientBalance()
            {
                Console.WriteLine("Insufficient Amount to withdraw..");
            }
            public static void Zerobalance()
            {
                Console.WriteLine("Current Balance is Zero ..");
            }
        }

        public class Banking
        {
            /*static void Main(string[] args)
            {
                Bank b = new Bank(5000);
                b.Insufficient += new MyDelegate(Message.InsufficientBalance);
                b.Zero += new MyDelegate(Message.Zerobalance);

                Console.WriteLine("Credit of 1000");
                b.credit(1000);
                Console.WriteLine(b);

                Console.WriteLine("Debit 15000");
                b.Debit(15000);
                Console.WriteLine(b);

                Console.WriteLine("debit 6000");
                b.Debit(6000);
                Console.WriteLine(b);
            }
*/
        }
    }


