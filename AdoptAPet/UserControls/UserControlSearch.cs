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
using AdoptAPet.UserControls;

namespace AdoptAPet
{
    public partial class UserControlSearch : UserControl
    {
        public UserControlSearch()
        {
            InitializeComponent();
            popComboBoxesWrapper();
            //populateComboboxes();
        }

        #region control events

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

            foreach (var item in breedBox)
            {
                cbBreed.Items.Add(item.ToString());
            }

            unhookBreedBox();

            if (lbAnimals.Items.Count != 0)
            {
                lbAnimals.SelectedIndex = 0;
            }

            listBoxWrapper();
        }


        private void cbBreed_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbAnimals.Items.Count != 0)
            {
                lbAnimals.SelectedIndex = 0;
            }

            listBoxWrapper();
        }

        private void lbAnimals_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (lbAnimals.Items.Count == 0 || lbAnimals.Items[0] == "No animals!")
            {
                //Don't do anything, dummy
            }

            else
            {
                setAnimalInfo();
            }

        }

        private void tbSearchName_TextChanged(object sender, EventArgs e)
        {
            //temp string to pass into information box: Animal Name
            //txtAnimalName_Information.Text = "Fake Animal Name";
        }

        private void btnSearchName_Click(object sender, EventArgs e)
        {
            listBoxWrapper();
        }

        private void clbfFilters_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxWrapper();
        }

        #endregion

        #region support functions

        /// <summary>
        /// Sets all animal information in concern to the image box and combo boxes
        /// </summary>
        private void setAnimalInfo()
        {
            List<Animal> animalList = getlbAnimalsTag();
            int index = getLbAnimalSelectedIndex();

            if (animalList.Count == 0)
            {
                setpbPictureImage(ImageGoBetween.returnPlaceholderPicture());
            }

            else
            {

                if (index == -1)
                {
                    index = 0;
                }

                Animal animal = animalList[index];

                setpnlContent(new UserControlAnimalRecord(animal));

                try
                {
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
                        setpbPictureImage(ImageGoBetween.imageFromAid(animal.aid));
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        /// <summary>
        /// Populate the initial comboboxes, setting the data which will automatically populate the rest of the information.
        /// </summary>
        public void populateComboboxes()
        {
            var speciesBox = Queries.returnAllSpeciesName();

            addItemCbSpecies("Select a Species");

            foreach (var item in speciesBox)
            {
                addItemCbSpecies(item);
            }

            setCbSpeciesIndex(0);
        }

        /// <summary>
        /// Populate the animal list box.
        /// </summary>
        public void populateLisBox()
        {
            try
            {
                clearLbAnimals();

                string speciesString = null;
                string breedString = null;
                string searchName = null;

                if (getSelectedCbSpeciesItem() != "Select a Species")
                {
                    speciesString = getSelectedCbSpeciesItem();

                }

                if (getSelectedCbBreedItem() != "Select a Breed")
                {
                    breedString = getSelectedCbBreedItem();
                }

                if (tbSearchName.Text.Trim().Length != 0)
                {
                    searchName = tbSearchName.Text;
                }


                List<Animal> toPopulate = Queries.animalNamesByParameter(speciesString, breedString, searchName, clbfFilters.GetItemChecked(0), clbfFilters.GetItemChecked(1), clbfFilters.GetItemChecked(2));
                toPopulate = toPopulate.OrderBy(x => x.name).ToList();
                lbAnimals.Tag = toPopulate;

                if (toPopulate.Count == 0)
                {
                    lbAnimalsAddItem("No animals!");
                }

                foreach (Animal item in toPopulate)
                {
                    lbAnimalsAddItem(item.name.ToString());
                }

                setAnimalInfo();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        #endregion

        #region background workers

        /// <summary>
        /// Acts as a stand-between the worker and function calls.
        /// </summary>
        private void popComboBoxesWrapper()
        {
            bwPopComboBoxes.RunWorkerAsync();
        }

        /// <summary>
        /// Worker for the comboboxes repopulation function.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void popComboBoxes_DoWork(object sender, DoWorkEventArgs e)
        {

            setFormEnabled(false);
            tssLabelStatus.Text = "Loading animal information...";
            populateComboboxes();
            tssLabelStatus.Text = "Animal information loaded";
            setFormEnabled(true);
        }

        private void listBoxWrapper()
        {
            bwListBox.RunWorkerAsync();
        }

        private void bwListBox_DoWork(object sender, DoWorkEventArgs e)
        {
            setFormEnabled(false);
            populateLisBox();
            setFormEnabled(true);
        }

        #endregion

        #region unhooking component methods

        /// <summary>
        /// Needed when you don't want the breedbox selected index changed event to fire.
        /// </summary>
        private void unhookBreedBox()
        {
            cbBreed.SelectedIndexChanged -= cbBreed_SelectedIndexChanged;
            cbBreed.SelectedIndex = 0;
            cbBreed.SelectedIndexChanged += cbBreed_SelectedIndexChanged;
        }

        #endregion

        #region threadsafe component interaction
        //All of these functions are needed if you're going to interact with a
        //component outside of this thread.

        private void setFormEnabled(bool state)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new MethodInvoker(() => { this.Enabled = state; }));
            }

            else
            {
                this.Enabled = state;
            }
        }

        private void addItemCbSpecies(string toSet)
        {
            if (cbSpecies.InvokeRequired)
            {
                cbSpecies.Invoke(new MethodInvoker(() => { cbSpecies.Items.Add(toSet); }));
            }

            else
            {
                cbSpecies.Items.Add(toSet);
            }
        }

        private void setCbSpeciesIndex(int index)
        {
            if(cbSpecies.InvokeRequired)
            {
                cbSpecies.Invoke(new MethodInvoker(() => { cbSpecies.SelectedIndex = index; }));
            }

            else
            {
                cbSpecies.SelectedIndex = 0;
            }
        }

        private void clearLbAnimals()
        {
            if (lbAnimals.InvokeRequired)
            {
                lbAnimals.Invoke(new MethodInvoker(() => { lbAnimals.Items.Clear(); }));
            }
            else
            {
                lbAnimals.Items.Clear();
            }
        }

        private string getSelectedCbSpeciesItem()
        {
            if(cbSpecies.InvokeRequired)
            {
                string toReturn = "";
                cbSpecies.Invoke(new MethodInvoker(() => { toReturn = cbSpecies.SelectedItem.ToString(); }));
                return toReturn;
            }
            else
            {
                return cbSpecies.SelectedItem.ToString();
            }
        }

        private string getSelectedCbBreedItem()
        {
            if(cbBreed.InvokeRequired)
            {
                string toReturn = "";
                cbBreed.Invoke(new MethodInvoker(() => { toReturn = cbBreed.SelectedItem.ToString(); }));
                return toReturn;
            }

            else
            {
                return cbBreed.SelectedItem.ToString();
            }
        }

        private void lbAnimalsAddItem(string toAdd)
        {
            if(lbAnimals.InvokeRequired)
            {
                lbAnimals.Invoke(new MethodInvoker(() => { lbAnimals.Items.Add(toAdd); }));
            }

            else
            {
                lbAnimals.Items.Add(toAdd);
            }
        }

        private List<Animal> getlbAnimalsTag()
        {
            if(lbAnimals.InvokeRequired)
            {
                List<Animal> toReturn = new List<Animal>();
                lbAnimals.Invoke(new MethodInvoker(() => { toReturn = lbAnimals.Tag as List<Animal>; }));
                return toReturn;
            }
            else
            {
                return lbAnimals.Tag as List<Animal>;
            }
        }

        private int getLbAnimalSelectedIndex()
        {
            if(lbAnimals.InvokeRequired)
            {
                int toReturn = 0;
                lbAnimals.Invoke(new MethodInvoker(() => { toReturn = lbAnimals.SelectedIndex; }));
                return toReturn;
            }

            else
            {
                return lbAnimals.SelectedIndex;
            }
        }

        private void setpbPictureImage(Image toSet)
        {
            if(pbPicture.InvokeRequired)
            {
                pbPicture.Invoke(new MethodInvoker(() => { pbPicture.Image = toSet; }));
            }

            else
            {
                pbPicture.Image = toSet;
            }
        }

        private void setpnlContent(UserControlAnimalRecord test)
        {
            if(pnlAnimalInfo.InvokeRequired)
            {
                pnlAnimalInfo.Invoke(new MethodInvoker(() =>
                {
                    pnlAnimalInfo.Controls.Clear();
                    pnlAnimalInfo.Controls.Add(test);

                }));
            }

            else
            {
                pnlAnimalInfo.Controls.Clear();
                pnlAnimalInfo.Controls.Add(test);
            }
        }

        #endregion
    }
}
