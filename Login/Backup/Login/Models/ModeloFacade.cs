using System;
namespace Login.Models
{
    public class ModeloFacade
    {
        public  bool checkLogin(string username, string password){
                return new loginSimple().login(username, password);
            }
        }
    }
