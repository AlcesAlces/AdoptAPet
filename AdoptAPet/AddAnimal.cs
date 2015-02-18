using AdoptAPet.HelperClasses;
using AdoptAPet.HelperFunctions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace AdoptAPet
{
    public partial class AddAnimal : Form
    {
        public AddAnimal()
        {
            InitializeComponent();
            cbSex.SelectedIndex = 0;
            populateComboboxes();
            panelAddess.Controls.Add(new UserControlAddress());
        }

        /// <summary>
        /// Populate the initial comboboxes, setting the data which will automatically populate the rest of the information.
        /// </summary>
        public void populateComboboxes()
        {
            var speciesBox = Queries.returnAllSpeciesName();

            cbSpecies.Items.Add("Select a Species");

            foreach (var item in speciesBox)
            {
                cbSpecies.Items.Add(item);
            }

            cbSpecies.SelectedIndex = 0;


            var colorBox = Queries.returnAllColor();

            cbColor.Items.Add("Select a Color");

            foreach (var item in colorBox)
            {
                cbColor.Items.Add(item);
            }

            cbColor.SelectedIndex = 0;
        }

        private void cbSpecies_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            cbBreed.Items.Clear();

            var breedBox = Queries.returnBreedBySpecies(cbSpecies.SelectedItem.ToString());

            cbBreed.Items.Add("Select a Breed");
            cbBreed.SelectedIndex = 0;

            foreach (var item in breedBox)
            {
                cbBreed.Items.Add(item.ToString());
            }
        }

        private void ofdAddAnimal_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void btnBrowseIMage_Click(object sender, EventArgs e)
        {
            ofdAddAnimal.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            var userClickedOK = ofdAddAnimal.ShowDialog();

            if(File.Exists(ofdAddAnimal.FileName))
            {
                pbPreview.ImageLocation = ofdAddAnimal.FileName;
            }

            else
            {

            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Animal toAdd = null;

            bool continueOn = true;
            int ImageId = 0;

            string eMssage = getErrorMessage();
            if (eMssage.Trim().Length != 0)
            {
                eMssage = "Please Fill out:\n" + eMssage;
                continueOn = false;
            }
           

            int addressIndex =-1;
            //get the address index
            if (panelAddess.Controls[0] != null)
            {
                UserControlAddress boundUserControl = panelAddess.Controls[0] as UserControlAddress;
                addressIndex = boundUserControl.returnAddressindex();
                if (addressIndex == -1)//field not filled 
                {
                    eMssage += "\tAddress\n";
                    continueOn = false;

                }
            }
            else {
                //error?
            }

            if (continueOn == false)
            {
                MessageBox.Show(eMssage);
            }

            try
            {
                XDocument doc = Imgur.uploadImage(ofdAddAnimal.FileName);
                string link = doc.Root.Element("link").Value;
                string deletehash = doc.Root.Element("deletehash").Value;
                ImageId = Queries.addImageToDatabase(link, deletehash);
            }

            catch (Exception ex)
            {
                continueOn = false;
                MessageBox.Show("Something messed up with imgur!");
            }

            try
            {
                if (continueOn)
                {
                    int t_age = Int32.Parse(txtAge.Text);
                    string t_description = rtbDescription.Text;
                    bool t_friendly = cbFriendly.Checked;
                    string t_name = txtName.Text;
                    string t_sex = cbSex.SelectedItem.ToString();
                    bool t_isFixed = cbFixed.Checked;
                    int t_color = cbColor.SelectedIndex;
                    int t_location= addressIndex;

                    toAdd = new Animal()
                    {
                        age = t_age,
                        description = t_description,
                        friendly = t_friendly,
                        name = t_name,
                        sex = t_sex,
                        isFixed = t_isFixed,
                        imgid = ImageId,
                        color = t_color,
                        location = t_location
                    };

                    string species = cbSpecies.SelectedItem.ToString();
                    string breed = cbBreed.SelectedItem.ToString();

                    Queries.addAnimal(species, breed, toAdd);

                    MessageBox.Show("Animal Added Successfully!");

                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Incorrect input format");
            }
        }

        public string getErrorMessage()
        {
            string eMessage = "";
            if (txtName.Text.Trim().Length == 0){
                eMessage += "\tName\n";
            }
            if (txtAge.Text.Trim().Length == 0)
            {
                eMessage += "\tAge\n";
            }
            if (txtName.Text.Trim().Length == 0)
            {
                eMessage += "\tName\n";
            }
            if (cbSex.SelectedIndex == 0)
            {
                eMessage += "\tSex\n";
            }
            if (cbSpecies.SelectedIndex == 0)
            {
                eMessage += "\tSpecies\n";
            } 
            if (cbBreed.SelectedIndex == 0)
            {
                eMessage += "\tBreed\n";
            }
            if (cbColor.SelectedIndex == 0)
            {
                eMessage += "\tColor\n";
            }
            if (rtbDescription.Text.Trim().Length == 0)
            {
                eMessage += "\tDescription\n";
            }

            return eMessage;
        }

        //make the text box numeric only 
        //so no need to do input validation
        private void txtAge_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
