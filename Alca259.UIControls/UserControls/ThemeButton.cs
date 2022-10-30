using System.Windows.Forms;

namespace Alca259.UIControls.UserControls
{
    public class ThemeButton : Button
    {
        public ThemeButton()
        {
            ForeColor = AppColors.ApplicationFontColor;
            BackColor = AppColors.ButtonBackgroundColor;
            FlatAppearance.BorderColor = AppColors.ButtonBorderColor;
            FlatAppearance.BorderSize = 1;
            FlatStyle = FlatStyle.Flat;
        }
    }
}
