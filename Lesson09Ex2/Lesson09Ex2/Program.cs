using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson09Ex2
{
    class Supermarket
    {
        private string strSupermarketName = "Nice Supermarket";
        protected static int intCustomerCount;
        protected static float fltTotalSales;

        public string SupermarketName
        {
            get { return strSupermarketName; }
        }

        public Supermarket (string strSupermarketName)
        {
            this.strSupermarketName = strSupermarketName;
        }

        public static int CustomerCount
        {
            get { return intCustomerCount;  }
        }

        public static float TotalSales
        {
            get { return fltTotalSales; }
        }

    }

    class Customer : Supermarket
    {
        private string strCustomerName;
        private float fltExpense;
        public Customer(string strSupermarketName, string strCustomerName, float fltExpense)
            : base(strSupermarketName)
        {
            fltTotalSales += fltExpense;
            intCustomerCount++; 
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Customer objC1, objC2;

            Console.Write("Enter the Supermarket's Name 1: ");
            string supermarket = Console.ReadLine();
            Console.Write("Enter the customer name 1: ");
            string customer = Console.ReadLine();
            Console.Write("Enter the expense 1: ");
            float Expense = float.Parse(Console.ReadLine());
            objC1 = new Customer(supermarket, customer, Expense);
            Console.WriteLine("Supermarket name: {0}", objC1.SupermarketName);

            Console.Write("Enter the Supermarket's Name 2: ");
            supermarket = Console.ReadLine();
            Console.Write("Enter the customer name 2: ");
            customer = Console.ReadLine();
            Console.Write("Enter the expense 2: ");
            Expense = float.Parse(Console.ReadLine());
            objC2 = new Customer(supermarket, customer, Expense);
            Console.WriteLine("Supermarket name: {0}", objC2.SupermarketName);

            Console.WriteLine(Supermarket.CustomerCount);
            Console.WriteLine(Supermarket.TotalSales);

        }
    }
}
