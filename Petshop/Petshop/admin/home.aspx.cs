using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class admin_home : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            LoadDashboardStats();
        }
    }

    private void LoadDashboardStats()
    {
        Dbo db = new Dbo();

        // Total Users
        DataTable dtUsers = db.getdata("SELECT COUNT(*) AS Total FROM Registration");
        lblTotalUsers.Text = dtUsers.Rows[0]["Total"].ToString();

        // Total Products
        DataTable dtProducts = db.getdata("SELECT COUNT(*) AS Total FROM Products");
        lblTotalProducts.Text = dtProducts.Rows[0]["Total"].ToString();

        // Total Categories
        DataTable dtCategories = db.getdata("SELECT COUNT(*) AS Total FROM Categories");
        lblTotalCategories.Text = dtCategories.Rows[0]["Total"].ToString();

        // Total Orders (from orders table)
        DataTable dtOrders = db.getdata("SELECT COUNT(*) AS Total FROM Orders");
        lblTotalOrders.Text = dtOrders.Rows[0]["Total"].ToString();
    }
}