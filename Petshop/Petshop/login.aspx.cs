using System;
using System.Data;

public partial class login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        Dbo db = new Dbo();
        DataTable dt;

        // Admin Login
        if (TextBox1.Text == "admin")
        {
            dt = db.getdata("select * from Admin where Username = '" + TextBox1.Text + "' and Password = '" + TextBox2.Text + "'");

            if (dt.Rows.Count == 0)
            {
                Response.Write("<script>alert('Invalid Username or Password');window.location='login.aspx'</script>");
            }
            else
            {
                Session["aid"] = dt.Rows[0]["Id"].ToString();
                Response.Redirect("admin/home.aspx");
            }

            return; // IMPORTANT
        }

        // User Login
        dt = db.getdata("select * from Registration where Username = '" + TextBox1.Text + "' and Password = '" + TextBox2.Text + "'");

        if (dt.Rows.Count == 0)
        {
            Response.Write("<script>alert('Invalid Username or Password');window.location='login.aspx'</script>");
        }
        else
        {
            Session["uid"] = dt.Rows[0]["Id"].ToString();
            Response.Redirect("categories.aspx");
        }
    }
}
