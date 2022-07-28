using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson06Ex2
{
    class Patient
    {
        public string strPatientName;
        public float fltFees;
        private static int intTotalPatients;
        private static float fltTotalFees;
        public static int TotalPatients()
        {
            return Patient.intTotalPatients;
        }

        public static float TotalFees()
        {
            return Patient.fltTotalFees;
        }

        public Patient(string strPatientName, float fltFees)
        {
            this.strPatientName = strPatientName;
            this.fltFees = fltFees;
            intTotalPatients++;
            fltTotalFees = fltFees + fltTotalFees;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Patient objPatient1, objPatient2;
            Console.WriteLine("Enter the name of Patient 1: ");
            string strPatientName = Console.ReadLine();
            Console.WriteLine("Enter the fees for Patient 1: ");
            float fltFees = float.Parse(Console.ReadLine());
            objPatient1 = new Patient(strPatientName, fltFees);

            Console.WriteLine("Enter the name of Patient 2: ");
            strPatientName = Console.ReadLine();
            Console.WriteLine("Enter the fees for Patient 2: ");
            fltFees = float.Parse(Console.ReadLine());
            objPatient2 = new Patient(strPatientName, fltFees);

            Console.WriteLine("Patient 1 Name: {0}  Fees: {1}",
                objPatient1.strPatientName, objPatient1.fltFees);
            Console.WriteLine("Patient 2 Name: {0}  Fees: {1}",
                objPatient2.strPatientName, objPatient2.fltFees);

            Console.WriteLine("Total number of patient = {0}.", Patient.TotalPatients());
            Console.WriteLine("Total fees = {0}.", Patient.TotalFees());


        }
    }
}
