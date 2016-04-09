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
    public partial class add_adult : Form
    {
        public add_adult()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (this.group.Text.Equals("Adult"))
                registrant_info.regHelper.addAdult(this.tbFName.Text, this.tbLName.Text, Data_Models.Registrant.groupType.Adult);
            else
                registrant_info.regHelper.addAdult(this.tbFName.Text, this.tbLName.Text, Data_Models.Registrant.groupType.Professional);
            
        }
    }
}
