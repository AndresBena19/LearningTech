using System;
namespace Login.Models
{
    public class loginSimple
    {
        public bool login(string username, string password){
                if (username== "ibanos" && password =="123"){
                    return true;

                }
                else {
                    return false;
                }
            }

        
        }
    }

