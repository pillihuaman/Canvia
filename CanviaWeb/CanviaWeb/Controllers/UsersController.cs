using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using System.Threading.Tasks;
using CanviaWeb.Business.Interface;
using System.Configuration;
using Newtonsoft.Json;
using CanviaWeb.Models;
using CanviaWeb.Template;
using System.Text;

namespace CanviaWeb.Controllers
{
    public class UsersController : Controller
    {
     
        // GET: Users

        public async Task<ActionResult> RegisterUser()
        {
            //cal to api Canvia and load User Information
            var httpcliente = new HttpClient();
            var userjson = await httpcliente.GetStringAsync(ConfigurationManager.AppSettings["ApiCanviaUrl"]+ "/api/Users/GetUser");
            var result = JsonConvert.DeserializeObject<UserModel[]>(userjson);
            var TemplateTable = Templete.getTable(result.ToList());
            ViewBag.listUsers = TemplateTable;
            return View();
        }
        [HttpPost]
        public async Task<ActionResult> RegisterUserPost( UserModel model)
        {
            //cal to api Canvia and load User Information
            var json = JsonConvert.SerializeObject(model);
            var httpcliente = new HttpClient();
            var stringContent = new StringContent(json, UnicodeEncoding.UTF8, "application/json"); // 
            var client = new HttpClient();
            var userjson = await httpcliente.PostAsync(ConfigurationManager.AppSettings["ApiCanviaUrl"] + "/api/Users/SaveUser", stringContent);
      
             return Json(userjson);
        }
    }
}