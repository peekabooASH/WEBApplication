using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProductApp.BLL;
using ProductApp.Models;

namespace ProductApp.UI
{
    public partial class ProductUI : System.Web.UI.Page
    {
        ProductManager aProductManager = new ProductManager();
        protected void Page_Load(object sender, EventArgs e)
        { }

        protected void saveButton_Click(object sender, EventArgs e)
        {
            Product aProduct=new Product(codeTextBox.Text,nameTextBox.Text,quantityTextBox.Text);
            ProductManager aProductManager=new ProductManager();
            string msg= aProductManager.Insert(aProduct);
            Label4.Text = msg;
        }

        protected void showButton_Click(object sender, EventArgs e)
        {
            ProductManager aProductManager1 = new ProductManager();
            List<Product> products= aProductManager1.GetAllProduct();
            ShowStudentStudentView(products);
            showQuantityTextBox.Text = aProductManager1.GetQuantity().ToString();
        }
        private void ShowStudentStudentView(List<Product> products)
        {
            GridView1.DataSource = products;
            GridView1.DataBind();
            GridView1.Visible = true;
        }
    }
}