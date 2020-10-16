using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class other_Report_Print : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        int year = DateTime.Now.AddDays(-1).Year;
        int month = DateTime.Now.AddDays(-1).Month;
        int date = DateTime.Now.AddDays(-1).Day;
        TextBox1.Text = year.ToString();
        TextBox2.Text = month.ToString();
        TextBox3.Text = date.ToString();
       
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        if(txtName1.Text=="" && txtName2.Text=="")
        {
            Response.Write("<script language='javascript'>alert('请输入开机人员名字！')</script>");
            return;
        }
        int year = DateTime.Now.AddDays(-1).Year;
        int month = DateTime.Now.AddDays(-1).Month;
        int day = DateTime.Now.AddDays(-1).Day;
        if (TextBox1.Text!="")
        {
            year = Convert.ToInt32(TextBox1.Text.Trim().ToString());
        }
        if(TextBox2.Text!="")
        {
            month = Convert.ToInt32(TextBox2.Text.Trim().ToString());
        }
        if(TextBox3.Text!="")
        {
            day = Convert.ToInt32(TextBox3.Text.Trim().ToString());
        }
        string orderNO = txtOrder.Text.Trim().ToString();
        string jitai = DropDownList1.SelectedValue.ToString();
        string banzu = RadioButtonList1.SelectedValue.ToString();
        string people = "";
        if(txtName1.Text!="")
        {
            people += txtName1.Text.Trim().ToString();
        }
        if(txtName2.Text!="")
        {
            people += ("," + txtName2.Text.Trim().ToString());
        }
        float sum = 0;
        if(TextBox6.Text!="")
        {
            sum = (float)Convert.ToDouble(TextBox6.Text.ToString().Trim());
        }
        SqlConnection conn = new SqlConnection("server=192.168.0.18;database=rego;uid=sa;pwd=REgo123456");
        SqlCommand cmd = conn.CreateCommand();
        cmd.CommandText = "insert into 报表录入 values('"+new DateTime(year,month,day)+"','"+orderNO+"','"+banzu+"','"+jitai+"','"+people+"',"+sum+",'"+RadioButtonList2.SelectedValue.ToString()+"')";
        try
        {
            conn.Open();
            if(cmd.ExecuteNonQuery()==1)
            {
                Response.Write("<script language='javascript'>alert('已录入！')</script>");
            }
        }
        catch(Exception ey) { }
        finally
        {
            conn.Close();
        }
    }

    protected void txtOrder_TextChanged(object sender, EventArgs e)
    {
        if(txtOrder.Text.Trim().ToString().Length==7)
        {
            SqlConnection conn = new SqlConnection("server=192.168.0.18;database=rego;uid=sa;pwd=REgo123456");
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "select customerName+productName from 订单描述 where orderNO='" + txtOrder.Text.Trim().ToString() + "'";
            try
            {
                conn.Open();
                Label1.Text = cmd.ExecuteScalar().ToString();
            }
            catch(Exception ey) { }
            finally
            {
                conn.Close();
            }
        }
    }
}