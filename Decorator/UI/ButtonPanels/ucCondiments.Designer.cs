using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Decorator.UI
{
    partial class ucCondiments
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
            pnlCondiments = new System.Windows.Forms.Panel();
            label5 = new System.Windows.Forms.Label();
            btnAddWhip = new System.Windows.Forms.Button();
            label4 = new System.Windows.Forms.Label();
            btnAddSoy = new System.Windows.Forms.Button();
            label3 = new System.Windows.Forms.Label();
            btnAddMocha = new System.Windows.Forms.Button();
            label2 = new System.Windows.Forms.Label();
            btnAddMilk = new System.Windows.Forms.Button();
            pnlCondiments.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(4, 5);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(73, 15);
            label1.TabIndex = 0;
            label1.Text = "Condiments";
            // 
            // pnlCondiments
            // 
            pnlCondiments.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pnlCondiments.Controls.Add(label5);
            pnlCondiments.Controls.Add(btnAddWhip);
            pnlCondiments.Controls.Add(label4);
            pnlCondiments.Controls.Add(btnAddSoy);
            pnlCondiments.Controls.Add(label3);
            pnlCondiments.Controls.Add(btnAddMocha);
            pnlCondiments.Controls.Add(label2);
            pnlCondiments.Controls.Add(btnAddMilk);
            pnlCondiments.Location = new System.Drawing.Point(6, 23);
            pnlCondiments.Name = "pnlCondiments";
            pnlCondiments.Padding = new System.Windows.Forms.Padding(5);
            pnlCondiments.Size = new System.Drawing.Size(84, 166);
            pnlCondiments.TabIndex = 3;
            pnlCondiments.BackColor = ColorTranslator.FromHtml("#B8B8B8");
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(41, 114);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(35, 13);
            label5.TabIndex = 10;
            label5.Text = "Whip";
            // 
            // btnAddWhip
            // 
            btnAddWhip.BackColor = System.Drawing.SystemColors.ButtonFace;
            btnAddWhip.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnAddWhip.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            btnAddWhip.Location = new System.Drawing.Point(8, 107);
            btnAddWhip.Name = "btnAddWhip";
            btnAddWhip.Size = new System.Drawing.Size(27, 27);
            btnAddWhip.TabIndex = 9;
            btnAddWhip.Tag = "3";
            btnAddWhip.Text = "+";
            btnAddWhip.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            btnAddWhip.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(41, 81);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(25, 13);
            label4.TabIndex = 8;
            label4.Text = "Soy";
            // 
            // btnAddSoy
            // 
            btnAddSoy.BackColor = System.Drawing.SystemColors.ButtonFace;
            btnAddSoy.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnAddSoy.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            btnAddSoy.Location = new System.Drawing.Point(8, 74);
            btnAddSoy.Name = "btnAddSoy";
            btnAddSoy.Size = new System.Drawing.Size(27, 27);
            btnAddSoy.TabIndex = 7;
            btnAddSoy.Tag = "2";
            btnAddSoy.Text = "+";
            btnAddSoy.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            btnAddSoy.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(38, 48);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(42, 13);
            label3.TabIndex = 6;
            label3.Text = "Mocha";
            // 
            // btnAddMocha
            // 
            btnAddMocha.BackColor = System.Drawing.SystemColors.ButtonFace;
            btnAddMocha.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnAddMocha.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            btnAddMocha.Location = new System.Drawing.Point(8, 41);
            btnAddMocha.Name = "btnAddMocha";
            btnAddMocha.Size = new System.Drawing.Size(27, 27);
            btnAddMocha.TabIndex = 5;
            btnAddMocha.Tag = "1";
            btnAddMocha.Text = "+";
            btnAddMocha.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            btnAddMocha.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(41, 15);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(29, 13);
            label2.TabIndex = 4;
            label2.Text = "Milk";
            // 
            // btnAddMilk
            // 
            btnAddMilk.BackColor = System.Drawing.SystemColors.ButtonFace;
            btnAddMilk.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnAddMilk.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            btnAddMilk.Location = new System.Drawing.Point(8, 8);
            btnAddMilk.Name = "btnAddMilk";
            btnAddMilk.Size = new System.Drawing.Size(27, 27);
            btnAddMilk.TabIndex = 3;
            btnAddMilk.Tag = "0";
            btnAddMilk.Text = "+";
            btnAddMilk.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            btnAddMilk.UseVisualStyleBackColor = false;
            // 
            // ucCondiments
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(pnlCondiments);
            Controls.Add(label1);
            Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Name = "ucCondiments";
            Padding = new System.Windows.Forms.Padding(3);
            Size = new System.Drawing.Size(90, 195);
            Load += this_OnLoad;
            pnlCondiments.ResumeLayout(false);
            pnlCondiments.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }        

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlCondiments;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAddWhip;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAddSoy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAddMocha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddMilk;
    }
}
