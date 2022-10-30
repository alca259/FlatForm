using System.Windows.Forms;

namespace Alca259.UIControls.Renderers
{
    public class ToolStripDarkRenderer : ToolStripProfessionalRenderer
    {
        public ToolStripDarkRenderer() : base(new AppColors()) { }

        protected override void OnRenderItemText(ToolStripItemTextRenderEventArgs e)
        {
            e.Item.ForeColor = AppColors.ApplicationFontColor;
            base.OnRenderItemText(e);
        }
    }
}
