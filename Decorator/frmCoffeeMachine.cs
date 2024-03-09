using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Decorator.UI;
using Decorator.Beverages;
using Decorator.Condiments;
using System.Linq;

namespace Decorator
{
    public partial class frmCoffeeMachine : Form
    {
        private double currentCupSize;
        private Beverage currentBeverage;
        private string currentCoffeeType;

        public frmCoffeeMachine()
        {
            InitializeComponent();
            UiControlsSet();
        }

        private void OnCupSizeChanged(int cupSize)
        {
            currentCupSize = cupSizeCost((CupSize)cupSize);
            beverageInfoShow(currentBeverage);
        }

        private void OnBeverageTypeChanged(int beverageType)
        {
            BeverageType enamBeverageType = (BeverageType)beverageType;

            switch (enamBeverageType)
            {
                case BeverageType.DarkRoast:
                    currentBeverage = new DarkRoast();
                    break;
                case BeverageType.Decaf:
                    currentBeverage = new Decaf();
                    break;
                case BeverageType.Espresso:
                    currentBeverage = new Espresso();
                    break;
                case BeverageType.HouseBlend:
                    currentBeverage = new HouseBlend();
                    break;
                default:
                    currentBeverage = new DarkRoast();
                    break;
            }

            currentCoffeeType = currentBeverage.getName();
            beverageInfoShow(currentBeverage);
        }

        private void onCondimentAdd(int condimentType)
        {
            CondimentType enamCondimentType = (CondimentType)condimentType;

            switch (enamCondimentType)
            {
                case CondimentType.Milk:
                    currentBeverage = new Milk(currentBeverage);
                    break;
                case CondimentType.Mocha:
                    currentBeverage = new Mocha(currentBeverage);
                    break;
                case CondimentType.Soy:
                    currentBeverage = new Soy(currentBeverage);
                    break;
                case CondimentType.Whip:
                    currentBeverage = new Whip(currentBeverage);
                    break;
                default:
                    currentBeverage = new Milk(currentBeverage);
                    break;
            }

            beverageInfoShow(currentBeverage);
        }

        private void beverageInfoShow(Beverage beverage)
        {
            ucBeverageInfo bi = ((ucBeverageInfo)Controls["ucBeverageInfo1"]);
            bi.SetInfo(currentCoffeeType, beverage.getDescription(), beverage.cost() + currentCupSize);
        }

        private double cupSizeCost(CupSize cupSize)
        {
            double cupCost;

            switch (cupSize)
            {
                case CupSize.Tall:
                    cupCost = 0.1;
                    break;
                case CupSize.Grande:
                    cupCost = 0.2;
                    break;
                case CupSize.Venti:
                    cupCost = 0.3;
                    break;
                case CupSize.Trenta:
                    cupCost = 0.4;
                    break;
                default:
                    cupCost = 0.1;
                    break;
            }

            return cupCost;
        }

        private void btnTakeTheCup_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Have You Paid??", "", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                MessageBox.Show("please take the cup :-)");
                machineResest();
            }
            else
            {
                MessageBox.Show("please pay!");
            }
        }

        private void machineResest()
        {   
            List<Control> controls = Controls.Cast<Control>().Where(c => c is ucButtonsPanel).ToList();
            foreach (ucButtonsPanel ctl in controls)
            {
                ctl.Reset();
            }
        }
    }
}
