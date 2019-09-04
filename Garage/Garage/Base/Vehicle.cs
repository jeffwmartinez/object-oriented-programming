using System;
using System.Collections.Generic;
using System.Text;

namespace Garage.Base
{
    public abstract class Vehicle
    {
        // Attributes
        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int NumberOfWheels { get; set; }

        // Methods
        public void Accelerate(int speed)
        {
            Console.WriteLine($"This vehicle is accelerating at a rate of {speed} mph");

        }

        public virtual void RegistrationFees()
        {
            Console.WriteLine("Every Vehicle needs to be registered");
        }

    }
}
