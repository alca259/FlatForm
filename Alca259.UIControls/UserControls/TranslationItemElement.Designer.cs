using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Alca259.UIControls.UserControls
{
    public sealed partial class TranslationItemElement
    {
        private void InitializeComponent()
        {
            this.lblLanguageKey = new Alca259.UIControls.UserControls.ThemeLabel();
            this.txtInputValue = new Alca259.UIControls.UserControls.FlatTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.approvedCheckbox = new Alca259.UIControls.UserControls.SwitchCheckBox();
            this.themeLabel1 = new Alca259.UIControls.UserControls.ThemeLabel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblLanguageKey
            // 
            this.lblLanguageKey.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLanguageKey.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblLanguageKey.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblLanguageKey.Location = new System.Drawing.Point(0, 0);
            this.lblLanguageKey.Name = "lblLanguageKey";
            this.lblLanguageKey.Size = new System.Drawing.Size(51, 36);
            this.lblLanguageKey.TabIndex = 0;
            this.lblLanguageKey.Text = "es-ES";
            this.lblLanguageKey.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtInputValue
            // 
            this.txtInputValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtInputValue.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(96)))), ((int)(((byte)(231)))));
            this.txtInputValue.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(98)))), ((int)(((byte)(169)))));
            this.txtInputValue.BorderSize = 1;
            this.txtInputValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtInputValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtInputValue.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtInputValue.Location = new System.Drawing.Point(4, 4);
            this.txtInputValue.Margin = new System.Windows.Forms.Padding(4);
            this.txtInputValue.Multiline = false;
            this.txtInputValue.Name = "txtInputValue";
            this.txtInputValue.Padding = new System.Windows.Forms.Padding(7);
            this.txtInputValue.PasswordChar = false;
            this.txtInputValue.Size = new System.Drawing.Size(491, 28);
            this.txtInputValue.TabIndex = 2;
            this.txtInputValue.Texts = "";
            this.txtInputValue.UnderlinedStyle = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblLanguageKey);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(51, 36);
            this.panel1.TabIndex = 3;
            this.panel1.BackColor = AppColors.TranslationItemBackground;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtInputValue);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(51, 0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(4);
            this.panel2.Size = new System.Drawing.Size(499, 36);
            this.panel2.TabIndex = 4;
            this.panel2.BackColor = AppColors.TranslationItemBackground;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.themeLabel1);
            this.panel3.Controls.Add(this.approvedCheckbox);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(550, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(116, 36);
            this.panel3.TabIndex = 5;
            this.panel3.BackColor = AppColors.TranslationItemBackground;
            // 
            // approvedCheckbox
            // 
            this.approvedCheckbox.AutoSize = true;
            this.approvedCheckbox.Location = new System.Drawing.Point(8, 10);
            this.approvedCheckbox.MinimumSize = new System.Drawing.Size(32, 16);
            this.approvedCheckbox.Name = "approvedCheckbox";
            this.approvedCheckbox.OffBackColor = System.Drawing.Color.Gray;
            this.approvedCheckbox.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.approvedCheckbox.OnBackColor = System.Drawing.Color.MediumSlateBlue;
            this.approvedCheckbox.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.approvedCheckbox.Size = new System.Drawing.Size(32, 16);
            this.approvedCheckbox.TabIndex = 0;
            this.approvedCheckbox.UseVisualStyleBackColor = true;
            // 
            // themeLabel1
            // 
            this.themeLabel1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.themeLabel1.ForeColor = System.Drawing.Color.Gainsboro;
            this.themeLabel1.Location = new System.Drawing.Point(46, 0);
            this.themeLabel1.Name = "themeLabel1";
            this.themeLabel1.Size = new System.Drawing.Size(70, 36);
            this.themeLabel1.TabIndex = 1;
            this.themeLabel1.Text = "Approved";
            this.themeLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TranslationItemElement
            // 
            this.BackColor = AppColors.TranslationItemBackground;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "TranslationItemElement";
            this.Size = new System.Drawing.Size(666, 36);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        private ThemeLabel lblLanguageKey;
        private FlatTextBox txtInputValue;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private ThemeLabel themeLabel1;
        private SwitchCheckBox approvedCheckbox;
    }
}
