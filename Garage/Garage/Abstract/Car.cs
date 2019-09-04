using Garage.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Garage.Abstract
{
    public abstract class Car : Vehicle
    {
        public string Color { get; set; }
        public int Doors { get; set; }

        public void Drive()
        {
            Console.WriteLine("This car can drive!");
        }

        public void StartCar()
        {
            Console.WriteLine("This car can start!");
        }

    }
}
