using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson07Ex2
{
    class Hospital
    {
        private string strHospitalName;
        public string HospitalName
        {
            get { return strHospitalName; }
        }

        public Hospital(string strHospitalName)
        {
            this.strHospitalName = strHospitalName;
        }
    }

    class Doctor : Hospital
    {
        public string strDoctorName;
        private float fltFees;

        public float Fees
        {
            get { return fltFees; }
        }

        public Doctor(string strHospitalName, string strDoctorName, float fltFees)
            : base(strHospitalName)
        {
            this.strDoctorName = strDoctorName;
            this.fltFees = fltFees;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Doctor objDoc;

            Console.Write("Enter the hospital name: ");
            string hospital = Console.ReadLine();
            Console.Write("Enter the doctor name: ");
            string doctor = Console.ReadLine();
            Console.Write("Enter the fees: ");
            float fees = float.Parse(Console.ReadLine());

            objDoc = new Doctor(hospital, doctor, fees);

            Console.WriteLine("Hospital Name: " + objDoc.HospitalName + "\nDoctor Name: " + objDoc.strDoctorName + "\nFees: " + objDoc.Fees);

        }
    }
}
