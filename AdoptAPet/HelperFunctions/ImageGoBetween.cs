using AdoptAPet.HelperClasses;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace AdoptAPet.HelperFunctions
{
    /// <summary>
    /// Use these functions to act as a go-between between the database and the user's local files.
    /// </summary>
    static class ImageGoBetween
    {
        public static Image imageFromAid(int aid)
        {
            ImageHandler result = Queries.imageByAid(aid);

            result = verifyImageIsLocal(result);

            return Image.FromFile(result.path);
        }

        public static ImageHandler verifyImageIsLocal(ImageHandler img)
        {
            var filters = new String[] { "jpg", "jpeg", "png", "gif", "tiff", "bmp" };
            //Files is now an array of strings, which are the local path of the img information.
            var files = GetFilesFrom(getImageDirectory(), filters, false);

            var filesParsed = (from b in files
                               select new
                               {
                                   fullPart = b.Split('\\')[b.Split('\\').Length - 1],
                                   filePart = (b.Split('\\')[b.Split('\\').Length - 1]).Split('.')[0]
                               }).ToList();

            ImageHandler toReturn;

            int resultCount = (from b in filesParsed
                               where b.filePart == img.imageId.ToString()
                               select b).Count();

            //Image has not been pulled locally.
            if(resultCount == 0)
            {
                toReturn = createImageLocal(img);
            }
            
            else
            {
                toReturn = new ImageHandler
                {
                    imageId = img.imageId,
                    local = true,
                    path = pathFromImageHandler(img)
                };
            }

            return toReturn;
        }

        private static ImageHandler createImageLocal(ImageHandler image)
        {
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
            string path = getImageDirectory() + "\\" + image.imageId.ToString() + "." + pathType;
            Frame.Save(path);
            return new ImageHandler
                {
                    imageId = image.imageId,
                    local = true,
                    path = pathFromImageHandler(image)
                };
        }

        public static string getImageDirectory()
        {
            return Path.Combine(Directory.GetCurrentDirectory(), "images");
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

        public static string pathFromImageHandler(ImageHandler img)
        {

            var pathtypeSplit = img.path.Split('\\');
            pathtypeSplit = pathtypeSplit[pathtypeSplit.Count() - 1].Split('.');
            string pathType = pathtypeSplit[pathtypeSplit.Count() - 1];

            return getImageDirectory() + "\\" + img.imageId.ToString() + "." + pathType;
        }
    }
}
