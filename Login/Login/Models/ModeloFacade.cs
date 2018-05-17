                

using System;
using System.Collections.Generic;
using Login.Models.Actions;

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

    }
    }
