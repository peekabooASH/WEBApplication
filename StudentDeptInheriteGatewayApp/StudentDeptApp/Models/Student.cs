using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentDeptApp.Models
{
    public class Student
    {
        public Student(string regNo, string email, string name,string dept):this()
        {
            RegNo = regNo;
            Email = email;
            Name = name;
            DepartmentCode = dept;
        }

        public Student()
        {
        }

        public string RegNo { set; get; }
        public string Name { set; get; }
        public string  Email { get; set; }
        public string DepartmentCode { get; set; }
    }
}