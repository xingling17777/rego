using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class kunming_Translate : System.Web.UI.Page
{
    
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
        {
            //new userAccess().getUserAccess("云南白药产品入库", 1);
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        double count = 0;
        try
        {
            count = Convert.ToDouble(TextBox1.Text.Trim().ToString());
        }
        catch (Exception ey) { }
        if (count != 0)
        {
            SqlConnection conn = new DataBase().getSqlConnection();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = cmd.CommandText = "select COALESCE(sum(ordercount),0) from 云南白药入库 where orderid=" +Session["OrderID"].ToString();
            double RuKued = 0;
            try
            {
                conn.Open();
                RuKued = Convert.ToDouble(cmd.ExecuteScalar());
                cmd.CommandText = "select COALESCE(sum(productcount),0) from 云南白药送货 where orderid=" + Session["OrderID"].ToString();
                if (RuKued + count <= Convert.ToDouble(cmd.ExecuteScalar()))
                {
                    cmd.CommandText = "insert into 云南白药入库 values(" + Session["OrderID"].ToString() + "," + count + ",'" + Calendar1.SelectedDate + "','" + TextBox2.Text.Trim().ToString() + "')";

                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        Response.Write("<script type='text/javascript'>alert('入库录入成功！')</script>");
                    }
                    else
                    {
                        Response.Write("<script type='text/javascript'>alert('数据提交失败，请联系管理员！')</script>");

                    }

                }
            }
            catch (Exception ey)
            {

            }
            finally
            {
                conn.Close();
            }

        }
        else
        {
            Response.Write("<script type='text/javascript'>alert('累计入库数量超过已送货数量！')</script>");

        }
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
      string  OrderNO = TextBox3.Text.Trim().ToString();
        SqlConnection conn = new DataBase().getSqlConnection();
        SqlCommand cmd = conn.CreateCommand();
        cmd.CommandText = "select * from 云南白药订单 where finish='' and orderno="+OrderNO+" order by id desc";
        
        try
        {
            conn.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            string product="";
            while (sdr.Read())
            {
                Session["OrderID"]= sdr[0].ToString();
                product = sdr[2].ToString();
               
            }
            sdr.Close();
            cmd.CommandText = "select name from 白药产品名称 where id=" + product;
            Label1.Text = cmd.ExecuteScalar().ToString();
        }
        catch (Exception ey) { }
        finally
        {
            conn.Close();
        }
    }
}
