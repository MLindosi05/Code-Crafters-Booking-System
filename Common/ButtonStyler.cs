using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Code_Crafters_Interface_Prototype_1.Common
{
    public static class ButtonStyler
    {
        public static void Apply(Button button)
        {
            button.BackColor = Theme.Gold;
            button.ForeColor = Theme.White;
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0;
        }
    }
}