using AdoptAPet.HelperClasses;
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

namespace AdoptAPet
{
    public partial class RemoveAnimal : Form
    {
        public RemoveAnimal()
        {
            InitializeComponent();
            List<Animal> animals = Queries.animalNamesByParameter(null, null);

            lbAvailableAnimals.Tag = animals;

            foreach(Animal animal in animals)
            {
                lbAvailableAnimals.Items.Add(animal.name);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
