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
                userId = (int)ds.Tables[0].Rows[0]["UID"],
                admin = (bool)ds.Tables[0].Rows[0]["ADMIN"]
            };
        }

        public static List<string> returnAllColor()
        {
            string sql = "SELECT \"NAME\" FROM \"COLOR\"";
            DataSet ds = dsBySql(sql);

            List<string> toReturn = new List<string>();
            
            foreach(DataRow item in ds.Tables[0].Rows)
            {
                toReturn.Add(item["NAME"].ToString().Trim());
            }

            return toReturn;
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

        public static List<Animal> allAnimals()
        {
            string sql = "SELECT* FROM \"ANIMAL\"";
            DataSet ds = dsBySql(sql);

            List<Animal> toReturn = new List<Animal>();
            
            foreach(DataRow item in ds.Tables[0].Rows)
            {
                toReturn.Add(DataConversions.AnimalFromDataRow(item));
            }

            return toReturn;
        }

        public static List<User> ReturnAllUsers()
        {
            string sql = "SELECT* FROM \"USER\"";
            DataSet ds = dsBySql(sql);

            List<User> toReturn = new List<User>();

            foreach (DataRow item in ds.Tables[0].Rows)
            {
                toReturn.Add(DataConversions.userFromDataRow(item));
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

        public static List<Animal> animalNamesByParameter(string species, string breed,string searchName, bool adopted, bool isfixed, bool friendly)
        {
            bool adddedWhere = false;
            string sql = "SELECT * FROM \"ANIMAL\" A INNER JOIN \"SPECIES\" S ON " +
                      "A.\"SPECIES\" = S.\"SID\" INNER JOIN \"BREED\" B ON A.\"BREED\" = " +
                      "B.\"BID\"";

            if (species == null && breed != null)
            {
                sql +=  "WHERE B.\"NAME\" = '" + breed + "'";
                adddedWhere = true;
            }

            else if(breed == null && species != null)
            {
                sql += "WHERE S.\"NAME\" = '" + species +"'";
                adddedWhere = true;
            }

            else if (breed != null && species != null)
            {
               sql += "WHERE S.\"NAME\" = '" + species + "' AND B.\"NAME\" = '" + breed + "'";
                adddedWhere = true;
            }

           //add part for search name
            if (searchName != null && adddedWhere)
            {
                sql += "AND difference(A.\"NAME\" , '" + searchName + "') > 1";
                adddedWhere = true;
            }
            else if (searchName != null && !adddedWhere)
            {
                sql += "WHERE difference(A.\"NAME\" , '" + searchName + "') > 1";
                adddedWhere = true;
            }

            // add part for adopted
            if (adopted && adddedWhere)
            {
                sql += "AND A.\"ADOPTED\" = 'TRUE'";
                adddedWhere = true;
            }
            else if (adopted && !adddedWhere)
            {
                sql += "WHERE A.\"ADOPTED\" = 'TRUE'";
                adddedWhere = true;
            } 
            //add part for friendly
            if (friendly && adddedWhere)
            {
                sql += "AND A.\"FRIENDLY\" = 'TRUE'";
                adddedWhere = true;
            }
            else if (friendly && !adddedWhere)
            {
                sql += "WHERE A.\"FRIENDLY\" = 'TRUE'";
                adddedWhere = true;
            } 

            // add part for fixed
            if (isfixed && adddedWhere)
            {
                sql += "AND A.\"FIXED\" = 'TRUE'";
                adddedWhere = true;
            }
            else if (isfixed && !adddedWhere)
            {
                sql += "WHERE A.\"FIXED\" = 'TRUE'";
                adddedWhere = true;
            } 



            DataSet ds = dsBySql(sql);

            List<Animal> toReturn = new List<Animal>();

            foreach(DataRow item in ds.Tables[0].Rows)
            {
                toReturn.Add(new Animal
                    {
                        aid = Int32.Parse(item["AID"].ToString()),
                        name = item["NAME"].ToString(),
                        isAdopted = (bool)item["ADOPTED"],
                        age = (int)item["AGE"],
                        breed = (int)item["BREED"],
                        color = (int)item["COLOR"],
                        description = item["DESCRIPTION"].ToString(),
                        friendly = (bool)item["FRIENDLY"],
                        imgid = (int)item["IMG_ID"],
                        isFixed = (bool)item["FIXED"],
                        location = (int)item["LOCATION"],
                        microchip = item["MICROCHIP"].ToString(),
                        sex = item["SEX"].ToString(),
                        size = item["SIZE"].ToString(),
                        species = (int)item["SPECIES"]

                    });
            }

            return toReturn;
        }

        public static ImageHandler imageByAid(int aid)
        {
            string sql = "SELECT IMG.\"IMAGE_URL\", IMG.\"IMAGE_ID\" FROM \"ANIMAL\" A "+
                          "INNER JOIN \"IMAGE\" I ON A.\"IMG_ID\" = I.\"IMAGE_ID\" "+
                          "INNER JOIN \"IMGUR_RESOURCE\" IMG ON I.\"IMGUR_ID\" = IMG.\"IMAGE_ID\" "+
                          "WHERE A.\"AID\" = "+aid;
            DataSet ds = dsBySql(sql);

            ImageHandler toReturn = new ImageHandler();

            foreach( DataRow item in ds.Tables[0].Rows)
            {
                toReturn = new ImageHandler
                {
                    imageId = Int32.Parse(item["IMAGE_ID"].ToString()),
                    local = false,
                    path = item["IMAGE_URL"].ToString()
                };
            }

            return toReturn;
        }

        public static List<ImageHandler> returnAllImages()
        {
            string sql = "SELECT IMG.\"IMAGE_URL\", I.\"IMAGE_ID\" FROM \"ANIMAL\" A " +
                          "INNER JOIN \"IMAGE\" I ON A.\"IMG_ID\" = I.\"IMAGE_ID\" " +
                          "INNER JOIN \"IMGUR_RESOURCE\" IMG ON I.\"IMGUR_ID\" = IMG.\"IMAGE_ID\"";

            DataSet ds = dsBySql(sql);

            List<ImageHandler> toReturn = new List<ImageHandler>();

            foreach(DataRow row in ds.Tables[0].Rows)
            {
                toReturn.Add(new ImageHandler
                    {
                        imageId = Int32.Parse(row["IMAGE_ID"].ToString()),
                        path = row["IMAGE_URL"].ToString()
                    });
            }

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
            int color = animal.color;
            string name = animal.name != null ? animal.name : "NOT PROVIDED";
            bool friendly = animal.friendly != null? animal.friendly : false;
            string description = animal.description != null? animal.description : "NOT PROVIDED";
            string microchip = "N/A";
            bool isFixed = animal.isFixed != null?animal.isFixed:false;
            int location = animal.location;
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
        /// Removes an user from the database
        /// </summary>
        public static void romoveUserById(int uid)
        {
            string sqlRemoval = "DELETE FROM \"USER\" WHERE \"UID\" =" + uid;
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

        public static int returnAddressIndexQuery(string city, int zip, string street, string state)
        {
            string sql = "SELECT \"ADDRESS_ID\" FROM \"ADDRESS\" WHERE \"STREET\" = '" + street + "' AND \"ZIP\" = '" 
                    + zip + "'AND \"CITY\" = '" + city + "' AND \"STATE\" = '" + state+ "'";

            DataSet ds = dsBySql(sql);

            List<int> returnList = new List<int>();

            foreach (DataRow item in ds.Tables[0].Rows)
            {
                returnList.Add(Int32.Parse(item["ADDRESS_ID"].ToString().Trim()));
            }

            //if that address exists
            if (returnList.Count == 1)
            {
                return returnList[0];
            }
            //make a new address and return the index
            else
            {
                string insretSql = "INSERT INTO \"ADDRESS\" (\"STREET\", \"ZIP\", \"CITY\", \"STATE\") VALUES"+
                    " ('" + street + "','" + zip + "','" + city + "','" + state + "')";
                dsBySql(insretSql);

                ds = dsBySql(sql);

                returnList.Clear();

                foreach (DataRow item in ds.Tables[0].Rows)
                {
                    returnList.Add(Int32.Parse(item["ADDRESS_ID"].ToString().Trim()));
                }

                return returnList[0];
            }
        }

        public static int returnSpeciesIdByName(string name)
        {
            string sql = "SELECT \"SID\" FROM \"SPECIES\" WHERE \"NAME\" = '" + name + "'";
            DataSet ds = dsBySql(sql);

            int toReturn = 0;

            foreach(DataRow row in ds.Tables[0].Rows)
            {
                toReturn = Int32.Parse(row["SID"].ToString());
            }

            return toReturn;
        }

        /// <summary>
        /// Add a new breed to the database.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="speciesId"></param>
        public static void addBreed(string name, int speciesId)
        {
            string sql = "INSERT INTO \"BREED\" (\"SPECIES\", \"NAME\") VALUES ("+speciesId+",'"+name+"')";
            dsBySql(sql);
        }

        /// <summary>
        /// Returns an animal's address as a string array
        /// </summary>
        /// <param name="address">int animal location</param>
        /// <returns>["street","city","state","zip"]</returns>
        public static string[] returnAnimalAddress(int address)
        {
            string sql = "SELECT adr.\"CITY\", adr.\"STREET\", adr.\"STATE\", adr.\"ZIP\" FROM \"ANIMAL\" AS a INNER JOIN \"ADDRESS\" AS adr ON a.\"LOCATION\" = adr.\"ADDRESS_ID\" WHERE a.\"LOCATION\" =" + address;
            DataSet ds = dsBySql(sql);
            List<string> toReturn = new List<string>();
            try
            {
                toReturn.Add(ds.Tables[0].Rows[0]["CITY"].ToString().Trim().ToUpper());
                toReturn.Add(ds.Tables[0].Rows[0]["STREET"].ToString().Trim().ToUpper());
                toReturn.Add(ds.Tables[0].Rows[0]["STATE"].ToString().Trim().ToUpper());
                toReturn.Add(ds.Tables[0].Rows[0]["ZIP"].ToString().Trim().ToUpper());
            }
            catch
            {
                //Something bad
                for (int i = 0; i < 4; i++)
                {
                    toReturn.Add("");
                }
            }
            return toReturn.ToArray();

        }
        /// <summary>
        /// Query is to return the animal's attributes that relate to what type animal the animal is.  
        /// </summary>
        /// <param name="breed"></param>
        /// <returns>Animal's breed, species, and color </returns>
        public static string[] returnAnimalMISC(int breed)
        {
            string sql = "SELECT b.\"NAME\" AS BREED, s.\"NAME\" AS SPECIES, c.\"NAME\" AS COLOR FROM \"ANIMAL\" a INNER JOIN \"BREED\" b ON a.\"BREED\" = b.\"BID\" INNER JOIN \"SPECIES\" s ON s.\"SID\" = b.\"SPECIES\" INNER JOIN \"COLOR\" c on c.\"COLOR_ID\" = a.\"COLOR\" WHERE \"BREED\" =" + breed;
            DataSet ds = dsBySql(sql);
            List<string> toReturn = new List<string>();
            try
            {
                toReturn.Add(ds.Tables[0].Rows[0]["BREED"].ToString().Trim().ToUpper());
                toReturn.Add(ds.Tables[0].Rows[0]["SPECIES"].ToString().Trim().ToUpper());
                toReturn.Add(ds.Tables[0].Rows[0]["COLOR"].ToString().Trim().ToUpper());
            }
            catch 
            {
                for (int i = 0; i < 3; i++)
                {
                    toReturn.Add("NA");
                }
            }

            return toReturn.ToArray(); ;
        }
        /// <summary>
        /// Query will keep track of which user has adopted which pet by inserting the ids into a adopted_checkout table
        /// </summary>
        /// <param name="userID"></param>
        /// <param name="animalID">UserID, PersonID, AnimalID</param>
        public static void adoptedCheckInformation(int userID, int animalID)
        {
            string sql = "INSERT INTO \"ADOPTED_CHECKOUT\"(\"PID\", \"AID\", \"UID\") SELECT p.\"PID\", a.\"AID\", u.\"UID\" FROM \"PERSON\" AS p, \"ANIMAL\" AS a, \"USER\" AS u WHERE a.\"AID\" =" + animalID + " and u.\"UID\" =" + userID + " and p.\"USER_ID\" = u.\"UID\"";
            dsBySql(sql);
        }

        public static int adoptedPersonID(int userID)
        {
            int personID = 0;
            string sql = "SELECT DISTINCT p.\"PID\" "+
                            "FROM \"PERSON\" AS p "+
                            "WHERE p.\"USER_ID\" = " + userID;
            DataSet ds = dsBySql(sql);
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                try
                {
                    personID = Int32.Parse(row["PID"].ToString());
                }
                catch
                {
                    personID = 0;
                }
            }
            return personID;
        }
        /// <summary>
        /// Query return the attributes of a customer
        /// </summary>
        /// <param name="personID"></param>
        /// <returns>Name,Email,DoB,User_ID,Has_Adopted,Num_Pets,StreetAddress,CityAddress,StateAddress,CityAddress</returns>
        public static Customer customerInformation(int personID)
        {
            string sql = "SELECT p.\"NAME\", p.\"EMAIL\", p.\"DOB\", p.\"USER_ID\", c.\"HAS_ADOPTED\", c.\"NUM_PETS\", a.\"STREET\", a.\"CITY\", a.\"STATE\", a.\"ZIP\""+
                "FROM \"CUSTOMER\" c INNER JOIN \"PERSON\" p ON c.\"CID\" = p.\"CID\" INNER JOIN \"ADDRESS\" a ON p.\"ADDRESS\" = a.\"ADDRESS_ID\"" +
                "WHERE p.\"PID\" =" + personID;

            DataSet ds = dsBySql(sql);

            Customer toReturn = new Customer();
            foreach(DataRow item in ds.Tables[0].Rows)
            {
	            
		            toReturn.name = item["NAME"].ToString().ToUpper();
		            toReturn. email = item["EMAIL"].ToString().ToUpper();
		            toReturn.dob = item["DOB"].ToString().ToUpper();
		            //toReturn.address = (int)item["ADDRESS"];
		            toReturn.user_id = (int)item["USER_ID"];
		            toReturn.has_adopted = (bool)item["HAS_ADOPTED"];
		            toReturn.num_pets = (int)item["NUM_PETS"];
                    toReturn.street = item["STREET"].ToString().ToUpper();
                    toReturn.city = item["CITY"].ToString().ToUpper();
                    toReturn.state = item["STATE"].ToString().ToUpper();
                    toReturn.zip = (int)item["ZIP"];
	           
            }
            return toReturn;
            }
        public static string[] adoptedCheckout_AnimalQuery(bool isAdopted, int animalID)
        {
            string sql = " SELECT * " +
                          " FROM \"ADOPTED_CHECKOUT\" AS ac INNER JOIN \"ANIMAL\" AS a ON ac.\"AID\" = a.\"AID\" " +
                          " WHERE a.\"ADOPTED\" = " + isAdopted + " AND ac.\"AID\" =" + animalID; 

             DataSet ds = dsBySql(sql);
             List<string> toReturn = new List<string>();
             try
             {                                                                                  //index
                 toReturn.Add(ds.Tables[0].Rows[0]["AID"].ToString());                          //0
                 toReturn.Add(ds.Tables[0].Rows[0]["AGE"].ToString());                          //1
                 toReturn.Add(ds.Tables[0].Rows[0]["SEX"].ToString().Trim().ToUpper());         //2
                 toReturn.Add(ds.Tables[0].Rows[0]["SIZE"].ToString().Trim().ToUpper());        //3
                 toReturn.Add(ds.Tables[0].Rows[0]["COLOR"].ToString());                        //4
                 toReturn.Add(ds.Tables[0].Rows[0]["NAME"].ToString().Trim().ToUpper());        //5
                 toReturn.Add(ds.Tables[0].Rows[0]["FRIENDLY"].ToString());                     //6
                 //toReturn.Add(ds.Tables[0].Rows[0]["WEIGHT"].ToString());                       //7 No, weight attribute in animal's table
                 toReturn.Add(ds.Tables[0].Rows[0]["DESCRIPTION"].ToString().Trim().ToUpper()); //8
                 toReturn.Add(ds.Tables[0].Rows[0]["VACCINES"].ToString());                     //9
                 toReturn.Add(ds.Tables[0].Rows[0]["MICROCHIP"].ToString().Trim().ToUpper());   //10
                 toReturn.Add(ds.Tables[0].Rows[0]["LOCATION"].ToString());                     //11
                 toReturn.Add(ds.Tables[0].Rows[0]["IMG_ID"].ToString());                       //12
                 toReturn.Add(ds.Tables[0].Rows[0]["SPECIES"].ToString());                      //13
                 toReturn.Add(ds.Tables[0].Rows[0]["BREED"].ToString());                        //14
                 toReturn.Add(ds.Tables[0].Rows[0]["FIXED"].ToString());                        //15
                 toReturn.Add(ds.Tables[0].Rows[0]["ADOPTED"].ToString());                      //16                 
             }
             catch
             {
                 for (int i = 0; i < 15; i++)
                 {
                     toReturn.Add("NA");
                 }
             }

             return toReturn.ToArray();
        }
        public static void adoptedCheckout_RemoveRow(int animalID)
        {
            string sql = "DELETE FROM \"ADOPTED_CHECKOUT\" WHERE \"UID\" = " + Global.publicUser.userId + "AND \"AID\" =" + animalID;
            DataSet ds = dsBySql(sql);

        }
        public static void adoptedCheckout_UpdatePet(int animalID)
        {
            string sql =    "UPDATE \"ANIMAL\" AS a " +
                            "SET \"ADOPTED\" = 'true' " +
                            "FROM \"ADOPTED_CHECKOUT\" AS ac " +
                            "WHERE ac.\"UID\" =" + Global.publicUser.userId + "AND ac.\"AID\" = " + animalID + "AND a.\"AID\" = ac.\"AID\"";
            DataSet ds = dsBySql(sql);
        }

        public static void adoptedCheckout_UpdateWithAIDUID(int aid)
        {
            string sql = "INSERT INTO \"ADOPTED_CHECKOUT\" (\"AID\", \"UID\") VALUES("+aid+","+Global.publicUser.userId+")";
            dsBySql(sql);
        }
        public static string[] isAdopted(int animalID)
        {
            string sql = "SELECT a.\"ADOPTED\" " +
                            "FROM \"ANIMAL\" AS a " +
                            "WHERE a.\"AID\" = " + animalID;
            DataSet ds = dsBySql(sql);
            List<string> toReturn = new List<string>();
            toReturn.Add(ds.Tables[0].Rows[0]["ADOPTED"].ToString());
            return toReturn.ToArray();
        }

        /// <summary>
        /// Returns an animal based on AID.
        /// </summary>
        /// <param name="aid"></param>
        /// <returns></returns>
        public static Animal getAnimalByAid(int aid)
        {
            string sql = "SELECT * FROM \"ANIMAL\" WHERE \"AID\" = " + aid;

            DataSet ds = dsBySql(sql);

            try
            {
                return DataConversions.AnimalFromDataRow(ds.Tables[0].Rows[0]);
            }
            catch
            {
                return null;
            }
        }

        }
    }