namespace Alca259.Test
{
    partial class Form1
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
            this.btnMini = new Alca259.Forms.UserControls.FlatButton();
            this.btnMaxi = new Alca259.Forms.UserControls.FlatButton();
            this.btnClose = new Alca259.Forms.UserControls.FlatButton();
            this.SuspendLayout();
            // 
            // btnMini
            // 
            this.btnMini.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMini.BackColor = System.Drawing.Color.White;
            this.btnMini.DarkColors = false;
            this.btnMini.FlatAppearance.BorderSize = 0;
            this.btnMini.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMini.ForeColor = System.Drawing.Color.Black;
            this.btnMini.Location = new System.Drawing.Point(799, 5);
            this.btnMini.Name = "btnMini";
            this.btnMini.Size = new System.Drawing.Size(32, 32);
            this.btnMini.TabIndex = 0;
            this.btnMini.Text = "-";
            this.btnMini.UseVisualStyleBackColor = false;
            // 
            // btnMaxi
            // 
            this.btnMaxi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaxi.BackColor = System.Drawing.Color.White;
            this.btnMaxi.DarkColors = false;
            this.btnMaxi.FlatAppearance.BorderSize = 0;
            this.btnMaxi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaxi.ForeColor = System.Drawing.Color.Black;
            this.btnMaxi.Location = new System.Drawing.Point(837, 5);
            this.btnMaxi.Name = "btnMaxi";
            this.btnMaxi.Size = new System.Drawing.Size(32, 32);
            this.btnMaxi.TabIndex = 1;
            this.btnMaxi.Text = "+";
            this.btnMaxi.UseVisualStyleBackColor = false;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.DarkColors = false;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.Black;
            this.btnClose.Location = new System.Drawing.Point(875, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(32, 32);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "x";
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderSize = 2;
            this.ClientSize = new System.Drawing.Size(912, 723);
            this.CloseButton = this.btnClose;
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnMaxi);
            this.Controls.Add(this.btnMini);
            this.MaximizeButton = this.btnMaxi;
            this.MinimizeButton = this.btnMini;
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Forms.UserControls.FlatButton btnMini;
        private Forms.UserControls.FlatButton btnMaxi;
        private Forms.UserControls.FlatButton btnClose;
    }
}
