using System;

public partial class payment_options : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["uid"] == null)
            Response.Redirect("login.aspx");
    }

    protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
    {
        Response.Redirect("payment.aspx");   // Cash on Delivery
    }

    protected void RadioButton2_CheckedChanged(object sender, EventArgs e)
    {
        Response.Redirect("card.aspx");      // Card Payment
    }
}
