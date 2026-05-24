using System;
using System.Data;
using System.Collections.Generic;

public partial class View_cart : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["uid"] == null)
        {
            Response.Redirect("login.aspx");
            return;
        }

        Dbo db = new Dbo();

        if (Request.QueryString["t1"] != null)
        {
            int id;
            if (int.TryParse(Request.QueryString["t1"], out id))
            {
                Dictionary<string, object> delParam = new Dictionary<string, object>();
                delParam.Add("@Id", id);

                db.setdata("DELETE FROM Cart WHERE Id=@Id", delParam);
            }
        }


        // GET CART DATA
        Dictionary<string, object> param = new Dictionary<string, object>();
        param.Add("@Custid", Convert.ToInt32(Session["uid"]));

        DataTable dt = db.getdata("SELECT * FROM Cart WHERE Custid=@Custid", param);

        string str = "";
        decimal total = 0;

        str += "<table class='cart-table'>";
        str += "<tr><th>Sr No</th><th>Image</th><th>Product Name</th><th>Qty</th><th>Amount</th><th>Delete</th></tr>";

        for (int i = 0; i < dt.Rows.Count; i++)
        {
            Dictionary<string, object> p2 = new Dictionary<string, object>();
            p2.Add("@Pid", Convert.ToInt32(dt.Rows[i]["Prodid"]));

            DataTable dt1 = db.getdata("SELECT * FROM Products WHERE Id=@Pid", p2);

            if (dt1.Rows.Count > 0)
            {
                decimal rowAmount = Convert.ToDecimal(dt.Rows[i]["Amount"]);
                total += rowAmount;

                str += "<tr>";
                str += "<td>" + (i + 1) + "</td>";
                str += "<td><img class='product-img' src='Project_images/" + dt1.Rows[0]["Image"] + "' /></td>";
                str += "<td>" + dt1.Rows[0]["Pname"] + "</td>";
                str += "<td>" + dt.Rows[i]["Qty"] + "</td>";
                str += "<td>₹ " + rowAmount.ToString("0.00") + "</td>";
                str += "<td><a href='View_cart.aspx?t1=" + dt.Rows[i]["Id"] + "'>Delete</a></td>";
                str += "</tr>";
            }
        }

        str += "</table>";

        Session["total"] = total;

        str += "<div class='cart-footer'>";
        str += "<div class='total-text'>Total Amount : ₹ " + total.ToString("0.00") + "</div>";
        str += "<a href='payment_options.aspx?t1=" + total.ToString("0.00") + "' class='btn-checkout'>Checkout</a>";
        str += "<a href='categories.aspx' class='btn-continue'>Continue Shopping</a>";
        str += "</div>";

        Literal2.Text = str;
    }
}
