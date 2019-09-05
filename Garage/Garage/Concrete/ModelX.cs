using Garage.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Garage.Concrete
{
    public class ModelX : Tesla
    {
        // Attribute(s)
        public bool IsSuv { get; set; } 


        /// <summary>
        /// Opens Falcon Wing Doors
        /// </summary>
        public void OpenFalconWingDoors()
        {
            Console.WriteLine("Falcon Wing Doors Opened");
        }

        /// <summary>
        /// Defines how much the Registration fees are for the vehicle. An override method
        /// </summary>
        public override void RegistrationFees()
        {
            Console.WriteLine("Model X Registration fees are $50");
        }
    }
}
