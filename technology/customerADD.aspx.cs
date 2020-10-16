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
            Response.Redirect("../user/login.aspx");
        }
        else
        {
            if (!IsPostBack)
            {
                SqlConnection conn = new DataBase().getSqlConnection();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "select id,name from 客户信息";
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
            cmd.CommandText = "select count(*) from 客户信息 where name='" + TextBox1.Text.Trim().ToString() + "'";
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
                    cmd.CommandText = "select top 1 no from 客户信息 order by id desc";
                    if (cmd.ExecuteScalar() == null)
                    {
                        cmd.CommandText = "insert into 客户信息 values('" + TextBox1.Text.Trim().ToString() + "',100)";
                        if (cmd.ExecuteNonQuery() == 1)
                        {
                            Response.Write("<script language='javascript'>alert('新客户提交成功!')</script>");
                            TextBox1.Text = "";
                        }
                    }
                    else
                    {
                        int no = Convert.ToInt32(cmd.ExecuteScalar().ToString()) + 1;
                        cmd.CommandText = "insert into 客户信息 values('" + TextBox1.Text.Trim().ToString() + "'," + no + ")";
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
                cmd.CommandText = "update 客户信息 set name='" + TextBox2.Text.Trim().ToString() + "' where id=" + DropDownList1.SelectedValue.ToString();
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

    protected void Button6_Click(object sender, EventArgs e)
    {
        ListBox1.Items.Clear();
        SqlConnection conn = new DataBase().getSqlConnection();
        SqlCommand cmd = conn.CreateCommand();
        cmd.CommandText = "select id,name from 客户信息 order by name";
        try
        {
            conn.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            //ListBox1.Items.Clear();
            while (sdr.Read())
            {

                ListBox1.Items.Add(new ListItem(sdr[1].ToString(), sdr[0].ToString()));

            }
        }

        catch (Exception ey) { }
        finally
        {
            conn.Close();
        }
        if (TextBox13.Text.Trim().ToString() != "")

        {
            for (int n = 0; n < ListBox1.Items.Count; n++)
            {
                if (!ListBox1.Items[n].ToString().Contains(TextBox13.Text.Trim().ToString()))
                {
                    ListBox1.Items.RemoveAt(n);
                    n--;
                }
            }
        }
    }

    protected void Button7_Click(object sender, EventArgs e)
    {
        ListBox2.Items.Clear();
        SqlConnection conn = new DataBase().getSqlConnection();
        SqlCommand cmd = conn.CreateCommand();
        cmd.CommandText = "select id,name from 客户信息 order by name";
        try
        {
            conn.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            //ListBox1.Items.Clear();
            while (sdr.Read())
            {

                ListBox2.Items.Add(new ListItem(sdr[1].ToString(), sdr[0].ToString()));

            }
        }

        catch (Exception ey) { }
        finally
        {
            conn.Close();
        }
        if (TextBox14.Text.Trim().ToString() != "")

        {
            for (int n = 0; n < ListBox2.Items.Count; n++)
            {
                if (!ListBox2.Items[n].ToString().Contains(TextBox14.Text.Trim().ToString()))
                {
                    ListBox2.Items.RemoveAt(n);
                    n--;
                }
            }
        }
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        if(ListBox1.SelectedIndex==ListBox2.SelectedIndex)
        {
            Response.Write("<script type=text/javascript>alert('不允许将客户与其本身合并!')</script>");
            return;
        }
        if(ListBox1.SelectedIndex!=-1 && ListBox2.SelectedIndex !=-1)
        {
            int oldcount = 0;
            SqlConnection conn = new DataBase().getSqlConnection();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "select top 1 no from 成品编码_产品 where customer = " + ListBox2.SelectedValue.ToString() + " order by no desc";
            try
            {
                conn.Open();
                if (cmd.ExecuteScalar()==null)
            {

            }
            else
            {
                oldcount = Convert.ToInt32(cmd.ExecuteScalar().ToString());
            }
            }
           catch(Exception ey) { }
            finally
            {
                conn.Close();
            }
            cmd.CommandText = "update 成品编码_产品 set customer=" + ListBox2.SelectedValue.ToString() + ",no=no+" + oldcount + " where customer=" + ListBox1.SelectedValue.ToString();
            try
            {
                conn.Open();
                if (cmd.ExecuteNonQuery() >0)
                {
                    Response.Write("<script type=text/javascript>alert('合并客户成功！')</script>");
                    cmd.CommandText = "insert into 系统日志 values ('" + Session["userName"].ToString() + "','" + System.DateTime.Now.ToShortDateString() + "','合并客户 [" + ListBox1.SelectedItem.ToString() + "] 到 [" + ListBox2.SelectedItem.ToString()+ "]')";
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = "delete from 客户信息 where id=" + ListBox1.SelectedValue.ToString();
                    cmd.ExecuteNonQuery();
                }
                else
                {
                    Response.Write("<script type=text/javascript>alert('产品信息更新失败！')</script>");
                }
            }
            catch (Exception ey)
            {
                Response.Write("<script type=text/javascript>alert('数据库打开失败！')</script>");
            }
            finally
            {
                conn.Close();
            }
        }
        else
        {
            Response.Write("<script type=text/javascript>alert('请选择客户!')</script>");
        }
    }
}