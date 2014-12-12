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
    public partial class BorrowBookUI : System.Web.UI.Page
    {
        BookManager aProductManager = new BookManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                msgLabel.Text = "";
                List<Book> produtcs = aProductManager.GetAllBook();
                DropDownList1.DataSource = produtcs;
                DropDownList1.DataTextField = "Title";
                DropDownList1.DataValueField = "Id";
                DropDownList1.DataBind();
            }
           
        }

        protected void showButton_Click(object sender, EventArgs e)
        {
           var book = DropDownList1.SelectedItem.Text;
            BookManager aBookManager=new BookManager();
          
            Book aBook = aBookManager.GetBookInfoByTitle(book);
            authorTextBox.Text = aBook.Author;
            publisherTextBox.Text = aBook.Publisher;

        }

        protected void borrowButton_Click(object sender, EventArgs e)
        {
            var book = DropDownList1.SelectedItem.Text;
            BookManager aBookManager=new BookManager();
            string member = memberTextBox.Text;
            Borrow aBorrow = new Borrow(memberTextBox.Text, book, authorTextBox.Text, publisherTextBox.Text);
            string msg = aBookManager.Insert(aBorrow);
            msgLabel.Text = msg;
        }
      

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }



        }
    }
