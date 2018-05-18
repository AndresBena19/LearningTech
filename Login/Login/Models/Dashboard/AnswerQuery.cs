using System;
using System.Collections.Generic;
using Login.Models.DataAccess;
using MySql.Data.MySqlClient;
namespace Login.Models.Dashboard
{
    public class AnswerQuery
    {


        public string MakeAnswer(string username, string usercomment, string idQuery)
        {

            List<Parametro> parametros = new List<Parametro>();
            parametros.Add(new Parametro() { nombre = "_idQuery", valor = idQuery });
            parametros.Add(new Parametro() { nombre = "_UserName", valor = username });
            parametros.Add(new Parametro() { nombre = "_Answer", valor = usercomment });


            string answer = null;
            try
            {
                MySqlDataReader reader = ExecuteProcedure.executeStoreProcedure("AnswerToQuery", parametros);
            }
            catch (Exception)
            {
                answer = "Something bad";
            }
            
           

            return answer="All GOOD";


        }
            
    }
}