using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Nhep_Ponhrith_text1
{
    internal class Program
    {
        class ComputerBrand
        {
            public string strBrandName;
            private float fltPrice;
            public static float fltTotalPrice()
            {

                return 0.0f;
            }

            public ComputerBrand(string strBrandName, float fltPrice)
            {
                this.strBrandName = strBrandName;
                this.fltPrice = fltPrice;
                fltTotalPrice = fltPrice + fltTotalPrice();
            }

            public float Price
            {
                get { return fltPrice; }
            }

            public string GetInfo()
            {
                return ("Computer brand: " + strBrandName + "Price: " + fltPrice);
            }
        }
        static void Main(string[] args)
        {
            ComputerBrand ComObj1, ComObj2;

            Console.Write("Enter computer brand 1: ");
            string BrandName = Console.ReadLine();
            ComObj1 = new ComputerBrand(BrandName);

            Console.Write("Enter computer brand 2: ");
            string BrandName2 = Console.ReadLine();
            ComObj2 = new ComputerBrand(BrandName2);

            Console.WriteLine("SHOPPING CART: = {0} Price: = {1}", ComObj1.GetInfo(), Price);
            Console.WriteLine("SHOPPING CART: = {0} Price: = {1}", ComObj2.GetInfo(), Price);

            Console.WriteLine("The total price is = ${0}", (ComObj1 + ComObj2).fltTotalPrice());


            
        }
    }
}
