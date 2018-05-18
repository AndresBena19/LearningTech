                

using System;
using System.Collections.Generic;
using Login.Models.Actions;
using Login.Models.Dashboard;

namespace Login.Models
{
    public class ModeloFacade
    {
        public  string checkLogin(string username, string password)
        {
            return new loginSimple().login(username, password);
        }

        public string SignUp(string UserName, string FullName, string Password, string Birthday)
        {
            return new Register().SignUp(UserName,FullName,Password,Birthday);
        }

        public Dictionary<string, Dictionary<string, string>> GetAllCourses(string username)
        {
            return new AllCourses().GetAllCourses(username);
        }

        public Dictionary<string, Dictionary<string, string>> GetMyCourses(string username)
        {
            return new OwnCourses().GetMyCourses(username);
        }

        public void AssociateCourse(string username, string idCourse)
        {
             new UserToCourse().AssociateCourse(username, idCourse);
        }

        public Dictionary<string, Dictionary<string, string>> GetQuerysByCourse(string username, string idCourse)
        {
            return new QuerysByCourse().GetQuerysByCourse(username, idCourse);
        }
        public Dictionary<string, Dictionary<string, string>> GetMyQuerysByCourse(string username, string idCourse)
        {
            return new MyQueryByCourse().GetMyQuerysByCourse(username, idCourse);
        }


        public Dictionary<string, Dictionary<string, string>> GetAnswerToQuery(string idQuery)
        {
            return new AnswersToQuery().GetAnswersToQuery(idQuery);
        }


        public string MakeAnswer(string username, string usercomment, string idQuery)
        {
            return new AnswerQuery().MakeAnswer(username, usercomment, idQuery);
        }

        public string MakePostUser(string username, string usercomment, string idCourse)
        {
            return new SendPost().MakePostdb(username, usercomment, idCourse);
        }

    }
    }
