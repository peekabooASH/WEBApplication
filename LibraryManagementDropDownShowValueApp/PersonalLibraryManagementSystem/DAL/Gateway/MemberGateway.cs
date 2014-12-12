using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace PersonalLibraryManagementSystem.DAL.Gateway
{
    public class MemberGateway:Gateway
    {
        public bool HasMember(string memberNo)
        {
            string query = "SELECT * FROM t_Member WHERE Number='" + memberNo + "'";
            Command.CommandText = query;
            Connection.Open();
            SqlDataReader aDataReader = Command.ExecuteReader();
            bool hasRow = aDataReader.HasRows;
            Connection.Close();
            return hasRow;
        }
    }
}