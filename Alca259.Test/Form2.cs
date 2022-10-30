using Alca259.UIControls;

namespace Alca259.Test
{
    public partial class Form2 : FlatForm
    {
        public Form2()
        {
            MenuItems.Add(new ButtonData
            {
                Text = "Prueba",
                Icon = FontAwesome.Sharp.IconChar.Exclamation,
                IconSize = 24,
                IconColor = System.Drawing.Color.Red,
                IconFont = FontAwesome.Sharp.IconFont.Auto,
            });
            InitializeComponent();
        }
    }
}
