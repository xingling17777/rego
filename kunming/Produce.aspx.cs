using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Web.SessionState;

public partial class kunming_Translate : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            new userAccess().getUserAccess("云南白药生产送库",1);            
            SqlConnection conn = new DataBase().getSqlConnection();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "select * from 云南白药订单 where finish='' order by id desc";
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
            cmd.CommandText = "select count from 云南白药订单 where id=" + DropDownList1.SelectedValue.ToString();
            try
            {
                conn.Open();
                double OrderCount = Convert.ToDouble(cmd.ExecuteScalar().ToString());
                cmd.CommandText = "select COALESCE(sum(producecount),0) from 云南白药生产 where orderid=" + DropDownList1.SelectedValue;
                if (OrderCount - Convert.ToDouble(cmd.ExecuteScalar().ToString()) >= count)
                {
                    cmd.CommandText = "insert into 云南白药生产 values(" + DropDownList1.SelectedValue.ToString() + "," + count + ",'" + Calendar1.SelectedDate + "','" + TextBox2.Text.Trim().ToString() + "')";                  
                        
                        if (cmd.ExecuteNonQuery() == 1)
                        {
                            Response.Write("<script type='text/javascript'>alert('生产录入成功！')</script>");
                        }
                        else
                        {
                            Response.Write("<script type='text/javascript'>alert('数据提交失败，请联系管理员！')</script>");
                        }                   
                }
                else
                {
                    Response.Write("<script type='text/javascript'>alert('订单超数！')</script>");
                }
            }

            catch (Exception ey) { }
            finally
            {
                conn.Close();
            }

        }
    }
}