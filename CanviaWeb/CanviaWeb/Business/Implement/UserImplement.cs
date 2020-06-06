using CanviaWeb.Business.Interface;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace CanviaWeb.Business.Implement
{
    public class UserImplement : IUser
    {
        public string GetUrlApiService(string Entorno)
        {
            string url = string.Empty;
            try
            {
                url = ConfigurationManager.AppSettings["ApiCanviaUrl"];
            }
            catch (Exception ex)
            { throw ex; }

            return url;
        }
    }
}