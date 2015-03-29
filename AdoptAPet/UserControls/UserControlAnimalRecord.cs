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
using AdoptAPet.HelperFunctions;

namespace AdoptAPet.UserControls
{
    public partial class UserControlAnimalRecord : UserControl
    {
        Animal _animal = new Animal();
        Customer _customer = new Customer();

        public UserControlAnimalRecord(Animal infoAnimal)
        {
            InitializeComponent();
            _animal = infoAnimal;
            populateItems();
            if (_animal.isAdopted != true)
            {
                btnAdopt_Information.Visible = true;

            }
            else
            {
                btnAdopt_Information.Visible = false;                
            }
        }

        private void populateItems()
        {
            //TODO: Fill in all of these functions.
            
            setAnimalName(_animal.name);
            setAnimalSex(_animal.sex);
            setAnimalAge(_animal.age);
            setAnimalDescription(_animal.description);

            string[] animalAttributes = HelperFunctions.Queries.returnAnimalMISC(_animal.breed);
            setAnimalBreed(animalAttributes[0]); 
            setAnimalSpecies(animalAttributes[1]);
            setAnimalColor(animalAttributes[2]); 

            //[0]Street|[1]city|[2]state|[3]zip
            string[] animalAddress = HelperFunctions.Queries.returnAnimalAddress(_animal.location);
            setAnimalStreetAddress(animalAddress[0]);
            setAnimalCity(animalAddress[1]);
            setAnimalState(animalAddress[2]);
            setAnimalZip(animalAddress[3]);
            setAnimalFriendly(_animal.friendly);
            setAnimalFixed(_animal.isFixed);
            // setAnimalVaccines        //Animal has no vaccines
            setAnimalMicrochip(_animal.microchip);
            
        }

        // (Set) Animal General Information
        private void setAnimalName(string setName)
        {
            if (txtAnimalName.InvokeRequired)
            {
                txtAnimalName.Invoke(new MethodInvoker(() => { txtAnimalName.Text = setName; }));
            }
            else
            {
                txtAnimalName.Text = setName;
            }
        }
        private void setAnimalSpecies(string setSpecies)
        {
            if (txtAnimalSpecies.InvokeRequired)
            {
                txtAnimalSpecies.Invoke(new MethodInvoker(() => { txtAnimalSpecies.Text = setSpecies; }));
            }
            else
            {
                txtAnimalSpecies.Text = setSpecies;
            }
        }
        private void setAnimalBreed(string setBreed)
        {
            if (txtAnimalBreed.InvokeRequired)
            {
                txtAnimalBreed.Invoke(new MethodInvoker(() => { txtAnimalBreed.Text = setBreed; }));
            }
            else
            {
                txtAnimalBreed.Text = setBreed;
            }
        }
        private void setAnimalSex(string setSex)
        {
            if (txtAnimalSex.InvokeRequired)
            {
                txtAnimalSex.Invoke(new MethodInvoker(() => { txtAnimalSex.Text = setSex; }));
            }
            else
            {
                txtAnimalSex.Text = setSex;
            }
        }
        private void setAnimalAge(int setAge)
        {
            if (txtAnimalAge.InvokeRequired)
            {
                txtAnimalAge.Invoke(new MethodInvoker(() => { txtAnimalAge.Text = setAge.ToString(); }));
            }
            else
            {
                txtAnimalAge.Text = setAge.ToString();
            }
        }
        private void setAnimalColor(string setColor)
        {
            if (txtAnimalColor.InvokeRequired)
            {
                txtAnimalColor.Invoke(new MethodInvoker(() => { txtAnimalColor.Text = setColor; }));
            }
            else
            {
                txtAnimalColor.Text = setColor;
            }
        }
        private void setAnimalDescription(string setDescription)
        {
            if (txtAnimalDescription.InvokeRequired)
            {
                txtAnimalDescription.Invoke(new MethodInvoker(() => { txtAnimalDescription.Text = setDescription; }));
            }
            else
            {
                txtAnimalDescription.Text = setDescription;
            }
        }
        // (Set) Animal location
        private void setAnimalStreetAddress(string setStreetAddress)
        {
            if (txtAnimalStreetAddress.InvokeRequired)
            {
                txtAnimalStreetAddress.Invoke(new MethodInvoker(() => { txtAnimalStreetAddress.Text = setStreetAddress; }));
            }
            else
            {
                txtAnimalStreetAddress.Text = setStreetAddress;
            }
        }
        private void setAnimalCity(string setCity)
        {
            if (txtAnimalCity.InvokeRequired)
            {
                txtAnimalCity.Invoke(new MethodInvoker(() => { txtAnimalCity.Text = setCity; }));
            }
            else
            {
                txtAnimalCity.Text = setCity;
            }
        }
        private void setAnimalState(string setState)
        {
            if (txtAnimalState.InvokeRequired)
            {
                txtAnimalState.Invoke(new MethodInvoker(() => { txtAnimalState.Text = setState; }));
            }
            else
            {
                txtAnimalState.Text = setState;
            }
        }
        private void setAnimalZip(string setZip)
        {
            if (txtAnimalZip.InvokeRequired)
            {
                txtAnimalZip.Invoke(new MethodInvoker(() => { txtAnimalZip.Text = setZip; }));
            }
            else
            {
                txtAnimalZip.Text = setZip.ToString();
            }
        }
        // (Set) Animal traits
        private void setAnimalFriendly(bool setFriendly)
        {
            if (cbAnimalFriendly.InvokeRequired)
            {
                cbAnimalFriendly.Invoke(new MethodInvoker(() => { cbAnimalFriendly.Checked = setFriendly; }));
            }
            else 
            { 
                cbAnimalFriendly.Checked = setFriendly; 
            }
        }
        private void setAnimalFixed(bool setFixed)
        {
            if (cbAnimalFixed.InvokeRequired)
            {
                cbAnimalFixed.Invoke(new MethodInvoker(() => { cbAnimalFixed.Checked = setFixed; }));
            }
            else
            {
                cbAnimalFixed.Checked = setFixed;
            }
        }
        private void setAnimalVaccines(bool setVaccines)
        {
            if (cbVaccines.InvokeRequired)
            {
                cbVaccines.Invoke(new MethodInvoker(() => { cbVaccines.Checked = setVaccines; }));
            }
            else
            {
                cbVaccines.Checked = setVaccines;
            }
        }
        private void setAnimalMicrochip(string setMicrochip)
        {
            bool isMicrochip = false;
                if (cbAnimalMicochip.InvokeRequired)
                {
                    switch (setMicrochip.ToUpper())
                    {
                    case "YES":
                            isMicrochip = true;
                        break;
                    case "NO":
                            isMicrochip = false;
                        break;
                    }
                
                cbAnimalMicochip.Invoke(new MethodInvoker(() => { cbAnimalMicochip.Checked = isMicrochip; }));
            }
            else
            {
                cbAnimalMicochip.Checked = isMicrochip;
            }
        }

        private void btnAdopt_Information_Click(object sender, EventArgs e)
        {
            
            //TODO: Threadsafe verification of adoption.
        }

        private void btnAdopt_Information_Click_1(object sender, EventArgs e)
        {
            /*
            Global.userPanel.Controls.Clear();
            Global.userPanel.Tag = "login";
            Global.userPanel.Controls.Add(new UserControlRegister());
             */
            if (_animal.isAdopted == false)
            {
                //This will pair the current user with a pet to adopt
                HelperFunctions.Queries.adoptedCheckInformation(Global.publicUser.userId, _animal.aid);
                
                //This will return person's information based on which user is logged in and adopted the current pet
                _customer = HelperFunctions.Queries.customerInformation(HelperFunctions.Queries.adoptedPersonID(Global.publicUser.userId));
                
                //Display the customer with adopted pet panel
                Global.panel.Controls.Clear();
                Global.panel.Controls.Add(new UserControlAdoptCheckOut(_customer, _animal.aid));
            }
        }
    }
}
