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
    public partial class WebForm8 : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (Request.QueryString["id"] == "1")
            {
                Label1.Text = "Enter Id  :";
            }
            else if (Request.QueryString["name"] == "1")
            {
                Label1.Text = "Enter Name  :";
            }
            else if (Request.QueryString["department"] == "1")
            {
                Label1.Text = "Enter Department Name:";
            }
            else if (Request.QueryString["role"] == "1")
            {
                Label1.Text = "Select Role";
                TextBox1.Visible = false;
                DropDownList1.Visible = true;
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label2.Text = "Search Result: ";
            Label3.Text = " ";
            if (Request.QueryString["id"] == "1")
            {
                string connstr = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
                string sql = "select * from userTableView where id=" + TextBox1.Text;
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
                    Label3.Text = "No Result Found";

                }
                GridView1.DataSource = reader;
                GridView1.DataBind();
                conn.Close();
            }
            else if (Request.QueryString["name"] == "1")
            {
                string connstr = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
                string sql = "select * from userTableView where userName like '%" + TextBox1.Text+"%'";
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
                    Label3.Text = "No Result Found";
                }
                GridView1.DataSource = reader;
                GridView1.DataBind();
                conn.Close();
            }

            else if (Request.QueryString["department"] == "1")
            {
                string connstr = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
                string sql = "select * from userTableView where departmentName like '%" + TextBox1.Text + "%'";
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
                    Label3.Text = "No Result Found";
                }
                GridView1.DataSource = reader;
                GridView1.DataBind();
                conn.Close();
            }

            else if (Request.QueryString["role"] == "1")
            {
                string connstr = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
                string sql = "select * from userTableView where type='" + DropDownList1.SelectedValue + "'";
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
                    Label3.Text = "No Result Found";
                }
                GridView1.DataSource = reader;
                GridView1.DataBind();
                conn.Close();
            }

        }
    }
}