using Garage.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Garage.Concrete
{
    public class Tesla : Car
    {
        public bool IsElectric { get; set; } = true;
    }
}
