﻿using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Alca259.Forms
{
    public partial class FlatForm : Form
    {
        #region Consts
        private const string WIN_LIB = "user32.dll";
        private const string CAT_NAME = "Flat Form";
        private const int DRAG_MESSAGE = 0x112;
        private const int DRAG_MESSAGE_PARAM = 0xf012;
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
        /// <summary>
        /// Win32, Mouse Input Notification: Determine what part of the window corresponds to a point, allows to resize the form.
        /// </summary>
        private const int WM_NCHITTEST = 0x0084;
        private const int WM_SYSCOMMAND = 0x0112;
        /// <summary>
        /// Minimize form (Before)
        /// </summary>
        private const int SC_MINIMIZE = 0xF020;
        /// <summary>
        /// Restore form (Before)
        /// </summary>
        private const int SC_RESTORE = 0xF120;
        private const int RESIZE_AREA_SIZE = 10;
        #endregion

        #region Fields
        /// <summary>
        /// Keep form size when it is minimized and restored.
        /// Since the form is resized because it takes into account the size of the title bar and borders.
        /// </summary>
        private Size _formSize;
        #endregion

        #region Protected properties
        protected bool IsMenuOpen { get; private set; } = true;
        #endregion

        #region Exposed properties
        [Category(CAT_NAME)]
        public Control DragControl { get; set; }

        [Category(CAT_NAME)]
        public Button MinimizeButton { get; set; }

        [Category(CAT_NAME)]
        public Button MaximizeButton { get; set; }

        [Category(CAT_NAME)]
        public Button CloseButton { get; set; }

        [Category(CAT_NAME)]
        public Panel MenuPanel { get; set; }

        [Category(CAT_NAME)]
        public Button MenuToggleButton { get; set; }

        [Category(CAT_NAME)]
        public bool StartMenuOpen { get; set; } = true;

        [Category(CAT_NAME)]
        public int MenuCollapsedWidth { get; set; } = 100;

        [Category(CAT_NAME)]
        public int MenuExpandedWidth { get; set; } = 230;
        
        [Category(CAT_NAME)]
        public int BorderSize { get; set; } = 1;

        [Category(CAT_NAME)]
        public Color BorderColor { get; set; } = Color.FromArgb(31, 98, 169);

        [Category(CAT_NAME)]
        public bool HideDefaultBorders { get; set; } = true;
        #endregion

        #region Constructor
        public FlatForm()
        {
            InitializeComponent();
            Padding = new Padding(BorderSize);
            BackColor = BorderColor;

            Resize += FlatForm_Resize;

            if ((IsMenuOpen && !StartMenuOpen) || (!IsMenuOpen && StartMenuOpen))
            {
                CollapseMenu();
            }
        }

        protected virtual void InitializeEventHandlers()
        {
            if (DragControl != null) DragControl.MouseDown += DragControl_MouseDown;
            if (MinimizeButton != null) MinimizeButton.Click += MinimizeButton_Click;
            if (MaximizeButton != null) MaximizeButton.Click += MaximizeButton_Click;
            if (CloseButton != null) CloseButton.Click += CloseButton_Click;
            if (MenuPanel != null && MenuToggleButton != null) MenuToggleButton.Click += MenuToggleButton_Click;

            _formSize = ClientSize;
        }
        #endregion

        #region Dll Import (Drag form)
        [DllImport(WIN_LIB, EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport(WIN_LIB, EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

        #region Event Handlers
        private void DragControl_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, DRAG_MESSAGE, DRAG_MESSAGE_PARAM, 0);
        }
        #endregion

        #endregion

        #region Hide Borders, working area and snap
        protected override void WndProc(ref Message m)
        {
            ResizeControl(ref m);

            if (HideDefaultBorders && m.Msg == WM_NC_CALC_SIZE && m.WParam.ToInt32() == 1)
            {
                // Hide borders
                return;
            }

            KeepFormSize(ref m);

            base.WndProc(ref m);
        }

        /// <summary>
        /// More Information: https://docs.microsoft.com/en-us/windows/win32/inputdev/wm-nchittest
        /// </summary>
        private void ResizeControl(ref Message m)
        {
            // If the windows m is WM_NCHITTEST
            if (m.Msg != WM_NCHITTEST)
            {
                return;
            }

            base.WndProc(ref m);
            if (WindowState != FormWindowState.Normal) // Resize the form if it is in normal state
            {
                return;
            }

            if ((int)m.Result != HTCLIENT) // If the result of the m (mouse pointer) is in the client area of the window
            {
                return;
            }

            Point screenPoint = new Point(m.LParam.ToInt32()); // Gets screen point coordinates(X and Y coordinate of the pointer)                           
            Point clientPoint = PointToClient(screenPoint); // Computes the location of the screen point into client coordinates                          
            if (clientPoint.Y <= RESIZE_AREA_SIZE)// If the pointer is at the top of the form (within the resize area- X coordinate)
            {
                if (clientPoint.X <= RESIZE_AREA_SIZE) // If the pointer is at the coordinate X=0 or less than the resizing area(X=10) in 
                    m.Result = (IntPtr)HTTOPLEFT; // Resize diagonally to the left
                else if (clientPoint.X < (Size.Width - RESIZE_AREA_SIZE))// If the pointer is at the coordinate X=11 or less than the width of the form(X=Form.Width-resizeArea)
                    m.Result = (IntPtr)HTTOP; // Resize vertically up
                else // Resize diagonally to the right
                    m.Result = (IntPtr)HTTOPRIGHT;
            }
            else if (clientPoint.Y <= (Size.Height - RESIZE_AREA_SIZE)) // If the pointer is inside the form at the Y coordinate(discounting the resize area size)
            {
                if (clientPoint.X <= RESIZE_AREA_SIZE)// Resize horizontally to the left
                    m.Result = (IntPtr)HTLEFT;
                else if (clientPoint.X > (Width - RESIZE_AREA_SIZE))// Resize horizontally to the right
                    m.Result = (IntPtr)HTRIGHT;
            }
            else
            {
                if (clientPoint.X <= RESIZE_AREA_SIZE)// Resize diagonally to the left
                    m.Result = (IntPtr)HTBOTTOMLEFT;
                else if (clientPoint.X < (Size.Width - RESIZE_AREA_SIZE)) // Resize vertically down
                    m.Result = (IntPtr)HTBOTTOM;
                else // Resize diagonally to the right
                    m.Result = (IntPtr)HTBOTTOMRIGHT;
            }
        }

        /// <summary>
        /// Keep form size when it is minimized and restored.
        /// Since the form is resized because it takes into account the size of the title bar and borders.
        /// </summary>
        /// <see cref="https://docs.microsoft.com/en-us/windows/win32/menurc/wm-syscommand"/>
        /// <remarks>
        /// In WM_SYSCOMMAND messages, the four low - order bits of the wParam parameter 
        /// are used internally by the system.To obtain the correct result when testing 
        /// the value of wParam, an application must combine the value 0xFFF0 with the 
        /// wParam value by using the bitwise AND operator.
        /// </remarks>
        /// <param name="m"></param>
        private void KeepFormSize(ref Message m)
        {
            if (m.Msg != WM_SYSCOMMAND)
            {
                return;
            }

            int wParam = (m.WParam.ToInt32() & 0xFFF0);
            if (wParam == SC_MINIMIZE) // Before
                _formSize = ClientSize;
            if (wParam == SC_RESTORE) // Restored form(Before)
                Size = _formSize;
        }

        #region Event Handlers
        private void FlatForm_Resize(object sender, EventArgs e)
        {
            // Working area
            AdjustForm();
        }

        private void AdjustForm()
        {
            switch (WindowState)
            {
                case FormWindowState.Normal when Padding.Top != BorderSize:
                    Padding = new Padding(BorderSize);
                    break;
                case FormWindowState.Maximized:
                    Padding = new Padding(0, 8, 8, 0);
                    break;
                default:
                    break;
            }
        }
        #endregion

        #endregion

        #region Top bar buttons
        protected void Minimize()
        {
            WindowState = FormWindowState.Minimized;
        }

        protected void Maximize()
        {
            WindowState = WindowState == FormWindowState.Normal
                ? FormWindowState.Maximized
                : FormWindowState.Normal;
        }

        protected void CloseForm()
        {
            Close();
        }

        #region Event Handlers
        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            Minimize();
        }

        private void MaximizeButton_Click(object sender, EventArgs e)
        {
            Maximize();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            CloseForm();
        }
        #endregion

        #endregion

        #region Menu panel
        protected virtual void CollapseMenu()
        {
            if (MenuPanel == null || MenuToggleButton == null) return;

            if (IsMenuOpen)
            {
                MenuPanel.Width = MenuCollapsedWidth;
                MenuToggleButton.Dock = DockStyle.Top;
                foreach (Control control in MenuPanel.Controls)
                {
                    if (control is Button t)
                    {
                        t.Text = string.Empty;
                        t.ImageAlign = ContentAlignment.MiddleCenter;
                        t.Padding = new Padding(0);
                        continue;
                    }

                    control.Visible = false;
                }

                IsMenuOpen = false;
                return;
            }

            MenuPanel.Width = MenuExpandedWidth;
            MenuToggleButton.Dock = DockStyle.None;
            foreach (Control control in MenuPanel.Controls)
            {
                if (control is Button t)
                {
                    t.Text = $"{string.Empty.PadLeft(5, ' ')} {t.Tag}";
                    t.ImageAlign = ContentAlignment.MiddleLeft;
                    t.Padding = new Padding(10, 0, 0, 0);
                    continue;
                }

                control.Visible = false;
            }

            IsMenuOpen = true;
        }

        #region Event handlers
        private void MenuToggleButton_Click(object sender, EventArgs e)
        {
            CollapseMenu();
        }
        #endregion

        #endregion
    }
}
