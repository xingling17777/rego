using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class other_009 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        if(TextBox1.Text!="")
        { 
        SqlConnection conn = new SqlConnection("server=192.168.0.18;database=XinWa_Elector_DB;uid=sa;pwd=REgo123456");
        SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "select 印刷版号 from Pro_生产工艺子表 where 生产单号 like (select 生产单号 from Pro_生产单主表 where 订单编号 like '"+ TextBox1.Text.Trim().ToString()+"')";
            try
            {
                conn.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                while(sdr.Read())
                {
                    Label1.Text = "订单号"+TextBox1.Text + "对应的印刷版号为：" + sdr[0].ToString();
                    TextBox1.Text = "";
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
    }
}