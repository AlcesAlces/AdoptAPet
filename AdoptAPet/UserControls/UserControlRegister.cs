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
using AdoptAPet.UserControls;

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

            if (txtPass.Text == txtPass2.Text)
            {

                if (Queries.checkUsernameUnique(txtUsername.Text.ToLower()))
                {
                    Queries.addPerson(txtUsername.Text.Trim(), txtPass.Text.Trim(), txtEmail.Text.Trim(), txtDoB.Text.Trim(), txtAdr_Street.Text.Trim(), txtAdr_City.Text.Trim(),txtState.Text.Trim(), int.Parse(txtZip.Text.Trim()));
                    MessageBox.Show("User created");
                    FormHelpers.setMainComponentsLogin();
                }

                else
                {
                    MessageBox.Show("Username is taken");
                }
            }

            else
            {
                MessageBox.Show("Passwords don't match!");
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

            if (Global.userPanel.Tag as string == "login")
            {

                Global.userPanel.Controls.Clear();
                Global.userPanel.Controls.Add(new UserControlLogin());
            }

            else
            {
                Global.userPanel.Controls.Clear();
                Global.userPanel.Controls.Add(new UserControlLoginOptions());
            }
        }

      
    }
}
