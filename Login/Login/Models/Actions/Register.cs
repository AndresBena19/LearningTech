
using System;
using System.Collections.Generic;
using Login.Models.DataAccess;
using MySql.Data.MySqlClient;

namespace Login.Models.Actions
{
    public class Register
    {

        public string SignUp(string UserName, string FullName, string Password, string Birthday)
        {

            List<Parametro> parametros = new List<Parametro>();
            parametros.Add(new Parametro() { nombre = "_UserName", valor = UserName});
            parametros.Add(new Parametro() { nombre = "_FullName", valor = FullName });
            parametros.Add(new Parametro() { nombre = "_Password", valor = Password });
            parametros.Add(new Parametro() { nombre = "_Birthdate", valor = Birthday });



            try
            {
                MySqlDataReader reader = ExecuteProcedure.executeStoreProcedure("CreateUser", parametros);

            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e);
                return e.ToString();
            }

            return "All Good";


        }
    }
}