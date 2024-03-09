using Decorator.Beverages;
using Decorator.UI;
using System.Drawing;
using System.Windows.Forms;

namespace Decorator
{
    partial class frmCoffeeMachine
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnTakeTheCup = new Button();
            SuspendLayout();
            // 
            // btnTakeTheCup
            // 
            btnTakeTheCup.AutoEllipsis = true;
            btnTakeTheCup.CausesValidation = false;
            btnTakeTheCup.Cursor = Cursors.Hand;
            btnTakeTheCup.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnTakeTheCup.Location = new Point(183, 326);
            btnTakeTheCup.Name = "btnTakeTheCup";
            btnTakeTheCup.Size = new Size(384, 30);
            btnTakeTheCup.TabIndex = 0;
            btnTakeTheCup.Text = "take the cup..";
            btnTakeTheCup.UseVisualStyleBackColor = true;
            btnTakeTheCup.Click += btnTakeTheCup_Click;
            // 
            // frmCoffeeMachine
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(800, 467);
            Controls.Add(btnTakeTheCup);
            Name = "frmCoffeeMachine";
            Text = "Coffee Machine";
            ResumeLayout(false);
        }

        //private void Form2_Load(object sender, System.EventArgs e)
        private void UiControlsSet()
        {
            this.Width = 480;
            this.Height = 480;
            
            int currentTop = 20;
            int currentLeft = 40;

            ucCoffeeTypes1 = new ucCoffeeTypes();
            ucCoffeeTypes1.Left = currentLeft;
            ucCoffeeTypes1.Top = currentTop;
            currentTop += 90;
            Controls.Add(ucCoffeeTypes1);

            //btnTakeTheCup.BackColor = System.Drawing.Color.RosyBrown;
            btnTakeTheCup.BackColor = ColorTranslator.FromHtml("#916F6F");
            btnTakeTheCup.Left = currentLeft + 3;
            btnTakeTheCup.Width = 380;
            btnTakeTheCup.Top = currentTop + 290;

            ucCupSizeButtons1 = new ucCupSizeButtons();            
            ucCupSizeButtons1.Left = currentLeft;
            currentLeft += 110;
            ucCupSizeButtons1.Top = currentTop + 25;
            Controls.Add(ucCupSizeButtons1);

            ucBeverageInfo1 = new ucBeverageInfo();
            ucBeverageInfo1.Name = "ucBeverageInfo1";
            ucBeverageInfo1.Left = currentLeft;
            currentLeft += 179;
            ucBeverageInfo1.Top = currentTop;
            Controls.Add(ucBeverageInfo1);

            ucCondiments1 = new ucCondiments();
            ucCondiments1.Left = currentLeft;
            ucCondiments1.Top = currentTop + 25;
            Controls.Add(ucCondiments1);                        

            currentCupSize = cupSizeCost(CupSize.Tall);
            currentBeverage = new Espresso();
            currentCoffeeType = currentBeverage.getName();

            ucCupSizeButtons1.OnValueChange += OnCupSizeChanged;
            ucCoffeeTypes1.OnValueChange += OnBeverageTypeChanged;
            ucCondiments1.OnValueChange += onCondimentAdd;

            this.BackColor = ColorTranslator.FromHtml("#E8E8E8");
        }

        #endregion

        private ucCoffeeTypes ucCoffeeTypes1;
        private ucCupSizeButtons ucCupSizeButtons1;
        private ucBeverageInfo ucBeverageInfo1;
        private ucCondiments ucCondiments1;
        private System.Windows.Forms.Button btnTakeTheCup;
    }
}