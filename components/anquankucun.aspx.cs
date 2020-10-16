using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class components_anquankucun : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["userName"] == null)
        {
            Session["url"] = Request.Url.ToString();
            Response.Redirect("../user/login.aspx");
        }
        if (!IsPostBack)
        {
            TableRow row1 = new TableRow();
            TableCell cell1 = new TableCell();
            cell1.Text = "配件名称";
            TableCell cell2 = new TableCell();
            cell2.Text = "配件规格";
            TableCell cell3 = new TableCell();
            cell3.Text = "实有库存";
            TableCell cell4 = new TableCell();
            cell4.Text = "最低库存";
            row1.Cells.Add(cell1);
            row1.Cells.Add(cell2);
            row1.Cells.Add(cell3);
            row1.Cells.Add(cell4);
            Table1.Rows.Add(row1);
            SqlConnection conn = new DataBase().getSqlConnection();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "select 配件编号,name,type,库存 from 配件库存 order by name,type";
            SqlDataReader sdr = null;
            SqlConnection comm = new DataBase().getSqlConnection();
            try
            {
                
                conn.Open();
                comm.Open();
                sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    
                    int m = Convert.ToInt32(sdr[3].ToString());
                    SqlCommand cmy = comm.CreateCommand();
                    cmy.CommandText = "select lessat from 配件基础信息 where id=" + sdr[0].ToString();
                  
                    if ((cmy.ExecuteScalar())!=null )
                    {
                        if(cmy.ExecuteScalar().ToString()=="")
                        {
                            continue;
                        }
                        
                        int n = Convert.ToInt32(cmy.ExecuteScalar().ToString());
                        if(n==0)
                        {
                            continue;
                        }
                        if(m>n)
                        {
                            continue;
                        }
                        else
                        {
                            m = n;
                        }
                    }
                        TableRow row = new TableRow();
                    TableCell cell11 = new TableCell();
                    cell11.Text = sdr[1].ToString();
                    row.Cells.Add(cell11);
                    TableCell cell12 = new TableCell();
                    cell12.Text = sdr[2].ToString();
                    row.Cells.Add(cell12);
                    TableCell cell13 = new TableCell();
                    cell13.Text = sdr[3].ToString();
                    row.Cells.Add(cell13);
                    TableCell cell14 = new TableCell();
                    cell14.Text =m.ToString();
                    row.Cells.Add(cell14);
                    Table1.Rows.Add(row);
                   
                }
            }
            catch(Exception ey)
            {

            }
            finally
            {
                comm.Close();
                conn.Close();
            }
        }
    }
}