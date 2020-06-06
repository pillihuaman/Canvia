using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CanviaWeb.Models
{
    public class UserModel
    {
        public String Name
        {
            get;
            set;
        }
        public String LastName
        {
            get;
            set;
        }
        public String UserCode
        {
            get;
            set;
        }
        public string Password
        {
            get;
            set;
        }
        public string Email
        {
            get;
            set;
        }
        public int IdUser
        {
            get;
            set;
        }
        public String IdSystem
        {
            get;
            set;
        }
        public String Status
        {
            get;
            set;
        }
    }
}