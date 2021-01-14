using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;


public partial class 工艺单_产品清单 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        if(TextBox1.Text!="")
        {
            string keyString = TextBox1.Text.Trim().ToString();
            SqlConnection conn = new DataBase().getSqlConnection();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "select * from 产品编码_产品 where name like '%" + keyString + "%'";
            SqlDataReader sdr = null; ;
            try
            {
                conn.Open();
                sdr = cmd.ExecuteReader();
                while(sdr.Read())
                {

                }
            }
            catch (Exception ey) { }
            finally
            {
                sdr.Close();
                conn.Close();
            }
        }
    }
}