using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alca259.UIControls.UserControls
{
    public partial class Slider
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.sliderBar = new System.Windows.Forms.TrackBar();
            this.sliderLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.sliderValue = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.sliderMax = new System.Windows.Forms.Label();
            this.sliderMin = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sliderBar)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // sliderBar
            // 
            this.sliderBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sliderBar.LargeChange = 10;
            this.sliderBar.Location = new System.Drawing.Point(0, 25);
            this.sliderBar.Maximum = 100;
            this.sliderBar.Minimum = 1;
            this.sliderBar.Name = "sliderBar";
            this.sliderBar.Size = new System.Drawing.Size(193, 28);
            this.sliderBar.TabIndex = 1;
            this.sliderBar.Value = 1;
            // 
            // sliderLabel
            // 
            this.sliderLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sliderLabel.Location = new System.Drawing.Point(0, 0);
            this.sliderLabel.Name = "sliderLabel";
            this.sliderLabel.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.sliderLabel.Size = new System.Drawing.Size(193, 25);
            this.sliderLabel.TabIndex = 0;
            this.sliderLabel.Text = "label..";
            this.sliderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.sliderValue);
            this.panel1.Controls.Add(this.sliderLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(193, 25);
            this.panel1.TabIndex = 2;
            // 
            // sliderValue
            // 
            this.sliderValue.Dock = System.Windows.Forms.DockStyle.Right;
            this.sliderValue.Location = new System.Drawing.Point(122, 0);
            this.sliderValue.Name = "sliderValue";
            this.sliderValue.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.sliderValue.Size = new System.Drawing.Size(71, 25);
            this.sliderValue.TabIndex = 1;
            this.sliderValue.Text = "1";
            this.sliderValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.sliderMax);
            this.panel2.Controls.Add(this.sliderMin);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 53);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(193, 17);
            this.panel2.TabIndex = 3;
            // 
            // sliderMax
            // 
            this.sliderMax.Dock = System.Windows.Forms.DockStyle.Right;
            this.sliderMax.Location = new System.Drawing.Point(141, 0);
            this.sliderMax.Name = "sliderMax";
            this.sliderMax.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.sliderMax.Size = new System.Drawing.Size(52, 17);
            this.sliderMax.TabIndex = 2;
            this.sliderMax.Text = "100";
            this.sliderMax.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // sliderMin
            // 
            this.sliderMin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sliderMin.Location = new System.Drawing.Point(0, 0);
            this.sliderMin.Name = "sliderMin";
            this.sliderMin.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.sliderMin.Size = new System.Drawing.Size(193, 17);
            this.sliderMin.TabIndex = 1;
            this.sliderMin.Text = "1";
            this.sliderMin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Slider
            // 
            this.Controls.Add(this.sliderBar);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Slider";
            this.Size = new System.Drawing.Size(193, 70);
            ((System.ComponentModel.ISupportInitialize)(this.sliderBar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TrackBar sliderBar;
        private Label sliderLabel;
        private Panel panel1;
        private Label sliderValue;
        private Panel panel2;
        private Label sliderMax;
        private Label sliderMin;
    }
}
