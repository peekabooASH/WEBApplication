using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ExamApp.BLL;
using ExamApp.Models;

namespace ExamApp.UI
{
    public partial class ReturnBookUI : System.Web.UI.Page
    {
        BookManager aBookManager=new BookManager();
        List<Borrow> borrows = new List<Borrow>();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void showBooksButton_Click(object sender, EventArgs e)
        {
            string memberno = memberNoTextBox.Text;
            borrows = aBookManager.GetBorroedInfo(memberno);
            if (IsPostBack)
            {
                borroedDropDownList.DataSource = borrows;
                borroedDropDownList.DataTextField = "BookId";
                //regshowDropDownList.DataValueField = "Name";
                borroedDropDownList.DataBind();
            }
        }

        protected void returnButton_Click(object sender, EventArgs e)
        {
            var book = borroedDropDownList.SelectedItem.Text;
            string msg = aBookManager.InsertReturnList(memberNoTextBox.Text,book);
            msgLabel.Text = msg;
        }



    }
}