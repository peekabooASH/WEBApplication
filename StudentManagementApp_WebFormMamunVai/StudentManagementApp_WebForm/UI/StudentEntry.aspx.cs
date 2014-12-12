using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using StudentManagementApp_WebForm.BLL;
using StudentManagementApp_WebForm.Models;

namespace StudentManagementApp_WebForm.UI
{
    public partial class StudentEntry : System.Web.UI.Page
    {
        StudentManager studentManager = new StudentManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            msgLabel.Text = "";
        }
        protected void btnSave_OnClick(object sender, EventArgs e)
        {
            try
            {

                var name = txtName.Text;
                var email = txtEmail.Text;
                var regNo = txtRegNo.Text;

                Student student = new Student(name, email, regNo);

                bool isSaved = studentManager.Insert(student);

                if (isSaved)
                {
                    msgLabel.Text = "Saved Successfully!";
                }
                else
                {
                    msgLabel.Text = "Insertion Failed!";
                }

            }
            catch (Exception exception)
            {
                msgLabel.Text = exception.Message;
            }
            
        }
    }
}