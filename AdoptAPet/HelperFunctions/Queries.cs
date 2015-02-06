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

        private static DataSet dsBySql(string sql)
        {
            string connection = String.Format("Server=127.0.0.1;Port=5432;User Id=postgres;Password=stimperman;Database=AdoptAPet");
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
                password = ds.Tables[0].Rows[0]["PASS"].ToString().Trim()
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
            string sql = "SELECT A.\"NAME\", A.\"AID\" FROM \"ANIMAL\" A INNER JOIN \"SPECIES\" S ON "+
                            "A.\"SPECIES\" = S.\"SID\" INNER JOIN \"BREED\" B ON A.\"BREED\" = "+
                            "B.\"BID\" WHERE S.\"NAME\" = '"+species+"' AND B.\"NAME\" = '"+breed+"'";

            DataSet ds = dsBySql(sql);

            List<Animal> toReturn = new List<Animal>();

            foreach(DataRow item in ds.Tables[0].Rows)
            {
                toReturn.Add(new Animal
                    {
                        aid = Int32.Parse(item["AID"].ToString()),
                        name = item["NAME"].ToString()
                    });
            }

            return toReturn;
        }

        public static string imageByAid(int aid)
        {

            string sql = "SELECT I.\"LOCAL_PATH\" FROM \"ANIMAL\" A INNER JOIN \"IMAGE\" I ON A.\"IMG_ID\" = I.\"IMAGE_ID\" WHERE A.\"IMG_ID\" = " + aid;
            DataSet ds = dsBySql(sql);

            string toReturn = "";

            foreach( DataRow item in ds.Tables[0].Rows)
            {
                toReturn = item["LOCAL_PATH"].ToString();
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
    }
}
