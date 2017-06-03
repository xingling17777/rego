using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class user_login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        if (txtbox1.Text.Trim().ToString() != "" && txtbox2.Text.Trim().ToString() != "")
        {
            SqlConnection conn = new DataBase().getSqlConnection();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "select * from 用户信息 where 用户名='" + txtbox1.Text.Trim().ToString() + "' and 密码='" + txtbox2.Text.Trim().ToString() + "' and 启用=1";
            try
            {
                conn.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                if (sdr.Read())
                {
                    Session["userName"] = sdr[3].ToString();
                    Session["userID"] = sdr[0].ToString();
                    Response.Write("<script type=text/javascript>alert('登录成功!')</script>");
                }
                else
                {
                    Response.Write("<script type=text/javascript>alert('用户名或密码错误!')</script>");
                }
            }
            catch (Exception ey) { }
            finally
            {
                conn.Close();
            }
            if (Session["url"] != null)
            {
                Response.Redirect(Session["url"].ToString());
            }
            Response.Write("<script type=text/javascript>history.go(-1);</script>");
        }

    }
}