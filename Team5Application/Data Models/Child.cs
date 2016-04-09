using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team5Application.Data_Models
{
    public class Child
    {
        
        public int childID { get; set; }
        public String firstName { get; set; }
        public String lastName { get; set; }
        public int age { get; set; }

        public String group { get; set; }
        public Child(String firstName, String Lastname, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            if (age < 4)
                group = "1-3";
            else if (age < 6)
                group = "4-5";
            else if (age < 10)
                group = "6-9";
            else if (age < 12)
                group = "10-11";
            else if (age < 16)
                group = "12-15";
            else
                group = "under 18";
        }

    }
}
