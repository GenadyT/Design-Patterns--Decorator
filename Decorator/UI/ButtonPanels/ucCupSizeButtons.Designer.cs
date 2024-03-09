using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Decorator.UI
{
    partial class ucCupSizeButtons
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
            label1 = new System.Windows.Forms.Label();
            pnlRdButtons = new System.Windows.Forms.Panel();
            rdbTrenta = new System.Windows.Forms.RadioButton();
            rdbVenti = new System.Windows.Forms.RadioButton();
            rdbGrande = new System.Windows.Forms.RadioButton();
            rdbTall = new System.Windows.Forms.RadioButton();
            pnlRdButtons.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(6, 4);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(54, 15);
            label1.TabIndex = 4;
            label1.Text = "Cup Size";
            // 
            // pnlRdButtons
            // 
            pnlRdButtons.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pnlRdButtons.Controls.Add(rdbTrenta);
            pnlRdButtons.Controls.Add(rdbVenti);
            pnlRdButtons.Controls.Add(rdbGrande);
            pnlRdButtons.Controls.Add(rdbTall);
            pnlRdButtons.Location = new System.Drawing.Point(6, 22);
            pnlRdButtons.Name = "pnlRdButtons";
            pnlRdButtons.Padding = new System.Windows.Forms.Padding(5);
            pnlRdButtons.Size = new System.Drawing.Size(78, 166);
            pnlRdButtons.TabIndex = 3;
            pnlRdButtons.BackColor = ColorTranslator.FromHtml("#B8B8B8");            
            // 
            // rdbTrenta
            // 
            rdbTrenta.AutoSize = true;
            rdbTrenta.Location = new System.Drawing.Point(8, 115);
            rdbTrenta.Name = "rdbTrenta";
            rdbTrenta.Size = new System.Drawing.Size(57, 19);
            rdbTrenta.TabIndex = 4;
            rdbTrenta.TabStop = true;
            rdbTrenta.Tag = "3";
            rdbTrenta.Text = "Trenta";
            rdbTrenta.UseVisualStyleBackColor = true;
            // 
            // rdbVenti
            // 
            rdbVenti.AutoSize = true;
            rdbVenti.Location = new System.Drawing.Point(8, 80);
            rdbVenti.Name = "rdbVenti";
            rdbVenti.Size = new System.Drawing.Size(51, 19);
            rdbVenti.TabIndex = 3;
            rdbVenti.Tag = "2";
            rdbVenti.Text = "Venti";
            rdbVenti.UseVisualStyleBackColor = true;
            // 
            // rdbGrande
            // 
            rdbGrande.AutoSize = true;
            rdbGrande.Location = new System.Drawing.Point(8, 46);
            rdbGrande.Name = "rdbGrande";
            rdbGrande.Size = new System.Drawing.Size(63, 19);
            rdbGrande.TabIndex = 2;
            rdbGrande.Tag = "1";
            rdbGrande.Text = "Grande";
            rdbGrande.UseVisualStyleBackColor = true;
            // 
            // rdbTall
            // 
            rdbTall.AutoSize = true;
            rdbTall.Location = new System.Drawing.Point(8, 12);
            rdbTall.Name = "rdbTall";
            rdbTall.Size = new System.Drawing.Size(42, 19);
            rdbTall.TabIndex = 1;
            rdbTall.Tag = "0";
            rdbTall.Text = "Tall";
            rdbTall.UseVisualStyleBackColor = true;
            // 
            // ucCupSizeButtons
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(label1);
            Controls.Add(pnlRdButtons);
            Name = "ucCupSizeButtons";
            Padding = new System.Windows.Forms.Padding(3);
            Size = new System.Drawing.Size(90, 193);
            Load += this_OnLoad;
            pnlRdButtons.ResumeLayout(false);
            pnlRdButtons.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }        

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlRdButtons;
        private System.Windows.Forms.RadioButton rdbVenti;
        private System.Windows.Forms.RadioButton rdbGrande;
        private System.Windows.Forms.RadioButton rdbTall;
        private System.Windows.Forms.RadioButton rdbTrenta;
    }
}
