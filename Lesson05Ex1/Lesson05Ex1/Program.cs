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

        public Point (float fltX, float fltY)
        {
            this.fltX = fltX;
            this.fltY = fltY;
        }

        public Point(float fltX, float fltY, float fltZ) 
        {
            this.fltX = fltX;
            this.fltY = fltY;
            this.fltZ = fltZ;
            
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
