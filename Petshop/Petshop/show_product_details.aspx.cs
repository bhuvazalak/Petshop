using System;
using System.Data;

public partial class show_product_details : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Request.QueryString["t1"] != null)
            {
                string pid = Request.QueryString["t1"].ToString();

                Dbo db = new Dbo();
                DataTable dt = db.getdata("select * from Products where Id = " + pid);

                if (dt.Rows.Count > 0)
                {
                    string str = "";
                    str += "<br/><br/><table>";
                    str += "<tr>";
                    str += "<td><img src='Project_images/" + dt.Rows[0]["Image"].ToString() + "' height='400' width='400'/></td>";
                    str += "<td valign='top'>";
                    str += "Product Name : " + dt.Rows[0]["Pname"].ToString();
                    str += "<br/>Company : " + dt.Rows[0]["CompanyName"].ToString();
                    str += "<br/>Price : " + dt.Rows[0]["Price"].ToString();
                    str += "<br/>Description : " + dt.Rows[0]["Description"].ToString();
                    str += "</td>";
                    str += "</tr>";
                    str += "</table>";

                    Literal2.Text = str;

                    // ✅ Store safe values
                    ViewState["price"] = dt.Rows[0]["Price"].ToString();
                    ViewState["pid"] = pid;
                }
            }
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        // ✅ Login check
        if (Session["uid"] == null)
        {
            Response.Redirect("login.aspx");
            return;
        }

        // ✅ ViewState null check
        if (ViewState["price"] == null || ViewState["pid"] == null)
        {
            Response.Write("<script>alert('Product data missing');</script>");
            return;
        }

        int quantity;
        if (!int.TryParse(TextBox1.Text, out quantity) || quantity <= 0)
        {
            Response.Write("<script>alert('Please enter valid quantity');</script>");
            return;
        }

        decimal price;
        if (!decimal.TryParse(ViewState["price"].ToString(), out price))
        {
            Response.Write("<script>alert('Invalid price format');</script>");
            return;
        }

        string pid = ViewState["pid"].ToString();

        decimal totalAmount = price * quantity;

        Dbo db = new Dbo();

        db.setdata("insert into Cart values('"
            + Session["uid"].ToString() + "','"
            + pid + "','"
            + quantity + "','"
            + totalAmount + "')");

        Response.Redirect("View_cart.aspx?t1=" + totalAmount);
    }
}
