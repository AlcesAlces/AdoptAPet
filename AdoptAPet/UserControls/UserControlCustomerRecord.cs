using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdoptAPet.UserControls
{
    public partial class UserControlCustomerRecord : UserControl
    {
        public UserControlCustomerRecord()
        {
            InitializeComponent();
        }
        // (Set) Customer Information
        private void setCustomerName(string name)
        {
            txtCustomerName.Text = name;
        }
        private void setCustomerEmail(string email)
        {
            txtCustomerEmail.Text = email;
        }
        // (Set) Customer Address
        private void setCustomerStreetAddress(string streetAddress)
        {
            txtCustomerStreetAddress.Text = streetAddress;
        }
        private void setCustomerState(string state)
        {
            txtCustomerState.Text = state;
        }
        private void setCustomerZip(int zip)
        {
            txtCustomerZip.Text = zip.ToString();
        }

    }
}
