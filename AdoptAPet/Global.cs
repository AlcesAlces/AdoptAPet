using AdoptAPet.HelperClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdoptAPet
{
    public static class Global
    {
        public static User publicUser = null;
        public static Panel panel;
        public static Panel userPanel;
        public static bool debug = false;
        public static List<ToolStripMenuItem> menuItemsEdit = new List<ToolStripMenuItem>();
        public static List<ToolStripMenuItem> menuItemsUser = new List<ToolStripMenuItem>();
    }
}
