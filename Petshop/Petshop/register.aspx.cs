using System;
using System.Collections.Generic;
using System.Data;

public partial class register : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Dbo db = new Dbo();

        // 1️⃣ Check if username exists using parameters
        var checkParams = new Dictionary<string, object>()
        {
            {"@Username", TextBox5.Text }
        };

        DataTable dt = db.getdata("SELECT * FROM Registration WHERE Username=@Username", checkParams);

        if (dt.Rows.Count > 0)
        {
            Response.Write("<script>alert('This Username already registered');window.location='register.aspx'</script>");
        }
        else
        {
            // 2️⃣ Insert new user using parameters
            var insertParams = new Dictionary<string, object>()
            {
                {"@First_name", TextBox1.Text },
                {"@Last_name", TextBox2.Text },
                {"@Contact_no", TextBox3.Text },
                {"@Email", TextBox4.Text },
                {"@Username", TextBox5.Text },
                {"@Password", TextBox6.Text }
            };

            db.setdata(
                "INSERT INTO Registration (First_name, Last_name, Contact_no, Email, Username, Password) " +
                "VALUES (@First_name, @Last_name, @Contact_no, @Email, @Username, @Password)", insertParams
            );

            Response.Write("<script>alert('User Created');window.location='login.aspx'</script>");
        }
    }
}
