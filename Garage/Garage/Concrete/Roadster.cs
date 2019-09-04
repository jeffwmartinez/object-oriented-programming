using Garage.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Garage.Concrete
{
    public class Roadster : Harley
    {
        public bool IsModern { get; set; } = true;
    }
}
