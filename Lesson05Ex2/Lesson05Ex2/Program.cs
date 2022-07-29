using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson05Ex2
{
    class Time
    {
        public int intHour;
        public int intMin;
        public int intSec;

        public Time()
        {

        }

        public Time(int Hour, int Min, int Sec)
        {
            this.intHour = Hour;
            this.intMin = Min;
            this.intSec = Sec;
        }

        public string GetTime()
        {
            
            return "3 hours 30 minutes and 50 seconds";
        }

        public string GetTime(string strType)
        {
            float ShowTime = 0;
            if (strType == "sec")
            {
                ShowTime = intHour * 3600 + intMin * 60 + intSec;
            }
            else if (strType == "min")
            {
                ShowTime = intHour * 60f + intMin + intSec / 60f;
            }
            else if (strType == "hour")
            {
               ShowTime = intHour + intMin / 60f + intSec / 3600f;
            }
            return ShowTime.ToString();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Time objTime1, objTime2;
            objTime1 = new Time();

            Console.WriteLine("Enter hour 1: ");
            float Hour1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter minute 1: ");
            float Min1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter second 1: ");
            int Sec1 = int.Parse(Console.ReadLine());

            objTime1.GetTime();

            Console.WriteLine("Enter hour 2: ");
            int Hour2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter minute 2: ");
            int Min2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second 2: ");
            int Sec2 = int.Parse(Console.ReadLine());

            objTime2 = new Time(Hour2, Min2, Sec2);

            Console.WriteLine("Time of objTime2: " + objTime2.GetTime("hour").ToString());
            Console.WriteLine("Time of objTime2: " + objTime2.GetTime("min").ToString());
            Console.WriteLine("Time of objTime2: " + objTime2.GetTime("sec").ToString());
        }
    }
}
