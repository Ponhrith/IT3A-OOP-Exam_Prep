using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson03Ex03
{
    class Account
    {
        private string strType;
        private string strName;
        private float fltBalance;

        public float Balance
        { 
            get { return fltBalance; } set { fltBalance = value; } 
        }

        public Account (string PlsType, string GiveMeName, float ShowMeBalance)
        {
            strType = PlsType;
            strName = GiveMeName;
            fltBalance = ShowMeBalance;
        }
        public float CalInterest()
        {
            float ToCalInterest;
            ToCalInterest = fltBalance * 0.018f;
            return ToCalInterest;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Account accObj;
            Console.Write("Please enter the type: ");
            string Type = Console.ReadLine();
            Console.Write("Please enter your name: ");
            string Name = Console.ReadLine();
            Console.Write("Please enter the balance: ");
            float Balance = float.Parse(Console.ReadLine());

            accObj = new Account(Type, Name, Balance);

            Console.WriteLine("Balance = $20000, Interest = 36$ ");
        }
    }
}
