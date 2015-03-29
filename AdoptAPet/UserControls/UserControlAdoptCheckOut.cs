using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdoptAPet.HelperClasses;
using AdoptAPet.HelperFunctions;
namespace AdoptAPet.UserControls
{
    public partial class UserControlAdoptCheckOut : UserControl
    {
        Customer _customer = new Customer();
        Animal _animal = new Animal();
        string[] animalAttributes = new string[17];
        public UserControlAdoptCheckOut(Customer infoCustomer, int animalID)
        {
            InitializeComponent();
            _customer = infoCustomer;
            animalAttributes = HelperFunctions.Queries.adoptedCheckout_AnimalQuery(false, animalID);
            populateItems();
        }

        public UserControlAdoptCheckOut()
        {
            // TODO: Complete member initialization
        }

        private void populateItems()
        {
            //customer information
            setAdopterName(_customer.name);
            setAdopterHasAdopted(_customer.has_adopted);
            setAdopterDateOfBirth(_customer.dob);
            setAdopterStreet(_customer.street);
            setAdopterCity(_customer.city);
            setAdopterState(_customer.state);
            setAdopterZip(_customer.zip);

            //animal information
            _animal.aid = int.Parse(animalAttributes[0]);
            _animal.age = int.Parse(animalAttributes[1]);
            _animal.sex = animalAttributes[2];
            _animal.size = animalAttributes[3];
            _animal.color = int.Parse(animalAttributes[4]);
            _animal.name = animalAttributes[5];
            _animal.friendly = bool.Parse(animalAttributes[6]);
            _animal.weight = int.Parse(animalAttributes[7]);
            _animal.description = animalAttributes[8];
            _animal.vacciness = int.Parse(animalAttributes[9]);
            _animal.microchip = animalAttributes[10];
            _animal.location = int.Parse(animalAttributes[11]);
            _animal.imgid = int.Parse(animalAttributes[12]);
            _animal.species = int.Parse(animalAttributes[13]);
            _animal.breed = int.Parse(animalAttributes[14]);
            _animal.isFixed = bool.Parse(animalAttributes[15]);
            _animal.isAdopted = bool.Parse(animalAttributes[16]);
        }
        private void setAdopterName(string setName)
        {
            if (txtAdopterName.InvokeRequired)
            {
                txtAdopterName.Invoke(new MethodInvoker(() => { txtAdopterName.Text = setName; }));
            }
            else
            {
                txtAdopterName.Text = setName;
            }
        }
        private void setAdopterDateOfBirth(string setDoB)
        {
            if (txtAdopterDoB.InvokeRequired)
            {
                txtAdopterDoB.Invoke(new MethodInvoker(() => { txtAdopterDoB.Text = setDoB; }));
            }
            else
            {
                txtAdopterDoB.Text = setDoB;
            }
        }
        private void setAdopterHasAdopted(bool setHasAdopted)
        {
            if (txtHasAdopted.InvokeRequired)
            {
                txtHasAdopted.Invoke(new MethodInvoker(() => { txtHasAdopted.Text = setHasAdopted.ToString(); }));
            }
            else
            {
                txtHasAdopted.Text = setHasAdopted.ToString();
            }
        }
        private void setEmail(string setEmail)
        {
            if (txtAdopterEmail.InvokeRequired)
            {
                txtAdopterEmail.Invoke(new MethodInvoker(() => { txtAdopterEmail.Text = setEmail; }));
            }
            else
            {
                txtAdopterEmail.Text = setEmail;
            }
        }
        private void setAdopterStreet(string setStreet)
        {
            if (txtAdopterStreetAddress.InvokeRequired)
            {
                txtAdopterStreetAddress.Invoke(new MethodInvoker(() => { txtAdopterStreetAddress.Text = setStreet; }));
            }
            else
            {
                txtAdopterStreetAddress.Text = setStreet;
            }
        }
        private void setAdopterCity(string setCity)
        {
            if (txtAdopterCity.InvokeRequired)
            {
                txtAdopterCity.Invoke(new MethodInvoker(() => { txtAdopterCity.Text = setCity; }));
            }
            else
            {
                txtAdopterCity.Text = setCity;
            }
        }
        private void setAdopterState(string setState)
        {
            if (txtAdopterState.InvokeRequired)
            {
                txtAdopterState.Invoke(new MethodInvoker(() => { txtAdopterState.Text = setState; }));
            }
            else
            {
                txtAdopterState.Text = setState;
            }
        }
        private void setAdopterZip(int setZip)
        {
            if (txtAdopterZip.InvokeRequired)
            {
                txtAdopterZip.Invoke(new MethodInvoker(() => { txtAdopterZip.Text = setZip.ToString(); }));
            }
            else
            {
                txtAdopterZip.Text = setZip.ToString();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            //go back to search menu
            Global.panel.Controls.Clear();
            Global.panel.Controls.Add(new UserControlSearch());
            string isAdopted = animalAttributes[10];
            if (isAdopted != "True")
            {
                HelperFunctions.Queries.adoptedCheckout_RemoveRow(int.Parse(animalAttributes[0]));
            }

        }

        /*
        private void setAnimalInfo()
        {
          

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

        */

        private void setpnlContent(UserControlAnimalRecord test)
        {
            if (pnlAnimalInfo.InvokeRequired)
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


    }
}
