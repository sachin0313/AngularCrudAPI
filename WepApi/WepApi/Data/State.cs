using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WepApi.Data
{
    public class State
    {
        //public State()
        //{
        //    this.Contacts = new HashSet<Contact>();
        //}
        [Key]
        public int ID { get; set; }

        public string Name { get; set; }

        public int CountryId { get; set; }

        public Country Country { get; set; }

        public virtual ICollection<Contact> Contacts { get; set; }

    }
}
