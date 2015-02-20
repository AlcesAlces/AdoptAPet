using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdoptAPet.HelperClasses;
using AdoptAPet.HelperFunctions;

namespace AdoptAPet.Forms
{
    public partial class RemoveUser : Form
    {
        public RemoveUser()
        {
            InitializeComponent();
        }

        private void RemoveUser_Load(object sender, EventArgs e)
        {
            populateRemoveList();
        }

        public void populateRemoveList()
        {
            lbRemoveUser.Items.Clear();

            List<User> userList = Queries.ReturnAllUsers();
            userList = (from b in userList
                        where !b.admin
                        select b).ToList();

            //List<User> example = (List<User>)lbRemoveUser.tag;
            lbRemoveUser.Tag = userList;

            foreach (User item in userList){
                
               lbRemoveUser.Items.Add(item.userName);
                
            } 

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            List<User> userList = (List<User>)lbRemoveUser.Tag;
            int userIndexToRomove = lbRemoveUser.SelectedIndex;

            Queries.romoveUserById(userList[userIndexToRomove].userId);

            populateRemoveList();

        }
    }
}
