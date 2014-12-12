using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace PersonalLibraryManagementSystem.DAL.Gateway
{
    public class Gateway
    {
        public SqlConnection  Connection { get; set; }
        public SqlCommand Command { get; set; }

        public Gateway()
        {
            Connection= new SqlConnection(WebConfigurationManager.ConnectionStrings["sqlcon"].ConnectionString);
            Command= new SqlCommand();
            Command.Connection = Connection;
        }
    }
}