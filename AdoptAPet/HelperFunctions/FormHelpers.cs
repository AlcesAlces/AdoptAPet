using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdoptAPet.HelperFunctions
{
    static class FormHelpers
    {

        public static void setMainComponentsLogin()
        {
            Global.panel.Controls.Clear();
            Global.panel.Controls.Add(new UserControlHome());
        }

        public static void changeElementsBasedOnPrivledge()
        {

            if(Global.publicUser == null)
            {
                foreach (ToolStripMenuItem item in Global.menuItemsEdit)
                {
                    item.Visible = false;
                }
            }

            else if (Global.publicUser.admin)
            {
                foreach (ToolStripMenuItem item in Global.menuItemsEdit)
                {
                    item.Visible = true;
                }
            }

            else
            {
                foreach (ToolStripMenuItem item in Global.menuItemsEdit)
                {
                    item.Visible = false;
                }
            }
        }
    }
}
