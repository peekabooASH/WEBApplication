using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using ProductApp.Models;

namespace ProductApp.DAL
{
    public class ProductGAteway:Gateway
    {
        public ProductGAteway(): base("StudentConnectionString")
        {
        }

        public bool HasThisProductExist(string code)
        {
            Connection.Open();
            string query = string.Format("SELECT * FROM productEntry WHERE Code=@code");
            SqlCommand command = new SqlCommand(query, Connection);
            command.Parameters.Add(new SqlParameter("@code", code));

            SqlDataReader aReader = command.ExecuteReader();
            bool Hasrow = aReader.HasRows;
            Connection.Close();
            return Hasrow;
        }

        public void Insert(Product aProduct)
        {
            Connection.Open();
            string query = string.Format("INSERT INTO productEntry VALUES(@NewCode,@Newname,@NewQuantity )");
            SqlCommand command = new SqlCommand(query, Connection);
            command.Parameters.Add(new SqlParameter("@NewCode", aProduct.Code));
            command.Parameters.Add(new SqlParameter("@Newname", aProduct.name));
            command.Parameters.Add(new SqlParameter("@NewQuantity", Convert.ToInt32(aProduct.Quantity)));
            

            SqlDataReader aReader = command.ExecuteReader();
            Connection.Close();
        }

        public List<Product> GetAllProduct()
        {
            List<Product> newlist = new List<Product>();

            Connection.Open();
            string query = string.Format("SELECT * FROM productEntry");
            SqlCommand command = new SqlCommand(query, Connection);
            SqlDataReader aReader = command.ExecuteReader();

            if (aReader.HasRows)
            {
                while (aReader.Read())
                {
                    Product aProduct = new Product();
                    aProduct.Code = aReader[0].ToString();
                    aProduct.name = aReader[1].ToString();
                    aProduct.Quantity = aReader[2].ToString();
                    

                    newlist.Add(aProduct);
                }
            }
            Connection.Close();

            return newlist;
        }

        public Product GetProductByCode(string aProductCode)
        {
            Connection.Open();
            string query = string.Format("SELECT * FROM productEntry WHERE Code=@code");
            SqlCommand command = new SqlCommand(query, Connection);
            command.Parameters.Add(new SqlParameter("@code", aProductCode));
            Product aProduct = new Product();
            SqlDataReader aReader = command.ExecuteReader();
            if (aReader.HasRows)
            {
                while (aReader.Read())
                {
                   
                    aProduct.Code = aReader[0].ToString();
                    aProduct.name = aReader[1].ToString();
                    aProduct.Quantity = aReader[2].ToString();
                }
            }
            Connection.Close();
            return aProduct;
        }
    }
}