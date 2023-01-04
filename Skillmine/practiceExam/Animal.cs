using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skillmine.practiceExam
{

    class Animal
    {
        public virtual void show()
        {
            Console.WriteLine("Base class");
        }
    }

    class Dog : Animal
    {
        public override void show()
        {
            Console.WriteLine("Derived class");
        }
    }
    class Main_Method
        {
            /*public static void Main(string []args)
            {
                Animal d = new Animal();
                d.show();

               Dog b = new Dog();
                b.show();
            }*/
        }
}
