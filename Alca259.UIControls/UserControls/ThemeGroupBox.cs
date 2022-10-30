using Alca259.UIControls.Extensions;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Alca259.UIControls.UserControls
{
    public sealed class ThemeGroupBox : GroupBox
    {
        #region Constants
        internal const string CAT_NAME = "Groupbox";
        #endregion

        #region Fields
        private bool _drawBorder = true;
        private Color _borderColor = AppColors.GroupBoxBorder;
        private int _borderWidth = 1;
        private int _borderRadius = 10;
        private int _textIndent = 20;
        #endregion

        #region Properties
        [Category(CAT_NAME)]
        public bool DrawBorder
        {
            get => _drawBorder;
            set
            {
                _drawBorder = value;
                DrawGroupBox();
            }
        }

        [Category(CAT_NAME)]
        public Color BorderColor
        {
            get => _borderColor;
            set
            {
                _borderColor = value;
                DrawGroupBox();
            }
        }

        [Category(CAT_NAME)]
        public int BorderWidth
        {
            get => _borderWidth;
            set
            {
                if (value > 0)
                {
                    _borderWidth = Math.Min(value, 5);
                    DrawGroupBox();
                }
            }
        }

        [Category(CAT_NAME)]
        public int BorderRadius
        {
            get => _borderRadius;
            set
            {   // Setting a radius of 0 produces square corners...
                if (value >= 0)
                {
                    _borderRadius = value;
                    DrawGroupBox();
                }
            }
        }

        [Category(CAT_NAME)]
        public int LabelIndent
        {
            get => _textIndent;
            set
            {
                _textIndent = value;
                DrawGroupBox();
            }
        }
        #endregion

        #region Constructor
        public ThemeGroupBox()
        {
            InitializeComponent();
        }
        #endregion

        #region Override
        protected override void OnPaint(PaintEventArgs e) => DrawGroupBox(e.Graphics);
        #endregion

        #region Private
        private void InitializeComponent()
        {
            BackColor = AppColors.GroupBoxBackground;
            ForeColor = AppColors.GroupBoxFont;
        }

        private void DrawGroupBox() => DrawGroupBox(CreateGraphics());

        private void DrawGroupBox(Graphics g)
        {
            // Clear text and border
            g.Clear(BackColor);

            SizeF strSize = g.MeasureString(Text, Font);
            Rectangle rect = new Rectangle(
                x: ClientRectangle.X,
                y: ClientRectangle.Y + (int)(strSize.Height / 2),
                width: ClientRectangle.Width - 1 - BorderWidth,
                height: ClientRectangle.Height - (int)(strSize.Height / 2) - 1);

            if (DrawBorder)
            {
                Brush borderBrush = new SolidBrush(BorderColor);
                Pen borderPen = new Pen(borderBrush, _borderWidth);

                // Drawing Border (added "Fix" from Jim Fell, Oct 6, '18)
                int rectX = (0 == _borderWidth % 2)
                    ? rect.X + _borderWidth / 2
                    : rect.X + 1 + _borderWidth / 2;

                int rectHeight = (0 == _borderWidth % 2)
                    ? rect.Height - _borderWidth / 2
                    : rect.Height - 1 - _borderWidth / 2;

                // NOTE DIFFERENCE: rectX vs rect.X and rectHeight vs rect.Height
                g.DrawRoundedRectangle(borderPen, rectX, rect.Y, rect.Width, rectHeight, (float)_borderRadius);
            }

            // Draw text
            if (Text.Length > 0)
            {
                Brush textBrush = new SolidBrush(ForeColor);
                Brush labelBrush = new SolidBrush(BackColor);

                // Do some work to ensure we don't put the label outside
                // of the box, regardless of what value is assigned to the Indent:
                int width = rect.Width, posX;

                posX = (_textIndent < 0)
                    ? Math.Max(0 - width, _textIndent)
                    : Math.Min(width, _textIndent);

                posX = (posX < 0)
                    ? rect.Width + posX - (int)strSize.Width
                    : posX;

                g.FillRectangle(labelBrush, posX, 0, strSize.Width + 1, strSize.Height);
                g.DrawString(Text, Font, textBrush, posX, 0);
            }
        }
        #endregion
    }
}
