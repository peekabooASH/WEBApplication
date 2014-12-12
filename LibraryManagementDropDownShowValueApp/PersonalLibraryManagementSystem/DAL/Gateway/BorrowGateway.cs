using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PersonalLibraryManagementSystem.Models;

namespace PersonalLibraryManagementSystem.DAL.Gateway
{
    public class BorrowGateway:Gateway
    {
        public int Save(Borrow aBorrow)
        {
            string query = "INSERT INTO t_Borrowed VALUES(@memberNo,@bookId)";
            Command.CommandText = query;
            Command.Parameters.AddWithValue("@memberNo", aBorrow.MemberNo);
            Command.Parameters.AddWithValue("@bookId",aBorrow.BookId);
            Connection.Open();
            int rowAffected = Command.ExecuteNonQuery();
            Connection.Close();
            return rowAffected;

        }
    }
}