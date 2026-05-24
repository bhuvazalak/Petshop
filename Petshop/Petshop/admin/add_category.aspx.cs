using System;
using System.Collections.Generic;
using System.Web.UI;

public partial class admin_add_category : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        if (!string.IsNullOrWhiteSpace(TextBox1.Text) && FileUpload1.HasFile)
        {
            Dbo db = new Dbo();

            // Prepare parameters for safe insert
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@Catname", TextBox1.Text);
            parameters.Add("@Image", FileUpload1.FileName);

            // Execute insert query using parameters
            db.setdata("INSERT INTO Categories (Catname, Image) VALUES (@Catname, @Image)", parameters);

            // Save uploaded image to server folder
            FileUpload1.SaveAs(Server.MapPath("~/Project_images/" + FileUpload1.FileName));

            // Redirect to categories page
            Response.Redirect("categories.aspx");
        }
        else
        {
            // Optional: show alert if name or image is empty
            Response.Write("<script>alert('Please enter category name and select an image.');</script>");
        }
    }
}
