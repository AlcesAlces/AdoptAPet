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
    public partial class UserControlAdoptCheckOut : UserControl
    {
        Customer _customer = new Customer();
        
        public UserControlAdoptCheckOut(Customer infoCustomer)
        {
            InitializeComponent();
            _customer = infoCustomer;
            populateItems();
        }

        private void populateItems()
        {
            setAdopterName(_customer.name);
            setAdopterHasAdopted(_customer.has_adopted);
            setAdopterDateOfBirth(_customer.dob);
            setAdopterStreet(_customer.street);
            setAdopterCity(_customer.city);
            setAdopterState(_customer.state);
            setAdopterZip(_customer.zip);
        }
        private void setAdopterName(string setName)
        {
            if (txtAdopterName.InvokeRequired)
            {
                txtAdopterName.Invoke(new MethodInvoker(() => { txtAdopterName.Text = setName; }));
            }
            else
            {
                txtAdopterName.Text = setName;
            }
        }
        private void setAdopterDateOfBirth(string setDoB)
        {
            if (txtAdopterDoB.InvokeRequired)
            {
                txtAdopterDoB.Invoke(new MethodInvoker(() => { txtAdopterDoB.Text = setDoB; }));
            }
            else
            {
                txtAdopterDoB.Text = setDoB;
            }
        }
        private void setAdopterHasAdopted(bool setHasAdopted)
        {
            if (txtHasAdopted.InvokeRequired)
            {
                txtHasAdopted.Invoke(new MethodInvoker(() => { txtHasAdopted.Text = setHasAdopted.ToString(); }));
            }
            else
            {
                txtHasAdopted.Text = setHasAdopted.ToString();
            }
        }
        private void setEmail(string setEmail)
        {
            if (txtAdopterEmail.InvokeRequired)
            {
                txtAdopterEmail.Invoke(new MethodInvoker(() => { txtAdopterEmail.Text = setEmail; }));
            }
            else
            {
                txtAdopterEmail.Text = setEmail;
            }
        }
        private void setAdopterStreet(string setStreet)
        {
            //TODO
        }
        private void setAdopterCity(string setCity)
        {
            //TODO
        }
        private void setAdopterState(string setState)
        {
            //TODO
        }
        private void setAdopterZip(int zip)
        {
            //TODO
        }
         
    }
}
