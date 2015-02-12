using AdoptAPet.HelperClasses;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace AdoptAPet.HelperFunctions
{
    static class UserFileHandler
    {

        /// <summary>
        /// Check to see if the user file exists.
        /// </summary>
        /// <returns></returns>
        public static bool checkUserFileExists()
        {
            return File.Exists(getUserPath());
        }

        public static string getUserPath()
        {
            string path = "userinfo.xml";
            return Path.Combine(Directory.GetCurrentDirectory(), path);
        }

        /// <summary>
        /// Handles all the verification of the user file (Creates a new one if it doesn't exist, updates, etc).
        /// </summary>
        /// <returns></returns>
        public static bool verifyUserFile()
        {
            //User file already exists, check integrity.
            if(checkUserFileExists())
            {
                
            }

            else
            {

            }

            return false;
        }

        //TODO: Also include user configuration.
        public static void createUserFile(List<ImageHandler> handlers)
        {
            XmlTextWriter writer = new XmlTextWriter("userinfo.xml", System.Text.Encoding.UTF8);
            writer.WriteStartDocument(true);
            writer.Formatting = Formatting.Indented;
            writer.Indentation = 2;
            writer.WriteStartElement("userconfig");
            writer.WriteStartElement("imagedata");
            
            foreach(ImageHandler handler in handlers)
            {
                createImageNode(writer, handler.local, handler.path, handler.imageId);
            }

            writer.WriteEndElement();
            writer.WriteEndElement();
            writer.Close();
        }

        /// <summary>
        /// Write a single node element to xml file.
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="isLocal"></param>
        /// <param name="imageid"></param>
        private static void createImageNode(XmlTextWriter writer, bool isLocal, string location, int imageid)
        {
            //Write root of this element.
            writer.WriteStartElement("image");
            writer.WriteStartElement("islocal");
            writer.WriteString(isLocal.ToString());
            writer.WriteEndElement();
            writer.WriteStartElement("localpath");
            writer.WriteString(location);
            writer.WriteEndElement();
            writer.WriteStartElement("imageid");
            writer.WriteString(imageid.ToString());
            writer.WriteEndElement();
            writer.WriteEndElement();
        }

        /// <summary>
        /// TODO: Do something with this, not implemented yet.
        /// </summary>
        /// <param name="writer"></param>
        private static void createUserconfigNode(XmlTextWriter writer)
        {

        }

        public static List<ImageHandler> allImagesInXML()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(getUserPath());
            XmlNodeList nodes = doc.DocumentElement.SelectNodes("/userconfig/imagedata");

            List<ImageHandler> toReturn = new List<ImageHandler>();
            
            foreach (XmlNode node in nodes)
            {

                toReturn.Add(new ImageHandler
                    {
                        imageId = Int32.Parse(node.SelectSingleNode("imageid").ToString()),
                        local = node.SelectSingleNode("islocal").ToString() == "true" ? true:false,
                        path = node.SelectSingleNode("localpath").ToString()
                    });
            }

            return toReturn;
        }
        
    }
    
}

