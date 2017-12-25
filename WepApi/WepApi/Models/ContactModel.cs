using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WepApi.Models
{
    public class ContactModel
    {
        public int ID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public string State { get; set; }

        public string Country { get; set; }

        public int StateId { get; set; }

        public int CountryId { get; set; }



    }
}
