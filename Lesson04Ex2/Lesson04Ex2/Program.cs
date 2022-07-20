using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson04Ex2
{
    class Computer
    {
        private string strBrand;
        private float fltPrice;

        public Computer(string strBrand, float fltPrice)
        {
            this.strBrand = strBrand;
            this.fltPrice = fltPrice;
        }

        public float UpdatePrice()
        {
            return fltPrice;
        }

        public float UpdatePrice(string model)
        {
            if (model == "IdeaPad")
            {
                fltPrice = fltPrice * 0.10f;
            }
            else if (model == "Aspire")
            {
                fltPrice = fltPrice * 0.20f;
            }
            else if (model == "ZBook")
            {
                fltPrice = fltPrice * 0.30f;
            }
            return fltPrice;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the brand: ");
            string Brand = Console.ReadLine();
            Console.Write("Enter the price: ");
            float Price = float.Parse(Console.ReadLine());

            Computer cObj = new Computer(Brand, Price);

            Console.WriteLine("The update price is: " + cObj.UpdatePrice().ToString());

            Console.Write("Enter the model: ");
            string model = Console.ReadLine();

            Console.WriteLine("The price is: " + cObj.UpdatePrice("model").ToString());

        }
    }
}
