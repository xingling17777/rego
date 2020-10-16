using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class machine_storebase : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(Session["userName"]==null)
        {
            Session["url"] = Request.Url.ToString();
            Response.Redirect("../user/login.aspx");
        }
        if(DropDownList1.SelectedIndex==-1)
        {
            DropDownList1.SelectedIndex = 0;
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        if(TextBox1.Text!="" )
        { 
        SqlConnection conn = new DataBase().getSqlConnection();
        SqlCommand cmd = conn.CreateCommand();
        cmd.CommandText = "select count(*) from 配件基础信息 where name ='"+TextBox1.Text.Trim().ToString()+"' and type='"+TextBox2.Text.Trim().ToString()+"'";
            try
            {
                conn.Open();
                if(Convert.ToInt32(cmd.ExecuteScalar().ToString())==0)
                {
                    if(TextBox5.Text=="")
                    {
                        TextBox5.Text = "0";
                    }
                    cmd.CommandText = "insert into 配件基础信息 values('"+TextBox1.Text.Trim().ToString()+"','"+TextBox2.Text.Trim().ToString()+"','"+TextBox3.Text.Trim().ToString()+"','"+TextBox4.Text.Trim().ToString()+"','"+DropDownList1.SelectedValue.ToString()+"',"+TextBox5.Text.Trim().ToString()+",'"+TextBox6.Text.Trim().ToString()+"')";
                    cmd.ExecuteNonQuery();
                }
            }
            catch(Exception ex)
            { }
            finally
            {
                conn.Close();
            }
        }
        TextBox1.Text = "";
        TextBox2.Text = "";
        TextBox3.Text = "";
        TextBox4.Text = "";
        TextBox5.Text = "";
        TextBox6.Text = "";
        TextBox1.Focus();
    }
}