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
using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
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
        private const string ADJUST_TAG = "Adjust";
        private const int COLLAPSED_WIDTH = 38;
        #endregion

        #region Protected properties
        protected bool IsMenuOpen { get; private set; } = true;
        #endregion

        #region Exposed properties
        [Category(CAT_NAME)] public List<ButtonData> Items { get; set; } = new List<ButtonData>();
        [Category(CAT_NAME)] public bool StartMenuOpen { get; set; } = true;
        [Category(CAT_NAME)] public int MenuExpandedWidth { get; set; } = 230;
        #endregion

        #region Private fields
        private Dictionary<Guid, (IconButton, ButtonData)> _displayedElements = new Dictionary<Guid, (IconButton, ButtonData)>();
        #endregion

        #region Constructor
        public NavigationMenu()
        {
            InitializeComponent();
        }

        public virtual void PostInitialize()
        {
            LoadElements();

            if ((IsMenuOpen && !StartMenuOpen) || (!IsMenuOpen && StartMenuOpen))
            {
                CollapseMenu();
            }

            foreach (Control control in Controls)
            {
                if (!ADJUST_TAG.Equals(control.Tag?.ToString(), StringComparison.InvariantCultureIgnoreCase)) continue;
                control.ForeColor = ForeColor;
            }

            toggleButton.BackColor = BackColor;
            var lightColor = toggleButton.BackColor.AdjustLight(0.05f, removeAlpha: true);

            toggleButton.FlatAppearance.MouseOverBackColor = lightColor;
            toggleButton.FlatAppearance.MouseDownBackColor = lightColor;
        }
        #endregion

        #region Menu panel
        protected virtual void LoadElements()
        {
            foreach (ButtonData item in Items)
            {
                var iconBtn = new IconButton
                {
                    Text = item.Text,
                    IconChar = item.Icon,
                    IconSize = item.IconSize,
                    IconFont = item.IconFont,
                    IconColor = item.IconColor,
                    BackColor = item.BackgroundColor,
                    ForeColor = item.ForegroudColor,
                    Dock = DockStyle.Top,
                    Height = 45,
                    FlatStyle = FlatStyle.Flat,

                };

                var lightColor = item.BackgroundColor.AdjustLight(0.05f, removeAlpha: true);

                iconBtn.FlatAppearance.BorderSize = 0;
                iconBtn.FlatAppearance.MouseOverBackColor = lightColor;
                iconBtn.FlatAppearance.MouseDownBackColor = lightColor;

                _displayedElements.Add(item.Key, (iconBtn, item));
                panelItems.Controls.Add(iconBtn);
            }
        }

        protected virtual void CollapseMenu()
        {
            Width = IsMenuOpen ? COLLAPSED_WIDTH : MenuExpandedWidth;
            labelFooter.Visible = !IsMenuOpen;

            foreach (KeyValuePair<Guid, (IconButton btn, ButtonData data)> item in _displayedElements)
            {
                item.Value.btn.Text = IsMenuOpen ? string.Empty : item.Value.data.DisplayText;
                item.Value.btn.Padding = IsMenuOpen ? new Padding(0) : new Padding(10, 0, 0, 0);
            }

            IsMenuOpen = !IsMenuOpen;
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
