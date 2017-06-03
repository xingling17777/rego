using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class system_log : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
if(!IsPostBack)
        {
            string sqlcmd = "select top 100 * from 系统日志 order by id desc";
            this.Display(sqlcmd);
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
       if(TextBox1.Text.Trim().ToString()!="")
        {
            string sqlcmd = "select * from 系统日志 where 用户姓名 like '%" + TextBox1.Text.Trim().ToString() + "%' or 操作内容 like '%" + TextBox1.Text.Trim().ToString() + "%' order by id desc";
            this.Display(sqlcmd);
        }
    }
    protected void Display(string strCMD)
    {
        if(strCMD!="")
        {
            TableCell cell11 = new TableCell();
            cell11.Text = "日期";
            TableCell cell12 = new TableCell();
            cell12.Text = "操作人员";
            TableCell cell13 = new TableCell();
            cell13.Text = "内容";
            TableRow row1 = new TableRow();
            row1.Style.Add("background-color", "green");
            row1.Style.Add("color", "white");
            row1.Cells.Add(cell11);
            row1.Cells.Add(cell12);
            row1.Cells.Add(cell13);
            Table1.Rows.Add(row1);
            SqlConnection conn = new DataBase().getSqlConnection();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = strCMD;
            try
            {
                conn.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                while(sdr.Read())
                {
                    TableCell cell21 = new TableCell();
                    cell21.Text = Convert.ToDateTime(sdr[2].ToString()).ToShortDateString();
                    TableCell cell22 = new TableCell();
                    cell22.Text = sdr[1].ToString();
                    TableCell cell23 = new TableCell();
                    cell23.Text = sdr[3].ToString();
                    TableRow row2 = new TableRow();
                    row2.Cells.Add(cell21);
                    row2.Cells.Add(cell22);
                    row2.Cells.Add(cell23);
                    Table1.Rows.Add(row2);
                }
            }catch(Exception ey) { }
            finally
            {
                conn.Close();
            }
        }
    }
}