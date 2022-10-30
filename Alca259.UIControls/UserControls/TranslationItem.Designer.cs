using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Alca259.UIControls.UserControls
{
    public sealed partial class TranslationItem
    {
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblKey = new Alca259.UIControls.UserControls.ThemeLabel();
            this.panelOutput = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblKey);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(675, 27);
            this.panel1.TabIndex = 1;
            this.panel1.BackColor = AppColors.TranslationItemBackground;
            // 
            // lblKey
            // 
            this.lblKey.AutoSize = true;
            this.lblKey.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblKey.Location = new System.Drawing.Point(5, 5);
            this.lblKey.Name = "lblKey";
            this.lblKey.Size = new System.Drawing.Size(25, 15);
            this.lblKey.TabIndex = 0;
            this.lblKey.Text = "key";
            // 
            // panelOutput
            // 
            this.panelOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelOutput.Location = new System.Drawing.Point(0, 27);
            this.panelOutput.Name = "panelOutput";
            this.panelOutput.Size = new System.Drawing.Size(675, 27);
            this.panelOutput.TabIndex = 2;
            this.panelOutput.BackColor = AppColors.TranslationItemBackground;
            // 
            // TranslationItem
            // 
            this.BackColor = AppColors.TranslationItemBackground;
            this.Controls.Add(this.panelOutput);
            this.Controls.Add(this.panel1);
            this.Name = "TranslationItem";
            this.Size = new System.Drawing.Size(675, 54);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        private ThemeLabel lblKey;
        private Panel panel1;
        private Panel panelOutput;
    }
}
