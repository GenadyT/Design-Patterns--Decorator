using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SWF = System.Windows.Forms;

namespace Decorator.UI
{
    public partial class ucCondiments : ucButtonsPanel
    {
        public ucCondiments()
        {
            InitializeComponent();
        }

        private void button_Clicked(Object sender, EventArgs e)
        {
            Button bt = sender as Button;
            int value = Convert.ToInt32(bt.Tag);
            OnValueChange(value);
        }

        protected void this_OnLoad(Object sender, EventArgs e)
        {
            Control panel = this.Controls.Find("pnlCondiments", false).First();
            List<Control> controls = panel.Controls.Cast<Control>().Where(c => c is Button).ToList();

            foreach (Control ctl in controls)
            {   
                ctl.Click += button_Clicked;
            }
        }

        public override void Reset()
        {
            // do nothing
        }
    }
}
