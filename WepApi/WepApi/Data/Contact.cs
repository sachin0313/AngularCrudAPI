using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WepApi.Data
{
    public class Contact
    {
        [Key]
        public int ID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public int StateId { get; set; }

        public int CountryId { get; set; }

        public virtual Country Country { get; set; }

        public virtual State State { get; set; }
    }
}
