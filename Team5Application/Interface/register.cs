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
    public partial class register : Form
    {
        public RegisterController regHelper;
        public register()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String fname = this.fname.Text;
            String lname = this.lname.Text;
            String group = this.group.Text;
            String street = this.street.Text;
            //String state = this.
            String city = this.city.Text;
            String zip = this.zip.Text;
            String phone = this.phone.Text;
            String email = this.email.Text;
            if (group.Equals("Adult"))
                regHelper.createMainRegistrant(fname, lname, Data_Models.Registrant.groupType.Adult, street, city, "", zip, phone, email);
            else
                regHelper.createMainRegistrant(fname, lname, Data_Models.Registrant.groupType.Professional, street, city, "", zip, phone, email);
            regHelper.user = new Data_Models.RegistrantUser();
            
            this.Hide();
            Interface.registrant_info info = new registrant_info();
            info.Show();
            this.Close();
        }

        private void register_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.formsOpen--;
            if (Program.formsOpen == 0)
                Application.Exit();
        }

        private void register_Load(object sender, EventArgs e)
        {
            Program.formsOpen++;
        }
    }
}
