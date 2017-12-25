using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WepApi.Data
{
    public class Country
    {
        //public Country()
        //{
        //    this.Contacts = new HashSet<Contact>();
        //    this.States = new HashSet<State>();

        //}
        [Key]
        public int ID { get; set; }

        public string Name { get; set; }

        public virtual ICollection<State> States { get; set; }

        public virtual ICollection<Contact> Contacts { get; set; }


    }
}
