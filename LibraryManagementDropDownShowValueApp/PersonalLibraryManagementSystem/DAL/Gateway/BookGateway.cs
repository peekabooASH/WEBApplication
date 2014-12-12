using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using PersonalLibraryManagementSystem.Models;

namespace PersonalLibraryManagementSystem.DAL.Gateway
{
    public class BookGateway:Gateway
    {
        public List<Book> GetAllBook()
        {
           List<Book> books = new List<Book>();
            string query = "SELECT * FROM t_Book";
            Command.CommandText = query;
            Connection.Open();
            SqlDataReader aDataReader = Command.ExecuteReader();
            while (aDataReader.Read())
            {
                Book book= new Book();
                book.Id = (int) aDataReader[0];
                book.Tital= aDataReader[1].ToString();
                book.Author= aDataReader[2].ToString();
                book.Publisher= aDataReader[3].ToString();
                books.Add(book);
            }
            aDataReader.Close();
            Connection.Close();
            return books;
        }

        public Book GetSelectedBook(int id)
        {
            Book abook = null;
            string query = "SELECT * FROM t_Book WHERE Id='"+id+"'";
            Command.CommandText = query;
            Connection.Open();
            SqlDataReader aDataReader = Command.ExecuteReader();
            while (aDataReader.Read())
            {
                abook = new Book();
                abook.Id = (int)aDataReader[0];
                abook.Tital = aDataReader[1].ToString();
                abook.Author = aDataReader[2].ToString();
                abook.Publisher = aDataReader[3].ToString();
   
            }
            aDataReader.Close();
            Connection.Close();
            return abook;
        }

        public List<Book> GetAllBookByMember(string memberNo)
        {
            List<Book> books= new List<Book>();
            string query = "SELECT * FROM SelectedBookByMember WHERE MemberNo='" + memberNo + "'";
            Command.CommandText = query;
            Connection.Open();
            SqlDataReader aDataReader = Command.ExecuteReader();
            while (aDataReader.Read())
            {
               Book  abook = new Book();
                abook.Id = (int)aDataReader[0];
                abook.Tital = aDataReader[1].ToString();
                abook.Author = aDataReader[2].ToString();
                abook.Publisher = aDataReader[3].ToString();

            }
            aDataReader.Close();
            Connection.Close();
            return books; 
        }
    }
}