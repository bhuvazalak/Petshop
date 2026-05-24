using System;
using System.Data;

public partial class showproducts : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        DataTable dt = new DataTable();
        Dbo db = new Dbo();

        if (Request.QueryString["t1"] != null)
        {
            string cid = Request.QueryString["t1"].ToString();
            dt = db.getdata("select * from Products where CategoryId = " + cid);
        }
        else
        {
            dt = db.getdata("select * from Products");
        }

        string str = "";
        str += "<table width='75%' align='center'>";

        for (int i = 0; i < dt.Rows.Count; i++)
        {
            if (i % 3 == 0)
                str += "<tr>";

            str += "<td align='center'>";
            str += "<a href='show_product_details.aspx?t1=" + dt.Rows[i]["Id"].ToString() + "'>";
            str += "<img src='Project_images/" + dt.Rows[i]["Image"].ToString() + "' height='200' width='200'/>";
            str += "<br/>" + dt.Rows[i]["Pname"].ToString() + "</a>";
            str += "</td>";

            if (i % 3 == 2)
                str += "</tr>";
        }

        str += "</table>";
        Literal2.Text = str;
    }
}
