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
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Alca259.Forms.UserControls
{
    public class FlatButton : Button
    {
        #region Consts
        internal const string CAT_NAME = "Flat Button";
        #endregion

        #region Exposed properties
        [Category(CAT_NAME)]
        public Color? DarkBackColor { get; set; } = Color.FromArgb(77, 77, 77);
        [Category(CAT_NAME)]
        public Color? DarkForeColor { get; set; } = Color.FromArgb(220, 220, 220);
        #endregion

        #region Constructor
        public FlatButton()
        {
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;
            BackColor = DarkBackColor ?? BackColor;
            ForeColor = DarkForeColor ?? ForeColor;
        }
        #endregion
    }
}