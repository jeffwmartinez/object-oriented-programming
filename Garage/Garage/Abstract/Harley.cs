using Garage.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Garage.Abstract
{
    public class Harley : Motorcycle
    {
        // Attribute(s)
        public bool IsBlack { get; set; }


        /// <summary>
        /// Make harley sounds
        /// </summary>
        public void MakeHarleySounds()
        {
            Console.WriteLine("rumble rumble!");
        }
        
    }
}
