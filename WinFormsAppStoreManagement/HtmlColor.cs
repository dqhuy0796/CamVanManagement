using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace WinFormsAppStoreManagement
{
    public class HtmlColor
    {
        #region color field
        // rainbow
        public static Color blue    = ColorTranslator.FromHtml("#007bff");
        public static Color indigo  = ColorTranslator.FromHtml("#6610f2");
        public static Color purple  = ColorTranslator.FromHtml("#6f42c1");
        public static Color pink    = ColorTranslator.FromHtml("#e83e8c");
        public static Color red     = ColorTranslator.FromHtml("#dc3545");
        public static Color orange  = ColorTranslator.FromHtml("#fd7e14");
        public static Color yellow  = ColorTranslator.FromHtml("#ffc107");
        public static Color green   = ColorTranslator.FromHtml("#28a745");
        public static Color teal    = ColorTranslator.FromHtml("#20c997");
        public static Color cyan    = ColorTranslator.FromHtml("#17a2b8");
        // system
        public static Color success = ColorTranslator.FromHtml("#28a745");
        public static Color info    = ColorTranslator.FromHtml("#17a2b8");
        public static Color warning = ColorTranslator.FromHtml("#ffc107");
        public static Color danger  = ColorTranslator.FromHtml("#dc3545");
        // basic
        public static Color black   = ColorTranslator.FromHtml("#030303");
        public static Color dark1   = ColorTranslator.FromHtml("#181818");
        public static Color dark2   = ColorTranslator.FromHtml("#212121");
        public static Color dark3   = ColorTranslator.FromHtml("#313131");
        public static Color dark4   = ColorTranslator.FromHtml("#373737");
        public static Color light4  = ColorTranslator.FromHtml("#eeeeee");
        public static Color light3  = ColorTranslator.FromHtml("#f2f2f2");
        public static Color light2  = ColorTranslator.FromHtml("#f8f8f8");
        public static Color light1  = ColorTranslator.FromHtml("#fafafa");
        public static Color white   = ColorTranslator.FromHtml("#ffffff");
        // custom
        public static Color gray    = ColorTranslator.FromHtml("#c8c8c8");
        public static Color border1 = ColorTranslator.FromHtml("#4b4b4b");
        public static Color border2 = ColorTranslator.FromHtml("#e5e5e5");
        public static Color text1   = ColorTranslator.FromHtml("#aaaaaa");
        public static Color text2   = ColorTranslator.FromHtml("#606060");
        public static Color primary = ColorTranslator.FromHtml("#00beac");

        /*#a70327*/ /*#920303*/ /*#96ed8c*/ /*#fdead9*/ /*#bb86fc*/
        #endregion

        public static Color ChangeColorBrightness(Color color, double correctionFactor)
        {
            double red = color.R;
            double green = color.G;
            double blue = color.B;
            // if correctionFactor < 0 darken
            if (correctionFactor < 0)
            {
                correctionFactor = 1 + correctionFactor;
                red *= correctionFactor;
                green *= correctionFactor;
                blue *= correctionFactor;
            }
            // else if correctionFactor > 0 lighten
            else
            {
                red = (255 - red) * correctionFactor + red;
                green = (255 - green) * correctionFactor + green;
                blue = (255 - blue) * correctionFactor + blue;
            }
            return Color.FromArgb(color.A, (byte)red, (byte)green, (byte)blue);
        }

        public static Color RandomColor()
        {
            Random random = new Random();
            List<string> ColorList = new List<string>()
            { "#007bff", "#6610f2", "#6f42c1", "#e83e8c","#dc3545","#fd7e14", "#ffc107", "#28a745", "#20c997", "#17a2b8"};
            int index = random.Next(ColorList.Count);
            int tempIndex = 100;
            while (tempIndex == index)
            {
                index = random.Next(ColorList.Count);
            }
            tempIndex = index;
            string color = ColorList[index];
            return ColorTranslator.FromHtml(color);
        }
    }
}
