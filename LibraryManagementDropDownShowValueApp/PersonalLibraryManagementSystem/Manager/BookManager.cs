using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PersonalLibraryManagementSystem.DAL.Gateway;
using PersonalLibraryManagementSystem.Models;

namespace PersonalLibraryManagementSystem.Manager
{
    public class BookManager
    {
        BookGateway aBookGateway= new BookGateway();
        public List<Book> GetAllBook()
        {
            return aBookGateway.GetAllBook();
        }


        public Book GetSelectedBook(int id)
        {
            return aBookGateway.GetSelectedBook(id);
        }


        public List<Book> GetAllBookByMember(string memberNo)
        {
            return aBookGateway.GetAllBookByMember(memberNo);
        }
    }
}