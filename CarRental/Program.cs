using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Creating car. . .");

            Car c = new Car();
            c.RegistrationNumber = "ABC123";
            c.HorsePower = 170;
            c.color = "Black";

            Console.ReadKey();
            Console.WriteLine("Car Created!\n");
            
            Console.WriteLine("We have a {0} car with registration {1} and {2} hp.", c.color ,c.RegistrationNumber, c.HorsePower);
            Console.ReadKey();

        }
    }

    class Car
    {
        public string RegistrationNumber { get; set; }
        public string color { get; set; }
        public int HorsePower { get; set; }

    }
}
