using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class technology_reset : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["userName"] == null)
        {
            Session["url"] = Request.Url.ToString();
            Response.Redirect("../user/login.aspx");
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        if(TextBox1.Text.Trim().ToString()=="hundun")
        {
            SqlConnection conn = new DataBase().getSqlConnection();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "delete from lastvisityinban";
            try
            {
                conn.Open();
               if( cmd.ExecuteNonQuery()>0)
                {
                    Response.Write("<script language=javascript>alert('已执行！')</script>");
                }
            }
            catch(Exception ey)
            {

            }
            finally
            {
                conn.Close();
            }
        }
    }
}