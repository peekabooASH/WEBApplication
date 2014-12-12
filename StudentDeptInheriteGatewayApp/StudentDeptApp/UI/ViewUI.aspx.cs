using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using StudentDeptApp.BLL;
using StudentDeptApp.Models;

namespace StudentDeptApp.UI
{
    public partial class ViewUI : System.Web.UI.Page
    {
        DepartmentManager aDepartmentManager = new DepartmentManager();
        private List<Student> studentss;
       protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                List<Department> departments = aDepartmentManager.GetAllDepartment();

                deptDropDownList.DataSource = departments;
                deptDropDownList.DataTextField = "Code";
                // regshowDropDownList.DataValueField = "Name";
                deptDropDownList.DataBind();
            }
           ShowStudentStudentView();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
             StudentManager aStudentManager=new StudentManager();
            string dept = deptDropDownList.SelectedItem.Text;
           
            studentss = aStudentManager.GetAllStudent(dept);

            studentDropDownList.DataSource = studentss;
            studentDropDownList.DataTextField = "RegNo";
            studentDropDownList.DataValueField = "Name";
            studentDropDownList.DataBind();
         
          }

      
        protected void Button2_Click(object sender, EventArgs e)
        {
            StudentManager aStudentManager = new StudentManager();
            string dept = deptDropDownList.SelectedItem.Text;

            studentss = aStudentManager.GetAllStudent(dept);
            ShowStudentStudentView();
       }

        private void ShowStudentStudentView()
        {
            GridView1.DataSource = studentss;
            GridView1.DataBind();
            GridView1.Visible = true;
        }

        protected void studentDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {
          
           var aStudentReg= studentDropDownList.SelectedItem.Text;

            StudentManager aStudentManager=new StudentManager();
            Student aStudent=aStudentManager.GetAStudentInfo(aStudentReg);
            shownameTextBox.Text = aStudent.Name;
            showemailTextBox.Text = aStudent.Email;
        }
    }
}