using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson03Ex4
{
    class HomeAppliance
    {
        private string strBrand;
        private string strModel;
        private float fltPrice;

        public float Price
        {
            get { return fltPrice; }
        }

        public HomeAppliance(string GiveBrand, string GiveModel, float GivePrice)
        {
            strBrand = GiveBrand;
            strModel = GiveModel;
            fltPrice = GivePrice;
        }
        
        public float GetDiscountedPrice()
        {
            float ToDiscount;
            ToDiscount = fltPrice *0.90f;
            return ToDiscount;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            HomeAppliance happyObj;
            Console.Write("Enter the brand: ");
            string Brand = Console.ReadLine();
            Console.Write("Enter the model: ");
            string Model = Console.ReadLine();
            Console.Write("Enter the price: ");
            float Price = float.Parse(Console.ReadLine());

            happyObj = new HomeAppliance(Brand, Model, Price);
            happyObj.GetDiscountedPrice();

            Console.WriteLine("Price before discount = ${0} Price after discount = ${1}", Price, happyObj.GetDiscountedPrice());
        }
    }
}
