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

       

        public ActionResult Courses()
        {
            Dictionary<string, Dictionary<string, string>> Courses = new Dictionary<string, Dictionary<string, string>>();


            ModeloFacade facade = new ModeloFacade();

            Courses = facade.GetAllCourses((string)Session["user"]);

            ViewData["Courses"] = Courses;

            return View();
        }


        public ActionResult MyCourses()
        {
            Dictionary<string, Dictionary<string, string>> Courses = new Dictionary<string, Dictionary<string, string>>();


            ModeloFacade facade = new ModeloFacade();

            Courses = facade.GetMyCourses((string)Session["user"]);

            ViewData["Courses"] = Courses;

            return View();
        }


        [HttpPost]
        public ActionResult MakeRegister(string UserName, string FullName, string Password, string Birthday)
        {
            ModeloFacade facade = new ModeloFacade();

        
            try
            {
                facade.SignUp(UserName, FullName, Password, Birthday);
            }catch(Exception e)
            {
                ViewData["message"] = "Something bad happend";
                return View("Register");
            }
            return View("Index");
        }


        [HttpPost]
        public ActionResult MakeLogin(string username, string password)
        {
            ModeloFacade facade = new ModeloFacade();

          
            string answer = null;
            try
            {
                answer= facade.checkLogin(username,password);
            }
            catch (Exception e)
            {
                ViewData["message"] = e.ToString();
                return View("Register");
            }

            if (answer == "ok"){
                Session["user"] = username;
                Session["Userchar"] = username[0];
                Courses();
                return View("Courses");
            }
            else
            {
                ViewData["message"] = answer;

                return View("Login");
            }

            
        }

        [HttpPost]
        public ActionResult AssociateCourse(string idCourse)
        {
            ModeloFacade facade = new ModeloFacade();
            facade.AssociateCourse((string)Session["user"], idCourse);

            MyCourses();
            return View("Courses");
        }


        }
}
