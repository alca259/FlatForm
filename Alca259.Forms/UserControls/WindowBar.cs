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
using Alca259.Forms.Resources;
using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Alca259.Forms.UserControls
{
    public partial class WindowBar : UserControl
    {
        #region Consts
        private const string WIN_LIB = "user32.dll";
        private const string CAT_NAME = "Window bar";
        private const int RESIZE_AREA_SIZE = 10;

        private const int DRAG_MESSAGE = 0x112;
        private const int DRAG_MESSAGE_PARAM = 0xf012;
        #endregion

        #region Events
        public event EventHandler<int> BorderSizeChanged;
        public event EventHandler<bool> WindowMaximized;
        #endregion

        #region Exposed properties
        [Category(CAT_NAME)]
        public string Title { get; set; }
        [Category(CAT_NAME)]
        public bool EnableMinimizeButton { get; set; } = true;
        [Category(CAT_NAME)]
        public bool EnableMaximizeButton { get; set; } = true;
        [Category(CAT_NAME)]
        public bool EnableCloseButton { get; set; } = true;
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


            TitleLabel.Text = Title;
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
            _referenceForm.WindowState = FormWindowState.Minimized;
        }

        public void Maximize()
        {
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

        private void SetMaximizeButton()
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

            ReleaseCapture();
            SendMessage(_referenceForm.Handle, DRAG_MESSAGE, DRAG_MESSAGE_PARAM, 0);
        }
        #endregion

        #endregion
    }
}
