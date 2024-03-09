using System;
using System.Collections.Generic;
using System.Text;
using Decorator.Beverages;
using Decorator.Condiments;

namespace Decorator
{
    public class Whip : CondimentDecorator
    {
        public Whip(Beverage beverage) : base(beverage) { }

        public override string getName()
        {
            return "Whip";
        }

        public override string getDescription()
        {
            return beverage.getDescription() + ", " + getName();
        }

        public override double cost()
        {
            return beverage.cost() + 0.10;
        }
    }
}
