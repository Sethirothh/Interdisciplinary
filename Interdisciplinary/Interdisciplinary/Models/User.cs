using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Interdisciplinary.Models
{
    public class User
    {
        public int UserID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public string Address { get; set; }

        public int Zip { get; set; }

        public string City { get; set; }

        public User()
        {

        }
        public User(string firstname, string lastname, int age, string address)
        {
            FirstName = firstname;

            LastName = lastname;

            Age = age;

            Address = address;
        }
    }
}
