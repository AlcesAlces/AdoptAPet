using AdoptAPet.HelperClasses;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
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

        public static string getImageDirectory()
        {
            return Path.Combine(Directory.GetCurrentDirectory(), "images");
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

        /// <summary>
        /// Use to ensure that all image files in the images directory are good.
        /// </summary>
        public static void verifyUserImageFiles()
        {
            //User already has the local directory "images", check for images.
            if(Directory.Exists(getImageDirectory()))
            {
                populateImageFolder();
            }
            
            //User has no image files, create directory and retrieve image files from imgur.
            else
            {
                Directory.CreateDirectory(getImageDirectory());
                populateImageFolder();
            }
        }

        private static void populateImageFolder()
        {
            List<ImageHandler> imagesLocal = Queries.returnAllImages();

            String searchFolder = getImageDirectory();
            var filters = new String[] { "jpg", "jpeg", "png", "gif", "tiff", "bmp" };
            //Files is now an array of strings, which are the local path of the img information.
            var files = GetFilesFrom(searchFolder, filters, false);

            //Returns the paths of all images in the /images folder
            var filesParsed = (from b in files
                               select new
                               {
                                   fullPart = b.Split('\\')[b.Split('\\').Length - 1],
                                   filePart = (b.Split('\\')[b.Split('\\').Length - 1]).Split('.')[0]
                               }).ToList();


            foreach(var image in imagesLocal)
            {
                if((from b in filesParsed
                   where b.filePart == image.imageId.ToString()
                   select b).Count() == 0)
                {
                    //File doesn't exist. Create it!
                    
                    //Pull file down from imgur
                    Image Frame;
                    WebClient wc = new WebClient();
                    byte[] bytes = wc.DownloadData(image.path);
                    MemoryStream ms = new MemoryStream(bytes);

                    //Write file to image
                    Frame = Image.FromStream(ms);
                    //Save file.
                    var pathTypeSplit = image.path.Split('.');
                    string pathType = pathTypeSplit[pathTypeSplit.Count() - 1];
                    Frame.Save(getImageDirectory() + "\\" + image.imageId.ToString() + "." + pathType);
                }
            }
        }

        private static String[] GetFilesFrom(String searchFolder, String[] filters, bool isRecursive)
        {
            List<String> filesFound = new List<String>();
            var searchOption = isRecursive ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly;
            foreach (var filter in filters)
            {
                filesFound.AddRange(Directory.GetFiles(searchFolder, String.Format("*.{0}", filter), searchOption));
            }
            return filesFound.ToArray();
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

