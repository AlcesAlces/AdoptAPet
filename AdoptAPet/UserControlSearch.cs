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
    public partial class UserControlSearch : UserControl
    {
        public UserControlSearch()
        {
            InitializeComponent();
            populateComboboxes();
        }

        public void populateComboboxes()
        {
            var speciesBox = Queries.returnAllSpeciesName();

            foreach(var item in speciesBox)
            {
                cbSpecies.Items.Add(item);
            }

            cbSpecies.SelectedIndex = 0;
        }

        public void populateLisBox()
        {
            lbAnimals.Items.Clear();
            List<Animal> toPopulate = Queries.animalNamesByParameter(cbSpecies.SelectedItem.ToString(), cbBreed.SelectedItem.ToString());

            lbAnimals.Tag = toPopulate;

            if(toPopulate.Count == 0)
            {
                lbAnimals.Items.Add("No animals!");
            }

            foreach(Animal item in toPopulate)
            {
                lbAnimals.Items.Add(item.name.ToString());
            }

            string toSet = null;

            if (toPopulate.Count != 0)
            {
                toSet = Queries.imageByAid(toPopulate[0].aid);
            }

            if (toSet != null)
            {
                pbPicture.ImageLocation = toSet;
            }

            else
            {
                try
                {
                    //TODO: Change the way this references the image
                    pbPicture.ImageLocation = @"pictures/other/shadow.png";
                }
                catch(Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
            }
        }

        private void UserControlSearch_Load(object sender, EventArgs e)
        {

        }

        private void cbSpecies_SelectedIndexChanged(object sender, EventArgs e)
        {

            cbBreed.Items.Clear();

            var breedBox = Queries.returnBreedBySpecies(cbSpecies.SelectedItem.ToString());

            foreach(var item in breedBox)
            {
                cbBreed.Items.Add(item.ToString());
            }

            cbBreed.SelectedIndex = 0;

            if (lbAnimals.Items.Count != 0)
            {
                lbAnimals.SelectedIndex = 0;
            }

            populateLisBox();
        }

        private void cbBreed_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbAnimals.Items.Count != 0)
            {
                lbAnimals.SelectedIndex = 0;
            }
            populateLisBox();
        }

        private void lbAnimals_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if(lbAnimals.Items.Count == 0 || lbAnimals.Items[0] == "No animals!")
            {
                //Don't do anything, dummy
            }

            else
            {
                List<Animal> animalList = (List<Animal>)lbAnimals.Tag;

                pbPicture.ImageLocation = Queries.imageByAid(animalList[lbAnimals.SelectedIndex].aid);

            }

        }
    }
}
