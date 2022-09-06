
namespace Alca259.Forms.UserControls
{
    partial class WindowBar
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
            this.MinimizeButton = new Alca259.Forms.UserControls.FlatButton();
            this.MaximizeButton = new Alca259.Forms.UserControls.FlatButton();
            this.CloseButton = new Alca259.Forms.UserControls.FlatButton();
            this.PanelRightButtons = new System.Windows.Forms.Panel();
            this.PanelMinimize = new System.Windows.Forms.Panel();
            this.PanelMaximize = new System.Windows.Forms.Panel();
            this.PanelClose = new System.Windows.Forms.Panel();
            this.PanelTitle = new System.Windows.Forms.Panel();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.PanelRightButtons.SuspendLayout();
            this.PanelMinimize.SuspendLayout();
            this.PanelMaximize.SuspendLayout();
            this.PanelClose.SuspendLayout();
            this.PanelTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MinimizeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.MinimizeButton.BackgroundImage = global::Alca259.Forms.Resources.ControlResources.Minimize;
            this.MinimizeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.MinimizeButton.DarkBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.MinimizeButton.DarkForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MinimizeButton.FlatAppearance.BorderSize = 0;
            this.MinimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MinimizeButton.Location = new System.Drawing.Point(3, 3);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(18, 18);
            this.MinimizeButton.TabIndex = 0;
            this.MinimizeButton.TabStop = false;
            this.MinimizeButton.UseVisualStyleBackColor = false;
            this.MinimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            // 
            // MaximizeButton
            // 
            this.MaximizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MaximizeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.MaximizeButton.BackgroundImage = global::Alca259.Forms.Resources.ControlResources.Maximize;
            this.MaximizeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.MaximizeButton.DarkBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.MaximizeButton.DarkForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MaximizeButton.FlatAppearance.BorderSize = 0;
            this.MaximizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MaximizeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MaximizeButton.Location = new System.Drawing.Point(3, 3);
            this.MaximizeButton.Margin = new System.Windows.Forms.Padding(0);
            this.MaximizeButton.Name = "MaximizeButton";
            this.MaximizeButton.Size = new System.Drawing.Size(18, 18);
            this.MaximizeButton.TabIndex = 1;
            this.MaximizeButton.TabStop = false;
            this.MaximizeButton.UseVisualStyleBackColor = false;
            this.MaximizeButton.Click += new System.EventHandler(this.MaximizeButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.CloseButton.BackgroundImage = global::Alca259.Forms.Resources.ControlResources.Close;
            this.CloseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CloseButton.DarkBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.CloseButton.DarkForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.CloseButton.FlatAppearance.BorderSize = 0;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.CloseButton.Location = new System.Drawing.Point(5, 3);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(18, 18);
            this.CloseButton.TabIndex = 2;
            this.CloseButton.TabStop = false;
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // PanelRightButtons
            // 
            this.PanelRightButtons.Controls.Add(this.PanelMinimize);
            this.PanelRightButtons.Controls.Add(this.PanelMaximize);
            this.PanelRightButtons.Controls.Add(this.PanelClose);
            this.PanelRightButtons.Dock = System.Windows.Forms.DockStyle.Right;
            this.PanelRightButtons.Location = new System.Drawing.Point(374, 0);
            this.PanelRightButtons.Name = "PanelRightButtons";
            this.PanelRightButtons.Size = new System.Drawing.Size(79, 51);
            this.PanelRightButtons.TabIndex = 3;
            // 
            // PanelMinimize
            // 
            this.PanelMinimize.Controls.Add(this.MinimizeButton);
            this.PanelMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.PanelMinimize.Location = new System.Drawing.Point(1, 0);
            this.PanelMinimize.Name = "PanelMinimize";
            this.PanelMinimize.Size = new System.Drawing.Size(26, 51);
            this.PanelMinimize.TabIndex = 5;
            // 
            // PanelMaximize
            // 
            this.PanelMaximize.Controls.Add(this.MaximizeButton);
            this.PanelMaximize.Dock = System.Windows.Forms.DockStyle.Right;
            this.PanelMaximize.Location = new System.Drawing.Point(27, 0);
            this.PanelMaximize.Name = "PanelMaximize";
            this.PanelMaximize.Size = new System.Drawing.Size(26, 51);
            this.PanelMaximize.TabIndex = 4;
            // 
            // PanelClose
            // 
            this.PanelClose.Controls.Add(this.CloseButton);
            this.PanelClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.PanelClose.Location = new System.Drawing.Point(53, 0);
            this.PanelClose.Name = "PanelClose";
            this.PanelClose.Size = new System.Drawing.Size(26, 51);
            this.PanelClose.TabIndex = 3;
            // 
            // PanelTitle
            // 
            this.PanelTitle.Controls.Add(this.TitleLabel);
            this.PanelTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelTitle.Location = new System.Drawing.Point(0, 0);
            this.PanelTitle.Name = "PanelTitle";
            this.PanelTitle.Padding = new System.Windows.Forms.Padding(2);
            this.PanelTitle.Size = new System.Drawing.Size(374, 51);
            this.PanelTitle.TabIndex = 4;
            // 
            // TitleLabel
            // 
            this.TitleLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TitleLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.TitleLabel.Location = new System.Drawing.Point(2, 2);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(370, 47);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // WindowBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.Controls.Add(this.PanelTitle);
            this.Controls.Add(this.PanelRightButtons);
            this.Name = "WindowBar";
            this.Size = new System.Drawing.Size(453, 26);
            this.PanelRightButtons.ResumeLayout(false);
            this.PanelMinimize.ResumeLayout(false);
            this.PanelMaximize.ResumeLayout(false);
            this.PanelClose.ResumeLayout(false);
            this.PanelTitle.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private FlatButton MinimizeButton;
        private FlatButton MaximizeButton;
        private FlatButton CloseButton;
        private System.Windows.Forms.Panel PanelRightButtons;
        private System.Windows.Forms.Panel PanelTitle;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Panel PanelClose;
        private System.Windows.Forms.Panel PanelMinimize;
        private System.Windows.Forms.Panel PanelMaximize;
    }
}
