using System;
using System.Collections.Generic;
using System.Text;

namespace Garage.Concrete
{
    public class ModelS : Tesla
    {
        public bool IsFast { get; set; } = true;

        public void OpenDoors()
        {
            Console.WriteLine("Tesla Model S Doors Opened");
        }

        public override void RegistrationFees()
        {
            Console.WriteLine("Model S Registration fees are $10");
        }
    }
}
