using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using StudentDeptApp.Models;

namespace StudentDeptApp.DAL
{
    public class StudentGateway:Gateway
    {
       
        public StudentGateway(): base("StudentConnectionString")
        {


        }

        public bool IsRegExist(string regNo)
        {
            Connection.Open();
            string query = string.Format("SELECT * FROM StudentDept WHERE RegNo=@regno");
            SqlCommand command = new SqlCommand(query, Connection);
            command.Parameters.Add(new SqlParameter("@regno",regNo));
          
            SqlDataReader aReader = command.ExecuteReader();
            bool Hasrow = aReader.HasRows;
            Connection.Close();
            return Hasrow;
        }

        public void Insert(Student aStudent)
        {
            Connection.Open();
            string query = string.Format("INSERT INTO StudentDept VALUES(@NewD_ID,@NewRegNo,@NewName,@NewEmail )");
            SqlCommand command = new SqlCommand(query, Connection);
            command.Parameters.Add(new SqlParameter("@NewD_ID", aStudent.DepartmentCode));

            command.Parameters.Add(new SqlParameter("@NewRegNo", aStudent.RegNo));
            command.Parameters.Add(new SqlParameter("@NewName", aStudent.Name));
            command.Parameters.Add(new SqlParameter("@NewEmail", aStudent.Email));

            SqlDataReader aReader = command.ExecuteReader();
            Connection.Close();
        }

        public List<Student> GetAllStudent(string dept)
        {
            List<Student> newlist = new List<Student>();

            Connection.Open();
            string query = string.Format("SELECT * FROM StudentDept WHERE D_Id=@D_Id");
            SqlCommand command = new SqlCommand(query, Connection);
            command.Parameters.Add(new SqlParameter("@D_Id",dept));
            SqlDataReader aReader = command.ExecuteReader();

            if (aReader.HasRows)
            {
                while (aReader.Read())
                {
                    Student aStudent = new Student();
                    aStudent.DepartmentCode = aReader[0].ToString();
                    aStudent.RegNo = aReader[1].ToString();
                    aStudent.Name = aReader[2].ToString();
                    aStudent.Email = aReader[3].ToString();
                   
                    newlist.Add(aStudent);
                }
            }
            Connection.Close();

            return newlist;
        }

        public Student GetStudentReg(string regNo)
        {
            Connection.Open();
            string query = string.Format("SELECT * FROM StudentDept WHERE RegNo=@regno");
            SqlCommand command = new SqlCommand(query, Connection);
            command.Parameters.Add(new SqlParameter("@regno", regNo));
            Student newStudent = new Student();

            SqlDataReader aReader = command.ExecuteReader();
            if (aReader.HasRows)
            {
                while (aReader.Read())
                {
                    Student aStudent = new Student();
                    aStudent.RegNo = aReader[1].ToString();
                    aStudent.Name = aReader[2].ToString();
                    aStudent.Email = aReader[3].ToString();
                    newStudent = aStudent;
                }
            }
            Connection.Close();

            return newStudent;
        }

        public List<Student> GetAllStudent1()
        {
            List<Student> newlist = new List<Student>();

            Connection.Open();
            string query = string.Format("SELECT * FROM StudentDept ");
            SqlCommand command = new SqlCommand(query, Connection);
            SqlDataReader aReader = command.ExecuteReader();

            if (aReader.HasRows)
            {
                while (aReader.Read())
                {
                    Student aStudent = new Student();
                    aStudent.RegNo = aReader[1].ToString();
                    aStudent.Name = aReader[2].ToString();
                    aStudent.Email = aReader[3].ToString();
                    newlist.Add(aStudent);
                }
            }
            Connection.Close();

            return newlist;
        }

        public Student GetAStudentInfo(string aStudentReg)
        {
            Connection.Open();
            string query = string.Format("SELECT * FROM StudentDept WHERE RegNo=@regno");
            SqlCommand command = new SqlCommand(query, Connection);
            command.Parameters.Add(new SqlParameter("@regno", aStudentReg));
            Student newStudent = new Student();

            SqlDataReader aReader = command.ExecuteReader();
            if (aReader.HasRows)
            {
                while (aReader.Read())
                {
                    Student aStudent = new Student();
                    aStudent.RegNo = aReader[1].ToString();
                    aStudent.Name = aReader[2].ToString();
                    aStudent.Email = aReader[3].ToString();
                    newStudent = aStudent;
                }
            }
            Connection.Close();

            return newStudent;
        }
    }
}