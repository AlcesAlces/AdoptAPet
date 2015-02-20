using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdoptAPet
{
    public partial class UserControlAnimalInformation : UserControl
    {
        public UserControlAnimalInformation()
        {
            InitializeComponent();
        }

        public void setTxtAnimalName(string toSet)
        {
            txtAnimalName_Information.Text = toSet;
        }
        public void setTxtAnimalSpecies(string toSet)
        {
            txtAnimalSpecies_Infomation.Text = toSet;
        }
        public void setTxtAnimalBreed(string toSet)
        {
            txtAnimalBreed_Information.Text = toSet;
        }
        public void setTextAnimalDescription(string toSet)
        {
            //may have to format this string 
            txtAnimalDes_Information.Text = toSet;
        }
        public void setAnimalAddress(string setStreet, string setCity, string setZip)
        {
            lblAnimalStreetAddress.Text = setStreet;
            lblAnimalCity.Text = setCity;
            lblAnimalZipCode.Text = setZip;
        }
    }
}
