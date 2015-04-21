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
            resetAllColors();

            if (txtPass.Text == txtPass2.Text)
            {

                if (Queries.checkUsernameUnique(txtUsername.Text.ToLower()))
                {

                    List<inputViolation> violations = checkForInputViolations();

                    if (violations.Count == 0)
                    {
                        Queries.addPerson(txtUsername.Text.Trim(), txtPass.Text.Trim(), txtEmail.Text.Trim(), txtDoB.Text.Trim(), txtAdr_Street.Text.Trim(), txtAdr_City.Text.Trim(), txtState.Text.Trim(), int.Parse(txtZip.Text.Trim()));
                        MessageBox.Show("User created");
                        FormHelpers.setMainComponentsLogin();
                    }

                    else
                    {
                        StringBuilder sb = new StringBuilder();
                        
                        if(violations.Count > 1)
                        {
                            sb.AppendLine("The following violations are preventing you from completing the form:");
                            foreach(var item in violations)
                            {
                                sb.AppendLine(item.ToString());
                                
                            }
                        }

                        else
                        {
                            sb.AppendLine("The following violation is preventing you from completing the form:");
                            sb.AppendLine(violations[0].ToString());
                        }

                        MessageBox.Show(sb.ToString());
                    }
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


        enum inputViolation { DOB, EMAIL, STATE, ZIP};

        private List<inputViolation> checkForInputViolations()
        {

            List<inputViolation> toReturn = new List<inputViolation>();

            //Check DOB
            string[] dobCheck = txtDoB.Text.Split('/');
            if(dobCheck.Length != 3)
            {
                toReturn.Add(inputViolation.DOB);
                componentIndicateByViolation(inputViolation.DOB);
            }
            else if(dobCheck[2].Length != 4)
            {
                toReturn.Add(inputViolation.DOB);
                componentIndicateByViolation(inputViolation.DOB);
            }

            //Check email
            if(!txtEmail.Text.Contains('@'))
            {
                toReturn.Add(inputViolation.EMAIL);
                componentIndicateByViolation(inputViolation.EMAIL);
            }

            //Check state
            if(txtState.Text.Length > 3)
            {
                toReturn.Add(inputViolation.STATE);
                componentIndicateByViolation(inputViolation.STATE);
            }

            try
            {
                int tmp = Int32.Parse(txtZip.Text);
            }
            catch
            {
                toReturn.Add(inputViolation.ZIP);
                componentIndicateByViolation(inputViolation.ZIP);
            }

            return toReturn;

        }

        private void componentIndicateByViolation(inputViolation v)
        {
            switch(v)
            {
                case inputViolation.DOB:
                    txtDoB.BackColor = Color.Red;
                    break;
                case inputViolation.EMAIL:
                    txtEmail.BackColor = Color.Red;
                    break;
                case inputViolation.STATE:
                    txtState.BackColor = Color.Red;
                    break;
                case inputViolation.ZIP:
                    txtZip.BackColor = Color.Red;
                    break;
            }
        }

        private void resetAllColors()
        {
            txtDoB.BackColor = Color.White;
            txtEmail.BackColor = Color.White;
            txtState.BackColor = Color.White;
            txtZip.BackColor = Color.White;
        }
      
    }
}
