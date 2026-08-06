using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Code_Crafters_Interface_Prototype_1.Common
{
    public static class ThemeManager
    {
        public static readonly Color Background = ColorTranslator.FromHtml("#F9EED8");
        public static readonly Color Panel = ColorTranslator.FromHtml("#F8F5F0");
        public static readonly Color Button = ColorTranslator.FromHtml("#C99A2E");
        public static readonly Color Header = ColorTranslator.FromHtml("#966919");

        public static void StyleButton(Button button)
        {
            button.BackColor = Button;
            button.ForeColor = Color.White;
        }

        public static void StylePanel(Panel panel)
        {
            panel.BackColor = Panel;
        }

        public static void StyleHeader(Control control)
        {
            control.BackColor = Header;
        }

        // ADD THIS METHOD
        public static void ApplyLoginTheme(
           Form form,
           Panel panel1,
           Panel pnlLogin,
           Panel panel3,
           Panel panel4,
           Panel pnlHelpDrawer,
           GroupBox groupBox1,
           Button button1,
           Button button2,
           Button button3)
        {
            form.BackColor = Background;

            panel1.BackColor = Panel;
            pnlLogin.BackColor = Panel;

            panel3.BackColor = Color.Black;
            panel4.BackColor = Color.Black;

            pnlHelpDrawer.BackColor = Header;
            groupBox1.BackColor = Header;

            StyleButton(button1);
            StyleButton(button2);
            StyleButton(button3);
        }
    }
}