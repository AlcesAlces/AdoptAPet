using System;
using System.Collections.Generic;
using AdoptAPet.HelperFunctions;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdoptAPet
{
    public partial class UserControlAddress : UserControl
    {
        public List<string> states;

        public UserControlAddress()
        {
            InitializeComponent();
        }

        private void UserControlAddress_Load(object sender, EventArgs e)
        {
            states = new List<string>(50);
            states.Add("Select");
            states.Add("AL");states.Add("AK");states.Add("AZ");states.Add("AR");states.Add("CA");states.Add("CO");
            states.Add("CT");states.Add("DE");states.Add("DC");states.Add("FL");states.Add("GA");states.Add("HI");
            states.Add("ID");states.Add("IL");states.Add("IN");states.Add("IA");states.Add("KS");states.Add("KY");
            states.Add("LA");states.Add("ME");states.Add("MD");states.Add("MA");states.Add("MI");states.Add("MN");
            states.Add("MS");states.Add("MO");states.Add("MT");states.Add("NE");states.Add("NV");states.Add("NH");
            states.Add("NJ");states.Add("NM");states.Add("NY");states.Add("NC");states.Add("ND");states.Add("OH");
            states.Add("OK");states.Add("OR");states.Add("PA");states.Add("RI");states.Add("SC");states.Add("SD");
            states.Add("TN");states.Add("TX");states.Add("UT");states.Add("VT");states.Add("VA");states.Add("WA");
            states.Add("WV");states.Add("WI");states.Add("WY");

            cbState.DataSource = states;
  }

         //make the text box numeric only 
        //so no need to do input validation
        private void tbZipCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }


        public int returnAddressindex()
        {
            string state;
            int zip;
            string street;
            string city;
            //TODO:
            //test the state thing


            if (cbState.SelectedItem.ToString().Trim().ToLower() == "select" || tbZipCode.Text.Trim() == "" || tbAddress.Text.Trim().ToLower() == ""
                || tbCity.Text.Trim().ToLower() == "") {
                    return -1;
            }
            else//error free
            {
                state = cbState.SelectedItem.ToString().Trim().ToLower();
                zip = Int32.Parse(tbZipCode.Text.Trim());
                street = tbAddress.Text.Trim().ToLower();
                city = tbCity.Text.Trim().ToLower();
            }

            int addressIndex = Queries.returnAddressIndexQuery(city, zip, street, state);
            return addressIndex;
        }
    }
}
