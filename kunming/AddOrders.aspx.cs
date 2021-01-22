using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class kunming_AddOrders : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
if(!IsPostBack)
        {
            new userAccess().getUserAccess("云南白药内部订单", 1);
            Calendar1.SelectedDate = DateTime.Now;
            SqlConnection conn = new DataBase().getSqlConnection();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "select * from 白药产品名称 order by name";
            DropDownList1.Items.Clear();
            try
            {
                conn.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                while(sdr.Read())
                {
                    DropDownList1.Items.Add(new ListItem(sdr[1].ToString(), sdr[0].ToString()));
                }
            }
            catch(Exception ey) { }
            finally
            {
                conn.Close();
            }
            if(DropDownList1.Items.Count!=0)
            {
                DropDownList1.SelectedIndex = 0;
            }
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        string OrderNO = TextBox1.Text.Trim().ToString();
        string product = DropDownList1.SelectedValue.ToString();
        double count = 0;
        try
        {
            count = Convert.ToDouble(TextBox2.Text.Trim().ToString());
        }
        catch(Exception ey) { }
        DateTime dt=Calendar1.SelectedDate;
        string ReMark = TextBox4.Text.Trim().ToString();
        if(OrderNO!="" && count!=0)
        {
            SqlConnection conn = new DataBase().getSqlConnection();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "select count(*) from 云南白药订单 where orderno='" + OrderNO + "'";
            try
            {
                conn.Open();
                if(cmd.ExecuteScalar().ToString()=="1")
                {
                    Response.Write("<script type='text/javascript'>alert('重复的订单')</script>");
                }
                else
                {
                    cmd.CommandText = "insert into 云南白药订单 values('" + OrderNO + "','" + product + "'," + count + ",'" + dt + "','" + ReMark + "','','','')";
                    if(cmd.ExecuteNonQuery()==1)
                    {
                        Response.Write("<script type='text/javascript'>alert('录入订单成功！')</script>");
                    }
                    else
                    {
                        Response.Write("<script type='text/javascript'>alert('录入订单失败！')</script>");
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