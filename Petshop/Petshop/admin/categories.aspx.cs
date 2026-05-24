using System;
using System.Data;
using System.Collections.Generic;

public partial class admin_categories : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Dbo db = new Dbo();

        // DELETE CATEGORY IF delid EXISTS
        if (Request["delid"] != null)
        {
            int delid = Convert.ToInt32(Request["delid"]); // convert safely to int
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@Id", delid);

            db.setdata("DELETE FROM Categories WHERE Id=@Id", parameters);
        }

        // GET ALL CATEGORIES
        DataTable dt = db.getdata("SELECT * FROM Categories");

        // BUILD HTML TABLE
        string str = "<table border='1' width='100%'>";
        str += "<tr><th>#</th><th>Category Name</th><th>Image</th><th>Delete</th><th>Edit</th></tr>";

        for (int i = 0; i < dt.Rows.Count; i++)
        {
            str += "<tr>";
            str += "<td>" + (i + 1) + "</td>";
            str += "<td>" + dt.Rows[i]["Catname"].ToString() + "</td>";
            str += "<td><img src='../Project_images/" + dt.Rows[i]["Image"].ToString() + "' height='100' width='100' /></td>";
            str += "<td><a href='categories.aspx?delid=" + dt.Rows[i]["Id"].ToString() + "' onclick=\"return confirm('Are you sure you want to delete this category?');\">Delete</a></td>";
            str += "<td><a href='edit_category.aspx?pid=" + dt.Rows[i]["Id"].ToString() + "'>Edit</a></td>";
            str += "</tr>";
        }

        str += "</table>";

        // SHOW TABLE
        Literal1.Text = str;
    }
}
