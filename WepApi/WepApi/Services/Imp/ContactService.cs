using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WepApi.Data;
using WepApi.Models;

namespace WepApi.Services
{
    public class ContactService : IContactService
    {
        private readonly ApplicationDbContext dbContext;
        public ContactService(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void DeleteContact(int id)
        {
            var contactDeatil = dbContext.Contacts.FirstOrDefault(x => x.ID == id);
            if (contactDeatil != null)
            {
                dbContext.Contacts.Remove(contactDeatil);
                dbContext.SaveChanges();
            }
        }

        public ContactModel GetContact(int id)
        {
            ContactModel contact = new ContactModel();
            var contactDeatil = dbContext.Contacts.FirstOrDefault(x => x.ID == id);
            if (contactDeatil != null)
            {
                contact.ID = contactDeatil.ID;
                contact.FirstName = contactDeatil.FirstName;
                contact.LastName = contactDeatil.LastName;
                contact.Email = contactDeatil.Email;
                contact.Phone = contactDeatil.Phone;
                contact.CountryId = contactDeatil.CountryId;
                contact.StateId = contactDeatil.StateId;

            }
            return contact;
        }

        public IEnumerable<ContactModel> GetData()
        {
            //ApplicationDbContext db = new ApplicationDbContext();
            var contactData = dbContext.Contacts.ToList().Select(x => new
            {
                FirstName=x.FirstName,
                LastName=x.LastName,
                Email = x.Email,
                Phone=x.Phone,
                State=x.StateId,
                Country=x.CountryId,
                ID=x.ID
            }).Select(x => new ContactModel()
            {
                FirstName = x.FirstName,
                LastName = x.LastName,
                Email = x.Email,
                Phone = x.Phone,
                State = GetStateName(x.State),
                Country = GetCountry(x.Country),
                ID = x.ID

            }).OrderBy(x => x.FirstName).ToList();
          //  var contactData=  dbContext.ExpoHead.ToList();
            return contactData;
        }



        private string GetCountry(int countryId)
        {
            return dbContext.Countries.FirstOrDefault(x => x.ID == countryId).Name;
        }

        private string GetStateName(int stateId)
        {
            return dbContext.States.FirstOrDefault(x => x.ID == stateId).Name;
        }

        public void SaveContact(ContactModel contactModel)
        {
            Contact contactDeatil = new Contact();
            
            contactDeatil.FirstName = contactModel.FirstName;
            contactDeatil.LastName = contactModel.LastName;
            contactDeatil.Email = contactModel.Email;
            contactDeatil.Phone = contactModel.Phone;
            contactDeatil.StateId = contactModel.StateId;
            contactDeatil.CountryId = contactModel.CountryId;

            dbContext.Contacts.Add(contactDeatil);
            dbContext.SaveChanges();
        }

        public void UpdateContact(ContactModel contactModel, int id)
        {
            var contactDeatil = dbContext.Contacts.FirstOrDefault(x => x.ID == id);
           
            contactDeatil.FirstName = contactModel.FirstName;
            contactDeatil.LastName = contactModel.LastName;
            contactDeatil.Email = contactModel.Email;
            contactDeatil.Phone = contactModel.Phone;
            contactDeatil.StateId = contactModel.StateId;
            contactDeatil.CountryId = contactModel.CountryId;
            dbContext.SaveChanges();
        }

        public IEnumerable<DropDownListModel> GetAllCountries()
        {
            var lstCountries = dbContext.Countries.ToList().Select(x => new
            {
                ID = x.ID,
                Name = x.Name
            }).Select(x => new DropDownListModel()
            {
                ID = x.ID,
                Name = x.Name
            }).OrderBy(x => x.Name).ToList();

            return lstCountries;
        }

        public IEnumerable<DropDownListModel> GeStates(int id)
        {
            var lstStates = dbContext.States.Where(x => x.CountryId == id).ToList().Select(x => new
            {
                ID = x.ID,
                Name = x.Name
            }).Select(x => new DropDownListModel()
            {
                ID = x.ID,
                Name = x.Name
            }).OrderBy(x => x.Name).ToList();

            return lstStates;
        }
    }

}
