using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm15 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["id"] == null)
            {
                Response.Redirect("~/login.aspx");
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string connstr = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            string sql = "select * from userTable where id="+Session["id"];
            SqlConnection conn = new SqlConnection(connstr);
            SqlCommand cmd = new SqlCommand(sql, conn);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            //conn.Close();
            if (reader.HasRows)
            {
                if (reader.Read())
                {
                    if (TextBox1.Text == reader["password"].ToString())
                    {
                        string sql1 = "UPDATE userTable SET password='" + TextBox2.Text + "' WHERE id=" + Session["id"];
                        SqlConnection conn1 = new SqlConnection(connstr);
                        SqlCommand cmd1 = new SqlCommand(sql1, conn1);
                        conn1.Open();
                        if (cmd1.ExecuteNonQuery() != null)
                        {
                            Label2.Text = "Password Change Successfull ";
                        }

                    }
                    else
                    {
                        Label1.Text = "Wrong Old Password";
                    }
                }
            }

        

        }
    }
}