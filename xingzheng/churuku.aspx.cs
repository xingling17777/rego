using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class xingzheng_churuku : System.Web.UI.Page
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
                DropDownList1.Items.Clear();
                SqlConnection conn = new DataBase().getSqlConnection();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "select * from 行政物料名称 order by 名称";
                try
                {
                    conn.Open();
                    SqlDataReader sdr = null;


                    sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        DropDownList1.Items.Add(new ListItem(sdr[1].ToString(), sdr[0].ToString()));
                    }
                    if (DropDownList1.Items.Count != 0)
                    {
                        DropDownList1.SelectedIndex = 0;
                    }
                }
                catch (Exception ey) { }
                finally
                {
                    conn.Close();
                }
                TextBox4.Text = System.DateTime.Now.Year.ToString();
                TextBox5.Text = DateTime.Now.Month.ToString();
                TextBox6.Text = DateTime.Now.Day.ToString();
            }
        }
    }


    protected void Button1_Click(object sender, EventArgs e)
    {
        if(TextBox1.Text==""||TextBox2.Text==""||TextBox3.Text=="")
        {
            Response.Write("<script type='text/javascript'>alert('数量、部门、入库人不能为空')</script>");
            return;
        }
        string product = DropDownList1.SelectedValue.ToString();
        double count = 0;
        try
        {
            count = Convert.ToDouble(TextBox1.Text.Trim().ToString());
        }
        catch (Exception ey)
        {

        }
        string depart = TextBox2.Text.Trim();
        string name = TextBox3.Text.Trim();
        DateTime dt = DateTime.Now; ;
        if (TextBox4.Text != "" && TextBox5.Text != "" && TextBox6.Text != "")
        {
            try
            {
                dt = new DateTime(Convert.ToInt32(TextBox4.Text.Trim().ToString()), Convert.ToInt32(TextBox5.Text.Trim().ToString()), Convert.ToInt32(TextBox6.Text.Trim().ToString()));
                    }
            catch (Exception ey) { }
        }
        
        if (RadioButton1.Checked)
        {
            count = -count;
        }
        SqlConnection conn = new DataBase().getSqlConnection();
        SqlCommand cmd = conn.CreateCommand();
        cmd.CommandText = "insert into 行政物料出入库 values(" + product + "," + count + ",'" + depart + "','" + name + "','" + dt.ToShortDateString() + "')";
        try
        {
            conn.Open();
            cmd.ExecuteNonQuery();
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox1.Focus();
        }
        catch (Exception ey) { }
        finally
        {
            conn.Close();
        }
    }
}
