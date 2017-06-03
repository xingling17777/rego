using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class user_access : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {
        if(Session["userName"]==null)
        {
            Session["url"] = Request.Url.ToString();
            Response.Redirect("/user/login.aspx");
        }

        if (!IsPostBack)
        {
            SqlConnection conn = new DataBase().getSqlConnection();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "select id,姓名 from 用户信息 order by 姓名";
            DropDownList1.Items.Clear();
            SqlDataReader sdr = null;
            try
            {
                conn.Open();
                sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    DropDownList1.Items.Add(new ListItem(sdr[1].ToString(), sdr[0].ToString()));
                }
                cmd.CommandText = "select distinct 功能 from 用户权限 order by 功能";
                sdr.Close();
                sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    DropDownList2.Items.Add(sdr[0].ToString());
                }
            }
            catch (Exception ey)
            {
                Response.Write("<script type=text/javascript>alert('加载用户信息出错!请联系管理员或稍后重试!')</script>");
            }
            finally
            {
                conn.Close();
            }
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        if (DropDownList1.SelectedIndex != -1 && DropDownList2.SelectedIndex != -1)
        {
            SqlConnection conn = new DataBase().getSqlConnection();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "select count(*) from 用户权限 where no =" + DropDownList1.SelectedValue.ToString() + " and 功能='" + DropDownList2.SelectedValue.ToString() + "'";
            try
            {
                conn.Open();
                if (Convert.ToInt32(cmd.ExecuteScalar().ToString()) == 0)
                {
                    string x = (CheckBox1.Checked) ? "1" : "0";
                    cmd.CommandText = "insert into 用户权限 values(" + DropDownList1.SelectedValue.ToString() + ",'" + DropDownList2.SelectedValue.ToString() + "'," + ((CheckBox1.Checked) ? "1" : "0") + "," + ((CheckBox2.Checked) ? "1" : "0") + "," + ((CheckBox3.Checked) ? "1" : "0") + "," + ((CheckBox4.Checked) ? "1" : "0") + ")";
                    if(cmd.ExecuteNonQuery()==1)
                    {
                        Response.Write("<script type=text/javascript>alert('权限更改已提交!')</script>");
                        Response.Redirect("");
                    }
                }
                else
                {
                    cmd.CommandText = "delete from 用户权限 where no=" + DropDownList1.SelectedValue.ToString() + " and 功能='" + DropDownList2.SelectedValue.ToString();
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = "insert into 用户权限 values(" + DropDownList1.SelectedValue.ToString() + ",'" + DropDownList2.SelectedValue.ToString() + "'," + ((CheckBox1.Checked) ? "1" : "0") + "," + ((CheckBox2.Checked) ? "1" : "0") + "," + ((CheckBox3.Checked) ? "1" : "0") + "," + ((CheckBox4.Checked) ? "1" : "0") + ")";
                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        Response.Write("<script type=text/javascript>alert('权限更改已提交!')</script>");
                        Response.Redirect("");
                    }
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