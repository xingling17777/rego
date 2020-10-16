using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class technology_lastvisityinban : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["userName"] == null)
        {
            Session["url"] = Request.Url.ToString();
            Response.Redirect("../user/login.aspx");
        }

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        if (TextBox1.Text.ToString().Trim().Length >= 7)
        {

            string customer = TextBox1.Text.Trim().Substring(0, 3);
            int product = Convert.ToInt32(TextBox1.Text.Trim().Substring(3, 3));
            int version = 0;
            try
            {
                version = Convert.ToInt32(TextBox1.Text.Trim().Substring(6));
            }

            catch (Exception es)
            {
                Response.Write("<script language=javascript>alert('编号的版本部分错误！')</script>");
                TextBox1.Focus();
                return;
            }
            if (version <= 0)
            {
                Response.Write("<script language=javascript>alert('编号的版本部分错误！')</script>");
                TextBox1.Focus();
                return;
            }
            SqlConnection conn = new DataBase().getSqlConnection();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "select id from 客户信息 where no=" + customer;
            try
            {
                conn.Open();
                string customerID = cmd.ExecuteScalar().ToString();
                if (customerID == null)
                {
                    Response.Write("<script language=javascript>alert('编号的客户编码部分错误！')</script>");
                    TextBox1.Focus();
                    return;
                }
                cmd.CommandText = "select id from 成品编码_产品 where customer=" + customerID + " and no=" + product;
                string productID = cmd.ExecuteScalar().ToString();
                if (productID == null)
                {
                    Response.Write("<script language=javascript>alert('编号的产品编码部分错误！')</script>");
                    TextBox1.Focus();
                    return;
                }
                char versions = (char)((int)'A' + version - 1);
                cmd.CommandText = "select id from 成品编码_印刷 where no= " + productID + " and version='" + versions + "'";
                string versionID = cmd.ExecuteScalar().ToString();
                if (versionID == null)
                {
                    Response.Write("<script language=javascript>alert('无此编码产品！')</script>");
                    TextBox1.Focus();
                    return;
                }
                cmd.CommandText = "select * from lastvisityinban where no=" + versionID;
                if (cmd.ExecuteNonQuery() == 1)
                {
                    cmd.CommandText = "update lastvisityinban set lastdate='" + System.DateTime.Now.ToShortDateString() + "' where no=" + versionID + ")";
                }
                else
                {
                    cmd.CommandText = "insert into lastvisityinban values (" + versionID + ",'" + System.DateTime.Now.ToShortDateString() + "')";
                }
                if (cmd.ExecuteNonQuery() == 1)
                {
                    Response.Write("<script language=javascript>alert('日期已登记！')</script>");
                    TextBox1.Text = "";
                    TextBox1.Focus();
                }
                else
                {
                    Response.Write("<script language=javascript>alert('日期登记失败！')</script>");
                    TextBox1.Text = "";
                    TextBox1.Focus();
                }
            }
            catch (Exception ey) { }
            finally
            {
                conn.Close();
            }
        }
        else
        {
            Response.Write("<script language=javascript>alert('编号格式错误，请重新输入！')</script>");
            TextBox1.Focus();
        }
    }
}