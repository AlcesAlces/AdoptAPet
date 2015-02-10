using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace AdoptAPet.HelperFunctions
{
    class Imgur
    {

        public static XDocument uploadImage(string location)
        {

            XDocument test = null;

            try
            {

                using (var w = new WebClient())
                {
                    //Hardcode your super secret code LIKE A BOSS!
                    string clientID = "7183222149d944c";
                    w.Headers.Add("Authorization", "Client-ID " + clientID);
                    var values = new NameValueCollection
                {
                    { "image", Convert.ToBase64String(File.ReadAllBytes(@location)) }
                };

                    byte[] response = w.UploadValues("https://api.imgur.com/3/upload.xml", values);

                    test = XDocument.Load(new MemoryStream(response));
                }
            }

            catch(Exception e)
            {
                MessageBox.Show("File not found!");
            }

            return test;
        }

    }
}
