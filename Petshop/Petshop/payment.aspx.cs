using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
public partial class payment : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        TextBox4.Text = Session["total"].ToString();
        TextBox4.Enabled = false;
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Dbo db = new Dbo();

        Dictionary<string, object> param = new Dictionary<string, object>();
        param.Add("@Custid", Convert.ToInt32(Session["uid"]));
        param.Add("@Amount", Convert.ToDecimal(TextBox4.Text));
        param.Add("@Address", TextBox2.Text);
        param.Add("@Name", TextBox1.Text);
        param.Add("@Phone", TextBox3.Text);

        db.setdata("insert into Payment values(@Custid,@Amount,@Address,@Name,@Phone)", param);

        DataTable dt = db.getdata("Select * from Cart where Custid = " + Session["uid"].ToString());

        for (int i = 0; i < dt.Rows.Count; i++)
        {
            Dictionary<string, object> p2 = new Dictionary<string, object>();
            p2.Add("@Custid", Convert.ToInt32(Session["uid"]));
            p2.Add("@Prodid", Convert.ToInt32(dt.Rows[i]["Prodid"]));
            p2.Add("@Qty", Convert.ToInt32(dt.Rows[i]["Qty"]));
            p2.Add("@Amount", Convert.ToDecimal(dt.Rows[i]["Amount"]));

            db.setdata("insert into orders values(@Custid,@Prodid,@Qty,@Amount)", p2);
        }

        db.setdata("delete from Cart where Custid = " + Session["uid"].ToString());

        Response.Write("<script>alert('Your order placed successfully');window.location='home.aspx';</script>");
    }
}