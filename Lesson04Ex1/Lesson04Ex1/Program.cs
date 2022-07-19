using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson04Ex1
{
    class Vehicle
    {
        private string strModel;
        private float fltPrice;

        public Vehicle(string strModel, float fltPrice)
        {
            this.strModel = strModel;
            this.fltPrice = fltPrice;
        }

        public float GetPrice(float coe)
        {
            coe = coe + fltPrice;
            return fltPrice;
        }
        public float GetPrice(string cat)
        {
            if (cat == "A")
            {
                fltPrice = fltPrice + 30000f;
            }
            else if (cat == "B")
            {
                fltPrice = fltPrice + 39000f;
            }
            else if (cat == "C")
            {
                fltPrice = fltPrice + 31000f;
            }
            return fltPrice;
        }

        
    }

    
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the model1: ");
            string Model = Console.ReadLine();
            Console.Write("Enter the price1: ");
            float Price = float.Parse(Console.ReadLine());

            Vehicle v1Obj = new Vehicle(Model, Price);

            Console.Write("Enter the coe: ");
            Console.WriteLine("The price is: " + v1Obj.GetPrice("coe").ToString());

            Console.Write("Enter the model2: ");
            Model = Console.ReadLine();
            Console.Write("Enter the price2");
            Price = float.Parse(Console.ReadLine());
            
            Vehicle v2Obj = new Vehicle(Model, Price);

            Console.Write("Enter the cat: ");
            Console.WriteLine("The price is: " + v2Obj.GetPrice("cat").ToString());
            
        }
    }
}
