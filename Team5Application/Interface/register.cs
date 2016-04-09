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
    public partial class register : Form
    {
        public Form1 main;
        public register()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                DataRow newRow = this.goFlyAKiteDataSet1.Tables["Users"].NewRow();
                newRow["Username"] = tbUsername.Text;
                newRow["Password"] = tbPassword.Text;
                this.goFlyAKiteDataSet1.Tables["main"].Rows.Add(newRow);
                this.goFlyAKiteDataSet1.AcceptChanges();
                this.bindingSource1.EndEdit();
            }
            catch(System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }










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
