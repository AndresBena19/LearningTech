using System;
using System.Collections.Generic;
using Login.Models.DataAccess;
using MySql.Data.MySqlClient;
using Login.Models.Dashboard;

namespace Login.Models.Dashboard
{
    public class SendPost
    {
        public string MakePostdb(string username, string usercomment, string idCourse)
        {

            List<Parametro> parametros = new List<Parametro>();
            parametros.Add(new Parametro() { nombre = "_idCourse", valor = idCourse });
            parametros.Add(new Parametro() { nombre = "_UserName", valor = username });
            parametros.Add(new Parametro() { nombre = "_TextQuery", valor = usercomment });


            string Value = null;
            try
            {
                MySqlDataReader reader = ExecuteProcedure.executeStoreProcedure("CreateQuery", parametros);
            }
            catch (Exception)
            {
                Value = "Something bad";
            }



            return Value = "All GOOD";


        }
    }
}