﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson07Example
{
    class School //base class
    {
        public string strSchoolName;
        private string strAddress; //private is a default, even if we're not mentioned
        public string Address
        {
            get {return strAddress;}
            set {  strAddress = value; }
        }
        public School(string strSchoolName, string strAddress)
        {
            this.strSchoolName = strSchoolName;
            this.strAddress = strAddress;
            
        }
    }
    class Student : School //part d, //derive class
    {
        public string strStudentName;
        private float fltSchoolFees;

        public float SchoolFees
        {
            get { return fltSchoolFees; }
            set { fltSchoolFees = value; }
        }
        public Student(string strStudentName, float fltSchoolFees, string strSchoolName, string strAddress): base(strSchoolName, strAddress)//4 variables, 2 from school
        { 
            this.strStudentName=strStudentName;
            this.fltSchoolFees = fltSchoolFees;
            //SchoolFees = fltSchoolFees;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student objS1;
            Console.Write("Enter the school: ");
            string mySchool = Console.ReadLine();
            Console.Write("Enter the address: ");
            string myAddress = Console.ReadLine();
            Console.Write("Enter the name of the student:");
            string myName = Console.ReadLine();
            Console.Write("Enter the school fee: ");
            float mySchoolFees = float.Parse(Console.ReadLine());


            objS1 = new Student(myName, mySchoolFees, mySchool, myAddress);
            Console.WriteLine("School name: {0}", objS1.strSchoolName);
            Console.WriteLine("Address: {0}", objS1.Address);
            Console.WriteLine("Student Name: {0}", objS1.strStudentName);
            Console.WriteLine("School Fees: {0}", objS1.SchoolFees);
        }
    }
}