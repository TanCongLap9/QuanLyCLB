using ReaLTaiizor.Colors;
using ReaLTaiizor.Controls;
using ReaLTaiizor.Drawing.Poison;
using ReaLTaiizor.Enum.Poison;
using ReaLTaiizor.Forms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCLB.Utils
{
    public static class ColorUtils
    {
        public static Color TínhRaCáiMàuChữSaoChoNóTươngPhảnVớiCáiMàuNền(Color màuNền)
        {
            // WCAG 2.0 Color Contrast formula incoming
            float rf = màuNền.R / 255f;
            float gf = màuNền.G / 255f;
            float bf = màuNền.B / 255f;
            float backColorLum = 0.2126f * rf + 0.7152f * gf + 0.0722f * bf;

            return backColorLum >= 0.5f
                ? SystemColors.ControlText
                : SystemColors.HighlightText;
        }

        public static void SetColor(PoisonForm f, ThemeStyle theme, ColorStyle style)
        {
            f.Theme = theme;
            f.Style = style;
            // Redraw control box
            bool oldControlBox = f.ControlBox;
            f.ControlBox = false;
            f.ControlBox = oldControlBox;
            f.Invalidate(false);
        }

        public static void SetColor(PoisonUserControl uc, ThemeStyle theme, ColorStyle style)
        {
            uc.Theme = theme;
            uc.Style = style;
            uc.Invalidate(false);
        }

        public static void SetColor(TextBoxBase t, ThemeStyle theme)
        {
            t.BackColor = PoisonPaint.BackColor.Form(theme);
            t.ForeColor = PoisonPaint.ForeColor.Label.Normal(theme);
        }

        public static void SetColor(ListView lv, ThemeStyle theme)
        {
            lv.BackColor = PoisonPaint.BackColor.Form(theme);
            lv.ForeColor = PoisonPaint.ForeColor.Label.Normal(theme);
        }
    }
}
