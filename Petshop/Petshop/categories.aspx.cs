using System;
using System.Data;

public partial class categories : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Dbo db = new Dbo();
            DataTable dt = db.getdata("select * from Categories");

            string str = "";
            str += "<table class='category-table'>";

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (i % 3 == 0)
                    str += "<tr>";

                str += "<td class='category-td'>";
                str += "<a href='showproducts.aspx?t1=" + dt.Rows[i]["id"].ToString() + "'>";
                str += "<img src='Project_images/" + dt.Rows[i]["Image"].ToString() + "' />";
                str += "<span class='category-name'>" + dt.Rows[i]["Catname"].ToString() + "</span>";
                str += "</a>";
                str += "</td>";

                if (i % 3 == 2)
                    str += "</tr>";
            }

            str += "</table>";
            Literal2.Text = str;
        }
    }
}
