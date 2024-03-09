using System;
using System.Collections.Generic;
using System.Text;
using Decorator.Beverages;

namespace Decorator.Condiments
{    
    public abstract class CondimentDecorator : Beverage
    {
        protected Beverage beverage;

        public CondimentDecorator(Beverage beverage)
        {
            this.beverage = beverage;
        }
    }
}
