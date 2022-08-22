using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson07Example
{
    class School
    {
        public string strSchoolName;
        private string strAddress;

        public string Address
        {
            get{ return strAddress; }
        }

        public School(string strSchoolName, string strAddress)
        {
            this.strSchoolName = strSchoolName;
            this.strAddress = strAddress;
        }
    }
    
    class Student : School
    {
        public string strStudentName;
        private float fltSchoolFees;

        public float SchoolFees
        {
            get{ return fltSchoolFees; }
            set { fltSchoolFees = value; }
        }

        public Student(string strStudentName, string Address, string strStudentName, float SchoolFees)
            :base (strStudentName, Address)
        {
            this.strStudentName = strStudentName;
            this.SchoolFees = SchoolFees;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student objS1;

            Console.Write("Enter the school name: ");
            string schoolname = Console.ReadLine();
            Console.Write("Enter the school address: ");
            string address = Console.ReadLine();
            Console.Write("Enter the student name: ");
            string studentname = Console.ReadLine();
            Console.Write("Enter the school fees: ");
            float fees = float.Parse(Console.ReadLine());

            objS1 = new Student(schoolname, address, studentname, fees);

            Console.WriteLine("School name: " + objS1.strSchoolName + "\nSchool Address: " + objS1.Address + "\nStudent Name: " + objS1.strStudentName + "\nSchool fees" + objS1.SchoolFees);
        }
    }
}
