using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;


public partial class kunming_Product : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
                   new userAccess().getUserAccess("云南白药产品名称",1);
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
       
        string name = TextBox1.Text.Trim().ToString();
        if(name.Length!=0)
        {
            SqlConnection conn = new DataBase().getSqlConnection();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "select count(*) from 白药产品名称 where name='" + name + "'";
            try
            {
                conn.Open();
                if(cmd.ExecuteScalar().ToString()=="1")
                {
                    Response.Write("<script type='text/javascript'>alert('重复的产品名称')</script>");
                }
                else
                {
                    cmd.CommandText = "insert into 白药产品名称 values('" + name + "')";
                    if(cmd.ExecuteNonQuery()==1)
                    {
                        Response.Write("<script type='text/javascript'>alert('录入新产品成功')</script>");
                    }
                    else
                    {
                        Response.Write("<script type='text/javascript'>alert('操作失败，请联系管理员！')</script>");
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