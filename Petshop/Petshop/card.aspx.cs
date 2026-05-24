using System;
using System.Data.SqlClient;

public partial class card : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        string cardNo = TextBox1.Text;
        string bankName = TextBox2.Text;
        string cvv = TextBox3.Text;
        string expiry = TextBox4.Text;
        string amount = TextBox5.Text;

        string connStr = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=PetShopDB;Integrated Security=True";

        using (SqlConnection con = new SqlConnection(connStr))
        {
            con.Open();

            // ✅ ONLY THIS LINE CHANGED
            string query = @"INSERT INTO card
            (Custid, Cardno, Bankname, Cvv, Expiry, Amount)
            VALUES (@Custid,@Cardno,@Bankname,@Cvv,@Expiry,@Amount)";

            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@Custid", Session["uid"]);
                cmd.Parameters.AddWithValue("@Cardno", cardNo);
                cmd.Parameters.AddWithValue("@Bankname", bankName);
                cmd.Parameters.AddWithValue("@Cvv", cvv);
                cmd.Parameters.AddWithValue("@Expiry", expiry);
                cmd.Parameters.AddWithValue("@Amount", amount);

                cmd.ExecuteNonQuery();
            }
        }
    }
}