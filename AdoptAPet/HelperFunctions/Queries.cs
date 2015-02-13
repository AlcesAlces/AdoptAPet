using AdoptAPet.HelperClasses;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoptAPet.HelperFunctions
{
    /// <summary>
    /// Cool queries for cool dudes
    /// </summary>
    static class Queries
    {

        /// <summary>
        /// Pass in a SQL statement, get a dataset back
        /// </summary>
        /// <param name="sql"></param>
        /// <returns>dataset</returns>
        private static DataSet dsBySql(string sql)
        {
            string connection = String.Format("Server=75.115.14.171;Port=5432;User Id=postgres;Password=stimperman;Database=postgres");
            NpgsqlConnection conn = new NpgsqlConnection(connection);
            conn.Open();
            DataSet ds = new DataSet();
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, conn);
            da.Fill(ds);
            conn.Close();

            return ds;
        }

        public static User returnUserByName(string userName)
        {
            
            string sql = "SELECT * FROM \"USER\" WHERE \"NAME\" ='" + userName.ToLower() + "'";
            DataSet ds = dsBySql(sql);

            if(ds.Tables[0].Rows.Count == 0)
            {
                //No tables
                return null;
            }

            return new User
            {
                userName = ds.Tables[0].Rows[0]["NAME"].ToString().Trim(),
                password = ds.Tables[0].Rows[0]["PASS"].ToString().Trim(),
                admin = (bool)ds.Tables[0].Rows[0]["ADMIN"]
            };
        }

        public static List<string> returnAllSpeciesName()
        {
            string sql = "SELECT \"NAME\" FROM \"SPECIES\"";
            DataSet ds = dsBySql(sql);

            List<string> toReturn = new List<string>();
            
            foreach(DataRow item in ds.Tables[0].Rows)
            {
                toReturn.Add(item["NAME"].ToString().Trim());
            }

            return toReturn;
        }

        public static List<string> returnBreedBySpecies(string species)
        {
            string sql = "SELECT B.\"NAME\" FROM \"BREED\" B, \"SPECIES\" S WHERE S.\"SID\" = B.\"SPECIES\" AND S.\"NAME\" ='" + species + "'";
            DataSet ds = dsBySql(sql);

            List<string> toReturn = new List<string>();

            foreach(DataRow item in ds.Tables[0].Rows)
            {
                toReturn.Add(item["NAME"].ToString().Trim());
            }

            return toReturn;
        }

        public static bool checkUsernameUnique(string username)
        {
            string sql = "SELECT COUNT(*) as usercount FROM \"USER\" U WHERE U.\"NAME\" = '"+username+"'";
            DataSet ds = dsBySql(sql);

            if(Int32.Parse(ds.Tables[0].Rows[0]["usercount"].ToString().Trim()) != 0)
            {
                return false;
            }

            else
            {
                return true;
            }
        }

        public static List<Animal> animalNamesByParameter(string species, string breed)
        {
            string sql = "";

            if(species == null && breed != null)
            {
                sql = "SELECT A.\"NAME\", A.\"AID\", A.\"ADOPTED\" FROM \"ANIMAL\" A INNER JOIN \"SPECIES\" S ON " +
                      "A.\"SPECIES\" = S.\"SID\" INNER JOIN \"BREED\" B ON A.\"BREED\" = " +
                      "B.\"BID\" WHERE B.\"NAME\" = '" + breed + "'";
            }

            else if(breed == null && species != null)
            {
                sql = "SELECT A.\"NAME\", A.\"AID\", A.\"ADOPTED\" FROM \"ANIMAL\" A INNER JOIN \"SPECIES\" S ON " +
                      "A.\"SPECIES\" = S.\"SID\" INNER JOIN \"BREED\" B ON A.\"BREED\" = " +
                      "B.\"BID\" WHERE S.\"NAME\" = '" + species +"'";
            }

            else if (breed == null && species == null)
            {
                sql = "SELECT A.\"NAME\", A.\"AID\", A.\"ADOPTED\" FROM \"ANIMAL\" A INNER JOIN \"SPECIES\" S ON " +
                      "A.\"SPECIES\" = S.\"SID\" INNER JOIN \"BREED\" B ON A.\"BREED\" = " +
                      "B.\"BID\"";
            }

            else
            {
                sql = "SELECT A.\"NAME\", A.\"AID\", A.\"ADOPTED\" FROM \"ANIMAL\" A INNER JOIN \"SPECIES\" S ON " +
                      "A.\"SPECIES\" = S.\"SID\" INNER JOIN \"BREED\" B ON A.\"BREED\" = " +
                      "B.\"BID\" WHERE S.\"NAME\" = '" + species + "' AND B.\"NAME\" = '" + breed + "'";
            }


            DataSet ds = dsBySql(sql);

            List<Animal> toReturn = new List<Animal>();

            foreach(DataRow item in ds.Tables[0].Rows)
            {
                toReturn.Add(new Animal
                    {
                        aid = Int32.Parse(item["AID"].ToString()),
                        name = item["NAME"].ToString(),
                        isAdopted = (bool)item["ADOPTED"]
                    });
            }

            return toReturn;
        }

        public static string imageByAid(int aid)
        {
            string sql = "SELECT IMG.\"IMAGE_URL\" FROM \"ANIMAL\" A "+
                          "INNER JOIN \"IMAGE\" I ON A.\"IMG_ID\" = I.\"IMAGE_ID\" "+
                          "INNER JOIN \"IMGUR_RESOURCE\" IMG ON I.\"IMGUR_ID\" = IMG.\"IMAGE_ID\" "+
                          "WHERE A.\"AID\" = "+aid;
            DataSet ds = dsBySql(sql);

            string toReturn = "";

            foreach( DataRow item in ds.Tables[0].Rows)
            {
                toReturn = item["IMAGE_URL"].ToString();
            }

            if (toReturn == "")
            {
                return null;
            }

            else
            {
                return toReturn;
            }
        }

        public static List<ImageHandler> returnAllImages()
        {
            string sql = "SELECT IMG.\"IMAGE_URL\", I.\"IMAGE_ID\" FROM \"ANIMAL\" A " +
                          "INNER JOIN \"IMAGE\" I ON A.\"IMG_ID\" = I.\"IMAGE_ID\" " +
                          "INNER JOIN \"IMGUR_RESOURCE\" IMG ON I.\"IMGUR_ID\" = IMG.\"IMAGE_ID\"";

            DataSet ds = dsBySql(sql);

            foreach(DataRow row in ds.Tables[0].Rows)
            {

            }

            List<ImageHandler> toReturn = new List<ImageHandler>();

            return toReturn;
        }

        public static void addAnimal(string species, string breed, Animal animal)
        {

            string sqlSpecies = "SELECT \"SID\" FROM \"SPECIES\" WHERE \"NAME\" = '"+species+"'";
            string sqlBreed = "SELECT \"BID\" FROM \"BREED\" WHERE \"NAME\"='"+breed+"'";

            //Should only return 1 result each.
            DataSet dsSpecies = dsBySql(sqlSpecies);
            DataSet dsBreed = dsBySql(sqlBreed);

            int sid = 0;
            int bid = 0;

            foreach(DataRow row in dsSpecies.Tables[0].Rows)
            {
                sid = Int32.Parse(row["SID"].ToString());
            }

            foreach(DataRow row in dsBreed.Tables[0].Rows)
            {
                bid = Int32.Parse(row["BID"].ToString());
            }

            int age = animal.age != null ? animal.age : 0;
            string sex = animal.sex != null ? animal.sex : "NOT PROVIDED";
            int color = 0;
            string name = animal.name != null ? animal.name : "NOT PROVIDED";
            bool friendly = animal.friendly != null? animal.friendly : false;
            string description = animal.description != null? animal.description : "NOT PROVIDED";
            string microchip = "N/A";
            bool isFixed = animal.isFixed != null?animal.isFixed:false;
            int location = 0;
            int imgId = animal.imgid!=null?animal.imgid:0;

            string sqlInsert = "INSERT INTO \"ANIMAL\" (\"AGE\", \"SEX\", \"COLOR\", \"NAME\", \"FRIENDLY\", \"DESCRIPTION\", \"MICROCHIP\", \"FIXED\", \"LOCATION\", \"IMG_ID\", \"SPECIES\", \"BREED\")"+
                                "VALUES ("+age+",'"+sex+"',"+color+",'"+name+"',"+friendly+",'"+description+"','"+microchip+"',"+isFixed+","+location+","+imgId+","+sid+","+bid+")";

            dsBySql(sqlInsert);
        
        }
        /// <summary>
        /// Uploads an image based on the link, and deletehash provided by caller. Returns imgid
        /// </summary>
        /// <param name="link"></param>
        /// <param name="?"></param>
        /// <returns></returns>
        public static int addImageToDatabase(string link, string deletehash)
        {

            string sqlImgur = "INSERT INTO \"IMGUR_RESOURCE\" (\"IMAGE_URL\", \"DELETE_HASH\") VALUES ('" + link + "','" + deletehash + "')";

            dsBySql(sqlImgur);

            string sqlTop = "SELECT MAX(\"IMAGE_ID\") FROM \"IMGUR_RESOURCE\"";
            DataSet topDs = dsBySql(sqlTop);
            int topImgur = 0;
            foreach(DataRow row in topDs.Tables[0].Rows)
            {
                topImgur = Int32.Parse(row["max"].ToString());
            }

            string sqlImage = "INSERT INTO \"IMAGE\" (\"IMGUR_ID\") VALUES(" + topImgur +")";
            dsBySql(sqlImage);

            string topImage = "SELECT MAX(\"IMAGE_ID\") FROM \"IMAGE\"";
            DataSet topImageDs = dsBySql(topImage);
            int topImageInt = 0;
            foreach (DataRow row in topImageDs.Tables[0].Rows)
            {
                topImageInt = Int32.Parse(row["max"].ToString());
            }

            return topImageInt;
        }

        /// <summary>
        /// Removes an animal from the database
        /// </summary>
        public static void removeAnimalByAID(int aid)
        {
            string sqlRemoval = "DELETE FROM \"ANIMAL\" WHERE \"AID\" =" + aid;
            dsBySql(sqlRemoval);
        }

        /// <summary>
        /// Set an Animal's adopted status based on AID and ADOPTED
        /// </summary>
        /// <param name="aid"></param>
        /// <param name="adopted"></param>
        public static void setAnimalAdoptedByAid(int aid, bool adopted)
        {
            string sqlAdopt = "UPDATE \"ANIMAL\" SET \"ADOPTED\" ="+adopted+" WHERE \"AID\" =" + aid;
            dsBySql(sqlAdopt);
        }

        public static void addUser(string name, string pass)
        {
            string sql = "INSERT INTO \"USER\" (\"NAME\", \"PASS\") VALUES ('" + name + "','" + pass + "')";
            dsBySql(sql);
        }
    }
}