using ApiCanvia.Models;
using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ApiCanvia.Controllers
{
    public class ValuesController : ApiController
    {
        [Route("api/Users/GetUser")]
        public HttpResponseMessage Get()
        {
            //Call to BL Users
           var lstUsers= UsersBL.ListAllUser();
            return Request.CreateResponse(HttpStatusCode.OK, lstUsers, Configuration.Formatters.JsonFormatter);
        }
        [Route("api/Users/SaveUser")]
        public HttpResponseMessage Post([FromBody]UserModel value)
        {
            var user = new Users(); 
            user.Email = value.Email;                     
            user.LastName = value.LastName;
            user.Name = value.Name;
            user.Password = value.Password;
    

            var status = UsersBL.InsertUsers(user);
            return  Request.CreateResponse(HttpStatusCode.OK, status, Configuration.Formatters.JsonFormatter);
        }   
    } 
}
