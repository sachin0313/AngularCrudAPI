using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WepApi.Services;
using WepApi.Models;
using WepApi.Data;

namespace WepApi.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        private readonly IContactService contactService;
        public ValuesController(IContactService contactService)
        {
            this.contactService = contactService;
        }
        // GET api/values
        [HttpGet("getContacts")]
        public IEnumerable<ContactModel> Get()
        {
            return contactService.GetData();
            //return new string[] { "sachin", "madhu","anji","hemu","tester" };
        }

       // GET api/values/5
        [HttpGet("contact/{id}")]
        public ContactModel Get(int id)
        {
            return contactService.GetContact(id);
        }

        // POST api/values
        [HttpPost("register")]
        public void Register([FromBody]ContactModel model)
        {
            contactService.SaveContact(model);
        }

        // PUT api/values/5
        [HttpPut("update/{id}")]
        public void Put(int id, [FromBody]ContactModel model)
        {
            contactService.UpdateContact(model, id);
        }

        // DELETE api/values/5
        [HttpDelete("delete/{id}")]
        public void Delete(int id)
        {
            contactService.DeleteContact(id);

        }


        [HttpGet("getCountries")]
        public IEnumerable<DropDownListModel> GetCountries()
        {
            return contactService.GetAllCountries();
        }

        [HttpGet("getStates/{id}")]
        public IEnumerable<DropDownListModel> GeStates(int id)
        {
            return contactService.GeStates(id);
        }




    }
}
