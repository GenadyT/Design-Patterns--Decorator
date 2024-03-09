using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.Beverages
{
    public abstract class Beverage
    {
        public abstract string getName();

        public abstract string getDescription();        

        public abstract double cost();
    }
}
