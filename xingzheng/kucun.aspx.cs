using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Collections;
using NPOI.HSSF.UserModel;
using System.IO;
using NPOI.SS.UserModel;

public partial class xingzheng_kucun : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["userName"] == null)
        {
            Session["url"] = Request.Url.ToString();
            Response.Redirect("../user/login.aspx");
        }
        else
        {
            TableRow row1 = new TableRow();
            row1.Style.Add("background-color", "green");
            row1.Style.Add("color", "white");
            TableCell cell11 = new TableCell();
            cell11.Text = "物料";
            TableCell cell13 = new TableCell();
            cell13.Text = "数量";
            row1.Cells.Add(cell11);
            row1.Cells.Add(cell13);
            Table1.Rows.Add(row1);
            SqlConnection conn = new DataBase().getSqlConnection();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "select * from 行政物料名称";
            SqlDataReader sdr = null;
            ArrayList alindex = new ArrayList();
            ArrayList alvalue = new ArrayList();
            ArrayList alunit = new ArrayList();
            try
            {
                conn.Open();
                sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    alindex.Add(sdr[0].ToString());
                    alvalue.Add(sdr[1].ToString());
                    alunit.Add(sdr[2].ToString());
                }
            }
            catch (Exception ey) { }
            finally
            {
                sdr.Close();
                conn.Close();
            }
            cmd.CommandText = "select 物料名称,sum(数量) as li from 行政物料出入库 group by 物料名称 order by li";
            try
            {
                conn.Open();
                sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    TableRow row = new TableRow();
                    TableCell cell21 = new TableCell();
                    int x = alindex.IndexOf(sdr[0].ToString());
                    cell21.Text = alvalue[x].ToString();
                    TableCell cell22 = new TableCell();
                    cell22.Text = sdr[1].ToString() + alunit[x].ToString();
                    row.Cells.Add(cell21);
                    row.Cells.Add(cell22);
                    Table1.Rows.Add(row);
                }
            }
            catch (Exception ey) { }
            finally
            {
                conn.Close();
            }
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        HSSFWorkbook workbook = new HSSFWorkbook();
        MemoryStream ms = new MemoryStream();
        // 新增試算表。
        ISheet sheet = workbook.CreateSheet("库存");
        //IRow row = sheet.CreateRow(1);
        SqlConnection conn = new DataBase().getSqlConnection();
        SqlCommand cmd = conn.CreateCommand();
        cmd.CommandText = "select * from 行政物料名称";
        SqlDataReader sdr = null;
        ArrayList alindex = new ArrayList();
        ArrayList alvalue = new ArrayList();
        ArrayList alunit = new ArrayList();
        try
        {
            conn.Open();
            sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                alindex.Add(sdr[0].ToString());
                alvalue.Add(sdr[1].ToString());
                alunit.Add(sdr[2].ToString());
            }
        }
        catch (Exception ey) { }
        finally
        {
            sdr.Close();
            conn.Close();
        }
        cmd.CommandText = "select 物料名称,sum(数量) as li from 行政物料出入库 group by 物料名称 order by li";
        try
        {
            conn.Open();
            sdr = cmd.ExecuteReader();

            for (int m = 0; sdr.Read(); m++)
            {
                IRow row = sheet.CreateRow(m);
                ICell cell10 = row.CreateCell(0);
                int x = alindex.IndexOf(sdr[0].ToString());
                cell10.SetCellValue(alvalue[x].ToString());
                ICell cell11 = row.CreateCell(1);                
                cell11.SetCellValue(sdr[1].ToString()+ alunit[x].ToString());               
            }
        }
        catch (SqlException ey) { }
        finally
        {
            conn.Close();
        }

        workbook.Write(ms);
        Response.AddHeader("Content-Disposition", string.Format("attachment; filename={0}.xls", DateTime.Now.ToString("yyyyMMddHHmmssfff")));
        Response.BinaryWrite(ms.ToArray());
        workbook = null;
        ms.Close();
        ms.Dispose();
    }
}