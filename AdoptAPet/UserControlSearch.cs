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
using System.Drawing.Drawing2D;
using System.Net;
using System.IO;

namespace AdoptAPet
{
    public partial class UserControlSearch : UserControl
    {
        public UserControlSearch()
        {
            InitializeComponent();
            populateComboboxes();
        }

        /// <summary>
        /// Populate the initial comboboxes, setting the data which will automatically populate the rest of the information.
        /// </summary>
        public void populateComboboxes()
        {
            var speciesBox = Queries.returnAllSpeciesName();

            cbSpecies.Items.Add("Select a Species");

            foreach(var item in speciesBox)
            {
                cbSpecies.Items.Add(item);
            }

            cbSpecies.SelectedIndex = 0;
        }

        /// <summary>
        /// Populate the animal list box.
        /// </summary>
        public void populateLisBox()
        {
            try
            {
                this.Enabled = false;

                lbAnimals.Items.Clear();

<<<<<<< HEAD
            if(cbSpecies.SelectedItem.ToString() != "Select a Species")
            {
                speciesString = cbSpecies.SelectedItem.ToString();
                txtAnimalSpecies_Infomation.Text = speciesString;
=======
                string speciesString = null;
                string breedString = null;
>>>>>>> origin/Chris_Branch

                if (cbSpecies.SelectedItem.ToString() != "Select a Species")
                {
                    speciesString = cbSpecies.SelectedItem.ToString();

<<<<<<< HEAD
            if (cbBreed.SelectedItem.ToString() != "Select a Breed")
            {
                breedString = cbBreed.SelectedItem.ToString();
                txtAnimalBreed_Information.Text = breedString;
            }
=======
                }
>>>>>>> origin/Chris_Branch

                if (cbBreed.SelectedItem.ToString() != "Select a Breed")
                {
                    breedString = cbBreed.SelectedItem.ToString();
                }

                List<Animal> toPopulate = Queries.animalNamesByParameter(speciesString, breedString);
                lbAnimals.Tag = toPopulate;

                if (toPopulate.Count == 0)
                {
                    lbAnimals.Items.Add("No animals!");
                }

                foreach (Animal item in toPopulate)
                {
                    lbAnimals.Items.Add(item.name.ToString());
                }

                Image toSet = null;

                if (toPopulate.Count != 0)
                {
                    toSet = ImageGoBetween.imageFromAid(toPopulate[0].aid);
                }

                if (toSet != null)
                {
                    pbPicture.Image = toSet;
                }

                else
                {
                    try
                    {
                        //TODO: Change the way this references the image
                        pbPicture.ImageLocation = @"pictures/other/shadow.png";
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.ToString());
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                this.Enabled = true;
            }
        }

        private void UserControlSearch_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// React to the species box changing.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbSpecies_SelectedIndexChanged(object sender, EventArgs e)
        {

            cbBreed.Items.Clear();
            
            var breedBox = Queries.returnBreedBySpecies(cbSpecies.SelectedItem.ToString());

            cbBreed.Items.Add("Select a Breed");

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

                if (lbAnimals.SelectedIndex != -1)
                {
                    Animal animal = animalList[lbAnimals.SelectedIndex];

                    if (animal.isAdopted)
                    {
                        Image playbutton;
                        try
                        {
                            playbutton = (Image)AdoptAPet.Properties.Resources.adopted;
                        }
                        catch (Exception ex)
                        {
                            return;
                        }

                        Image Frame;
                        try
                        {
                            Frame = ImageGoBetween.imageFromAid(animal.aid);
                        }
                        catch (Exception ex)
                        {
                            return;
                        }

                        using (Frame)
                        {
                            int height = pbPicture.Height;
                            int width = pbPicture.Width;
                            using (var bitmap = new Bitmap(width, height))
                            {
                                using (var canvas = Graphics.FromImage(bitmap))
                                {
                                    canvas.InterpolationMode = InterpolationMode.HighQualityBicubic;
                                    canvas.DrawImage(Frame, new Rectangle(0, 0, width, height), new Rectangle(0, 0, Frame.Width, Frame.Height), GraphicsUnit.Pixel);
                                    canvas.DrawImage(playbutton, (bitmap.Width / 2) - (playbutton.Width / 2 + 5), (bitmap.Height / 2) - (playbutton.Height / 2 + 5));
                                    canvas.Save();
                                }
                                try
                                {
                                    pbPicture.Image = new Bitmap(bitmap);
                                }
                                catch (Exception ex) { }
                            }
                        }
                    }

                    else
                    {
                        pbPicture.Image = ImageGoBetween.imageFromAid(animal.aid);
                    }
                }

            }

        }

        private void tbSearchName_TextChanged(object sender, EventArgs e)
        {
            //temp string to pass into information box: Animal Name
            txtAnimalName_Information.Text = "Fake Animal Name";
        }

        private void cbAdopted_CheckedChanged(object sender, EventArgs e)
        {

        }

       
    }
}
