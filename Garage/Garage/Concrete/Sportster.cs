using Garage.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Garage.Concrete
{
    public class Sportster : Harley
    {
        // Attribute(s)
        public bool IsVintage { get; set; }


        /// <summary>
        /// Defines how much the Registration fees are for the vehicle. An override method
        /// </summary>
        public override void RegistrationFees()
        {
            Console.WriteLine("Sportster Registration fees are $10");
        }

    }
}
