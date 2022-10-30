using System.Windows.Forms;

namespace Alca259.UIControls.UserControls
{
    public sealed class ThemeGridView : DataGridView
    {
        public ThemeGridView()
        {
            InitializeComponent();
        }

        #region Private
        private void InitializeComponent()
        {
            SuspendLayout();

            AllowDrop = false;
            AllowUserToAddRows = false;
            AllowUserToDeleteRows = false;
            AllowUserToOrderColumns = false;
            AllowUserToResizeColumns = false;
            AllowUserToResizeRows = false;
            AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            BackgroundColor = AppColors.GridBackground;
            BorderStyle = BorderStyle.None;
            CausesValidation = false;
            ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            ColumnHeadersDefaultCellStyle = new DataGridViewCellStyle
            {
                BackColor = AppColors.GridHeaderBackground,
                ForeColor = AppColors.GridHeaderFontColor,
                SelectionBackColor = AppColors.GridHeaderHighlightBackground,
                SelectionForeColor = AppColors.GridHeaderHighlightFontColor
            };
            ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DefaultCellStyle = new DataGridViewCellStyle
            {
                BackColor = AppColors.GridRowsBackground,
                ForeColor = AppColors.GridRowsFontColor,
                SelectionBackColor = AppColors.GridRowsHighlightBackground,
                SelectionForeColor = AppColors.GridRowsHighlightFontColor
            };
            EditMode = DataGridViewEditMode.EditProgrammatically;
            EnableHeadersVisualStyles = false;
            GridColor = AppColors.GridRowsSeparator;
            MultiSelect = false;
            ReadOnly = true;
            RowHeadersVisible = false; // Quita la columna izquierda!
            RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            ScrollBars = ScrollBars.Vertical;
            SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ShowCellErrors = false;
            ShowCellToolTips = false;
            ShowEditingIcon = false;
            ShowRowErrors = false;
            TabStop = false;

            ResumeLayout();
        }
        #endregion
    }
}
