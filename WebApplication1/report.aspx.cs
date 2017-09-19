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
    public partial class WebForm16 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["id"] == null)
            {
                Response.Redirect("login.aspx");
            }
            if (Session["type"].ToString() == "Admin")
            {
                string connstr = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
                string sql = "select count(id) from userTable";
                SqlConnection conn = new SqlConnection(connstr);
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();

                int emp = (int)cmd.ExecuteScalar();
                totalemp.Text = emp.ToString();
                conn.Close();
                sql = "select sum(salary) from userTable;";
                conn = new SqlConnection(connstr);
                cmd = new SqlCommand(sql, conn);
                conn.Open();
                decimal sal = (decimal)cmd.ExecuteScalar();
                totalsal.Text = sal.ToString();
                conn.Close();
                sql = "select avg(salary) from userTable;";
                conn = new SqlConnection(connstr);
                cmd = new SqlCommand(sql, conn);
                conn.Open();
                decimal avg = (decimal)cmd.ExecuteScalar();
                avgsalary.Text = avg.ToString();
                conn.Close();
                sql = "select Department.departmentName as 'Department Name', count(userName) as 'Employee', sum(salary) as 'Total Salary', avg(salary) as 'Average Salary' from userTable, Department where Department.id=userTable.departmentId group by departmentName;";
                conn = new SqlConnection(connstr);
                cmd = new SqlCommand(sql, conn);
                conn.Open();
                
                SqlDataReader reader = cmd.ExecuteReader();

                //Response.Write(reader[0].ToString());
                GridView1.DataSource = reader;
                GridView1.DataBind();
                //Response.Write(reader["name"].ToString());
                //Response.Write("HIIII");
                //Response.Write(reader["name"].ToString() + "<br/>");

            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('You do not have admin privilege')", true);
                //Response.Redirect("adminHome.aspx");
            }
        }
    }
}