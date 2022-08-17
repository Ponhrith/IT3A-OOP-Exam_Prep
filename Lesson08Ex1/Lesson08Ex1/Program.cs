using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson08Ex1
{
    class ElectronicsShop
    {
        private string strShopname;

        public string ShopName
        {
            get { return strShopname; }
            set { strShopname = value; }
        }

        public ElectronicsShop(string strShopName)
        {
            this.strShopname = strShopName;
        }

        public virtual string GetDiscout()
        {
            return "0%";
        }
    }

    class Computer : ElectronicsShop
    {
        private string strBrand;
        public string Brand
        {
            get { return strBrand; }
            set { strBrand = value; }
        }

        public Computer(string strShopName, string strBrand)
            :base(strShopName)
        {
            this.strBrand = strShopName;
            this.strBrand = strBrand;
        }

        public override string GetDiscout()
        {
            return ("10% discount");
        }
    }

    class Phone : ElectronicsShop
    {
        private string strModel;

        public string Model
        {
            get { return strModel; }
            set { strModel = value; }
        }

        public Phone(string strShopName, string strModel)
            : base(strShopName)
        {
            this.strModel = strModel;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Computer objCom;

            Console.Write("Enter the computer brand: ");
            string brand = Console.ReadLine();
            Console.Write("Enter the shop name: ");
            string shop = Console.ReadLine();
            objCom = new Computer(brand, shop);
            Console.WriteLine("This computer gets discount {0}", objCom.GetDiscout());
            

            Phone objPhone;
            Console.Write("Enter the phone model: ");
            string model = Console.ReadLine();
            Console.Write("Enter the shop name: ");
            shop = Console.ReadLine();
            objPhone = new Phone(brand, shop);
            Console.WriteLine("This phone gets discount {0}", objCom.GetDiscout());


        }
    }
}
