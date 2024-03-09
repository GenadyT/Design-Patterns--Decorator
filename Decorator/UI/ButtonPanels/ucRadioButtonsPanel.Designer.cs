using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Decorator.UI
{
    partial class ucRadioButtonsPanel
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

        protected override void SubInit()
        {
            /*Panel panel = this.Controls.OfType<Panel>().First() as Panel;
            panel.BackColor = ColorTranslator.FromHtml("#B8B8B8");*/
        }        

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;            
        }

        #endregion
    }
}
