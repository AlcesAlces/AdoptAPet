using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdoptAPet.HelperFunctions;

namespace AdoptAPet
{
    public partial class UserControlRegister : UserControl
    {
        public UserControlRegister()
        {
            InitializeComponent();
        }

        private void UserControlRegister_Load(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {

            if (Queries.checkUsernameUnique(txtUsername.Text.ToLower()))
            {

            }

            else
            {
                MessageBox.Show("Username is taken");
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Global.userPanel.Controls.Clear();
            Global.userPanel.Controls.Add(new UserControlLogin());
        }
    }
}
