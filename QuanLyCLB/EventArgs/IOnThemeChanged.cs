using ReaLTaiizor.Enum.Poison;

namespace QuanLyCLB.EventArgs
{
    public class ThemeChangedEventArgs : System.EventArgs
    {
        public ThemeStyle Theme { get; }
        public ColorStyle Style { get; }

        public ThemeChangedEventArgs(ThemeStyle theme, ColorStyle style)
        {
            Theme = theme;
            Style = style;
        }
    }
}
