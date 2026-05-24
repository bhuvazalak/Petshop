using System;
using System.Data;

public partial class admin_edit_product : System.Web.UI.Page
{
    static string pid;

    protected void Page_Load(object sender, EventArgs e)
    {
        Dbo db = new Dbo();

        if (!Page.IsPostBack)
        {
            pid = Request["pid"];

            DataTable dt = db.getdata("select * from products where Id = " + pid);

            if (dt.Rows.Count > 0)
            {
                TextBox1.Text = dt.Rows[0]["Pname"].ToString();
                TextBox2.Text = dt.Rows[0]["CompanyName"].ToString();
                TextBox3.Text = dt.Rows[0]["Description"].ToString();
                TextBox4.Text = dt.Rows[0]["Price"].ToString();
            }
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Dbo db = new Dbo();

        if (FileUpload1.FileName == "")
        {
            db.setdata("update products set Pname ='" + TextBox1.Text +
                       "', CompanyName = '" + TextBox2.Text +
                       "' , Description = '" + TextBox3.Text +
                       "' , Price = '" + TextBox4.Text +
                       "' where Id = '" + pid + "'");
        }
        else
        {
            db.setdata("update products set Pname ='" + TextBox1.Text +
                       "', CompanyName = '" + TextBox2.Text +
                       "' , Description = '" + TextBox3.Text +
                       "' , Price = '" + TextBox4.Text +
                       "', Image ='" + FileUpload1.FileName +
                       "' where Id = '" + pid + "'");

            FileUpload1.SaveAs(Server.MapPath("~/Project_images/" + FileUpload1.FileName));
        }

        Response.Redirect("products.aspx");
    }
}
