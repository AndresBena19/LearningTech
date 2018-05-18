using System;
using System.Collections.Generic;
using Login.Models.DataAccess;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;

namespace Login.Models.Dashboard
{
    public class AnswersToQuery
    {

        public Dictionary<string, Dictionary<string, string>> GetAnswersToQuery(string idQuery)
        {

            List<Parametro> parametros = new List<Parametro>();
            parametros.Add(new Parametro() { nombre = "_idQuery", valor = idQuery });



            Dictionary<string, Dictionary<string, string>> Answers = new Dictionary<string, Dictionary<string, string>>();

            MySqlDataReader reader = ExecuteProcedure.executeStoreProcedure("GetAnswersToQuery", parametros);

            while (reader.Read())
            {
                Dictionary<string, string> DataQueries = new Dictionary<string, string>();
                DataQueries.Add("Answer", reader["Answer"] + "");
                DataQueries.Add("UserName", reader["UserName"] + "");



                Answers.Add(reader["idAnswer"] + "", DataQueries);

            }


            return Answers;


        }
    }
}