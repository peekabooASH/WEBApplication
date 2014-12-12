using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;
using StudentDeptApp.DAL;
using StudentDeptApp.Models;

namespace StudentDeptApp.BLL
{
    public class StudentManager
    {
        private StudentGateway aGateway;

        public StudentManager()
        {
            aGateway = new StudentGateway();
        }
          
        public string Insert(Student aStudent)
        {
            if (!IsRegExist(aStudent.RegNo))
            {
                aGateway.Insert(aStudent);
                return "Insert Successfully";
            }
            return "There are some problem .";
        }

        private bool IsRegExist(string regNo)
        {
            bool hasrow = aGateway.IsRegExist(regNo);
            if (hasrow)
            {
                return true;
            }
            return false;
        }

        public List<Student> GetAllStudent(string dept)
        {
            List<Student> students;
            students = aGateway.GetAllStudent(dept);
            return students;

        }

        public Student GetStudentReg(string regNo)
        {
            Student student;
            student = aGateway.GetStudentReg(regNo);
            return student;
        }

        public List<Student> GetAllStudent1()
        {
            List<Student> student;
            student = aGateway.GetAllStudent1();
            return student;
        }


        public Student GetAStudentInfo(string aStudentReg)
        {
            Student student;
            student = aGateway.GetAStudentInfo(aStudentReg);
            return student;
        }
    }
}