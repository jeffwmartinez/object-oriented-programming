using Garage.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Garage.Abstract
{
    public abstract class Car : Vehicle
    {
        // Attribute(s)
        public string Color { get; set; }
        public int Doors { get; set; }


        /// <summary>
        /// Allows the car to start up
        /// </summary>
        public void Start()
        {
            Console.WriteLine("This car can start!");
        }


        /// <summary>
        /// Allows the car to drive
        /// </summary>
        public void Drive()
        {
            Console.WriteLine("This car can drive!");
        }


       

    }
}
