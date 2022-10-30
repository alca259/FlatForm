namespace System.Drawing
{
    public static class ColorUtils
    {
        /// <summary>
        /// Alpha is ignored.
        /// </summary>
        /// <param name="color">The color to convert.</param>
        /// <param name="colorBrightness">0.0 to 1.0</param>
        /// <param name="removeAlpha">Remove alpha channel</param>
        public static Color AdjustLight(this Color color, float colorBrightness, bool removeAlpha = false)
        {
            float alpha = removeAlpha ? 255 : color.A;
            float red = color.R;
            float green = color.G;
            float blue = color.B;

            if (colorBrightness < 0)
            {
                colorBrightness += 1;
                red *= colorBrightness;
                green *= colorBrightness;
                blue *= colorBrightness;
            }
            else
            {
                red = (255 - red) * colorBrightness + red;
                green = (255 - green) * colorBrightness + green;
                blue = (255 - blue) * colorBrightness + blue;
            }

            return Color.FromArgb(alpha: (int)Math.Clamp(alpha, 0, 255),
                red: (int)Math.Clamp(red, 0, 255),
                green: (int)Math.Clamp(green, 0, 255),
                blue: (int)Math.Clamp(blue, 0, 255));
        }
    }
}