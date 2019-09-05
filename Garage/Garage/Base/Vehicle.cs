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


        /// <summary>
        /// Gives the ability for a vehicle to accelerate
        /// </summary>
        /// <param name="speed">int</param>
        public void Accelerate(int speed)
        {
            Console.WriteLine($"This vehicle is accelerating at a rate of {speed} mph");

        }


        /// <summary>
        /// Virtual method that should be ovverriden
        /// </summary>
        public virtual void RegistrationFees()
        {
            Console.WriteLine("Every Vehicle needs to be registered");
        }

    }
}
