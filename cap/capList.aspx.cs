using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class capList : System.Web.UI.Page
{ 
    protected void Page_Load(object sender, EventArgs e)
    {
if(!IsPostBack)
        {
            SqlConnection conn = new DataBase().getSqlConnection();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "select count(name) from cap";
            int count = 0;
            try
            {
                conn.Open();
                count = Convert.ToInt32(cmd.ExecuteScalar().ToString());
            }
            catch (Exception ee)
            {
                Response.Write("数据库打开失败！");
            }
            finally
            {
                conn.Close();
            }
            if(count!=0)
            {
                TableRow row1 = new TableRow();
                TableCell cell11 = new TableCell();
                cell11.Text = "帽盖名称";
                row1.Cells.Add(cell11);
                TableCell cell1 = new TableCell();
                cell1.Text = "模具编号";
                row1.Cells.Add(cell1);
                TableCell cell2 = new TableCell();
                cell2.Text = "每模（pcs）";
                row1.Cells.Add(cell2);
                TableCell cell3 = new TableCell();
                cell3.Text = "净重（g）";
                row1.Cells.Add(cell3);
                TableCell cell4 = new TableCell();
                cell4.Text = "日产（pcs）";
                row1.Cells.Add(cell4);
                TableCell cell5 = new TableCell();
                cell5.Text = "备注";
                row1.Cells.Add(cell5);
                Table1.Rows.Add(row1);
                cmd.CommandText = "select * from cap";
                SqlDataReader sdr;
                try
                {
                    conn.Open();
                    sdr = cmd.ExecuteReader();
                    while(sdr.Read())
                    {
TableRow row = new TableRow();
                        for(int i =0;i<7;i++)
                        {
                            if (i == 5)
                                continue;
                            TableCell cell = new TableCell();
                            cell.Text = sdr[i + 1].ToString();
                            row.Cells.Add(cell);
                        }
                        Table1.Rows.Add(row);
                    }
                   
                }
                catch(Exception se)
                {

                }
                finally
                {
                    
                    conn.Close();
                }
               
            }
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("Cap.aspx");
    }
}