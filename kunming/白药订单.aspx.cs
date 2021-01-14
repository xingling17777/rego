using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class kunming_白药订单 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            //new userAccess().getUserAccess("云南白药客户订单", 1);
            SqlConnection conn = new DataBase().getSqlConnection();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "select * from 云南白药订单 order by id desc";
            DropDownList1.Items.Clear();
            try
            {
                conn.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
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
            if (DropDownList1.Items.Count != 0)
            {
                DropDownList1.SelectedIndex = 0;
            }
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        string BaiYaoOrder = TextBox1.Text.Trim().ToString();
        string PO = TextBox2.Text.Trim().ToString();
        string Order = DropDownList1.SelectedValue.ToString();
        SqlConnection conn = new DataBase().getSqlConnection();
        SqlCommand cmd = conn.CreateCommand();
        cmd.CommandText = "update 云南白药订单 set baiyaoorder='" + BaiYaoOrder + "',po='" + PO + "' where id=" + Order;
        try
        {
            conn.Open();
           if(cmd.ExecuteNonQuery()==1)
            {
                Response.Write("<script type='text/javascript'>alert('录入成功！')</script>");
            }
           else
            {
                Response.Write("<script type='text/javascript'>alert('录入失败，请联系管理员！')</script>");
            }
        }
        catch(Exception ey) { }
        finally
        {
            conn.Close();
        }
    }
}