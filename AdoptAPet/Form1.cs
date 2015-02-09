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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Global.menuItemsEdit.Add(addAnimalToolStripMenuItem);
            Global.menuItemsEdit.Add(removeAnimalToolStripMenuItem);
            Global.menuItemsEdit.Add(addUserToolStripMenuItem);
            Global.menuItemsEdit.Add(removeUserToolStripMenuItem);
            Global.menuItemsUser.Add(loginToolStripMenuItem);
            Global.menuItemsUser.Add(logoutToolStripMenuItem);
            Global.menuItemsUser.Add(registerToolStripMenuItem);
            Global.panel = panelMain;

            registerToolStripMenuItem.Visible = true;
            loginToolStripMenuItem.Visible = true;
            panelMain.Controls.Add(new UserControlHome());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void addAnimalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form addAnimalForm = new AddAnimal();
            addAnimalForm.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Global.publicUser.handleLogout();
            FormHelpers.setMainComponentsLogin();
        }
    }
}
