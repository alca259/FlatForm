using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Alca259.Forms.UserControls
{
    public class FlatButton : Button
    {
        #region Consts
        private const string CAT_NAME = "Flat Button";
        #endregion

        #region Exposed properties
        [Category(CAT_NAME)]
        public bool DarkColors { get; set; } = true;
        #endregion

        #region Constructor
        public FlatButton()
        {
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;

            if (DarkColors)
            {
                BackColor = Color.FromArgb(77, 77, 77);
                ForeColor = Color.FromArgb(220, 220, 220);
            }
        }
        #endregion
    }
}