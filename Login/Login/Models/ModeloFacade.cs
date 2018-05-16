                

using System;
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
    }
    }
