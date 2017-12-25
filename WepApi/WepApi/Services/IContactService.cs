using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WepApi.Models;
using WepApi.Data;

namespace WepApi.Services
{
    public interface IContactService
    {
        IEnumerable<ContactModel> GetData();
        void SaveContact(ContactModel contactModel);
        ContactModel GetContact(int id);
        void UpdateContact(ContactModel contactModel, int id);
        void DeleteContact(int id);
        IEnumerable<DropDownListModel> GetAllCountries();
        IEnumerable<DropDownListModel> GeStates(int id);



    }
}
