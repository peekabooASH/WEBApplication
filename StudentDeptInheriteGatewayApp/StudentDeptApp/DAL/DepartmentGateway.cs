using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using StudentDeptApp.Models;

namespace StudentDeptApp.DAL
{
    public class DepartmentGateway:Gateway
    {
        public DepartmentGateway(): base("StudentConnectionString")
        {


        }

        public void Insert(Department aDepartment)
        {
            Connection.Open();
            string query = string.Format("INSERT INTO Department VALUES(@NewCode,@NewTitle )");
            SqlCommand command = new SqlCommand(query, Connection);
            command.Parameters.Add(new SqlParameter("@NewCode", aDepartment.Code));
            command.Parameters.Add(new SqlParameter("@NewTitle", aDepartment.Title));
            SqlDataReader aReader = command.ExecuteReader();
            Connection.Close();
        }

        public bool IsCodeExist(string code)
        {
            Connection.Open();
            string query = string.Format("SELECT * FROM Department WHERE Code=@code");
            SqlCommand command = new SqlCommand(query, Connection);
            command.Parameters.Add(new SqlParameter("@code", code));

            SqlDataReader aReader = command.ExecuteReader();
            bool Hasrow = aReader.HasRows;
            Connection.Close();
            return Hasrow;
        }

        public List<Department> GetAllDepartment()
        {
            List<Department> newlist = new List<Department>();

            Connection.Open();
            string query = string.Format("SELECT * FROM Department");
            SqlCommand command = new SqlCommand(query, Connection);
            SqlDataReader aReader = command.ExecuteReader();

            if (aReader.HasRows)
            {
                while (aReader.Read())
                {
                    Department aDepartment= new Department();
                    aDepartment.Code = aReader[0].ToString();
                    aDepartment.Title= aReader[1].ToString();
                    
                    newlist.Add(aDepartment);
                }
            }
            Connection.Close();

            return newlist;
        }
    }
}