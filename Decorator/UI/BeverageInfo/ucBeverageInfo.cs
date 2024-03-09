using Decorator.Beverages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Decorator.UI
{
    public partial class ucBeverageInfo : UserControl
    {
        private double cost;
        public double Cost
        {
            get { return cost; }
        }

        private string[] condiments;
        public string[] Condiments
        {
            get { return condiments; }
        }

        public ucBeverageInfo()
        {
            InitializeComponent();
        }

        public void SetInfo(string coffeeType, string beverageCondiments, double cost)
        {
            this.cost = cost;
            tbxCost.Text = String.Format("{0:0.00}$", cost);            
            tbxType.Text = coffeeType;
            condiments = beverageCondiments.Split(',').Where(s => s != String.Empty).ToArray();

            var condimentGroups = condiments
                .GroupBy(s => s)
                .Select(group => new { Condiment = group.Key, Count = group.Count() }).ToList();

            tbxCondiments.Clear();
            foreach (var condGroup in condimentGroups)
            {
                tbxCondiments.AppendText($"{condGroup.Condiment} - {condGroup.Count}" );
                tbxCondiments.AppendText(Environment.NewLine);
            }
        }
    }
}
