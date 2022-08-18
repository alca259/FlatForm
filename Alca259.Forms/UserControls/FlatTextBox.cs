using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Alca259.Forms.UserControls
{
    [DefaultEvent("FlatTextChanged")]
    public partial class FlatTextBox : UserControl
    {
        #region Consts
        private const string CAT_NAME = "Flat TextBox";
        #endregion

        #region Fields
        private Color _borderColor = Color.FromArgb(31, 98, 169);
        private Color _borderFocusColor = Color.FromArgb(31, 98, 169);
        private int _borderSize = 2;
        private bool _borderUnderlinedStyle = false;
        private bool _flatTextBoxIsFocused = false;
        #endregion

        #region Properties
        [Category(CAT_NAME)]
        public Color BorderColor
        {
            get { return _borderColor; }
            set
            {
                _borderColor = value;
                Invalidate();
            }
        }

        [Category(CAT_NAME)]
        public int BorderSize
        {
            get { return _borderSize; }
            set
            {
                _borderSize = value;
                Invalidate();
            }
        }

        [Category(CAT_NAME)]
        public bool UnderlinedStyle
        {
            get { return _borderUnderlinedStyle; }
            set
            {
                _borderUnderlinedStyle = value;
                Invalidate();
            }
        }

        [Category(CAT_NAME)]
        public bool PasswordChar
        {
            get { return textBox1.UseSystemPasswordChar; }
            set { textBox1.UseSystemPasswordChar = value; }
        }

        [Category(CAT_NAME)]
        public bool Multiline
        {
            get { return textBox1.Multiline; }
            set { textBox1.Multiline = value; }
        }

        [Category(CAT_NAME)]
        public override Color BackColor
        {
            get { return base.BackColor; }
            set
            {
                base.BackColor = value;
                textBox1.BackColor = value;
            }
        }

        [Category(CAT_NAME)]
        public override Color ForeColor
        {
            get { return base.ForeColor; }
            set
            {
                base.ForeColor = value;
                textBox1.ForeColor = value;
            }
        }

        [Category(CAT_NAME)]
        public override Font Font
        {
            get { return base.Font; }
            set
            {
                base.Font = value;
                textBox1.Font = value;
                if (DesignMode)
                    UpdateControlHeight();
            }
        }

        [Category(CAT_NAME)]
        public string Texts
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }

        [Category(CAT_NAME)]
        public Color BorderFocusColor
        {
            get { return _borderFocusColor; }
            set { _borderFocusColor = value; }
        }

        public bool IsFocused => _flatTextBoxIsFocused;
        #endregion

        #region Events
        public event EventHandler FlatTextChanged;
        #endregion

        #region Constructors
        public FlatTextBox()
        {
            InitializeComponent();
        }
        #endregion

        #region Override
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics graph = e.Graphics;

            using Pen penBorder = new Pen(_borderColor, _borderSize);

            penBorder.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset;
            if (_flatTextBoxIsFocused) penBorder.Color = _borderFocusColor;

            if (_borderUnderlinedStyle)
            {
                graph.DrawLine(penBorder, 0, Height - 1, Width, Height - 1);
            }
            else
            {
                graph.DrawRectangle(penBorder, 0, 0, Width - 0.5F, Height - 0.5F);
            }
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if (DesignMode)
                UpdateControlHeight();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            UpdateControlHeight();
        }
        #endregion

        #region Private
        private void UpdateControlHeight()
        {
            if (textBox1.Multiline != false) return;

            int txtHeight = TextRenderer.MeasureText("Text", Font).Height + 1;
            textBox1.Multiline = true;
            textBox1.MinimumSize = new Size(0, txtHeight);
            textBox1.Multiline = false;

            Height = textBox1.Height + Padding.Top + Padding.Bottom;
        }
        #endregion

        #region Event Handlers
        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            if (FlatTextChanged != null)
                FlatTextChanged.Invoke(sender, e);
        }

        private void TextBox1_Click(object sender, EventArgs e)
        {
            OnClick(e);
        }

        private void TextBox1_MouseEnter(object sender, EventArgs e)
        {
            OnMouseEnter(e);
        }

        private void TextBox1_MouseLeave(object sender, EventArgs e)
        {
            OnMouseLeave(e);
        }

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnKeyPress(e);
        }

        private void TextBox1_Enter(object sender, EventArgs e)
        {
            _flatTextBoxIsFocused = true;
            Invalidate();
        }

        private void TextBox1_Leave(object sender, EventArgs e)
        {
            _flatTextBoxIsFocused = false;
            Invalidate();
        }
        #endregion
    }
}