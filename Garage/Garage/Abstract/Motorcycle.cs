using Garage.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Garage.Abstract
{
    public abstract class Motorcycle : Vehicle
    {
        // Attribute(s)
        public virtual bool Kickstart { get; set; }
        public string Handlebars { get; set; }


        /// <summary>
        /// Uses the Front Brakes to slow down the Motorcycle
        /// </summary>
        public void FrontBrake()
        {
            Console.WriteLine("Front Brakes activated");
        }
        
    }
}
