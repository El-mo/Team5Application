using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Team5Application.Interface
{
    public partial class registrant_info : Form
    {
        public registrant_info()
        {
            InitializeComponent();
        }

        private void editMyInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //this.Hide();
            Interface.register editinfo = new register();
            editinfo.Show();
        }
    }
}
