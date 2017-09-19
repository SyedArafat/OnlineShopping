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
    public partial class WebForm13 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label1.Text = " ";
            string connstr = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            string sql = "select * from userTableView where userName like '%" + TextBox1.Text + "%' and type='Staff'";
            SqlConnection conn = new SqlConnection(connstr);
            SqlCommand cmd = new SqlCommand(sql, conn);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            //Response.Write(reader[0].ToString());
            if (reader.HasRows)
            {

            }
            else
            {
                reader = null;
                
                Label1.Text = "No Result Found";
            }
            GridView1.DataSource = reader;
            GridView1.DataBind();
            conn.Close();
        }
    }
}