using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson09Ex1
{
    internal class Program
    {
        class Cinema
        {
            private string strCinema;
            protected static int intTicketSold;
            protected static float fltTicketSales;

            public string CinemaName
            {
                get { return strCinema; }
            }

            public Cinema (string strCinemaName)
            {
                this.strCinema = strCinemaName;
            }

        }

        class Ticket : Cinema
        {
            
        }
        static void Main(string[] args)
        {

        }
    }
}
