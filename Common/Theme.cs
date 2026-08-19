using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Code_Crafters_Interface_Prototype_1.Common
{
    public static class Theme
    {
        public static Color Background =>
            ColorTranslator.FromHtml("#F9EED8");

        public static Color Panel =>
            ColorTranslator.FromHtml("#D3D3D3");    

        public static Color Brown =>
            ColorTranslator.FromHtml("#966919");

        public static Color Gold =>
            ColorTranslator.FromHtml("#C99A2E");

        public static Color White => Color.White;

        public static Color Black => Color.Black;
    }
}