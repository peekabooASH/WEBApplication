using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using StudentDeptApp.BLL;
using StudentDeptApp.Models;

namespace StudentDeptApp.UI
{
    public partial class StudentEntryUI : System.Web.UI.Page
    {
        DepartmentManager aDepartmentManager=new DepartmentManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                List<Department> departments = aDepartmentManager.GetAllDepartment();

                departmentDropDownList.DataSource = departments;
                departmentDropDownList.DataTextField = "Code";
                // regshowDropDownList.DataValueField = "Name";
                departmentDropDownList.DataBind();

            }
        }

        protected void saveButton_Click(object sender, EventArgs e)
        {
            var dept = departmentDropDownList.SelectedItem.Text;
            StudentManager aStudentManager=new StudentManager();
            Student aStudent=new Student(regTextBox.Text,nameTextBox.Text,emailTextBox.Text,dept);
            string msg = aStudentManager.Insert(aStudent);
            msglebel.Text = msg;
        }
    }
}