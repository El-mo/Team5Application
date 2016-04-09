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
using System.Data.OleDb;

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

            try
            {
                OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=goFlyAKite.accdb;Persist Security Info=True");
                OleDbCommand addCreds = new OleDbCommand("INSERT INTO Users (Username, Pass) VALUES (@Username, @Password)", conn);
                addCreds.Parameters.AddWithValue("@Username", this.tbUsername.Text);
                addCreds.Parameters.AddWithValue("@Password", this.tbPassword.Text);
               
             

                OleDbCommand addInfo = new OleDbCommand("INSERT INTO Registrants (First_Name, Last_Name, Group, Street, City, State, Zip, Phone, Email) VALUES (@First_Name, @Last_Name, @Group, @Street, @City, @State, @Zip, @Phone, @Email)", conn);
                addInfo.Parameters.AddWithValue("@First_Name", this.fname.Text);
                addInfo.Parameters.AddWithValue("@Last_Name", this.lname.Text);
                addInfo.Parameters.AddWithValue("@Group", this.group.Text);
                addInfo.Parameters.AddWithValue("@Street", this.street.Text);
                addInfo.Parameters.AddWithValue("@City", this.city.Text);
                addInfo.Parameters.AddWithValue("@State", this.tbState.Text);
                addInfo.Parameters.AddWithValue("@Zip", this.zip.Text);
                addInfo.Parameters.AddWithValue("@Phone", this.phone.Text);
                addInfo.Parameters.AddWithValue("@Email", this.email.Text);

                conn.Open();
                addCreds.ExecuteNonQuery();
                addInfo.ExecuteNonQuery();
                conn.Close();
                this.Validate();
                this.bindingSource1.EndEdit();
            }
            catch(System.Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }

            if (regHelper == null)
                regHelper = new RegisterController();
            String fname = this.fname.Text;
            String lname = this.lname.Text;
            String group = this.group.Text;
            String street = this.street.Text;
            String state = this.tbState.Text;
            String city = this.city.Text;
            String zip = this.zip.Text;
            String phone = this.phone.Text;
            String email = this.email.Text;
            if (group.Equals("Adult"))
                regHelper.createMainRegistrant(fname, lname, Data_Models.Registrant.groupType.Adult, street, city, state, zip, phone, email);
            else
                regHelper.createMainRegistrant(fname, lname, Data_Models.Registrant.groupType.Professional, street, city, state, zip, phone, email);
            regHelper.user = new Data_Models.RegistrantUser();
            regHelper.user.username = this.tbUsername.Text;
            regHelper.user.password = this.tbPassword.Text;
            


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
