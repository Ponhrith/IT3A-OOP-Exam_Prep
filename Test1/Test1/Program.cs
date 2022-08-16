using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    class ComputerBrand
    {
        public string strBrandName;
        private float fltPrice;
        public float Price
        {
            get { return fltPrice; }
        }

        public static float fltTotalPrice = 0.0f;
        
        public ComputerBrand(string strBrandName, float fltPrice)
        {
            this.strBrandName = strBrandName;
            this.fltPrice = fltPrice;
            fltTotalPrice += fltPrice;
        }
        public string GetInfo()
        {
            return ("Computer brand: " + strBrandName + "Price" + Price.ToString());         
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            ComputerBrand ComObj1, ComObj2;
            Console.Write("Enter computer brand #1: ");
            string ComBrand = Console.ReadLine();
            Console.Write("Enter price of computer #1: ");
            float price = float.Parse(Console.ReadLine());
            ComObj1 = new ComputerBrand(ComBrand, price);

            Console.Write("Enter computer brand #2: ");
            ComBrand = Console.ReadLine();
            Console.Write("Enter price of computer #2: ");
            price = float.Parse(Console.ReadLine());
            ComObj2 = new ComputerBrand(ComBrand, price);

            Console.WriteLine("SHOPPING CART: {0}", ComObj1.GetInfo());

            Console.WriteLine("SHOPPING CART: {0}", ComObj2.GetInfo());

            Console.WriteLine("The total price is {0}", ComputerBrand.fltTotalPrice);
        }
    }
}
