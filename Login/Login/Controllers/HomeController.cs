using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Login.Models;

namespace Login.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
        public ActionResult Register()
        {
            return View();
        }


        [HttpPost]
        public ActionResult CheckLogin(string username, string password){
            ModeloFacade facade = new ModeloFacade();
  
            return View(); 
            
        }

        [HttpPost]
        public ActionResult MakeRegister(string UserName, string FullName, string Password, string Birthday)
        {
            ModeloFacade facade = new ModeloFacade();

            string answer;

            answer = facade.SignUp(UserName, FullName, Password, Birthday);

            ViewData["message"] = answer;
            return View("Index");
        }

        
    }
}
