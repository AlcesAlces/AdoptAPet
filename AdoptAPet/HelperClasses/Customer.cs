using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoptAPet.HelperClasses
{
    public class Customer
    {
        //public int aid { get; set; }
        //public int age { get; set; }
        //public string sex { get; set; }
        //public string size { get; set; }
        //public int color { get; set; }

        public string name { get; set; }
        public string email { get; set; }
        public string dob { get; set; }
        public int address { get; set; }
        public string street { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public int zip { get; set; }
        public int user_id { get; set; }
        public bool has_adopted { get; set; }
        public int num_pets { get; set; }


    }
}
