using Alca259.UIControls.DTOs;
using System.Linq;
using System.Windows.Forms;

namespace Alca259.UIControls.UserControls
{
    public sealed partial class TranslationItem : UserControl
    {
        public TranslationItem()
        {
            InitializeComponent();
        }

        public void SetElements(TranslationItemData data)
        {
            int elementHeight = 0;
            lblKey.Text = data.Key;

            panelOutput.Controls.Clear();
            foreach (TranslationItemElementData item in data.Elements.OrderByDescending(o => o.LanguageKey))
            {
                var control = new TranslationItemElement(item.LanguageKey, item.Value, item.IsApproved) { Dock = DockStyle.Top };
                if (control.Height > elementHeight) elementHeight = control.Height;
                panelOutput.Controls.Add(control);
            }

            // Set height
            Height = (elementHeight * panelOutput.Controls.Count) + panel1.Height;
        }
    }
}
