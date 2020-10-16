using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class gift_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        if(TextBox1.Text.Trim()!="" && TextBox2.Text.Trim()!="")
        {
            string userName = TextBox1.Text.Trim().ToString();
            string userPWD = TextBox2.Text.Trim().ToString();
            SqlConnection conn = new DataBase().getSqlConnection();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "select * from giftUser where userName='" + userName + "' and userPWD='" + userPWD + "'";
            try
            {
                conn.Open();
                if((Session["userID"] = cmd.ExecuteScalar())!=null)
                {                    
                    Session["userName"] = userName;
                    Response.Redirect("Default.aspx");
                }
                else
                {
                    Response.Write("<script>alert('用户名或密码错误！')</script>");
                    TextBox1.Text = "";
                    TextBox2.Text = "";
                }
            }
            catch(Exception ey) { }
            finally
            {
                conn.Close();
            }
        }
    }
}