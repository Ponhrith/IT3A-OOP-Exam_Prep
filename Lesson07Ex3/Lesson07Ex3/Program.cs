using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson07Ex3
{
    class Shape
    {
        public string strOutline;
        private string strFill;

        public string Fill
        {
            get { return strFill; } 
            set { strFill = value; }
        }
        public Shape(string strOutline, string strFill)
        {
            this.strOutline = strOutline;
            this.strFill = strFill;            
        }
    }
    class Triangle : Shape
    {
        private float fltBase;
        private float fltHeight;

        public float Base
        {
            get { return fltBase; }
            set { fltBase = value; }
        }

        public float Height
        {
            get { return fltHeight; } 
            set { fltHeight = value; }
        }

        public float fltArea
        {
            get { return 0.5f*fltBase*fltHeight; }
        }
        public Triangle(string strOutline, string strFill, float fltBase, float fltHeight)
            :base(strOutline, strFill)
        {
            this.fltBase = fltBase;
            this.fltHeight = fltHeight;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Triangle objTriangle;

            Console.Write("Enter the outline: ");
            string outline = Console.ReadLine();
            Console.Write("Enter the fill: ");
            string fill = Console.ReadLine();
            Console.Write("Enter the base: ");
            float Base = float.Parse(Console.ReadLine());
            Console.Write("Enter the height: ");
            float height = float.Parse(Console.ReadLine());

            objTriangle = new Triangle(outline, fill, Base, height);

            Console.WriteLine("Outline: " + objTriangle.strOutline + "\nFill: " + objTriangle.Fill + "\nBase: " + objTriangle.Base + "\nHeight: " + objTriangle.Height + "\nArea: "+ objTriangle.fltArea);

        }
    }
}
