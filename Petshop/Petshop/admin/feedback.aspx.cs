using System;
using System.Data;

public partial class admin_feedback : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            LoadFeedback();
        }
    }

    private void LoadFeedback()
    {
        Dbo db = new Dbo();
        DataTable dt = db.getdata("select * from Feedback");

        GridView1.DataSource = dt;
        GridView1.DataBind();
    }
}
