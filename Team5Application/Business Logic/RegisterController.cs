using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Team5Application.Data_Models;

namespace Team5Application.Business_Logic
{
    public class RegisterController
    {
        public RegistrantUser user { get; set; }
        public Registrant registrant { get; set; }
        public Boolean isParent = false;
        public Boolean hasRegistered = false;

        public Boolean addChild(String firstName, String lastName, int Age)
        {
            if (this.registrant == null)
                return false;
            if (this.registrant.children == null)
                this.registrant.children = new List<Child>();
            this.registrant.children.Add(new Child(firstName, lastName, Age));
            isParent = true;
            return true;
        }

        public Boolean createMainRegistrant (String firstName, String lastName, Registrant.groupType group, String street, String city, 
            String state, String zip, String phonenum)
        {
            this.registrant = new Registrant();

            this.registrant.currentPrice = (int)group;

            this.registrant.firstName = firstName;
            this.registrant.lastName = lastName;
            this.registrant.group = (int)group == 10 ? "Adult" : "Professional";
            this.registrant.street = street;
            this.registrant.city = city;
            this.registrant.state = state;
            this.registrant.zip = zip;
            this.registrant.phone = phonenum;

            return true;
        }

        public Boolean addAdult(String firstName, String lastName, Registrant.groupType group)
        {
            if (this.registrant == null)
                return false;
            if (this.registrant.adults == null)
                this.registrant.adults = new List<Adult>();
            Adult addAdult = new Adult();
            addAdult.firstName = firstName;
            addAdult.lastName = lastName;
            addAdult.lastName = (int)group == 10 ? "Adult" : "Professional";
            return true;
        }

    }
}
