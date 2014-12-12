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
    public partial class DepartmentEntryUI : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void deptSaveButton_Click(object sender, EventArgs e)
        {
            DepartmentManager aDepartmentManager = new DepartmentManager();
            Department aDepartment = new Department(codeTextBox.Text,titleTextBox.Text);
            string msg = aDepartmentManager.Insert(aDepartment);
            Label3.Text = msg;
        }
    }
}