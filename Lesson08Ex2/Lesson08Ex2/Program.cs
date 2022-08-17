using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson08Ex2
{
    class Picture
    {
        private string strTitle;
        private float fltPrice;

        public string Title
        {
            get { return strTitle; }
            set { strTitle = value; }
        }

        public float Price
        {
            get { return fltPrice; }
            set { fltPrice = value; }
        }

        public Picture(string strTitle, float fltPrice)
        {
            this.strTitle = strTitle;
            this.fltPrice = fltPrice;
        }

        public virtual float GetPrice()
        {
            return fltPrice;
        }

    }

    class Photograph : Picture
    {
        private string strPhotographer;
        private string strCamera;

        public string Photographer
        {
            get { return strPhotographer; }
            set { string strPhotographer = value; }
        }

        public string Camera
        {
            get { return strCamera; }
            set { string strCamera = value; }
        }

        public Photograph(string strPhotographer, string strCamera, string strTitle , float fltPrice)
            :base (strTitle, fltPrice)
        {
            this.strPhotographer = strPhotographer;
            this.strCamera = strCamera;            
        }

        public override float GetPrice()
        {
            //float fltPrice =+ 30f;
            return Price += 30f;
        }
            
    }
    class Painting : Picture
    {
        private string strArtist;
        private string strType;

        public string Artist 
        { 
            get { return strArtist; } 
            set { strArtist = value; } 
        }

        public string Type
        {
            get { return strType; }
            set { string type = value; }
        }

        public Painting(string strArtist, string strType, string strTitle, float fltPrice)
            : base(strTitle, fltPrice)
        { 
            this.strArtist = strArtist;
            this.strType = strType;
        }

        public override float GetPrice()
        {
            
            return Price +=50f;
        }
    }

    
    internal class Program
    {
        static void Main(string[] args)
        {
            Photograph objPhoto;

            Console.Write("Enter the photographer's name: ");
            string photographer = Console.ReadLine();
            Console.Write("Enter the camera: ");
            string camera = Console.ReadLine();
            Console.Write("Enter the title of the photo: ");
            string title = Console.ReadLine();
            Console.Write("Enter the price of the photo: ");
            float price = float.Parse(Console.ReadLine());
            objPhoto = new Photograph(photographer, camera, title, price);

            Console.WriteLine("The price of the photo is {0}" +"$", objPhoto.GetPrice());

            Painting objPainting;

            Console.Write("Enter the artist's name: ");
            string artist = Console.ReadLine();
            Console.Write("Enter the type of painting: ");
            string type = Console.ReadLine();
            Console.Write("Enter the title of the painting: ");
            title = Console.ReadLine();
            Console.Write("Enter the price of the painting: ");
            price = float.Parse(Console.ReadLine());

            objPainting = new Painting(photographer, camera, title, price);

            Console.WriteLine("The price of the painting is {0}" + "$", objPainting.GetPrice());
        }
    }
}
