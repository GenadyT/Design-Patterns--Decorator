using System;
using System.Collections.Generic;
using System.Text;
using Decorator.Beverages;
using Decorator.Condiments;

namespace Decorator
{
    public class Mocha : CondimentDecorator
    {
        public Mocha(Beverage beverage) : base(beverage) { }

        public override string getName()
        {
            return "Mocha";
        }

        public override string getDescription()
        {
            return beverage.getDescription() + ", " + getName();
        }

        public override double cost()
        {
            return beverage.cost() + 0.20;
        }
    }
}
