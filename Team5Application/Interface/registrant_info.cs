using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Team5Application.Business_Logic;

namespace Team5Application.Interface
{
    public partial class registrant_info : Form
    {
        public RegisterController regHelper;
        public registrant_info()
        {
            InitializeComponent();
        }

        private void editMyInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Interface.register editinfo = new register();
            editinfo.Show();
        }

        private void registrant_info_Load(object sender, EventArgs e)
        {
            Program.formsOpen++;
            ////If first time in system
            //if (regHelper == null)
            //{
            //    regHelper = new RegisterController();
            //}
        }

        private void current_owe_Click(object sender, EventArgs e)
        {

        }

        private void registrant_info_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.formsOpen--;
            if (Program.formsOpen == 0)
                Application.Exit();
        }
    }
}
