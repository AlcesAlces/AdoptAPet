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
using System.Drawing.Drawing2D;
namespace AdoptAPet.UserControls
{
    public partial class UserControlAdoptCheckOut : UserControl
    {
        Customer _customer = new Customer();
        Animal _animal = new Animal();
        public UserControlAdoptCheckOut(Customer infoCustomer, int animalID)
        {
            InitializeComponent();
            _customer = infoCustomer;
            populateItems(animalID);
            setAnimalInfo();
        }

        public UserControlAdoptCheckOut()
        {
            // TODO: Complete member initialization
        }

        private void populateItems(int aid)
        {
            //customer information
            setAdopterName(_customer.name);
            setAdopterHasAdopted(_customer.has_adopted);
            setAdopterDateOfBirth(_customer.dob);
            setAdopterStreet(_customer.street);
            setAdopterCity(_customer.city);
            setAdopterState(_customer.state);
            setAdopterZip(_customer.zip);

            _animal = Queries.getAnimalByAid(aid);
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
        }

        private void setAnimalInfo()
        {
            UserControlAnimalRecord animalRecord = new UserControlAnimalRecord(_animal);
            animalRecord.setAdoptButtonVis(false);
            setpnlContent(animalRecord);

                try
                {
                    if (_animal.isAdopted)
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
                            Frame = ImageGoBetween.imageFromAid(_animal.aid);
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
                        setpbPictureImage(ImageGoBetween.imageFromAid(_animal.aid));
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        

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

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to adopt this pet?", "AdoptAPet",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    //HelperFunctions.Queries.adoptedCheckout_UpdatePet(_animal.aid);
                    HelperFunctions.Queries.adoptedCheckout_UpdateWithAIDUID(_animal.aid);
                    HelperFunctions.Queries.setAnimalAdoptedByAid(_animal.aid, true);
                    MessageBox.Show("Animal adopted successfully!");
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Something terrible happened. Contact your systems administrator or cry a whole lot!");
                    MessageBox.Show(ex.ToString());
                }

                Global.panel.Controls.Clear();
                Global.panel.Controls.Add(new UserControlSearch());
            }

        }
      }
    }

