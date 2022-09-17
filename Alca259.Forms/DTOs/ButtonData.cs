using FontAwesome.Sharp;
using System;
using System.Drawing;

namespace Alca259.Forms
{
    [Serializable]
    public class ButtonData
    {
        private string Spaces => string.Empty.PadLeft(10, ' ');
        public string DisplayText => $"{Spaces} {Text}";
        public Guid Key { get; } = Guid.NewGuid();
        public string Text { get; set; }
        public IconChar Icon { get; set; }
        public Color IconColor { get; set; }
        public int IconSize { get; set; } = 24;
        public IconFont IconFont { get; set; } = IconFont.Auto;
        public Color BackgroundColor { get; set; } = Color.FromArgb(77, 77, 77);
        public Color ForegroudColor { get; set; } = Color.Gainsboro;
    }
}