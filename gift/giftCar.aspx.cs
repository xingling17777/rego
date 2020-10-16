using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class gift_giftCar : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["userName"] == null)
        {
            Response.Redirect("login.aspx");
        }
        else
        {
            TableRow row1 = new TableRow();
            TableCell cell1 = new TableCell();
            cell1.Text = "序号";
            TableCell cell2 = new TableCell();
            cell2.Text = "名称";
            TableCell cell3 = new TableCell();
            cell3.Text = "图片";
            TableCell cell4 = new TableCell();
            cell4.Text = "数量";
            TableCell cell5 = new TableCell();
            cell5.Text = "选择";
            
            row1.Cells.Add(cell1);
            row1.Cells.Add(cell2);
            row1.Cells.Add(cell3);
            row1.Cells.Add(cell4);
            row1.Cells.Add(cell5);
            Table1.Rows.Add(row1);
            //TODO:开始加载,图片暂时不做
            SqlConnection conn = new DataBase().getSqlConnection();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "select * from giftCar where userID='" + Session["userID"] + "' order by giftID;";
            try
            {
                conn.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
            }
            catch(Exception ey) { }
            finally
            {
                conn.Close();
            }
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {

    }
}