using System.Drawing;
using System.Windows.Forms;

namespace Alca259.UIControls
{
    internal class AppColors : ProfessionalColorTable
    {
        public static Color ApplicationBorderColor => Color.FromArgb(113, 96, 231);
        public static Color ApplicationBackground => Color.FromArgb(66, 66, 66);
        public static Color ApplicationFontColor => Color.Gainsboro;

        public static Color MenuBackgroundColor => Color.FromArgb(66, 66, 66);
        public static Color MenuBorderColor => Color.FromArgb(30, 30, 30);

        public static Color ButtonBackgroundColor => Color.FromArgb(66, 66, 66);
        public static Color ButtonBorderColor => Color.FromArgb(30, 30, 30);

        public static Color TopBarBackgroundColor => Color.FromArgb(77, 77, 77);
        public static Color TopBarForegroundColor => Color.Gainsboro;

        public static Color TextBoxBorderColor => Color.FromArgb(113, 96, 231);
        public static Color TextBoxBorderFocusColor => Color.FromArgb(31, 98, 169);

        public static Color SwitchOnBackColor => Color.MediumSlateBlue;
        public static Color SwitchOnToggleColor => Color.WhiteSmoke;
        public static Color SwitchOffBackColor => Color.Gray;
        public static Color SwitchOffToggleColor => Color.Gainsboro;

        public static Color SeparatorColor => Color.FromArgb(100, 100, 100);

        public static Color GridBackground => Color.FromArgb(30, 30, 30);
        public static Color GridHeaderBackground => Color.FromArgb(66, 66, 66);
        public static Color GridHeaderFontColor => Color.Gainsboro;
        public static Color GridHeaderHighlightBackground => Color.FromArgb(66, 66, 66);
        public static Color GridHeaderHighlightFontColor => Color.Gainsboro;
        public static Color GridRowsBackground => Color.FromArgb(30, 30, 30);
        public static Color GridRowsFontColor => Color.Gainsboro;
        public static Color GridRowsHighlightBackground => SystemColors.Highlight;
        public static Color GridRowsHighlightFontColor => Color.Gainsboro;
        public static Color GridRowsSeparator => Color.FromArgb(66, 66, 66);

        public static Color GroupBoxBackground => Color.FromArgb(66, 66, 66);
        public static Color GroupBoxBorder => Color.FromArgb(80, 80, 80);
        public static Color GroupBoxFont => Color.Gainsboro;

        public static Color TranslationItemBackground => Color.FromArgb(50, 50, 50);

        #region Override
        public override Color MenuBorder => MenuBorderColor;

        public override Color MenuItemBorder => MenuBorderColor;
        public override Color MenuItemSelectedGradientBegin => MenuBackgroundColor;
        public override Color MenuItemSelectedGradientEnd => MenuBackgroundColor;

        public override Color MenuItemPressedGradientBegin => MenuBackgroundColor;
        public override Color MenuItemPressedGradientMiddle => MenuBackgroundColor;
        public override Color MenuItemPressedGradientEnd => MenuBackgroundColor;

        public override Color ImageMarginGradientBegin => MenuBackgroundColor;
        public override Color ImageMarginGradientMiddle => MenuBackgroundColor;
        public override Color ImageMarginGradientEnd => MenuBackgroundColor;

        public override Color ToolStripDropDownBackground => MenuBackgroundColor;

        public override Color ButtonSelectedHighlightBorder => MenuBackgroundColor;
        #endregion
    }
}
