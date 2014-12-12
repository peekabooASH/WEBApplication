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
    public partial class StudentView : System.Web.UI.Page
    {
        StudentManager studentManager = new StudentManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                List<Student> students = studentManager.GetAllStudent1();

                regshowDropDownList.DataSource = students;
                regshowDropDownList.DataTextField = "RegNo";
               // regshowDropDownList.DataValueField = "Name";
                regshowDropDownList.DataBind();

            }
        }

        protected void showButton_Click(object sender, EventArgs e)
        {
            var regNo = regshowDropDownList.SelectedItem.Text;

           Student student = studentManager.GetStudentReg(regNo);

           nameshowTextBox.Text = student.Name;
           emailshowTextBox.Text = student.Email;
        }
    }
}