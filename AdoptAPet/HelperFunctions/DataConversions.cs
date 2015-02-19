using AdoptAPet.HelperClasses;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoptAPet.HelperFunctions
{
    static class DataConversions
    {

        public static Animal AnimalFromDataRow(DataRow row)
        {
            Animal returnAnimal = new Animal();

            returnAnimal.age = Int32.Parse(row["AGE"].ToString().Trim());
            returnAnimal.sex = row["SEX"].ToString().Trim();
            returnAnimal.color = Int32.Parse(row["COLOR"].ToString().Trim());
            returnAnimal.name = row["NAME"].ToString().Trim();
            returnAnimal.friendly = row["FRIENDLY"].ToString().Trim() == "TRUE" ? true : false;
            returnAnimal.description = row["DESCRIPTION"].ToString().Trim();
            returnAnimal.microchip = row["MICROCHIP"].ToString().Trim();
            returnAnimal.isFixed = row["FIXED"].ToString().Trim() == "TRUE" ? true : false;
            returnAnimal.location = Int32.Parse(row["LOCATION"].ToString().Trim());
            returnAnimal.imgid = Int32.Parse(row["IMG_ID"].ToString().Trim());
            returnAnimal.species= Int32.Parse(row["SPECIES"].ToString().Trim());
            returnAnimal.breed = Int32.Parse(row["BREED"].ToString().Trim());
            returnAnimal.aid = Int32.Parse(row["AID"].ToString().Trim());
            returnAnimal.isAdopted = row["ADOPTED"].ToString().Trim() == "TRUE" ? true : false;
            return returnAnimal;
        }

    }
}
