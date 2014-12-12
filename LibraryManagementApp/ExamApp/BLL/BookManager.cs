using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;
using ExamApp.DAL;
using ExamApp.Models;

namespace ExamApp.BLL
{
    public class BookManager
    {
        private BookGateway aBookGateway;

        public BookManager()
        {
            aBookGateway = new BookGateway();
        }

        public List<Book> GetAllBook()
        {
            return aBookGateway.GetAllBook();
        }

        public Book GetBookInfoByTitle(string book)
        {
            return aBookGateway.GetBookInfoByTitle(book);
        }

        public string Insert(Borrow aBorrow)
        {
            
            if (!HasThisMemberExist(aBorrow.MemberNo))
            {
                return "Member is not Exist.";
            }
            if (!HasThisBookExist(aBorrow.BookId))
            {
                aBookGateway.Insert(aBorrow);
                return "Inserted";
            }
         
            return "There are some problem.";

        }

        private bool HasThisBookExist(string bookId)
        {
            if (aBookGateway.HasThisBookExist(bookId))
            {
                return true;
            }
            return false;
        }

        private bool HasThisMemberExist(string memberNo)
        {
            if (aBookGateway.HasThisMemberExist(memberNo))
            {
                return true;
            }
            return false;
        }

        public List<Borrow> GetBorroedInfo(string memberno)
        {
            return aBookGateway.GetBorroedInfo(memberno);
        }

        public string InsertReturnList(string memberNoTextBox, string book)
        {

            aBookGateway.InsertReturnList(memberNoTextBox, book);
                return "Information is Saved.";

           
        }

    }
}