namespace Alca259.Forms.UserControls
{
    partial class NavigationMenu
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelHeader = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.toggleButton = new FontAwesome.Sharp.IconButton();
            this.panelItems = new System.Windows.Forms.Panel();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.labelFooter = new System.Windows.Forms.Label();
            this.panelHeader.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panelFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.Transparent;
            this.panelHeader.Controls.Add(this.panel1);
            this.panelHeader.Controls.Add(this.panel2);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(205, 41);
            this.panelHeader.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(166, 41);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(166, 41);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.toggleButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(166, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(39, 41);
            this.panel2.TabIndex = 2;
            // 
            // toggleButton
            // 
            this.toggleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.toggleButton.FlatAppearance.BorderSize = 0;
            this.toggleButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.toggleButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.toggleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.toggleButton.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.toggleButton.IconChar = FontAwesome.Sharp.IconChar.ToggleOff;
            this.toggleButton.IconColor = System.Drawing.Color.DimGray;
            this.toggleButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.toggleButton.IconSize = 24;
            this.toggleButton.Location = new System.Drawing.Point(6, 7);
            this.toggleButton.Name = "toggleButton";
            this.toggleButton.Rotation = 90D;
            this.toggleButton.Size = new System.Drawing.Size(28, 28);
            this.toggleButton.TabIndex = 0;
            this.toggleButton.Tag = "Adjust";
            this.toggleButton.UseVisualStyleBackColor = true;
            this.toggleButton.Click += new System.EventHandler(this.MenuToggleButton_Click);
            // 
            // panelItems
            // 
            this.panelItems.BackColor = System.Drawing.Color.Transparent;
            this.panelItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelItems.Location = new System.Drawing.Point(0, 41);
            this.panelItems.Name = "panelItems";
            this.panelItems.Size = new System.Drawing.Size(205, 334);
            this.panelItems.TabIndex = 1;
            // 
            // panelFooter
            // 
            this.panelFooter.BackColor = System.Drawing.Color.Transparent;
            this.panelFooter.Controls.Add(this.labelFooter);
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(0, 375);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Padding = new System.Windows.Forms.Padding(5);
            this.panelFooter.Size = new System.Drawing.Size(205, 25);
            this.panelFooter.TabIndex = 0;
            // 
            // labelFooter
            // 
            this.labelFooter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelFooter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelFooter.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.labelFooter.Location = new System.Drawing.Point(5, 5);
            this.labelFooter.Name = "labelFooter";
            this.labelFooter.Size = new System.Drawing.Size(195, 15);
            this.labelFooter.TabIndex = 0;
            this.labelFooter.Tag = "Adjust";
            this.labelFooter.Text = "Copyright 2022";
            this.labelFooter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // NavigationMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelItems);
            this.Controls.Add(this.panelFooter);
            this.Controls.Add(this.panelHeader);
            this.Name = "NavigationMenu";
            this.Size = new System.Drawing.Size(205, 400);
            this.panelHeader.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panelFooter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panelItems;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.Label labelFooter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton toggleButton;
    }
}
