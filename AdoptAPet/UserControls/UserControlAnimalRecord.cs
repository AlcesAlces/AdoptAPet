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
    public partial class UserControlAnimalRecord : UserControl
    {
        public UserControlAnimalRecord()
        {
            InitializeComponent();
        }
        // (Set) Animal General Information
        private void setAnimalName(string setName)
        {
            txtAnimalName.Text = setName;
        }
        private void setAnimalSpecies(string setSpecies)
        {
            txtAnimalSpecies.Text = setSpecies;
        }
        private void setAnimalBreed(string setBreed)
        {
            txtAnimalBreed.Text = setBreed;
        }
        private void setAnimalSex(string setSex)
        {
            txtAnimalSex.Text = setSex;
        }
        private void setAnimalAge(short setAge)
        {
            txtAnimalAge.Text = setAge.ToString();
        }
        private void setAnimalColor(string setColor)
        {
            txtAnimalColor.Text = setColor;
        }
        private void setAnimalDescription(string setDescription)
        {
            txtAnimalDescription.Text = setDescription;
        }
        // (Set) Animal location
        private void setAnimalStreetAddress(string setStreetAddress)
        {
            txtAnimalStreetAddress.Text = setStreetAddress;
        }
        private void setAnimalCity(string setCity)
        {
            txtAnimalCity.Text = setCity;
        }
        private void setAnimalState(string setState)
        {
            txtAnimalState.Text = setState;
        }
        private void setAnimalZip(short setZip)
        {
            txtAnimalZip.Text = setZip.ToString();
        }
        // (Set) Animal traits
        private void setAnimalFriendly(bool setFriendly)
        {
            cbAnimalFriendly.Checked = setFriendly;
        }
        private void setAnimalFixed(bool setFixed)
        {
            cbAnimalFixed.Checked = setFixed;
        }
        private void setAnimalVaccines(bool setVaccines)
        {
            cbVaccines.Checked = setVaccines;
        }
        private void setAnimalMicrochip(bool setMicrochip)
        {
            cbAnimalMicochip.Checked = setMicrochip;
        }




    }
}
