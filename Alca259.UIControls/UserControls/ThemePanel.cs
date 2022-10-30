using System.Windows.Forms;

namespace Alca259.UIControls.UserControls
{
    public sealed class ThemePanel : Panel
    {
        public ThemePanel()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            BackColor = AppColors.ApplicationBackground;
        }
    }
}
