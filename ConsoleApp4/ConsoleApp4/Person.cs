using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Person
    {
        public string firstname;
        public string lastname;
        public string emailaddress;
        public DateTime dob;

        public Person(string fname,string lname,string email)
        {
            this.firstname = fname;
            this.lastname = lname;
            this.emailaddress = email;
        }

        public Person(string fname1,string lname1,DateTime d)
        {
            this.firstname = fname1;
            this.lastname = lname1;
            this.dob = d;
        }

       
    }
}
