using Alca259.UIControls.Resources;
using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Alca259.UIControls.UserControls
{
    public partial class WindowBar : UserControl
    {
        #region Consts
        internal const string CAT_NAME = "Window bar";

        private const string WIN_LIB = "user32.dll";
        private const int RESIZE_AREA_SIZE = 10;

        private const int DRAG_MESSAGE = 0x112;
        private const int DRAG_MESSAGE_PARAM = 0xf012;
        #endregion

        #region Events
        public event EventHandler<int> BorderSizeChanged;
        public event EventHandler<bool> WindowMaximized;
        #endregion

        #region Exposed properties
        [Category(CAT_NAME)] public string Title { get; set; }
        [Category(CAT_NAME)] public bool ShowTitle { get; set; } = true;
        [Category(CAT_NAME)] public bool EnableMinimizeButton { get; set; } = true;
        [Category(CAT_NAME)] public bool EnableMaximizeButton { get; set; } = true;
        [Category(CAT_NAME)] public bool EnableCloseButton { get; set; } = true;
        [Category(CAT_NAME)] public bool EnableMoveWindow { get; set; } = true;
        #endregion

        #region References
        private Form _referenceForm;
        #endregion

        #region Constructor
        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            _referenceForm = FindForm();
            Ensure.That<Exception>(_referenceForm != null, "Form not found. Assign this control to any form.");
        }

        public WindowBar()
        {
            InitializeComponent();
        }

        public virtual void PostInitialize()
        {
            TitleLabel.Text = Title;
            TitleLabel.Visible = ShowTitle;
            PanelMinimize.Visible = EnableMinimizeButton;
            PanelMaximize.Visible = EnableMaximizeButton;
            PanelClose.Visible = EnableCloseButton;

            TitleLabel.MouseDown += DragControl_MouseDown;
        }
        #endregion

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

        #region Toolbar actions
        public void Minimize()
        {
            if (!EnableMinimizeButton) return;

            _referenceForm.WindowState = FormWindowState.Minimized;
        }

        public void Maximize()
        {
            if (!EnableMaximizeButton) return;

            if (_referenceForm.WindowState == FormWindowState.Normal)
            {
                _referenceForm.MaximumSize = Screen.FromHandle(_referenceForm.Handle).WorkingArea.Size;
                _referenceForm.WindowState = FormWindowState.Maximized;

                WindowMaximized?.Invoke(this, true);
                BorderSizeChanged?.Invoke(this, RESIZE_AREA_SIZE);
            }
            else
            {
                _referenceForm.WindowState = FormWindowState.Normal;

                WindowMaximized?.Invoke(this, false);
            }

            SetMaximizeButton();
        }

        public void CloseForm()
        {
            _referenceForm.Close();
        }

        public void SetMaximizeButton()
        {
            MaximizeButton.BackgroundImage = _referenceForm.WindowState == FormWindowState.Normal ? ControlResources.Maximize : ControlResources.Restore;
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
            if (e.Clicks > 1)
            {
                Maximize();
                return;
            }

            if (!EnableMoveWindow) return;

            ReleaseCapture();
            SendMessage(_referenceForm.Handle, DRAG_MESSAGE, DRAG_MESSAGE_PARAM, 0);
        }
        #endregion

        #endregion
    }
}
