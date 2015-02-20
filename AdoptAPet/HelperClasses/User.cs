using AdoptAPet.HelperFunctions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoptAPet.HelperClasses
{
    public class User
    {
        public string userName { get; set; }
        public string password { get; set; }
        public int userId { get; set; }
        public bool admin { get; set; }

        public void handleLogout()
        {
            Global.menuItemsUser[0].Visible = true;
            Global.menuItemsUser[1].Visible = false;
            Global.menuItemsUser[2].Visible = true;
            Global.publicUser = null;

            FormHelpers.changeElementsBasedOnPrivledge();
        }

    }
}
