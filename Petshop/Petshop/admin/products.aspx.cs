using System;
using System.Data;

public partial class admin_products : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Dbo db = new Dbo();

        if (Request["delid"] != null)
        {
            db.setdata("delete from Products where Id = " + Request["delid"]);
            Response.Redirect("products.aspx");
        }

        DataTable dt = db.getdata("Select * from Products");

        String str = "<table border='1' width='100%'>";
        str += "<tr>";
        str += "<th>No</th>";
        str += "<th>Product Name</th>";
        str += "<th>Company Name</th>";
        str += "<th>Description</th>";
        str += "<th>Price</th>";
        str += "<th>Image</th>";
        str += "<th>Delete</th>";
        str += "<th>Edit</th>";
        str += "</tr>";

        for (int i = 0; i < dt.Rows.Count; i++)
        {
            str += "<tr>";
            str += "<td>" + (i + 1) + "</td>";
            str += "<td>" + dt.Rows[i]["Pname"].ToString() + "</td>";
            str += "<td>" + dt.Rows[i]["CompanyName"].ToString() + "</td>";  // ✅ Yaha change kiya
            str += "<td>" + dt.Rows[i]["Description"].ToString() + "</td>";
            str += "<td>" + dt.Rows[i]["Price"].ToString() + "</td>";
            str += "<td><img src='../Project_images/" + dt.Rows[i]["Image"].ToString() + "' height='100' width='100'/></td>";
            str += "<td><a href='products.aspx?delid=" + dt.Rows[i]["Id"].ToString() + "'>Delete</a></td>";
            str += "<td><a href='edit_product.aspx?pid=" + dt.Rows[i]["Id"].ToString() + "'>Edit</a></td>";
            str += "</tr>";
        }

        str += "</table>";

        Literal1.Text = str;
    }
}
