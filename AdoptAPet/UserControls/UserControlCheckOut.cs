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
    public partial class UserControlCheckOut : UserControl
    {
        public UserControlCheckOut()
        {
            InitializeComponent();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrintDialog PrintDialog1 = new PrintDialog();
            PrintDialog1.ShowDialog();
        }

        private void btnSaveToFile_Click(object sender, EventArgs e)
        {
            

        }
    }
}
