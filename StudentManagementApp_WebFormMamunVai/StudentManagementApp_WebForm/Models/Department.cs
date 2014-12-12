using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentManagementApp_WebForm.Models
{
    public class Department
    {
        public string Dept_Code { get; set; }
        public string dept_Name { get; set; }

         public Department(string name, string code):this()
        {
            dept_Name = name;
            Dept_Code = code;
            
        }

        public Department()
        {
            
        }



    }
}