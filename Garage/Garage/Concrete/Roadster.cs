using Garage.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Garage.Concrete
{
    public class Roadster : Harley
    {
        // Attribute(s)
        public bool IsModern { get; set; }


        /// <summary>
        /// Defines how much the Registration fees are for the vehicle. An override method
        /// </summary>
        public override void RegistrationFees()
        {
            Console.WriteLine("Roadster Registration fees are $10");
        }
    }
}
