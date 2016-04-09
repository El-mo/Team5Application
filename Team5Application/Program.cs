using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Team5Application
{
    static class Program
    {
        public static int formsOpen= 0;
        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var myLoginForm = new Form1();
            myLoginForm.Show();
            Application.Run();
        }
    }
}
