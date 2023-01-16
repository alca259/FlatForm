using Alca259.UIControls.DTOs;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace Alca259.UIControls.UserControls
{
    public sealed partial class ExtendedTreeView : UserControl
    {
        #region Constants
        internal const string CAT_NAME = "Tree view";
        #endregion

        #region Fields
        private string headerText = "Title";
        #endregion

        #region Properties
        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always), Category(CAT_NAME)]
        public string HeaderText
        {
            get => headerText;
            set
            {
                headerText = value;
                themeLabel1.Text = value;
            }
        }
        #endregion

        #region Constructor
        public ExtendedTreeView()
        {
            InitializeComponent();

            panel1.BackColor = BackColor;
            panel2.BackColor = BackColor;
            treeView1.BackColor = BackColor;
        }
        #endregion

        #region Methods
        public void SetNodes(List<TreeItemData> items)
        {
            treeView1.Nodes.AddRange(TreeItemData.GetNodes(items));
        }

        public void ClearNodes()
        {
            treeView1.Nodes.Clear();
        }
        #endregion

        #region Events
        private void TreeView_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            e.Node.ImageIndex = (int)TreeItemData.Constants.FolderOpened;
            e.Node.SelectedImageIndex = e.Node.ImageIndex;
        }

        private void TreeView_BeforeCollapse(object sender, TreeViewCancelEventArgs e)
        {
            e.Node.ImageIndex = (int)TreeItemData.Constants.FolderClosed;
            e.Node.SelectedImageIndex = e.Node.ImageIndex;
        }
        #endregion
    }
}
