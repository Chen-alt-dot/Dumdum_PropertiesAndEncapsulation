using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dumdum_PropertiesAndEncapsulation
{
    internal class Shoe
    {
        // Name: Christian Benedict P. Dumdum
        // Section: IT301
        // EXER_04: Basics on Encapsulation

        //Fields
        private string brand;
        private int size;


        //Public property for Brand
        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }

        //Public property for Size
        public int Size
        {
            get { return size; }
            set { size = value; }
        }

        //Method
        public void DisplayShoeInfo()
        {
            Console.WriteLine("Your Shoe Info!!!");
            Console.WriteLine($"Brand: {Brand}");
            Console.WriteLine($"Size: {Size}");
        }

    }
}
