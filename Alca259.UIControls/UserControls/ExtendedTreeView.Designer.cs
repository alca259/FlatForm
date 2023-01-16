using System;
using System.Collections.Generic;
using System.Text;

namespace Alca259.UIControls.UserControls
{
    public sealed partial class ExtendedTreeView
    {
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExtendedTreeView));
            this.panel1 = new System.Windows.Forms.Panel();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.imageTreeList = new System.Windows.Forms.ImageList(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.treeViewButtonAdvancedFilters = new FontAwesome.Sharp.IconButton();
            this.themeLabel1 = new Alca259.UIControls.UserControls.ThemeLabel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.treeView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(332, 504);
            this.panel1.TabIndex = 0;
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.treeView1.CausesValidation = false;
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.ForeColor = System.Drawing.Color.Gainsboro;
            this.treeView1.FullRowSelect = true;
            this.treeView1.HideSelection = false;
            this.treeView1.ImageIndex = 0;
            this.treeView1.ImageList = this.imageTreeList;
            this.treeView1.LineColor = System.Drawing.Color.Gainsboro;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            this.treeView1.PathSeparator = ".";
            this.treeView1.SelectedImageIndex = 0;
            this.treeView1.Size = new System.Drawing.Size(332, 504);
            this.treeView1.TabIndex = 0;
            this.treeView1.TabStop = false;
            this.treeView1.BeforeCollapse += new System.Windows.Forms.TreeViewCancelEventHandler(this.TreeView_BeforeCollapse);
            this.treeView1.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.TreeView_BeforeExpand);
            // 
            // imageTreeList
            // 
            this.imageTreeList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageTreeList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageTreeList.ImageStream")));
            this.imageTreeList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageTreeList.Images.SetKeyName(0, "File.png");
            this.imageTreeList.Images.SetKeyName(1, "FolderClosed.png");
            this.imageTreeList.Images.SetKeyName(2, "FolderOpened.png");
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.treeViewButtonAdvancedFilters);
            this.panel2.Controls.Add(this.themeLabel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(332, 32);
            this.panel2.TabIndex = 1;
            // 
            // treeViewButtonAdvancedFilters
            // 
            this.treeViewButtonAdvancedFilters.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.treeViewButtonAdvancedFilters.FlatAppearance.BorderSize = 0;
            this.treeViewButtonAdvancedFilters.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.treeViewButtonAdvancedFilters.ForeColor = System.Drawing.Color.Gainsboro;
            this.treeViewButtonAdvancedFilters.IconChar = FontAwesome.Sharp.IconChar.Filter;
            this.treeViewButtonAdvancedFilters.IconColor = System.Drawing.Color.Gainsboro;
            this.treeViewButtonAdvancedFilters.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.treeViewButtonAdvancedFilters.IconSize = 24;
            this.treeViewButtonAdvancedFilters.Location = new System.Drawing.Point(299, 2);
            this.treeViewButtonAdvancedFilters.Name = "treeViewButtonAdvancedFilters";
            this.treeViewButtonAdvancedFilters.Size = new System.Drawing.Size(31, 30);
            this.treeViewButtonAdvancedFilters.TabIndex = 3;
            this.treeViewButtonAdvancedFilters.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.treeViewButtonAdvancedFilters.UseVisualStyleBackColor = true;
            // 
            // themeLabel1
            // 
            this.themeLabel1.AutoSize = true;
            this.themeLabel1.ForeColor = System.Drawing.Color.Gainsboro;
            this.themeLabel1.Location = new System.Drawing.Point(11, 9);
            this.themeLabel1.Name = "themeLabel1";
            this.themeLabel1.Size = new System.Drawing.Size(106, 15);
            this.themeLabel1.TabIndex = 0;
            this.themeLabel1.Text = "Extended tree view";
            // 
            // ExtendedTreeView
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "ExtendedTreeView";
            this.Size = new System.Drawing.Size(332, 536);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ImageList imageTreeList;
        private System.ComponentModel.IContainer components;
        private ThemeLabel themeLabel1;
        private FontAwesome.Sharp.IconButton treeViewButtonAdvancedFilters;
    }
}
