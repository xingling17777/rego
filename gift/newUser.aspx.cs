using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;


public partial class gift_newUser : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        if(!IsPostBack)
        {
            if(TextBox1.Text!="" && TextBox2.Text!="")
            {
                string userName = TextBox1.Text.Trim().ToString();
                string userPWD = TextBox2.Text.Trim().ToString();
                SqlConnection conn = new DataBase().getSqlConnection();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "select count(*) from giftUser where userName='" + userName + "'";
                try
                {
                    conn.Open();
                    if(cmd.ExecuteScalar().ToString()!="0")
                    {
                        Response.Write("<script>alert('用户名重复！')</script>");
                    }
                    else
                    {
                        cmd.CommandText = "insert into giftUser values('" + userName + "','" + userPWD + "')";
                        cmd.ExecuteNonQuery();
                        Session["userName"] = userName;
                        
                    }
                }
                catch(Exception ey) { }
                finally
                {
                    conn.Close();
                    Response.Redirect("Default.aspx");
                }
            }
            else
            {
                Response.Write("<script>alert('用户名或密码不能为空！')</script>");
            }
        }
    }
}