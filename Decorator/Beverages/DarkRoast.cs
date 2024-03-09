using System;
using System.Collections.Generic;
using System.Text;
using Decorator.Beverages;

namespace Decorator
{
    public class DarkRoast : Beverage
    {
        public DarkRoast() { }

        public override string getName()
        {
            return "Dark Roast";
        }

        public override string getDescription()
        {
            return String.Empty;
        }

        public override double cost()
        {
            return 2.35;
        }
    }
}
