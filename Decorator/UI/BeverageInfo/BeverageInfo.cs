using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.UI.BeverageInfo
{
    internal class BeverageInfo
    {
        private double cost;
        public double Cost
        {
            get { return cost; }
        }

        private string content;
        public string Content
        {
            get { return content; }
        }

        public BeverageInfo() { }
    }
}
