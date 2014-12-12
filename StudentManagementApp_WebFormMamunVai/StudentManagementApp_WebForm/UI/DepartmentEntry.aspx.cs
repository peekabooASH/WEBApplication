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
    public partial class DepartmentEntry : System.Web.UI.Page
    {
        DepartmentManager aDepartmentManager=new DepartmentManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            Label.Text = "";
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            try
            {

                var name = nameTextBox.Text;
                var code = codeTextBox.Text;
              

                Department aDepartment = new Department(name,code);

                bool isSaved = aDepartmentManager.Insert(aDepartment);

                if (isSaved)
                {
                    Label.Text = "Saved Successfully!";
                }
                else
                {
                    Label.Text = "Insertion Failed!";
                }

            }
            catch (Exception exception)
            {
                Label.Text = exception.Message;
            }
            
        }
    }
}