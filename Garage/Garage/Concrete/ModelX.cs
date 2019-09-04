using Garage.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Garage.Concrete
{
    public class ModelX : Tesla
    {
        public bool IsSuv { get; set; } = true;

        public void OpenFalconWingDoors()
        {
            Console.WriteLine("Falcon Wing Doors Opened");
        }

        public override void RegistrationFees()
        {
            Console.WriteLine("Model X Registration fees are $50");
        }
    }
}
