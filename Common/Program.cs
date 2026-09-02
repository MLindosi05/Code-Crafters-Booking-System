using Code_Crafters_Interface_Prototype_1;
using Code_Crafters_Interface_Prototype_1.Business;
using Code_Crafters_Interface_Prototype_1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Code_Crafters_Booking_System
{
    internal static class Program
    {
        
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();  
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ForgotPasswordForm());
            //Application.Run(new Code_Crafters_Interface_Prototype_1.Interfaces.HomeForm());

        }
    }
}
