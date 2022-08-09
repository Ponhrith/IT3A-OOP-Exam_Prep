using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson08Example
{
    class PetShop
    {
        private string strPetShopName;
        private string strAddress;
        public string Address
        {
            get { return strAddress; }
            set { strAddress = value; }
        }
        public PetShop(string strPetShopName, string strAddress)
        {
            this.strPetShopName = strPetShopName;
            this.strAddress = strAddress;
        }
        public string PetShopInfo()
        {
            return ("Pet Shop Name: " +
                strPetShopName + "Address: " + strAddress);

        }
        public virtual string Sound()
        {
            return ("The animal makes a sound");
        }

    }
    class Dog : PetShop
    {
        private string strName;
        public string Name
        {
            get { return strName; }
            set { strName = value; }
        }
        public Dog (string strPetShopName, string strAddress, string strName): base(strPetShopName, strAddress)
        {
            this.strName = strName;
        }
        public override string Sound()
        {
            return ("My dog barks");
        }
       

    }

    class Cat : PetShop
    {
        private string strName;
        public string NameCat
        {
            get { return strName; }
            set { strName = value; }
        }
        public Cat(string strPetShopName, string strAddress, string strName) : base(strPetShopName, strAddress)
        {
            this.strName = strName;
        }
        public override string Sound()
        {
            return ("My cat meow");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the name of the dog: ");
            string MyBestPet = Console.ReadLine();
            Console.Write("Enter the name of the pet shop: ");
            string ILovePet = Console.ReadLine();
            Console.Write("Enter the address: ");
            string PetShopAddress = Console.ReadLine();

            Dog objDog = new Dog(ILovePet, PetShopAddress, MyBestPet);
            Console.WriteLine("Pet Shop Name: {0}, Address: {1}", objDog.PetShopName, objDog.Address);
            Console.WriteLine("The animal makes a sound {0}", objDog.Sound());


            Cat objCat;
            Console.Write("Enter the name of the cat: ");
            string CatPet = Console.ReadLine();
            Console.Write("Enter the name of the pet shop: ");
            string PetShop = Console.ReadLine();
            Console.Write("Enter the address: ");
            string pet_Saddr = Console.ReadLine();

            objCat = new Cat(CatPet, PetShop, pet_Saddr);
            Console.WriteLine("Pet Shop Name for Cat: {0}, Address for Cat: {1}", objCat.NameCat, objCat.Address);
            Console.WriteLine("The cat makes sound {0}", objCat.Sound());

        }
    }
}
