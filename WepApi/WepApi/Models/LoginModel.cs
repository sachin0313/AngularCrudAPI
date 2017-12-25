using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WepApi.Models
{
    public class LoginModel
    {
        public string username { get; set; }
        public string password { get; set; }
        public string email { get; set; }

        public string role { get; set; }
    }
}
