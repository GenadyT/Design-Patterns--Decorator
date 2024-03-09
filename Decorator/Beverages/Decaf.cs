using System;
using System.Collections.Generic;
using System.Text;
using Decorator.Beverages;

namespace Decorator
{
    public class Decaf : Beverage
    {
        public Decaf() { }

        public override string getName()
        {
            return "Decaf";
        }

        public override string getDescription()
        {
            return String.Empty;
        }

        public override double cost()
        {
            return 3.15;
        }
    }
}
