using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class xingzheng_wuliaomingcheng : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["userName"] == null)
        {
            Session["url"] = Request.Url.ToString();
            Response.Redirect("../user/login.aspx");
        }
        else
        {

        }
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        if(TextBox1.Text.Trim().ToString()!=""&&TextBox2.Text.Trim().ToString()!="")
        {
            string name = TextBox1.Text.Trim().ToString();
            string unit = TextBox2.Text.Trim().ToString();
            SqlConnection conn = new DataBase().getSqlConnection();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "select count(*) from 行政物料名称 where 名称='"+name+"'";
            try
            {
                conn.Open();
                if(cmd.ExecuteScalar().ToString()!="0")
                {
                    Response.Write("<script type='text/javascript'>alert('物料名称重复，请重新输入！')</script>");
                    TextBox1.Text = "";
                    TextBox2.Text = "";
                    TextBox1.Focus();
                }
                else
                {
                    cmd.CommandText = "insert into 行政物料名称 values('" + name + "','" + unit + "')";
                    if(cmd.ExecuteNonQuery()==1)
                    {
                        Response.Write("<script type='text/javascript'>alert('物料名称录入成功！')</script>");
                        TextBox1.Text = "";
                        TextBox2.Text = "";
                        TextBox1.Focus();
                    }
                    else
                    {
                        Response.Write("<script type='text/javascript'>alert('物料名称录入错误！')</script>");
                    }
                }
            }
            catch(Exception ey) {
                Response.Write("<script type='text/javascript'>alert('"+ey.Message+"')</script>");
            }
            finally
            {
                conn.Close();
            }

        }
        else
        {
            Response.Write("<script type='text/javascript'>alert('名称或单位不能为空！')</script>");
        }
    }
}