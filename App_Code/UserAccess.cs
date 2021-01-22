using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

/// <summary>
/// userAccess 的摘要说明
/// </summary>
public class userAccess
{
    public userAccess()
    {
        //
        // TODO: 在此处添加构造函数逻辑
        //
    }
    public bool getUserAccess(string ss, int i)
    {
        if (HttpContext.Current.Session["userName"] == null)
        {
            HttpContext.Current.Session["url"] = HttpContext.Current.Request.Url.ToString();
            HttpContext.Current.Response.Redirect("../user/login.aspx");
        }
        else
        {
            SqlConnection conn = new DataBase().getSqlConnection();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "select * from 用户权限 where no=" + HttpContext.Current.Session["userID"].ToString() + " and 功能='" + ss + "'";
            try
            {
                conn.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                if (sdr.Read())
                {
                    if (sdr[i + 2].ToString() == "1")
                    {
                        return true;
                    }
                    else
                    {
                        HttpContext.Current.Response.Write("<script type=text/javascript>alert('没有此权限，即将退出！')</script>");
                        HttpContext.Current.Response.Redirect("Default.aspx");
                    }
                }
                else
                {
                    HttpContext.Current.Response.Write("<script type=text/javascript>alert('没有此权限，即将退出！')</script>");
                    HttpContext.Current.Response.Redirect("Default.aspx");
                }
            }
            catch (Exception ey) { }
            finally
            {
                conn.Close();
            }
        }
        return false;

    }

}