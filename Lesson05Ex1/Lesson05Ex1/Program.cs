using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson05Ex1
{
    class Point
    {
        public float fltX;
        public float fltY;
        public float fltZ;
        private string strType;

        public Point (float X, float Y)
        {
            this.fltX = X;
            this.fltY = Y;
            this.strType = "2D";
        }

        public Point(float XX, float YY, float ZZ) 
        {
            this.fltX = XX;
            this.fltY = YY;
            this.fltZ = ZZ;
            this.strType = "3D";
            
        }
        public void DisplayCoordinates()
        {
            if (strType == "2D")
            {
                Console.WriteLine("2D: X = {0}, Y = {1}", fltX, fltY);
            }
            else if (strType == "3D")
            {
                Console.WriteLine("3D: X = {0}, Y = {1}, Z = {2}", fltX, fltY, fltZ);
            }
        }
        
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Point objP1, objP2;
            Console.WriteLine("Enter x1: ");
            float X = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter y1: ");
            float Y = float.Parse(Console.ReadLine());
            objP1 = new Point(X, Y);
            objP1.DisplayCoordinates();

            Console.WriteLine("Enter x2: ");
            X = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter y2: ");
            Y = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter z2: ");
            float Z = float.Parse(Console.ReadLine());

            objP2 = new Point(X, Y, Z);
            objP2.DisplayCoordinates();


        }
    }
}
