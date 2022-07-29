using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson03Ex2
{
    class Circle
    {
        private float fltRadius;

        public float Area
        {
            get { return fltRadius; }
            
        }

        public Circle(float GiveMeRadius)
        {
            fltRadius = GiveMeRadius;
        }

        public float Circumference()
        {
            float ToCircumference;
            ToCircumference = 2 * 3.1416f * fltRadius;
            return ToCircumference;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle c1, c2;
            Console.WriteLine("Enter the radius of Circle 1: ");
            float fltRadius = float.Parse(Console.ReadLine());
            c1 = new Circle(fltRadius);

            Console.WriteLine("Enter the radius of Circle 2: ");
            fltRadius = float.Parse(Console.ReadLine());
            c2 = new Circle(fltRadius);
            //c1.Circumference();
            //c2.Circumference();

            Console.WriteLine("Total Area of the Circles = {0}", Circle.Area());
            Console.WriteLine("Total Circumference of the Circles = {0}", Circle.Circumference());
        }
    }
}
