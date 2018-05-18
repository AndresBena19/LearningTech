using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Login.Models;

namespace Login.Controllers
{
    public class DashboardController : Controller
    {
        public ActionResult Post(string Query,string owner, string idQuery)
        {
            Dictionary<string, Dictionary<string, string>> Answers = new Dictionary<string, Dictionary<string, string>>();

            ModeloFacade facade = new ModeloFacade();

            Answers = facade.GetAnswerToQuery(idQuery);

            ViewData["Answers"] = Answers;
            ViewData["Query"] = Query;
            ViewData["Owner"] = owner;

            Session["Owner"] = owner;



            Session["idQuery"] = idQuery;

            return View();
        }

        public ActionResult Dashboard(string idCourse)
        {
            Session["ActualCourse"] = idCourse;
            AllQuerysByCourse();
            return View("AllQuerysByCourse");
        }

        public ActionResult AllQuerysByCourse()
        {
            Dictionary<string, Dictionary<string, string>> Queries = new Dictionary<string, Dictionary<string, string>>();


            ModeloFacade facade = new ModeloFacade();

            Queries = facade.GetQuerysByCourse((string)Session["user"], (string)Session["ActualCourse"]);

            ViewData["Queries"] = Queries;


            return View();
        }


        [HttpPost]
        public ActionResult MakePost(string Query)
        {
            ModeloFacade facade = new ModeloFacade();
            string value = null;
            value = facade.MakePostUser((string)Session["user"], Query, (string)Session["ActualCourse"]);

            ViewData["R"]= value;
            AllQuerysByCourse();
            return View("AllQuerysByCourse");
            
        }


        public ActionResult AllMyQuerysByCourse()
        {
            Dictionary<string, Dictionary<string, string>> MyQueries = new Dictionary<string, Dictionary<string, string>>();


            ModeloFacade facade = new ModeloFacade();

            MyQueries = facade.GetMyQuerysByCourse((string)Session["user"], (string)Session["ActualCourse"]);

            ViewData["Queries"] = MyQueries;


            return View();
        }




        public ActionResult MakeAnswer( string usercomment)
        {
            
            ModeloFacade facade = new ModeloFacade();

            facade.MakeAnswer((string)Session["user"], usercomment, (string)Session["idQuery"]);

            Post((string)ViewData["Query"], (string)Session["Owner"],(string)Session["idQuery"]);
            return View("Post");
        }
        
    }
}
