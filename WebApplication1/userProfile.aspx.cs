﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm7 : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["id"] == null)
            {
                Response.Redirect("~/login.aspx");
            }
            string connstring = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            string sql = "select * from userTableView where id="+Session["id"];
                SqlConnection conn = new SqlConnection(connstring);
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    userName.Text = reader["userName"].ToString();
                    fullName.Text = reader["fullName"].ToString();
                    phoneNo.Text = reader["phoneNumber"].ToString();
                    email.Text = reader["email"].ToString();
                    address.Text = reader["address"].ToString();
                    role.Text = reader["type"].ToString();
                    //DataView readers = (DataView)SqlDataSource1.Select(DataSourceSelectArguments.Empty);
                    //department.Text = 

                    department.Text = reader["departmentName"].ToString();

                    salary.Text = reader["salary"].ToString();
                }

        }

        protected void edit_Click(object sender, EventArgs e)
        {
            //edit.Style.Add("display", "none");

            edit.Visible = false;
            update.Visible = true;
            cancel.Visible = true;
            TextBox1.Visible = true;
            TextBox2.Visible = true;
            TextBox3.Visible = true;
            TextBox4.Visible = true;
            TextBox5.Visible = true;
            TextBox6.Visible = true;
            TextBox7.Visible = true;
            TextBox8.Visible = true;
            userName.Visible = false;
            fullName.Visible = false;
            phoneNo.Visible = false;
            email.Visible = false;
            address.Visible = false;
            role.Visible = false;
            salary.Visible = false;
            department.Visible = false;

            string s = Request.QueryString["id"];
            
                string connstring = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
                string sql = "select * from userTable where id=" + Session["id"];
                SqlConnection conn = new SqlConnection(connstring);
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {

                    TextBox1.Text = reader["userName"].ToString();
                    TextBox2.Text = reader["fullName"].ToString();
                    TextBox3.Text = reader["phoneNumber"].ToString();
                    TextBox4.Text = reader["email"].ToString();
                    TextBox5.Text = reader["address"].ToString();
                    TextBox6.ClearSelection();
                    TextBox6.Items.FindByValue(reader["type"].ToString()).Selected = true;
                    TextBox7.Text = reader["departmentId"].ToString();
                    TextBox8.Text = reader["salary"].ToString();
                }
            
        }

        protected void update_Click(object sender, EventArgs e)
        {
            string sql = "UPDATE [dbo].[userTable] SET userName='" + TextBox1.Text + "', fullName='" + TextBox2.Text + "', " +
                "phoneNumber='" + TextBox3.Text + "', email='" + TextBox4.Text + "', address='" + TextBox5.Text + "', " +
                "type='" + TextBox6.Text + "', departmentId='" + TextBox7.Text + "', salary='" + TextBox8.Text + "' WHERE id=" + Session["id"];
            string connstr = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            SqlConnection conn = new SqlConnection(connstr);
            SqlCommand cmd = new SqlCommand(sql, conn);
            conn.Open();
            int i = cmd.ExecuteNonQuery();
            conn.Close();
            Response.Redirect("~/userProfile.aspx");

        }

        protected void cancel_Click(object sender, EventArgs e)
        {
            cancel.Visible = false;
            edit.Visible = true;
            update.Visible = false;
            TextBox1.Visible = false;
            TextBox2.Visible = false;
            TextBox3.Visible = false;
            TextBox4.Visible = false;
            TextBox5.Visible = false;
            TextBox6.Visible = false;
            TextBox7.Visible = false;
            TextBox8.Visible = false;
            userName.Visible = true;
            fullName.Visible = true;
            phoneNo.Visible = true;
            email.Visible = true;
            address.Visible = true;
            role.Visible = true;
            salary.Visible = true;
            department.Visible = true;
        }

        protected void delete_Click(object sender, EventArgs e)
        {
            Response.Redirect("changePassword.aspx");
        }
    }
}