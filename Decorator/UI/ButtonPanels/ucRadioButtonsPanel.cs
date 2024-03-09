using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using SWF = System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Decorator.UI
{
    public partial class ucRadioButtonsPanel : ucButtonsPanel
    {
        private List<SWF.RadioButton> rdButtons;

        public ucRadioButtonsPanel() 
        {
            InitializeComponent();            
        }

        private void radioButton_CheckedChanged(Object sender, EventArgs e)
        {
            SWF.RadioButton rb = sender as SWF.RadioButton;

            if (rb.Checked)
            {
                int value = Convert.ToInt32(rb.Tag);
                OnValueChange(value);
            }            
        }

        protected void this_OnLoad(Object sender, EventArgs e)
        {
            rdButtons = this.Controls["pnlRdButtons"].Controls.Cast<SWF.RadioButton>().ToList();

            foreach (var rdb in rdButtons)
            {
                ((SWF.RadioButton)rdb).CheckedChanged += radioButton_CheckedChanged;
            }

            reset();
        }

        public override void Reset()
        {
            reset();
        }

        private void reset()
        {
            rdButtons.Where(rdb => Convert.ToInt32(rdb.Tag) == 0).First().PerformClick();
        }
    }
}
