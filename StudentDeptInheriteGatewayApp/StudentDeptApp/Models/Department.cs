using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentDeptApp.Models
{
    public class Department
    {
        public Department(string code, string title):this()
        {
            Code = code;
            Title = title;
        }

        public string Code { get; set; }
        public string Title{ get; set; }

        public Department()
        {
        }
    }
}