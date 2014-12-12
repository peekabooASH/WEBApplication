using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using StudentManagementApp_WebForm.Models;

namespace StudentManagementApp_WebForm.DAL
{
    public class DeparmentGateway:Gateway
    {
        public DeparmentGateway(): base("StudentConnectionString")
        {
        }

        public int Insert(Department aDepartment)
        {
            var query = @"INSERT INTO Department VALUES('" + aDepartment.Dept_Code + "','" + aDepartment.dept_Name +"')";

            Command.CommandText = query;

            Connection.Open();
            int rowAffected = Command.ExecuteNonQuery();
            Connection.Close();

            return rowAffected;
        }

        public Department GetDepartment(string deptName)
        {
            Department aDepartment = null;
            var query = "SELECT * FROM Department WHERE Dept_Name = '" + deptName + "'";

            Command.CommandText = query;

            Connection.Open();
            SqlDataReader rdr = Command.ExecuteReader();

            while (rdr.Read())
            {
              aDepartment = new Department();
              aDepartment.Dept_Code = rdr["Dept_Code"].ToString();
              aDepartment.dept_Name = rdr["Dept_Name"].ToString();
                
            }

            rdr.Close();
            Connection.Close();
            return aDepartment;
        }

        public List<Department> GetAllDepartment()
        {

            List<Department> departments = new List<Department>();

            var query = "SELECT * FROM Department";

            Command.CommandText = query;

            Connection.Open();
            SqlDataReader rdr = Command.ExecuteReader();

            while (rdr.Read())
            {
              
              Department  adepartment = new Department();
              adepartment.Dept_Code = rdr["Dept_Code"].ToString();
              adepartment.dept_Name = rdr["Dept_Name"].ToString();

              departments.Add(adepartment);
            }

            rdr.Close();
            Connection.Close();

            return departments; 


        }
    }
}