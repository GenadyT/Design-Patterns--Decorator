using System;
using System.Collections.Generic;
using System.Text;
using Decorator.Beverages;

namespace Decorator
{
    public class HouseBlend : Beverage
    {
        public HouseBlend() { }

        public override string getName()
        {
            return "House Blend";
        }

        public override string getDescription()
        {
            return String.Empty;
        }

        public override double cost()
        {
            return 2.85;
        }
    }
}
