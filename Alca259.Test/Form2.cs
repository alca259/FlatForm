using Alca259.Forms;

namespace Alca259.Test
{
    public partial class Form2 : FlatForm
    {
        public Form2()
        {
            MenuItems.Add(new ButtonData
            {
                Text = "Prueba",
                Icon = FontAwesome.Sharp.IconChar.Exclamation
            });
            InitializeComponent();
        }
    }
}
