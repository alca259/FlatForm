/**
 * Author: Alca259
 * Creation date: 5 Sept 2022
 * Last modified date: 5 Sept 2022
 * 
 * Copyright 2022 Alca259
 *
 * Redistribution and use in source and binary forms, with or without modification,
 * only for NON-COMMERCIAL USE,
 * are permitted provided that the following conditions are met:
 * 
 * 1. Redistributions of source code must retain the above copyright notice,
 * this list of conditions and the following disclaimer.
 *
 * 2. Redistributions in binary form must reproduce the above copyright notice,
 * this list of conditions and the following disclaimer in the documentation
 * and/or other materials provided with the distribution.
 *
 * 3. Neither the name of the copyright holder nor the names of its contributors
 * may be used to endorse or promote products derived from this software without
 * specific prior written permission.
 * 
 * THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS"
 * AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO,
 * THE IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED.
 * IN NO EVENT SHALL THE COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT, INDIRECT,
 * INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES
 * (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION)
 * HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY,
 * OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE,
 * EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
 **/
using System.ComponentModel;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Windows.Forms;

namespace Alca259.Forms.UserControls
{
    public class SwitchCheckBox : CheckBox
    {
        #region Consts
        private const string CAT_NAME = "Switch CheckBox";
        #endregion

        #region Fields
        private Color _onBackColor = Color.MediumSlateBlue;
        private Color _onToggleColor = Color.WhiteSmoke;
        private Color _offBackColor = Color.Gray;
        private Color _offToggleColor = Color.Gainsboro;
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
        protected override void OnPaint(PaintEventArgs @event)
        {
            int toggleSize = Height - 5;
            @event.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            @event.Graphics.Clear(Parent.BackColor);

            if (Checked)
            {
                if (_solidStyle)
                    @event.Graphics.FillPath(new SolidBrush(_onBackColor), GetFigurePath());
                else @event.Graphics.DrawPath(new Pen(_onBackColor, 2), GetFigurePath());

                @event.Graphics.FillEllipse(new SolidBrush(_onToggleColor),
                    new Rectangle(Width - Height + 1, 2, toggleSize, toggleSize));

                return;
            }

            if (_solidStyle) @event.Graphics.FillPath(new SolidBrush(_offBackColor), GetFigurePath());
            else @event.Graphics.DrawPath(new Pen(_offBackColor, 2), GetFigurePath());

            @event.Graphics.FillEllipse(new SolidBrush(_offToggleColor), new Rectangle(2, 2, toggleSize, toggleSize));
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