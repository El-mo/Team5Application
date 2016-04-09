using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team5Application.Data_Models
{
    public class Registrant
    {
        public Registrant()
        {
            this.adults = new List<Adult>();
            this.children = new List<Child>();
        }
        public int registrantID { get; set; }
        public enum groupType
        {
            Child = 0,
            Adult = 10,
            Professional = 100

        }

        public static String[] groups = { "1-3" , "4-5", "6-9", "10-11", "12-15", "under 18", "College", "Adult", "Professional"};
        public static double[] price = { 0, 0, 0, 0, 0, 0, 10, 10, 100 };
        public String firstName { get; set; }
        public String lastName { get; set; }
        public String group { get; set; }
        public String street { get; set; }
        public String city { get; set; }
        public String state { get; set; }
        public String zip { get; set; }
        public String phone { get; set; }
        public String email { get; set; }


        public List<Child> children { get; set; }
        public List<Adult> adults { get; set; }
        public Double currentPrice { get; set; }
        
    }
}
