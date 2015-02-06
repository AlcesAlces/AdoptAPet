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
using AdoptAPet.HelperClasses;

namespace AdoptAPet
{
    public partial class UserControlLogin : UserControl
    {

        public User user { get; set; }

        public UserControlLogin()
        {
            InitializeComponent();

            if(Global.debug)
            {
                user = new User
                {
                    userName = "blake",
                    password = "pass"
                };

                Global.publicUser = user;

                Global.panel.Controls.Clear();
                Global.panel.Controls.Add(new UserControlSearch());
                
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            setElementsNuetral();
            verifyLogin();
        }

        /// <summary>
        /// Ensure user name set in text boxes is correct
        /// </summary>
        private void verifyLogin()
        {
            User user = Queries.returnUserByName(tbUsername.Text);

            if (user != null)
            {
                if (user.userName == tbUsername.Text.ToLower())
                {
                    if (user.password == tbPassword.Text)
                    {
                        Global.publicUser = user;
                        Global.panel.Controls.Clear();
                        Global.panel.Controls.Add(new UserControlSearch());
                    }

                    else
                    {
                        setElementsWrong();
                    }
                }
            }

            else
            {
                setElementsWrong();
            }
        }

        private void setElementsWrong()
        {
            tbPassword.BackColor = Color.Red;
            tbUsername.BackColor = Color.Red;
        }

        private void setElementsNuetral()
        {
            tbPassword.BackColor = Color.White;
            tbUsername.BackColor = Color.White;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Global.userPanel.Controls.Clear();
            Global.userPanel.Controls.Add(new UserControlRegister());
        }

        private void tbPassword_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
        }
    }
}
