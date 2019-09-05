using Garage.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Garage.Concrete
{
    public class Tesla : Car
    {
        // Attribute(s)
        public bool IsElectric { get; set; }


        /// <summary>
        /// Make electric Tesla sounds
        /// </summary>
        public void MakeTelsaSounds()
        {
            Console.WriteLine("");
        }
    }
}
