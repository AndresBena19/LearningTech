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
        [HttpPost]
        public ActionResult Login(string username, string password){
            ModeloFacade facade = new ModeloFacade();
            if(facade.checkLogin(username,password)){
                ViewBag.message = "login succesful";

            }else {
                ViewBag.message = "login fail";
            }
            return View("Respuesta");
        }
    }
}
