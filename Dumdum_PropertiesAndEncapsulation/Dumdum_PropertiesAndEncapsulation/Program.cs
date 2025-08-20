using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dumdum_PropertiesAndEncapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Instantiate a shoe object
            Shoe shoe1 = new Shoe();

            //Setting Values for properties
            shoe1.Brand = "JORDAN";
            shoe1.Size = 10;

            //Display the shoe's details
            shoe1.DisplayShoeInfo();

            Console.ReadKey();
        }
    }
}
