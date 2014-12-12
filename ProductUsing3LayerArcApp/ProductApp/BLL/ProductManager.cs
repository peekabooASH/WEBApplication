using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProductApp.DAL;
using ProductApp.Models;

namespace ProductApp.BLL
{
    public class ProductManager
    {
        private ProductGAteway aProductGAteway;
        private int total = 0;
        public ProductManager()
        {
            aProductGAteway=new ProductGAteway();
        }

        public string Insert(Product aProduct)
        {
            if (aProduct.Code==String.Empty &&aProduct.name==String.Empty&&aProduct.Quantity==String.Empty)
            {
                return "Fill all the information.";
            }
            int length = aProduct.Code.Length;
            if (length > 3 || length < 3)
            {
                return "Length must be in 3 char.";
            }
            if (!HasThisProductExist(aProduct.Code))
            {
                aProductGAteway.Insert(aProduct);
                return "Product is Inserted";

            }
            return "There are some problem.";

        }

        private bool HasThisProductExist(string code)
        {
            if (aProductGAteway.HasThisProductExist(code))
            {
                return true;
            }
            return false;
        }


        public List<Product> GetAllProduct()
        {
            List<Product> products;
            products = aProductGAteway.GetAllProduct();
            foreach (Product aProduct in products)
            {
                total += Convert.ToInt32(aProduct.Quantity);
            }
            return products;
        }

        public int GetQuantity()
        {
            return total;
        }

        public Product GetProductByCode(string aProductCode)
        {
            return aProductGAteway.GetProductByCode(aProductCode);
        }
    }
}