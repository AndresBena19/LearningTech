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
            parametros.Add(new Parametro() { nombre = "_pasword", valor = password });
            parametros.Add(new Parametro() { nombre = "mensaje", valor = "" });


            MySqlDataReader reader = ExecuteProcedure.executeStoreProcedure("Login", parametros);
            reader.Read();

            return (string)reader["mensaje"];
            

        }
    }
}
