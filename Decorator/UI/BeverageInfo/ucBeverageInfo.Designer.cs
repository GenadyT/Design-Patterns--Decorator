using System.Drawing;
using System.Windows.Forms;

namespace Decorator.UI
{
    partial class ucBeverageInfo
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
            pnlPrepareInfo = new System.Windows.Forms.Panel();
            tbxType = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            tbxCondiments = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            tbxCost = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            pnlPrepareInfo.SuspendLayout();
            SuspendLayout();
            // 
            // pnlPrepareInfo
            // 
            pnlPrepareInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pnlPrepareInfo.Controls.Add(tbxType);
            pnlPrepareInfo.Controls.Add(label4);
            pnlPrepareInfo.Controls.Add(tbxCondiments);
            pnlPrepareInfo.Controls.Add(label2);
            pnlPrepareInfo.Controls.Add(tbxCost);
            pnlPrepareInfo.Controls.Add(label1);
            pnlPrepareInfo.Location = new System.Drawing.Point(6, 21);
            pnlPrepareInfo.Name = "pnlPrepareInfo";
            pnlPrepareInfo.Padding = new System.Windows.Forms.Padding(5);
            pnlPrepareInfo.Size = new System.Drawing.Size(147, 227);
            pnlPrepareInfo.TabIndex = 1;
            pnlPrepareInfo.BackColor = ColorTranslator.FromHtml("#B8B8B8");
            // 
            // tbxType
            // 
            tbxType.Location = new System.Drawing.Point(8, 79);
            tbxType.Name = "tbxType";
            tbxType.ReadOnly = true;
            tbxType.Size = new System.Drawing.Size(127, 23);
            tbxType.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(6, 61);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(39, 15);
            label4.TabIndex = 6;
            label4.Text = "Name";
            // 
            // tbxCondiments
            // 
            tbxCondiments.Location = new System.Drawing.Point(8, 140);
            tbxCondiments.Multiline = true;
            tbxCondiments.Name = "tbxCondiments";
            tbxCondiments.ReadOnly = true;
            tbxCondiments.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            tbxCondiments.Size = new System.Drawing.Size(129, 77);
            tbxCondiments.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(8, 122);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(72, 15);
            label2.TabIndex = 3;
            label2.Text = "Condiments";
            // 
            // tbxCost
            // 
            tbxCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            tbxCost.Location = new System.Drawing.Point(8, 26);
            tbxCost.Name = "tbxCost";
            tbxCost.ReadOnly = true;
            tbxCost.Size = new System.Drawing.Size(129, 23);
            tbxCost.TabIndex = 2;
            tbxCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(8, 8);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(31, 15);
            label1.TabIndex = 1;
            label1.Text = "Cost";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(6, 3);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(90, 15);
            label3.TabIndex = 4;
            label3.Text = "Beverage Info:";
            // 
            // ucBeverageInfo
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(pnlPrepareInfo);
            Controls.Add(label3);
            Name = "ucBeverageInfo";
            Padding = new System.Windows.Forms.Padding(3);
            Size = new System.Drawing.Size(158, 254);
            pnlPrepareInfo.ResumeLayout(false);
            pnlPrepareInfo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel pnlPrepareInfo;
        private System.Windows.Forms.TextBox tbxCondiments;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxCost;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxType;
        private System.Windows.Forms.Label label4;
    }
}
