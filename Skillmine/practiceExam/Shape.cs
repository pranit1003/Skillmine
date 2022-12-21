using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skillmine.practiceExam
{
    abstract public class Shape
    {
      public abstract void CalculateArea();
    }

    public class Circle : Shape
    {
        private int r;
        private double area;
        public Circle(int r)
        {
            this.r = r;
        }

        public override void CalculateArea()
        {
            area = 3.14 * r * r;
        }
        public override string ToString()
        {
            return $"area of circle is {area}";
        }
    }
    public class Rectangle : Shape
    {
        private int l, w;
        private double area;
        public Rectangle(int l , int w)
        {
            this.l = l;
            this.w = w;
        }
        public override void CalculateArea()
        {
            area = l * w;
        }
        public override string ToString()
        {
            return $"area of Rectangle is {area}";
        }
    }

}

