using System;
using System.Collections.Generic;
using System.Text;

namespace Garage.Concrete
{
    public class ModelS : Tesla
    {
        // Attribute(s)
        public bool IsFast { get; set; } = true;


        /// <summary>
        /// Opens doors to the car
        /// </summary>
        public void OpenDoors()
        {
            Console.WriteLine("Tesla Model S Doors Opened");
        }


        /// <summary>
        /// Defines how much the Registration fees are for the vehicle. An override method
        /// </summary>
        public override void RegistrationFees()
        {
            Console.WriteLine("Model S Registration fees are $10");
        }
    }
}
