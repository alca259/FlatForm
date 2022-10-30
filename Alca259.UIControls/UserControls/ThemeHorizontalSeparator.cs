using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Alca259.UIControls.UserControls
{
    public sealed class ThemeHorizontalSeparator : UserControl
    {
        #region Constants
        internal const string CAT_NAME = "Separator";
        #endregion

        #region Fields
        private int _size = 2;
        private Color _color = AppColors.SeparatorColor;
        #endregion

        #region Properties
        [Category(CAT_NAME)]
        public Color SeparatorColor
        {
            get => _color;
            set
            {
                _color = value;
                Invalidate();
            }
        }

        [Category(CAT_NAME)]
        public int SeparatorSize
        {
            get => _size;
            set
            {
                _size = value;
                Invalidate();
            }
        }
        #endregion

        #region Constructors
        public ThemeHorizontalSeparator()
        {
            InitializeComponent();
        }
        #endregion

        #region Override
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics g = e.Graphics;

            using Pen penBorder = new Pen(SeparatorColor, SeparatorSize);
            penBorder.Alignment = PenAlignment.Inset;

            float middleHeight = Height / 2.0f;

            g.DrawLine(penBorder, 0, middleHeight, Width, middleHeight);
        }
        #endregion

        #region Private
        private void InitializeComponent()
        {
            SuspendLayout();
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.Transparent;
            ForeColor = Color.DimGray;
            Margin = new Padding(0);
            Name = "HorizontalSeparator";
            Padding = new Padding(0);
            Size = new Size(250, 30);
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion
    }
}
