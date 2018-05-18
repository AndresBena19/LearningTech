using System;
using System.Collections.Generic;
using Login.Models.DataAccess;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;


namespace Login.Models.Dashboard
{
    public class MyQueryByCourse
    {
        public Dictionary<string, Dictionary<string, string>> GetMyQuerysByCourse(string username, string idcourse)
        {

            List<Parametro> parametros = new List<Parametro>();
            parametros.Add(new Parametro() { nombre = "_UserName", valor = username });
            parametros.Add(new Parametro() { nombre = "_idCourse", valor = idcourse });


            Dictionary<string, Dictionary<string, string>> MyQueries = new Dictionary<string, Dictionary<string, string>>();

            MySqlDataReader reader = ExecuteProcedure.executeStoreProcedure("GetMyQuerysByCourse", parametros);

            while (reader.Read())
            {
                Dictionary<string, string> DataQueries = new Dictionary<string, string>();
                DataQueries.Add("Owner", reader["UserName"] + "");
                DataQueries.Add("Query", reader["TextQuery"] + "");


                MyQueries.Add(reader["idQuery"] + "", DataQueries);

            }


            return MyQueries;


        }
    }
}