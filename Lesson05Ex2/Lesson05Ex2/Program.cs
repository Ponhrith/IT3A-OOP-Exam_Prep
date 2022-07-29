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

        public Time(int intHour, int intMin, int intSec)
        {
            this.intHour = intHour;
            this.intMin = intMin;
            this.intSec = intSec;
        }

        public string GetTime()
        {
            string strReturn = (intHour.ToString() + " hours " + intMin.ToString() + " minutes " + intSec.ToString() + " seconds");
            return strReturn;
        }

        public string GetTime(string strType)
        {
            if (strType == "sec")
            {
                intSec = intHour * 3600 + intMin * 60 + intSec;
            }
            else if (strType == "min")
            {
                intMin = intHour * 60f + intMin + intSec / 60f;
            }
            else if (strType == "hour")
            {
                intHour = intHour + intMin / 60f + intSec / 3600f;
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
