using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Team5Application
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Interface.registrant_info info = new Interface.registrant_info();
            info.Show();
            this.Close();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            Interface.register register = new Interface.register();
            register.Show();
            this.Close();
        }

        private void Form1_VisibleChanged(object sender, EventArgs e)
        {
            
        }


    }
}
