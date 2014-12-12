using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PersonalLibraryManagementSystem.Manager;
using PersonalLibraryManagementSystem.Models;

namespace PersonalLibraryManagementSystem.UI
{
    public partial class ReturnBook : System.Web.UI.Page
    {
        BookManager aBookManager= new BookManager();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void showButton_Click(object sender, EventArgs e)
        {
            string memberNo = memberNoTextBox.Text;
            List<Book> books = aBookManager.GetAllBookByMember(memberNo);
            bookDropDownList.DataSource = books;
            bookDropDownList.DataTextField = "Tital";
            bookDropDownList.DataValueField = "Id";
            bookDropDownList.DataBind();
        }

       

       

        
    }
}