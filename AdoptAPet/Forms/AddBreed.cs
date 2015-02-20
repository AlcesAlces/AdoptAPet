using AdoptAPet.HelperFunctions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdoptAPet.Forms
{
    public partial class AddBreed : Form
    {
        public AddBreed()
        {
            InitializeComponent();

            List<string> toBind = Queries.returnAllSpeciesName();

            cbSpecies.Items.Add("Select a species");

            foreach(var item in toBind)
            {
                cbSpecies.Items.Add(item.ToString());
            }

            cbSpecies.SelectedIndex = 0;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            if (cbSpecies.SelectedItem as string != "Select a species")
            {
                List<string> breeds = Queries.returnBreedBySpecies(cbSpecies.SelectedItem.ToString());

                if(!breeds.Contains(txtBreed.Text))
                {
                    //Add aminal
                    int speciesId = Queries.returnSpeciesIdByName(cbSpecies.SelectedItem.ToString());
                    Queries.addBreed(txtBreed.Text, speciesId);
                }
            }
            this.Enabled = true;
        }
    }
}
