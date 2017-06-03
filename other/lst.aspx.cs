using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class other_lst : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request["id"] != null)
        {
            string id = Request["id"].ToString();
            SqlConnection conn = new DataBase().getSqlConnection();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "delete from 设备保养记录 where id = " + id;

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
                Response.Redirect("/machine/machinelist.aspx");
            }
        }
    }
}