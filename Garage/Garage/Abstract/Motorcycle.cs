using Garage.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Garage.Abstract
{
    public abstract class Motorcycle : Vehicle
    {
        public virtual string Kickstart { get; set; }
        public string Handlebars { get; set; }
        
    }
}
