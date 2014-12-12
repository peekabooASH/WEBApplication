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
    public partial class BorrowBook : System.Web.UI.Page
    {
        BookManager aBookManager= new BookManager();
        BorrowManager aBorrowManager= new BorrowManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                List<Book> books = aBookManager.GetAllBook();
                bookDropDownList.DataSource = books;
                bookDropDownList.DataTextField = "Tital";
                bookDropDownList.DataValueField = "Id";
                bookDropDownList.DataBind();
            }
        }

        protected void borrowButton_Click(object sender, EventArgs e)
        {
            string menberNo = memberNoTextBox.Text;
            int bookId = Convert.ToInt32(bookDropDownList.SelectedValue);
           
            try
            {
                Borrow aBorrow = new Borrow(menberNo, bookId);
                int IsSave = aBorrowManager.Save(aBorrow);

                if (IsSave > 0)
                {
                    Label1.Text = "Borrow has been saved";
                }
                else
                {
                    Label1.Text = "Borrow can't save";
                }
            }
            catch (Exception exception)
            {
                Label5.Text = exception.Message;
            }
        }

        protected void bookDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {
            var s = bookDropDownList.SelectedItem;
           
            int id = Convert.ToInt32(bookDropDownList.SelectedValue);
            Book book = aBookManager.GetSelectedBook(id);
            authorTextBox.Text = book.Author;
            publisherTextBox.Text = book.Publisher;
        }
    }
}