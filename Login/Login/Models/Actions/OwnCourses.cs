using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Login.Models.DataAccess;
using MySql.Data.MySqlClient;

namespace Login.Models.Actions
{
    public class OwnCourses
    {
        public Dictionary<string, Dictionary<string, string>> GetMyCourses(string username)
        {

            List<Parametro> parametros = new List<Parametro>();
            parametros.Add(new Parametro() { nombre = "_UserName", valor = username });

            Dictionary<string, Dictionary<string, string>> Courses = new Dictionary<string, Dictionary<string, string>>();

            MySqlDataReader reader = ExecuteProcedure.executeStoreProcedure("GetMyCourses", parametros);

            while (reader.Read())
            {
                Dictionary<string, string> DataCourses = new Dictionary<string, string>();
                DataCourses.Add("CourseName", reader["CourseName"] + "");
                DataCourses.Add("Description", reader["CourseDescription"] + "");


                Courses.Add(reader["idCourse"] + "", DataCourses);

            }


            return Courses;


        }

    }
}