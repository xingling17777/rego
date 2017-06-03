using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class user_register : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        if (TextBox1.Text != "" && TextBox2.Text != "" && TextBox3.Text != "" && TextBox4.Text != "")
        {
            if (TextBox2.Text.Trim().ToString() != TextBox3.Text.Trim().ToString())
            {
                Response.Write("<script type=text/javascript>alert('两次输入密码不一致!')</script>");
            }
            else
            {
                SqlConnection conn = new DataBase().getSqlConnection();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "select count(*) from 用户信息 where 用户名='" + TextBox1.Text.Trim().ToString()+"'";

                try
                {
                    conn.Open();
                    if(Convert.ToInt32(cmd.ExecuteScalar().ToString())==1)
                    {
                        Response.Write("<script type=text/javascript>alert('用户名重复，请选择其他用户名!')</script>");
                        return;
                    }
                    cmd.CommandText = "insert into 用户信息 values('" + TextBox1.Text.Trim().ToString() + "','" + TextBox2.Text.Trim().ToString() + "','" + TextBox4.Text.Trim().ToString() + "',0)";
                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        Response.Write("<script type=text/javascript>alert('注册成功，请等待管理员审核!')</script>");

                    }
                    //Response.Redirect("/Default.aspx");
                }
                catch (Exception ey)
                {
                    Response.Write("<script type=text/javascript>alert('提交失败,请联系管理员处理!')</script>");
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        else
        {
            Response.Write("<script type=text/javascript>alert('必须填写所有内容!')</script>");
        }
    }
}