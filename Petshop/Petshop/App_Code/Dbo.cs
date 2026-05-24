using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

public class Dbo
{
    private string str = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=PetShopDB;Integrated Security=True";
    private SqlConnection con;

    public Dbo()
    {
        con = new SqlConnection(str);
        con.Open();
    }

    // -----------------------------
    // SIMPLE Insert, Update, Delete
    // -----------------------------
    public void setdata(string query)
    {
        using (SqlCommand cmd = new SqlCommand(query, con))
        {
            cmd.ExecuteNonQuery();
        }
    }

    // -----------------------------------------
    // ADVANCE Insert, Update, Delete (Dictionary)
    // -----------------------------------------
    public void setdata(string query, Dictionary<string, object> parameters)
    {
        using (SqlCommand cmd = new SqlCommand(query, con))
        {
            if (parameters != null)
            {
                foreach (var param in parameters)
                {
                    cmd.Parameters.AddWithValue(param.Key, param.Value);
                }
            }

            cmd.ExecuteNonQuery();
        }
    }

    // -----------------------------
    // SIMPLE SELECT
    // -----------------------------
    public DataTable getdata(string query)
    {
        using (SqlCommand cmd = new SqlCommand(query, con))
        {
            using (SqlDataAdapter da = new SqlDataAdapter(cmd))
            {
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
    }

    // -----------------------------------------
    // SELECT WITH PARAMETERS (Dictionary)
    // -----------------------------------------
    public DataTable getdata(string query, Dictionary<string, object> parameters)
    {
        using (SqlCommand cmd = new SqlCommand(query, con))
        {
            if (parameters != null)
            {
                foreach (var param in parameters)
                {
                    cmd.Parameters.AddWithValue(param.Key, param.Value);
                }
            }

            using (SqlDataAdapter da = new SqlDataAdapter(cmd))
            {
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
    }

    // -----------------------------
    // Close Connection (Optional)
    // -----------------------------
    public void CloseConnection()
    {
        if (con != null && con.State == ConnectionState.Open)
        {
            con.Close();
        }
    }
}
