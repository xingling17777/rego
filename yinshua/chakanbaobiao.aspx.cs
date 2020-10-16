using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class yinshua_chakanbaobiao : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
        {
            TableRow row1 = new TableRow();
            TableCell cell11 = new TableCell();
            cell11.Text = "日期";
            TableCell cell12 = new TableCell();
            cell12.Text = "订单号";
            TableCell cell13 = new TableCell();
            cell13.Text = "班次";
            TableCell cell14 = new TableCell();
            cell14.Text = "机台";
            TableCell cell15 = new TableCell();
            cell15.Text = "开机人员";
            TableCell cell16 = new TableCell();
            cell16.Text = "米数";
            TableCell cell17 = new TableCell();
            cell17.Text = "订单类型";
            row1.Cells.Add(cell11);
            row1.Cells.Add(cell12);
            row1.Cells.Add(cell13);
            row1.Cells.Add(cell14);
            row1.Cells.Add(cell15);
            row1.Cells.Add(cell16);
            row1.Cells.Add(cell17);
            Table1.Rows.Add(row1);
            SqlConnection conn = new SqlConnection("server=192.168.0.18;database=rego;uid=sa;pwd=REgo123456;MultipleActiveResultSets=true");
        SqlCommand cmd = conn.CreateCommand();
        cmd.CommandText = "select top 30 * from 报表录入 order by id desc";
            try
            {
                conn.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                while(sdr.Read())
                {
                    TableRow row = new TableRow();
                    TableCell cell21 = new TableCell();
                    cell21.Text = sdr[1].ToString();
                    TableCell cell22 = new TableCell();
                    cell22.Text = sdr[2].ToString();
                    TableCell cell23 = new TableCell();
                    cell23.Text = sdr[3].ToString();
                    TableCell cell24 = new TableCell();
                    cell24.Text = sdr[4].ToString();
                    TableCell cell25 = new TableCell();
                    cell25.Text = sdr[5].ToString();
                    TableCell cell26 = new TableCell();
                    cell26.Text = sdr[6].ToString();
                    TableCell cell27 = new TableCell();
                    cell27.Text = sdr[7].ToString();
                    row.Cells.Add(cell21);
                    row.Cells.Add(cell22);
                    row.Cells.Add(cell23);
                    row.Cells.Add(cell24);
                    row.Cells.Add(cell25);
                    row.Cells.Add(cell26);
                    row.Cells.Add(cell27);
                    Table1.Rows.Add(row);
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