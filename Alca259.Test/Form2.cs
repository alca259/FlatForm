using Alca259.UIControls;
using Alca259.UIControls.DTOs;
using Alca259.UIControls.Renderers;
using Alca259.UIControls.UserControls;
using System.Collections.Generic;

namespace Alca259.Test
{
    public partial class Form2 : FlatForm
    {
        public Form2()
        {
            //MenuItems.Add(new ButtonData
            //{
            //    Text = "Prueba",
            //    Icon = FontAwesome.Sharp.IconChar.Exclamation,
            //    IconSize = 24,
            //    IconColor = System.Drawing.Color.Red,
            //    IconFont = FontAwesome.Sharp.IconFont.Auto,
            //});
            InitializeComponent();
            menuStrip1.Renderer = new ToolStripDarkRenderer();

            Load += Form2_Load;
        }

        private void Form2_Load(object sender, System.EventArgs e)
        {
            var nodes = new List<TreeItemData>
            {
                new TreeItemData { Key = "mydata.test.abc1" },
                new TreeItemData { Key = "mydata.test.abcd2" },
                new TreeItemData { Key = "mydata.test.abce3" },
                new TreeItemData { Key = "mydata.test.abcf4" },
                new TreeItemData { Key = "mydata.test2.abc1" },
                new TreeItemData { Key = "mydata.test2.abcd2" },
                new TreeItemData { Key = "mydata.test2.abce3" },
                new TreeItemData { Key = "mydata.test2.abcf4" },
                new TreeItemData { Key = "mydata1.test3.abc1" },
                new TreeItemData { Key = "mydata1.test3.abcd2" },
                new TreeItemData { Key = "mydata1.test3.abce3" },
                new TreeItemData { Key = "mydata1.test3.abcf4" },
                new TreeItemData { Key = "mydata1.test3." },
                new TreeItemData { Key = "mydata1..abcf4" },
            };

            extendedTreeView1.SetNodes(nodes);

            themeGridView1.Rows.Add("Text 1", "Text 2", "Text 3", "Text 4");
            themeGridView1.Rows.Add("Text 5", "Text 6", "Text 7", "Text 8");
        }
    }
}
