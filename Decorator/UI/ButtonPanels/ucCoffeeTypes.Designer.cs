using System.Drawing;

namespace Decorator.UI
{
    partial class ucCoffeeTypes
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlRdButtons = new System.Windows.Forms.Panel();
            rdbHouseBlend = new System.Windows.Forms.RadioButton();
            rdbEspresso = new System.Windows.Forms.RadioButton();
            rdbDecaf = new System.Windows.Forms.RadioButton();
            rdbDarkRoast = new System.Windows.Forms.RadioButton();
            label2 = new System.Windows.Forms.Label();
            pnlRdButtons.SuspendLayout();
            SuspendLayout();
            // 
            // pnlRdButtons
            // 
            pnlRdButtons.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pnlRdButtons.Controls.Add(rdbHouseBlend);
            pnlRdButtons.Controls.Add(rdbEspresso);
            pnlRdButtons.Controls.Add(rdbDecaf);
            pnlRdButtons.Controls.Add(rdbDarkRoast);
            pnlRdButtons.Location = new System.Drawing.Point(6, 28);
            pnlRdButtons.Name = "pnlRdButtons";
            pnlRdButtons.Size = new System.Drawing.Size(373, 49);
            pnlRdButtons.TabIndex = 6;
            pnlRdButtons.BackColor = ColorTranslator.FromHtml("#B8B8B8");
            // 
            // rdbHouseBlend
            // 
            rdbHouseBlend.AutoSize = true;
            rdbHouseBlend.Location = new System.Drawing.Point(198, 13);
            rdbHouseBlend.Name = "rdbHouseBlend";
            rdbHouseBlend.Size = new System.Drawing.Size(92, 19);
            rdbHouseBlend.TabIndex = 3;
            rdbHouseBlend.TabStop = true;
            rdbHouseBlend.Tag = "2";
            rdbHouseBlend.Text = "House Blend";
            rdbHouseBlend.UseVisualStyleBackColor = true;
            // 
            // rdbEspresso
            // 
            rdbEspresso.AutoSize = true;
            rdbEspresso.Location = new System.Drawing.Point(7, 13);
            rdbEspresso.Name = "rdbEspresso";
            rdbEspresso.Size = new System.Drawing.Size(70, 19);
            rdbEspresso.TabIndex = 2;
            rdbEspresso.TabStop = true;
            rdbEspresso.Tag = "0";
            rdbEspresso.Text = "Espresso";
            rdbEspresso.UseVisualStyleBackColor = true;
            // 
            // rdbDecaf
            // 
            rdbDecaf.AutoSize = true;
            rdbDecaf.Location = new System.Drawing.Point(309, 13);
            rdbDecaf.Name = "rdbDecaf";
            rdbDecaf.Size = new System.Drawing.Size(55, 19);
            rdbDecaf.TabIndex = 1;
            rdbDecaf.TabStop = true;
            rdbDecaf.Tag = "3";
            rdbDecaf.Text = "Decaf";
            rdbDecaf.UseVisualStyleBackColor = true;
            // 
            // rdbDarkRoast
            // 
            rdbDarkRoast.AutoSize = true;
            rdbDarkRoast.Location = new System.Drawing.Point(99, 13);
            rdbDarkRoast.Name = "rdbDarkRoast";
            rdbDarkRoast.Size = new System.Drawing.Size(81, 19);
            rdbDarkRoast.TabIndex = 0;
            rdbDarkRoast.TabStop = true;
            rdbDarkRoast.Tag = "1";
            rdbDarkRoast.Text = "Dark Roast";
            rdbDarkRoast.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(6, 10);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(74, 15);
            label2.TabIndex = 5;
            label2.Text = "Coffee Type";
            // 
            // ucCoffeeTypes
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(pnlRdButtons);
            Controls.Add(label2);
            Name = "ucCoffeeTypes";
            Size = new System.Drawing.Size(384, 85);
            Load += this_OnLoad;
            pnlRdButtons.ResumeLayout(false);
            pnlRdButtons.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel pnlRdButtons;
        private System.Windows.Forms.RadioButton rdbHouseBlend;
        private System.Windows.Forms.RadioButton rdbEspresso;
        private System.Windows.Forms.RadioButton rdbDecaf;
        private System.Windows.Forms.RadioButton rdbDarkRoast;
        private System.Windows.Forms.Label label2;
    }
}
