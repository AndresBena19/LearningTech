using System;
using System.Collections.Generic;
using Login.Models.DataAccess;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;

namespace Login.Models.Actions
{
    public class UserToCourse
    {

        public void  AssociateCourse(string username, string idCourse)
        {

            List<Parametro> parametros = new List<Parametro>();
            parametros.Add(new Parametro() { nombre = "_UserName", valor = username });
            parametros.Add(new Parametro() { nombre = "_idCourse", valor = idCourse });

            MySqlDataReader reader = ExecuteProcedure.executeStoreProcedure("Associate_to_Course", parametros);

         

        }
    }
}