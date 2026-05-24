using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Web.UI;

public partial class admin_Login : System.Web.UI.Page
{
    // ✅ Web.config se connection le rahe hai
    string conStr = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

    protected void Page_Load(object sender, EventArgs e)
    {
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        // Static login
        if (TextBox1.Text == "admin" && TextBox2.Text == "12345")
        {
            Session["aid"] = "1";
            Response.Redirect("home.aspx");
            return;
        }

        using (SqlConnection con = new SqlConnection(conStr))
        {
            SqlCommand cmd = new SqlCommand(
                "SELECT Id FROM admin WHERE Username=@Username AND Password=@Password", con);

            cmd.Parameters.AddWithValue("@Username", TextBox1.Text);
            cmd.Parameters.AddWithValue("@Password", TextBox2.Text);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count == 0)
            {
                Response.Write("<script>alert('Invalid Username or Password');</script>");
            }
            else
            {
                Session["aid"] = dt.Rows[0]["Id"].ToString();
                Response.Redirect("home.aspx");
            }
        }
    }
}