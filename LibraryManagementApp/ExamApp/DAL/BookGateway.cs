using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using ExamApp.Models;

namespace ExamApp.DAL
{
    public class BookGateway:Gateway
    {
        public BookGateway(): base("LibraryString")
        {
        }

        public List<Book> GetAllBook()
        {
            List<Book> newlist = new List<Book>();

            Connection.Open();
            string query = string.Format("SELECT * FROM t_Book");
            SqlCommand command = new SqlCommand(query, Connection);
            SqlDataReader aReader = command.ExecuteReader();

            if (aReader.HasRows)
            {
                while (aReader.Read())
                {
                    Book aBook = new Book();
                    aBook.Id = aReader[0].ToString();
                    aBook.Title = aReader[1].ToString();
                    aBook.Author = aReader[2].ToString();
                    aBook.Publisher = aReader[3].ToString();


                    newlist.Add(aBook);
                }
            }
            Connection.Close();

            return newlist;
        }

        public Book GetBookInfoByTitle(string book)
        {
            Connection.Open();
            string query = string.Format("SELECT * FROM t_Book WHERE Title=@book");
            SqlCommand command = new SqlCommand(query, Connection);
            command.Parameters.Add(new SqlParameter("@book",book));

            
            Book aBook = new Book();
            SqlDataReader aReader = command.ExecuteReader();
            if (aReader.HasRows)
            {
                while (aReader.Read())
                {

                   aBook.Id = aReader[0].ToString();
                    aBook.Title = aReader[1].ToString();
                    aBook.Author= aReader[2].ToString();
                    aBook.Publisher = aReader[3].ToString();
                }
            }
            Connection.Close();
            return aBook;


        }
        public bool HasThisBookExist(string bookid)
        {
            Connection.Open();
            string query = string.Format("SELECT * FROM t_Borrow WHERE BookId=@BookId");
            SqlCommand command = new SqlCommand(query, Connection);
            command.Parameters.Add(new SqlParameter("@BookId", bookid));

            SqlDataReader aReader = command.ExecuteReader();
            bool Hasrow = aReader.HasRows;
            Connection.Close();
            return Hasrow;
        }


        public bool HasThisMemberExist(string memberNo)
        {
            Connection.Open();
            string query = string.Format("SELECT * FROM t_Member WHERE Id=@Id");
            SqlCommand command = new SqlCommand(query, Connection);
            command.Parameters.Add(new SqlParameter("@Id", memberNo));

            SqlDataReader aReader = command.ExecuteReader();
            bool Hasrow = aReader.HasRows;
            Connection.Close();
            return Hasrow;
        }

        public void Insert(Borrow aBorrow)
        {
            Connection.Open();
            string query = string.Format("INSERT INTO t_Borrow VALUES(@MemberNo,@BookId,@Author,@Publisher )");
            SqlCommand command = new SqlCommand(query, Connection);
            command.Parameters.Add(new SqlParameter("@MemberNo", aBorrow.MemberNo));
            command.Parameters.Add(new SqlParameter("@BookId", aBorrow.BookId));
            command.Parameters.Add(new SqlParameter("@Author", aBorrow.Author));
            command.Parameters.Add(new SqlParameter("@Publisher", aBorrow.Publisher));

            SqlDataReader aReader = command.ExecuteReader();
            Connection.Close();
        }

        public List<Borrow> GetBorroedInfo(string memberno)
        {
            List<Borrow> newlist = new List<Borrow>();

            Connection.Open();
            string query = string.Format("SELECT * FROM t_Borrow where MemberNo=@MemberNo");
           
            SqlCommand command = new SqlCommand(query, Connection);
            command.Parameters.Add(new SqlParameter("@MemberNo", memberno));
            SqlDataReader aReader = command.ExecuteReader();

            if (aReader.HasRows)
            {
                while (aReader.Read())
                {
                    Borrow aBorrow = new Borrow();
                    aBorrow.MemberNo = aReader[0].ToString();
                    aBorrow.BookId= aReader[1].ToString();
                    aBorrow.Author = aReader[2].ToString();
                    aBorrow.Publisher = aReader[3].ToString();


                    newlist.Add(aBorrow);
                }
            }
            Connection.Close();

            return newlist;
        }

        public void InsertReturnList(string memberNoTextBox, string book)
        {
            Connection.Open();
            string query = string.Format("INSERT INTO t_Return VALUES(@MemberNo,@BookId)");
            SqlCommand command = new SqlCommand(query, Connection);
            command.Parameters.Add(new SqlParameter("@MemberNo", memberNoTextBox));
            command.Parameters.Add(new SqlParameter("@BookId", book));
           
            SqlDataReader aReader = command.ExecuteReader();
            Connection.Close();
            DeleteInfofromBorrow(memberNoTextBox, book);
        }

        private void DeleteInfofromBorrow(string memberNoTextBox, string book)
        {
            Connection.Open();
            string query = string.Format("DELETE FROM t_Borrow where MemberNo=@MemberNo AND BookId=@BookId ");
            SqlCommand command = new SqlCommand(query, Connection);
            command.Parameters.Add(new SqlParameter("@MemberNo", memberNoTextBox));
            command.Parameters.Add(new SqlParameter("@BookId", book));
            SqlDataReader aReader = command.ExecuteReader();
            Connection.Close();
       }

      
    }
}