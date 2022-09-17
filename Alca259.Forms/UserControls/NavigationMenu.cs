/**
 * Author: Alca259
 * Creation date: 5 Sept 2022
 * Last modified date: 17 Sept 2022
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
using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Alca259.Forms.UserControls
{
    public partial class NavigationMenu : UserControl
    {
        #region Consts
        internal const string CAT_NAME = "Navigation Menu";
        #endregion

        #region Protected properties
        protected bool IsMenuOpen { get; private set; } = true;
        #endregion

        #region Exposed propertie
        [Category(CAT_NAME)]
        public Button MenuToggleButton { get; set; }

        [Category(CAT_NAME)]
        public bool StartMenuOpen { get; set; } = true;

        [Category(CAT_NAME)]
        public int MenuCollapsedWidth { get; set; } = 100;

        [Category(CAT_NAME)]
        public int MenuExpandedWidth { get; set; } = 230;
        #endregion

        #region Constructor

        public NavigationMenu()
        {
            InitializeComponent();
            PostInitialize();
        }

        protected virtual void PostInitialize()
        {
            if (MenuToggleButton != null) MenuToggleButton.Click += MenuToggleButton_Click;

            if ((IsMenuOpen && !StartMenuOpen) || (!IsMenuOpen && StartMenuOpen))
            {
                CollapseMenu();
            }
        }
        #endregion

        #region Menu panel
        protected virtual void CollapseMenu()
        {
            if (MenuToggleButton == null) return;

            if (IsMenuOpen)
            {
                Width = MenuCollapsedWidth;
                MenuToggleButton.Dock = DockStyle.Top;
                foreach (Control control in Controls.OfType<Button>().ToList())
                {
                    if (control == MenuToggleButton) continue;

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

            Width = MenuExpandedWidth;
            MenuToggleButton.Dock = DockStyle.None;
            foreach (Control control in Controls.OfType<Button>().ToList())
            {
                if (control == MenuToggleButton) continue;

                if (control is Button t)
                {
                    t.Text = $"{string.Empty.PadLeft(5, ' ')} {t.Tag}";
                    t.ImageAlign = ContentAlignment.MiddleLeft;
                    t.Padding = new Padding(10, 0, 0, 0);
                    continue;
                }

                control.Visible = true;
            }

            IsMenuOpen = true;
        }
        #endregion

        #region Event handlers
        private void MenuToggleButton_Click(object sender, EventArgs e)
        {
            CollapseMenu();
        }
        #endregion
    }
}
