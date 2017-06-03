using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class components_list : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            string id = "";
            if (Request["id"] != null)
            {
                id = Request["id"].ToString();
                SqlConnection conn = new DataBase().getSqlConnection();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "select * from 配件流水 where 配件编号 = " + id+" order by id desc";
                SqlDataReader sdr = null;
                try
                {
                    conn.Open();
                    sdr = cmd.ExecuteReader();
                    TableRow row1 = new TableRow();
                    TableCell cell11 = new TableCell();
                    cell11.Text = "日期";
                    row1.Cells.Add(cell11);
                    TableCell cell12 = new TableCell();
                    cell12.Text = "数量";
                    row1.Cells.Add(cell12);
                    TableCell cell13 = new TableCell();
                    cell13.Text = "人员";
                    row1.Cells.Add(cell13);
                    TableCell cell14 = new TableCell();
                    cell14.Text = "事项";
                    row1.Cells.Add(cell14);
                   
                    //row1.Style.Add("width","100%");
                    Table1.Rows.Add(row1);

                    while (sdr.Read())
                    {
                        TableRow row = new TableRow();
                        TableCell cell21 = new TableCell();
                        cell21.Text = Convert.ToDateTime(sdr[5].ToString()).ToShortDateString();
                        row.Cells.Add(cell21);
                        TableCell cell22 = new TableCell();
                        cell22.Text = sdr[2].ToString();
                        row.Cells.Add(cell22);
                        TableCell cell23 = new TableCell();
                        cell23.Text = sdr[3].ToString();
                        row.Cells.Add(cell23);
                        TableCell cell24 = new TableCell();
                        cell24.Text = sdr[4].ToString();
                        row.Cells.Add(cell24);
                        Table1.Rows.Add(row);
                    }

                }
                catch (Exception ex)

                {
                    Response.Write("数据库连接出错");
                }
                finally
                {
                    sdr.Close();
                    conn.Close();
                }
            }
            else
            {
                Response.Redirect("/components/componentslist.aspx");
            }
        }
    }
}
