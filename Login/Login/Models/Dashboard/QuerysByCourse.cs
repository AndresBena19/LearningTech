using System;
using System.Collections.Generic;
using Login.Models.DataAccess;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;

namespace Login.Models.Dashboard
{
    public class QuerysByCourse
    {

        public Dictionary<string, Dictionary<string, string>> GetQuerysByCourse(string username, string idcourse)
        {

            List<Parametro> parametros = new List<Parametro>();
            parametros.Add(new Parametro() { nombre = "_UserName", valor = username });
            parametros.Add(new Parametro() { nombre = "_idCourse", valor = idcourse });


            Dictionary<string, Dictionary<string, string>> Queries = new Dictionary<string, Dictionary<string, string>>();

            MySqlDataReader reader = ExecuteProcedure.executeStoreProcedure("GetQuerysByCourse", parametros);

            while (reader.Read())
            {
                Dictionary<string, string> DataQueries = new Dictionary<string, string>();
                DataQueries.Add("Owner", reader["UserName"] + "");
                DataQueries.Add("Query", reader["TextQuery"] + "");


                Queries.Add(reader["idQuery"] + "", DataQueries);

            }


            return Queries;


        }

    }
}