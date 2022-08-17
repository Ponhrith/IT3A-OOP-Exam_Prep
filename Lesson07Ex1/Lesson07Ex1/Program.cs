using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson07Ex1
{
    class Animal
    {
        private string strCountry;
        public string Country
        {
            get { return strCountry; }
        }

        public Animal(string strCountry)
        {
            this.strCountry = strCountry;
        }
    }

    class Cat : Animal
    {
        public string strSpecies;
        private int intNumber;

        public int Number
        {
            get { return intNumber; }
        }

        public Cat(string strCountry, string strSpecies, int intNumber)
            : base(strCountry)
        {
            this.strSpecies = strSpecies;
            this.intNumber = intNumber;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Cat objCat;

            Console.Write("Enter the country: ");
            string country = Console.ReadLine();
            Console.Write("Enter the species: ");
            string species = Console.ReadLine();
            Console.Write("Enter the number: ");
            int number = int.Parse(Console.ReadLine());

            objCat = new Cat(country, species, number);

            Console.WriteLine("Country: " + objCat.Country + "\nSpecies: " + objCat.strSpecies + "\nNumber: " + objCat.Number);
        }
    }
}
