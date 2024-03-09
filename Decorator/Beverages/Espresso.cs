using System;
using System.Collections.Generic;
using System.Text;
using Decorator.Beverages;

namespace Decorator
{
    public class Espresso : Beverage
    {
        public Espresso() { }

        public override string getName()
        {
            return "Espresso";
        }

        public override string getDescription()
        {
            return String.Empty;
        }

        public override double cost()
        {
            return 1.95;
        }
    }
}
