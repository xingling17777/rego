using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class technology_productADD : System.Web.UI.Page
{
    static int x = 0;
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
                cmd.CommandText = "select id,name from 成品编码_客户信息 order by name";
                try
                {
                    conn.Open();
                    SqlDataReader sdr = cmd.ExecuteReader();
                    DropDownList1.Items.Clear();
                    DropDownList2.Items.Clear();
                    DropDownList4.Items.Clear();
                    while (sdr.Read())
                    {
                        DropDownList1.Items.Add(new ListItem(sdr[1].ToString(), sdr[0].ToString()));
                        DropDownList2.Items.Add(new ListItem(sdr[1].ToString(), sdr[0].ToString()));
                        DropDownList4.Items.Add(new ListItem(sdr[1].ToString(), sdr[0].ToString()));
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
                //DropDownList1.SelectedIndex = x;
            }
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {

        if (TextBox1.Text.Trim().ToString() != "" && DropDownList1.SelectedIndex != -1)
        {
            int color, bantong, count;
            if (TextBox2.Text.Trim().ToString() == "")
            {
                color = -1;
            }
            else
            {
                try
                {
                    color = Convert.ToInt32(TextBox2.Text.Trim().ToString());
                }
                catch (Exception ey)
                {
                    Response.Write("<script language='javascript'>alert('无效的色数,仅限数字!')</script>");
                    return;
                }
            }
            if (TextBox3.Text.Trim().ToString() == "")
            {
                bantong = -1;
            }
            else
            {
                try
                {
                    bantong = Convert.ToInt32(TextBox3.Text.Trim().ToString());
                   
                }
                catch (Exception ey)
                {
                    Response.Write("<script language='javascript'>alert('无效的齿数,仅限数字!')</script>");
                    return;
                }
            }
            if (TextBox4.Text.Trim().ToString() == "")
            {
                count = -1;
            }
            else
            {
                try
                {
                    count = Convert.ToInt32(TextBox4.Text.Trim().ToString());
                }
                catch (Exception ey)
                {
                    Response.Write("<script language='javascript'>alert('无效的版筒个数,仅限数字!')</script>");
                    return;
                }
            }
            SqlConnection conn = new DataBase().getSqlConnection();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "select count(*) from 成品编码_产品 where customer = " + DropDownList1.SelectedValue.ToString() + " and name='" + TextBox1.Text.Trim().ToString() + "'";
            try
            {
                conn.Open();
                if (cmd.ExecuteScalar().ToString() != "0")
                {
                    Response.Write("<script language='javascript'>alert('重复的产品,请检查后再提交!')</script>");
                }
                else
                {
                    cmd.CommandText = "select top 1 no from 成品编码_产品 where customer = " + DropDownList1.SelectedValue.ToString() + " order by id desc";
                    if (cmd.ExecuteScalar() == null)
                    {
                        cmd.CommandText = "insert into 成品编码_产品 (customer,name,no,color,bantong,count,beizhu) values (" + DropDownList1.SelectedValue.ToString() + ",'" + TextBox1.Text.Trim().ToString() + "',1," + color + "," + bantong + "," + count + ",'" + TextBox6.Text.Trim().ToString() + "')";
                    }
                    else
                    {
                        int no = Convert.ToInt32(cmd.ExecuteScalar().ToString()) + 1;
                        cmd.CommandText = "insert into 成品编码_产品 (customer,name,no,color,bantong,count,beizhu) values (" + DropDownList1.SelectedValue.ToString() + ",'" + TextBox1.Text.Trim().ToString() + "'," + no + "," + color + "," + bantong + "," + count + ",'" + TextBox6.Text.Trim().ToString() + "')";

                    }
                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        Response.Write("<script language='javascript'>alert('新产品提交成功!')</script>");
                        cmd.CommandText = "select top 1 id from 成品编码_产品 order by id desc";
                        string no = cmd.ExecuteScalar().ToString();
                        cmd.CommandText = "insert into 成品编码_印刷 (no,version,样板,菲林,树脂版,片材,彩稿) values (" + no + ",'A',-1,-1,-1,-1,-1)";
                        cmd.ExecuteNonQuery();
                        cmd.CommandText = "insert into 系统日志 values ('" + Session["userName"].ToString() + "','" + System.DateTime.Now.ToShortDateString() + "','录入" +DropDownList1.SelectedItem.ToString()+"的新产品"+ TextBox1.Text.Trim().ToString() + "')";
                        cmd.ExecuteNonQuery();
                        TextBox1.Text = "";
                        TextBox2.Text = "";
                        TextBox3.Text = "";
                        TextBox4.Text = "";
                        TextBox6.Text = "";
                        
                    }
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
            Response.Write("<script type=text/javascript>alert('请选择客户并输入产品名字！')</script>");
        }
    }

    protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (DropDownList2.SelectedIndex != -1)
        {
            SqlConnection conn = new DataBase().getSqlConnection();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "select id,name from 成品编码_产品 where customer=" + DropDownList2.SelectedValue.ToString();
            try
            {
                conn.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                DropDownList3.Items.Clear();
                while (sdr.Read())
                {
                    DropDownList3.Items.Add(new ListItem(sdr[1].ToString(), sdr[0].ToString()));
                }
                if (DropDownList3.Items.Count > 0)
                {
                    DropDownList3.SelectedIndex = 0;
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
            Response.Write("<script type=text/javascript>alert('请选择客户！')</script>");
        }
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        if (DropDownList3.SelectedIndex != -1 && TextBox5.Text.Trim().ToString() != "")
        {
            SqlConnection conn = new DataBase().getSqlConnection();
            SqlCommand cmd = conn.CreateCommand();

            int color, bantong, count;
            if (TextBox7.Text.Trim().ToString() == "")
            {
                color = -1;
            }
            else
            {
                try
                {
                    color = Convert.ToInt32(TextBox7.Text.Trim().ToString());
                }
                catch (Exception ey)
                {
                    Response.Write("<script language='javascript'>alert('无效的色数,仅限数字!')</script>");
                    return;
                }
            }
            if (TextBox8.Text.Trim().ToString() == "")
            {
                bantong = -1;
            }
            else
            {
                try
                {
                    bantong = Convert.ToInt32(TextBox8.Text.Trim().ToString());
                }
                catch (Exception ey)
                {
                    Response.Write("<script language='javascript'>alert('无效的齿数,仅限数字!')</script>");
                    return;
                }
            }
            if (TextBox9.Text.Trim().ToString() == "")
            {
                count = -1;
            }
            else
            {
                try
                {
                    count = Convert.ToInt32(TextBox9.Text.Trim().ToString());
                }
                catch (Exception ey)
                {
                    Response.Write("<script language='javascript'>alert('无效的版筒个数,仅限数字!')</script>");
                    return;
                }
            }
            cmd.CommandText = "update 成品编码_产品 set name='" + TextBox5.Text.Trim().ToString() + "',color="+color+",bantong="+bantong+",count="+count+",beizhu='"+TextBox10.Text.Trim().ToString()+"' where id=" + DropDownList3.SelectedValue.ToString();
            try
            {
                conn.Open();
                if (cmd.ExecuteNonQuery() == 1)
                {
                    Response.Write("<script type=text/javascript>alert('产品信息更新成功！')</script>");
                    cmd.CommandText = "insert into 系统日志 values ('" + Session["userName"].ToString() + "','" + System.DateTime.Now.ToShortDateString() + "','修改" + DropDownList2.SelectedItem.ToString()+"的"+ DropDownList3.SelectedItem.ToString() + "的产品信息!')";
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
            Response.Write("<script type=text/javascript>alert('请选择产品并输入新名字！')</script>");
        }
    }

    protected void DropDownList4_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (DropDownList4.SelectedIndex != -1)
        {
            SqlConnection conn = new DataBase().getSqlConnection();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "select id,name from 成品编码_产品 where customer=" + DropDownList4.SelectedValue.ToString();
            try
            {
                conn.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                DropDownList5.Items.Clear();
                while (sdr.Read())
                {
                    DropDownList5.Items.Add(new ListItem(sdr[1].ToString(), sdr[0].ToString()));
                }
                if (DropDownList5.Items.Count > 0)
                {
                    DropDownList5.SelectedIndex = 0;
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
            Response.Write("<script type=text/javascript>alert('请选择客户！')</script>");
        }
    }

    protected void DropDownList5_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (DropDownList5.SelectedIndex != -1)
        {
            Label1.Text = DropDownList5.SelectedItem.ToString();
        }
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        if (DropDownList5.SelectedIndex != -1)
        {
            SqlConnection conn = new DataBase().getSqlConnection();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "delete from 成品编码_产品 where id=" + DropDownList5.SelectedValue.ToString();
            try
            {
                conn.Open();
                if (cmd.ExecuteNonQuery() == 1)
                {
                    cmd.CommandText = "delete  from 成品编码_印刷 where no=" + DropDownList5.SelectedValue.ToString();
                    cmd.ExecuteNonQuery();
                    Response.Write("<script type=text/javascript>alert('产品更新成功！')</script>");
                    cmd.CommandText = "insert into 系统日志 values ('" + Session["userName"].ToString() + "','" + System.DateTime.Now.ToShortDateString() + "','删除" + DropDownList4.SelectedItem.ToString() + "的" + DropDownList5.SelectedItem.ToString() + "的产品信息!')";
                    cmd.ExecuteNonQuery();
                }
                else
                {
                    Response.Write("<script type=text/javascript>alert('产品更新失败！')</script>");
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
            Response.Write("<script type=text/javascript>alert('请选择产品！')</script>");
        }
    }

    protected void DropDownList3_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (DropDownList3.SelectedIndex != -1)
        {
            SqlConnection conn = new DataBase().getSqlConnection();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "select * from 成品编码_产品 where id=" + DropDownList3.SelectedValue.ToString();
            try
            {
                conn.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    TextBox5.Text = sdr[2].ToString();
                    if (sdr[4].ToString() != ""&& sdr[4].ToString()!="-1")
                    {
                        TextBox7.Text = sdr[4].ToString();
                    }
                    if (sdr[5].ToString() != "" && sdr[5].ToString() != "-1")
                    {
                        TextBox8.Text = sdr[5].ToString();
                    }
                    if (sdr[6].ToString() != "" && sdr[6].ToString() != "-1")
                    {
                        TextBox9.Text = sdr[6].ToString();
                    }
                    if (sdr[7].ToString() != "")
                    {
                        TextBox10.Text = sdr[7].ToString();
                    }
                }
            }
            catch (Exception ey) { }
            finally { conn.Close(); }
        }
    }
}