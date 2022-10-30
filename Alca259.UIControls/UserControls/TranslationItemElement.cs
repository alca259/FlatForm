using System.Windows.Forms;

namespace Alca259.UIControls.UserControls
{
    public sealed partial class TranslationItemElement : UserControl
    {
        #region Properties
        public string LanguageKey
        {
            get => lblLanguageKey.Text;
            set => lblLanguageKey.Text = value;
        }

        public string Value
        {
            get => txtInputValue.Texts;
            set => txtInputValue.Texts = value;
        }

        public bool Approved
        {
            get => approvedCheckbox.Checked;
            set => approvedCheckbox.Checked = value;
        }
        #endregion

        public TranslationItemElement()
        {
            InitializeComponent();

            txtInputValue.FlatTextChanged += TxtInputValue_FlatTextChanged;
        }

        public TranslationItemElement(string key, string value, bool isApproved) : this()
        {
            LanguageKey = key;
            Value = value;
            Approved = isApproved;
        }

        private void TxtInputValue_FlatTextChanged(object sender, System.EventArgs e)
        {
            if (approvedCheckbox.Checked) approvedCheckbox.Checked = false;
        }
    }
}
