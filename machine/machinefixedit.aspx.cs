using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class machine_machinefixedit : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["userName"] == null)
        {
            Session["url"] = Request.Url.ToString();
            Response.Redirect("../user/login.aspx");
        }
        if (!IsPostBack)
        {
            SqlConnection conn = new DataBase().getSqlConnection();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "select id,设备名称 from machine";
            SqlDataReader sdr = null;
            try
            {
                conn.Open();
                sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    DropDownList1.Items.Add(new ListItem(sdr[1].ToString(), sdr[0].ToString()));
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                sdr.Close();
                conn.Close();
            }
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        string id = DropDownList1.SelectedValue;

        SqlConnection conn = new DataBase().getSqlConnection();
        SqlCommand cmd = conn.CreateCommand();
        //cmd.CommandText = "insert into 设备履历表 values("+id+",'"+DateTime.Now.ToShortDateString()+"','"+contents+"','"+duty+"')";

        try
        {
            conn.Open();
            if (TextBox11.Text != "" && TextBox12.Text != "" && TextBox13.Text != "")
            {
                try
                {
                    Convert.ToDateTime(TextBox11.Text).ToShortDateString();
                }
                catch (Exception e11)
                { Response.Write("<script type=text/javascript>alert('日期格式错误')</script>"); }
                finally { }
                cmd.CommandText = "insert into 设备保养记录 values(" + id + ",'" + Convert.ToDateTime(TextBox11.Text).ToShortDateString() + "','" + TextBox12.Text + "','" + TextBox13.Text + "')";

                if (cmd.ExecuteNonQuery() == 1)
                {
                    Response.Write("<script type=text/javascript>alert('第1条内容添加成功')</script>");
                }
            }
            if (TextBox21.Text != "" && TextBox22.Text != "" && TextBox23.Text != "")
            {
                try
                {
                    Convert.ToDateTime(TextBox21.Text).ToShortDateString();
                }
                catch (Exception e22)
                { Response.Write("<script type=text/javascript>alert('日期格式错误')</script>"); }
                finally { }
                cmd.CommandText = "insert into 设备保养记录 values(" + id + ",'" + Convert.ToDateTime(TextBox21.Text).ToShortDateString() + "','" + TextBox22.Text + "','"  + TextBox23.Text + "')";

                if (cmd.ExecuteNonQuery() == 1)
                {
                    Response.Write("<script type=text/javascript>alert('第2条内容添加成功')</script>");
                }
            }
            if (TextBox31.Text != "" && TextBox32.Text != "" && TextBox33.Text != "")
            {
                try
                {
                    Convert.ToDateTime(TextBox31.Text).ToShortDateString();
                }
                catch (Exception e33)
                { Response.Write("<script type=text/javascript>alert('日期格式错误')</script>"); }
                finally { }
                cmd.CommandText = "insert into 设备保养记录 values(" + id + ",'" + Convert.ToDateTime(TextBox31.Text).ToShortDateString() + "','" + TextBox32.Text + "','" + TextBox33.Text + "')";

                if (cmd.ExecuteNonQuery() == 1)
                {
                    Response.Write("<script type=text/javascript>alert('第3条内容添加成功')</script>");
                }
            }
            if (TextBox41.Text != "" && TextBox42.Text != "" && TextBox43.Text != "")
            {
                try
                {
                    Convert.ToDateTime(TextBox41.Text).ToShortDateString();
                }
                catch (Exception e44)
                { Response.Write("<script type=text/javascript>alert('日期格式错误')</script>"); }
                finally { }
                cmd.CommandText = "insert into 设备保养记录 values(" + id + ",'" + Convert.ToDateTime(TextBox41.Text).ToShortDateString() + "','" + TextBox42.Text + "','" +  TextBox43.Text + "')";

                if (cmd.ExecuteNonQuery() == 1)
                {
                    Response.Write("<script type=text/javascript>alert('第4条内容添加成功')</script>");
                }
            }
            if (TextBox51.Text != "" && TextBox52.Text != "" && TextBox53.Text != "")
            {
                try
                {
                    Convert.ToDateTime(TextBox51.Text).ToShortDateString();
                }
                catch (Exception e55)
                { Response.Write("<script type=text/javascript>alert('日期格式错误')</script>"); }
                finally { }
                cmd.CommandText = "insert into 设备履历表 values(" + id + ",'" + Convert.ToDateTime(TextBox51.Text).ToShortDateString() + "','" + TextBox52.Text + "','" + TextBox53.Text + "')";

                if (cmd.ExecuteNonQuery() == 1)
                {
                    Response.Write("<script type=text/javascript>alert('第5条内容添加成功')</script>");
                }
            }
            


        }
        catch (Exception ey)
        {
            Response.Write("<script type=text/javascript>alert('数据更新失败,请联系管理员')</script>");
        }
        finally
        {

            conn.Close();
            Response.Redirect("/machine/machinefixedit.aspx");
        }
    }
}