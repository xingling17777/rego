using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class technology_customerADD : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["userName"] == null)
        {
            Session["url"] = Request.Url.ToString();
            Response.Redirect("/user/login.aspx");
        }
        else
        {
            if (!IsPostBack)
            {
                SqlConnection conn = new DataBase().getSqlConnection();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "select id,name from 成品编码_客户信息";
                try
                {
                    conn.Open();
                    SqlDataReader sdr = cmd.ExecuteReader();
                    DropDownList1.Items.Clear();
                    DropDownList1.Items.Add("-");
                    while (sdr.Read())
                    {
                        DropDownList1.Items.Add(new ListItem(sdr[1].ToString(), sdr[0].ToString()));
                    }
                }
                catch (Exception ey) { }
                finally
                {
                    conn.Close();
                }
            }
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        if (TextBox1.Text != "")
        {
            SqlConnection conn = new DataBase().getSqlConnection();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "select count(*) from 成品编码_客户信息 where name='" + TextBox1.Text.Trim().ToString() + "'";
            try
            {
                conn.Open();
                if (cmd.ExecuteScalar().ToString() != "0")
                {
                    Response.Write("<script language='javascript'>alert('重复的客户,请检查后再提交!')</script>");
                    TextBox1.Text = "";
                }
                else
                {
                    //cmd.Dispose();
                    cmd.CommandText = "select top 1 no from 成品编码_客户信息 order by id desc";
                    if (cmd.ExecuteScalar() == null)
                    {
                        cmd.CommandText = "insert into 成品编码_客户信息 values('" + TextBox1.Text.Trim().ToString() + "',100)";
                        if (cmd.ExecuteNonQuery() == 1)
                        {
                            Response.Write("<script language='javascript'>alert('新客户提交成功!')</script>");
                            TextBox1.Text = "";
                        }
                    }
                    else
                    {
                        int no = Convert.ToInt32(cmd.ExecuteScalar().ToString()) + 1;
                        cmd.CommandText = "insert into 成品编码_客户信息 values('" + TextBox1.Text.Trim().ToString() + "'," + no + ")";
                        if (cmd.ExecuteNonQuery() == 1)
                        {
                            Response.Write("<script language='javascript'>alert('新客户提交成功!')</script>");
                            TextBox1.Text = "";
                        }
                    }
                }

            }
            catch (Exception ey) { }
            finally
            {
                conn.Close();
            }
        }
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        if (DropDownList1.SelectedIndex > 0)
        {
if(TextBox2.Text.Trim().ToString()!="")
            {
                SqlConnection conn = new DataBase().getSqlConnection();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "update 成品编码_客户信息 set name='" + TextBox2.Text.Trim().ToString() + "' where id=" + DropDownList1.SelectedValue.ToString();
                try
                {
                    conn.Open();
                    if(cmd.ExecuteNonQuery()==1)
                    {
Response.Write("<script type=text/javascript>alert('客户信息更新成功!')</script>");
                    }
                    else
                    {
                        Response.Write("<script type=text/javascript>alert('客户信息更新失败,请联系管理员!')</script>");
                    }
                }
                catch(Exception ey) {
                    Response.Write("<script type=text/javascript>alert('数据库打开失败,请联系管理员!')</script>");
                }
                finally
                {
                    conn.Close();
                }
                
            }
            else
            {
                Response.Write("<script type=text/javascript>alert('请输入客户新名字!')</script>");
            }
        }
        else
        {
            Response.Write("<script type=text/javascript>alert('请选择客户!')</script>");
        }
    }
}