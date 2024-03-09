using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Decorator.Beverages;

namespace Decorator.UI
{
    public abstract partial class ucButtonsPanel : UserControl
    {
        public Action<int> OnValueChange { get; set; }

        public ucButtonsPanel()
        {
            InitializeComponent();
            SubInit();
        }

        public abstract void Reset();
    }
}
