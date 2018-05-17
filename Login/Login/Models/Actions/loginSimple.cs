using System;
using System.Collections.Generic;
using Login.Models.DataAccess;
using MySql.Data.MySqlClient;

namespace Login.Models
{
    public class loginSimple
    {
        public string login(string username, string password)
        {

            List<Parametro> parametros = new List<Parametro>();
            parametros.Add(new Parametro() { nombre = "_UserName", valor = username });
            parametros.Add(new Parametro() { nombre = "_Password", valor = password});
            parametros.Add(new Parametro() { nombre = "_message", valor = "" });


            MySqlDataReader reader = ExecuteProcedure.executeStoreProcedure("login", parametros);

            string answer = null;
            while (reader.Read())
            {

                answer = (string)reader["_message"];

            }

            return answer;
            

        }
    }
}
