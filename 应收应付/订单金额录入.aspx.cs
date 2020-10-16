using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class 应收应付_订单金额录入 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            ListBox1.Items.Clear();
            SqlConnection conn = new DataBase().getSqlConnection();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "select * from 客户信息 order by name";
            try
            {
                conn.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                while(sdr.Read())
                {
                    ListBox1.Items.Add(new ListItem(sdr[1].ToString(), sdr[0].ToString()));
                }
            }
            catch(Exception ey) {
                Response.Write("<script language=javascript>alert('读取客户信息出错，请联系管理员!')</script>");
            }
            finally
            {
                conn.Close();
            }
        }
    }
    //
    protected void Button1_Click(object sender, EventArgs e)
    {
        //define data;
        string orderID = TextBox1.Text.Trim().ToString();
        if (orderID == "")
        {
            Response.Write("<script language=javascript>alert('请输入订单编号!')</script>");
            return;
        }
        decimal money = 0;
        try
        {
            money = Convert.ToDecimal(TextBox2.Text.Trim().ToString());
        }
        catch (Exception ey)
        {
            Response.Write("<script language=javascript>alert('请输入正确的订单金额!')</script>");
            return;
        }
        int customerID = 0;
        if (ListBox1.SelectedIndex == -1)
        {
            Response.Write("<script language=javascript>alert('请选择客户!')</script>");
            return;
        }
        else
        {
            customerID = Convert.ToInt32(ListBox1.SelectedValue.ToString());
        }
        //sql operation
        SqlConnection conn = new DataBase().getSqlConnection();
        SqlCommand cmd = conn.CreateCommand();
        cmd.CommandText = "insert into ";
            try
        {
            conn.Open();

        }
        catch(Exception ey) { }
        finally { }
    }
}