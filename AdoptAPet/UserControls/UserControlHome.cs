using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdoptAPet.UserControls;

namespace AdoptAPet
{
    public partial class UserControlHome : UserControl
    {

        public UserControlHome()
        {
            InitializeComponent();
            panelHome.Controls.Add(new UserControlLoginOptions());
            Global.userPanel = panelHome;
        }

        private void UserControlHome_Load(object sender, EventArgs e)
        {

        }
    }
}
