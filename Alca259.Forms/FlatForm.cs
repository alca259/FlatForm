/**
 * Author: Alca259
 * Creation date: 5 Sept 2022
 * Last modified date: 5 Sept 2022
 * 
 * Copyright 2022 Alca259
 *
 * Creative Commons Attribution-NonCommercial-ShareAlike 4.0 International Public License
 * License: https://creativecommons.org/licenses/by-nc-sa/4.0/legalcode
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
using Alca259.Forms.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Alca259.Forms
{
    public partial class FlatForm : Form
    {
        #region Consts
        internal const string CAT_NAME = "Flat Form";

        private const int RESIZE_MSG = 132;
        private const int WM_NC_CALC_SIZE = 0x0083;
        /// <summary>
        /// Represents the client area of the window
        /// </summary>
        private const int HTCLIENT = 1;
        /// <summary>
        /// Left border of a window, allows resize horizontally to the left
        /// </summary>
        private const int HTLEFT = 10;
        /// <summary>
        /// Right border of a window, allows resize horizontally to the right
        /// </summary>
        private const int HTRIGHT = 11;
        /// <summary>
        /// Upper-horizontal border of a window, allows resize vertically up
        /// </summary>
        private const int HTTOP = 12;
        /// <summary>
        /// Upper-left corner of a window border, allows resize diagonally to the left
        /// </summary>
        private const int HTTOPLEFT = 13;
        /// <summary>
        /// Upper-right corner of a window border, allows resize diagonally to the right
        /// </summary>
        private const int HTTOPRIGHT = 14;
        /// <summary>
        /// Lower-horizontal border of a window, allows resize vertically down
        /// </summary>
        private const int HTBOTTOM = 15;
        /// <summary>
        /// Lower-left corner of a window border, allows resize diagonally to the left
        /// </summary>
        private const int HTBOTTOMLEFT = 16;
        /// <summary>
        /// Lower-right corner of a window border, allows resize diagonally to the right
        /// </summary>
        private const int HTBOTTOMRIGHT = 17;
        private const int RESIZE_AREA_SIZE = 10;
        #endregion

        #region Fields
        private int _borderSize = 1;
        private int _initialBorderSize = 1;
        private bool _isMaximized = false;
        private WindowBar _topWindowBar;
        private NavigationMenu _navigationMenu;
        #endregion

        #region Exposed properties

        #region Navigation menu options
        [Category(NavigationMenu.CAT_NAME)] public bool EnableNavigationMenu { get; set; } = true;
        [Category(NavigationMenu.CAT_NAME)] public bool StartMenuOpen { get; set; } = true;
        [Category(NavigationMenu.CAT_NAME)] public int MenuExpandedWidth { get; set; } = 230;
        [Category(NavigationMenu.CAT_NAME)] public Color MenuBackgroundColor { get; set; } = Color.FromArgb(77, 77, 77);
        [Category(NavigationMenu.CAT_NAME)] public Color MenuForegroundColor { get; set; } = Color.Gainsboro;
        [Category(NavigationMenu.CAT_NAME)] public List<ButtonData> MenuItems { get; set; } = new List<ButtonData>();
        #endregion

        #region Form options
        [Category(CAT_NAME)]
        public int BorderSize
        {
            get => _borderSize;
            set
            {
                _borderSize = value;
                Padding = new Padding(_borderSize);
            }
        }

        [Category(CAT_NAME)] public Color BorderColor { get; set; } = Color.FromArgb(31, 98, 169);
        [Category(CAT_NAME)] public bool HideDefaultBorders { get; set; } = true;
        #endregion

        #region Control bar options
        [Category(WindowBar.CAT_NAME)] public bool EnableControlBar { get; set; } = true;
        [Category(WindowBar.CAT_NAME)] public int TopWindowHeight { get; set; } = 26;
        [Category(WindowBar.CAT_NAME)] public Color TopBarBackgroundColor { get; set; } = Color.FromArgb(77, 77, 77);
        [Category(WindowBar.CAT_NAME)] public Color TopBarForegroundColor { get; set; } = Color.Gainsboro;
        [Category(WindowBar.CAT_NAME)] public string Title { get; set; }
        [Category(WindowBar.CAT_NAME)] public bool EnableMinimizeButton { get; set; } = true;
        [Category(WindowBar.CAT_NAME)] public bool EnableMaximizeButton { get; set; } = true;
        [Category(WindowBar.CAT_NAME)] public bool EnableCloseButton { get; set; } = true;
        #endregion

        #endregion

        #region Constructor
        protected virtual void PreInitializate()
        {

        }

        public FlatForm()
        {
            PreInitializate();
            InitializeComponent();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            PostInitialize();
        }

        protected virtual void PostInitialize()
        {
            Resize += FlatForm_Resize;

            if (EnableNavigationMenu)
            {
                _navigationMenu = new NavigationMenu
                {
                    StartMenuOpen = StartMenuOpen,
                    MenuExpandedWidth = MenuExpandedWidth,
                    Dock = DockStyle.Left,
                    BackColor = MenuBackgroundColor,
                    ForeColor = MenuForegroundColor,
                    Items = MenuItems
                };
                _navigationMenu.PostInitialize();
                Controls.Add(_navigationMenu);
            }

            if (EnableControlBar)
            {
                _topWindowBar = new WindowBar
                {
                    Dock = DockStyle.Top,
                    Height = TopWindowHeight,
                    BackColor = TopBarBackgroundColor,
                    ForeColor = TopBarForegroundColor,
                    Title = Title,
                    EnableMinimizeButton = EnableMinimizeButton,
                    EnableMaximizeButton = EnableMaximizeButton,
                    EnableCloseButton = EnableCloseButton
                };
                _topWindowBar.BorderSizeChanged += TopWindowBar_BorderSizeChanged;
                _topWindowBar.WindowMaximized += TopWindowBar_WindowMaximized;
                Controls.Add(_topWindowBar);
            }

            _initialBorderSize = _borderSize;
            Padding = new Padding(BorderSize);
            BackColor = BorderColor;
        }
        #endregion

        #region Hide Borders, working area and snap
        protected override void WndProc(ref Message m)
        {
            if (HideDefaultBorders && m.Msg == WM_NC_CALC_SIZE && m.WParam.ToInt32() == 1)
            {
                // Hide borders
                return;
            }

            base.WndProc(ref m);
            ResizeControl(ref m);
        }

        /// <summary>
        /// More Information: https://docs.microsoft.com/en-us/windows/win32/inputdev/wm-nchittest
        /// </summary>
        private void ResizeControl(ref Message m)
        {
            // If the windows m is RESIZE_MSG
            if (m.Msg != RESIZE_MSG)
            {
                return;
            }

            // Resize the form if it is in normal state or the result of the m (mouse pointer) is in the client area of the window
            if (WindowState != FormWindowState.Normal || (int)m.Result != HTCLIENT)
                return;

            // Gets screen point coordinates(X and Y coordinate of the pointer)
            Point screenPoint = new Point(m.LParam.ToInt32());

            // Computes the location of the screen point into client coordinates
            Point client = PointToClient(screenPoint);

            // If the pointer is at the top of the form (within the resize area- X coordinate)
            if (client.Y <= RESIZE_AREA_SIZE)
            {
                // If the pointer is at the coordinate X=0 or less than the resizing area(X=10) in
                if (client.X <= RESIZE_AREA_SIZE)
                {
                    // Resize diagonally to the left
                    m.Result = (IntPtr)HTTOPLEFT;
                }
                else
                {
                    // If the pointer is at the coordinate X=11 or less than the width of the form(X=Form.Width-resizeArea)
                    // Resize vertically up
                    // Resize diagonally to the right
                    int x = client.X;
                    int num = Size.Width - RESIZE_AREA_SIZE;
                    m.Result = x >= num ? (IntPtr)HTTOPRIGHT : (IntPtr)HTTOP;
                }
            }
            else
            {
                // If the pointer is inside the form at the Y coordinate(discounting the resize area size)
                int y = client.Y;
                Size size = Size;
                int num1 = size.Height - RESIZE_AREA_SIZE;
                if (y <= num1)
                {
                    // Resize horizontally to the left
                    if (client.X <= RESIZE_AREA_SIZE) m.Result = (IntPtr)HTLEFT;
                    // Resize horizontally to the right
                    else if (client.X > Width - RESIZE_AREA_SIZE) m.Result = (IntPtr)HTRIGHT;
                }
                else if (client.X <= RESIZE_AREA_SIZE)
                {
                    // Resize diagonally to the left
                    m.Result = (IntPtr)HTBOTTOMLEFT;
                }
                else
                {
                    // Resize vertically down
                    // Resize diagonally to the right
                    int x = client.X;
                    int num2 = size.Width - RESIZE_AREA_SIZE;
                    m.Result = x >= num2 ? (IntPtr)HTBOTTOMRIGHT : (IntPtr)HTBOTTOM;
                }
            }
        }
        #endregion

        #region Event Handlers
        private void FlatForm_Resize(object sender, EventArgs e)
        {
            if (WindowState != FormWindowState.Normal || !_isMaximized) return;

            _isMaximized = false;
            BorderSize = _initialBorderSize;
            _topWindowBar.SetMaximizeButton();
        }

        private void TopWindowBar_WindowMaximized(object sender, bool e)
        {
            _isMaximized = e;
        }

        private void TopWindowBar_BorderSizeChanged(object sender, int e)
        {
            BorderSize = e;
        }
        #endregion
    }
}
