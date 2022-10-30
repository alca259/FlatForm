using System.ComponentModel;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Windows.Forms;

namespace Alca259.UIControls.UserControls
{
    public class SwitchCheckBox : CheckBox
    {
        #region Consts
        internal const string CAT_NAME = "Switch CheckBox";
        #endregion

        #region Fields
        private Color _onBackColor = AppColors.SwitchOnBackColor;
        private Color _onToggleColor = AppColors.SwitchOnToggleColor;
        private Color _offBackColor = AppColors.SwitchOffBackColor;
        private Color _offToggleColor = AppColors.SwitchOffToggleColor;
        private bool _solidStyle = true;
        #endregion

        #region Properties
        [Category(CAT_NAME)]
        public Color OnBackColor
        {
            get => _onBackColor;
            set
            {
                _onBackColor = value;
                Invalidate();
            }
        }

        [Category(CAT_NAME)]
        public Color OnToggleColor
        {
            get => _onToggleColor;
            set
            {
                _onToggleColor = value;
                Invalidate();
            }
        }

        [Category(CAT_NAME)]
        public Color OffBackColor
        {
            get => _offBackColor;
            set
            {
                _offBackColor = value;
                Invalidate();
            }
        }

        [Category(CAT_NAME)]
        public Color OffToggleColor
        {
            get => _offToggleColor;
            set
            {
                _offToggleColor = value;
                Invalidate();
            }
        }

        [Browsable(false)]
        public override string Text { get => base.Text; set {} }

        [Category(CAT_NAME)]
        [DefaultValue(true)]
        public bool SolidStyle
        {
            get => _solidStyle;
            set
            {
                _solidStyle = value;
                Invalidate();
            }
        }
        #endregion

        #region Constructors
        public SwitchCheckBox()
        {
            MinimumSize = new Size(32, 16);
        }
        #endregion

        #region Override
        protected override void OnPaint(PaintEventArgs pevent)
        {
            int toggleSize = Height - 5;
            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            pevent.Graphics.Clear(Parent.BackColor);

            if (Checked)
            {
                if (_solidStyle)
                    pevent.Graphics.FillPath(new SolidBrush(_onBackColor), GetFigurePath());
                else pevent.Graphics.DrawPath(new Pen(_onBackColor, 2), GetFigurePath());

                pevent.Graphics.FillEllipse(new SolidBrush(_onToggleColor),
                    new Rectangle(Width - Height + 1, 2, toggleSize, toggleSize));

                return;
            }

            if (_solidStyle) pevent.Graphics.FillPath(new SolidBrush(_offBackColor), GetFigurePath());
            else pevent.Graphics.DrawPath(new Pen(_offBackColor, 2), GetFigurePath());

            pevent.Graphics.FillEllipse(new SolidBrush(_offToggleColor), new Rectangle(2, 2, toggleSize, toggleSize));
        }
        #endregion

        #region Private
        private GraphicsPath GetFigurePath()
        {
            int arcSize = Height - 1;
            Rectangle leftArc = new Rectangle(0, 0, arcSize, arcSize);
            Rectangle rightArc = new Rectangle(Width - arcSize - 2, 0, arcSize, arcSize);

            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(leftArc, 90, 180);
            path.AddArc(rightArc, 270, 180);
            path.CloseFigure();

            return path;
        }
        #endregion
    }
}