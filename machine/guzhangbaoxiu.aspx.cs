using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class machine_guzhangbaoxiu : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["userName"] == null)
        {
            Session["url"] = Request.Url.ToString();
            Response.Redirect("/user/login.aspx");
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

    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (DropDownList1.SelectedIndex != -1)
            TextBox2.Text = DropDownList1.SelectedItem.ToString();
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        DateTime dt=DateTime.Now;
        if(TextBox5.Text=="")
        {
            TextBox5.Text = DateTime.Now.ToShortDateString();
        }
        try
        {
            dt = Convert.ToDateTime(TextBox5.Text.ToString());  
        }
        catch(Exception ey)
        {
            
        }
        finally
        {

        }
        SqlConnection conn = new DataBase().getSqlConnection();
        SqlCommand cmd = conn.CreateCommand();
        cmd.CommandText = "insert into 维修记录  values("+DropDownList1.SelectedValue.ToString()+",'"+dt.ToShortDateString()+"','"+TextBox1.Text.ToString()+"','"+TextBox3.Text.ToString()+"','"+TextBox4.Text.ToString()+"',null,null,null,null)";
        try
        {
            conn.Open();
            if(cmd.ExecuteNonQuery()==1)
            {
                Response.Write("<script type=text/javascript>alert('故障提交成功!')</script>");
            }
            else
            {
                Response.Write("<script type=text/javascript>alert('故障报修未录入,请联系管理员处理!')</script>");
            }
        }
        catch(Exception ey)
        {
            Response.Write("<script type=text/javascript>alert('数据处理失败!"+ey.ToString()+"')</script>");
        }
        finally
        {
            conn.Close();
        }

    }
}