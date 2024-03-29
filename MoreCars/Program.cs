﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreCars
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Collections.ArrayList Cars = new System.Collections.ArrayList();

            Car c = new Car();
            c.Brand = "Volvo";
            c.Model = "V70";

            Cars.Add(c);

            Car d = new Car() { Brand = "Audi", Model = "A4", Color = "White" };
            Cars.Add(d);

            Cars.Add(new Car() { Brand = "BMW", Model = "X7", Color = "Dark Blue" });
            Cars.Add(new Car() { Brand = "BMW", Model = "X6", Color = "Black" });
            Cars.Add(new Car() { Brand = "Ford", Model = "Galaxy", Color = "Olive Green" });

            Console.WriteLine("Vi har {0} bilar just nu", Cars.Count);

            foreach (Car anka in Cars) {
                Console.WriteLine("{0} {1} ({2})", anka.Brand , anka.Model , anka.Color);
            }

        }
    }
}
