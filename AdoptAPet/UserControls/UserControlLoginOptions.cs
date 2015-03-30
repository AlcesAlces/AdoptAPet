using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdoptAPet.HelperClasses;

namespace AdoptAPet.UserControls
{
    public partial class UserControlLoginOptions : UserControl
    {
        public UserControlLoginOptions()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Global.userPanel.Controls.Clear();
            Global.userPanel.Controls.Add(new UserControlLogin());
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Global.userPanel.Controls.Clear();
            Global.userPanel.Tag = "not login";
            Global.userPanel.Controls.Add(new UserControlRegister());
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            Global.publicUser = new User();
            Global.publicUser.admin = false;
            Global.publicUser.userName = "Guest";
            Global.publicUser.userId = 7;
            Global.menuItemsUser[0].Visible = false;
            Global.menuItemsUser[1].Visible = true;
            Global.menuItemsUser[2].Visible = false;
            Global.panel.Controls.Clear();
            Global.panel.Controls.Add(new UserControlSearch());
        }
    }
}
