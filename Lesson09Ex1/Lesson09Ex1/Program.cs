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
            private string strCinemaName;
            protected static int intTicketSold;
            protected static float fltTicketSales;

            public string CinemaName
            {
                get { return strCinemaName; }
            }

            public Cinema (string strCinemaName)
            {
                this.strCinemaName = strCinemaName;
            }

            public static int TicketSold
            {
                get { return intTicketSold; }
            }

            public static float TicketSales
            {
                get { return fltTicketSales; }
            }
        }

        class Ticket : Cinema
        {
            private string strMovie;
            private float fltTicketPrice;
            public Ticket (string strCinemaName,string strMovie, float fltTicketPrice)
                : base (strCinemaName)
            {
                fltTicketSales += fltTicketPrice;
                intTicketSold++; 
            }
        }
        static void Main(string[] args)
        {
            Ticket objT1, objT2;

            Console.Write("Enter the cinema's name 1: ");
            string cinema = Console.ReadLine();
            Console.Write("Enter the name of the movie 1: ");
            string movie = Console.ReadLine();
            Console.Write("Enter the price 1: ");
            float price = float.Parse((Console.ReadLine()));
            objT1 = new Ticket(cinema, movie, price);
            Console.WriteLine("Cinema Name: {0}", objT1.CinemaName);
            

            Console.Write("Enter the cinema's name 2: ");
            cinema = Console.ReadLine();
            Console.Write("Enter the name of the movie 2: ");
            movie = Console.ReadLine();
            Console.Write("Enter the price 2: ");
            price = float.Parse((Console.ReadLine()));
            objT2 = new Ticket(cinema, movie, price);
            Console.WriteLine("Cinema Name: {0}", objT.CinemaName);

            Console.WriteLine(Cinema.TicketSold);
            Console.WriteLine(Cinema.TicketSales);

        }
    }
}
