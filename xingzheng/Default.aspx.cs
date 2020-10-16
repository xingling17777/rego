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

public partial class xingzheng_Default : System.Web.UI.Page
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
            cell11.Text = "日期";
            TableCell cell12 = new TableCell();
            cell12.Text = "物料";
            TableCell cell13 = new TableCell();
            cell13.Text = "数量";
            TableCell cell14 = new TableCell();
            cell14.Text = "部门";
            TableCell cell15 = new TableCell();
            cell15.Text = "姓名";
            row1.Cells.Add(cell11);
            row1.Cells.Add(cell12);
            row1.Cells.Add(cell13);
            row1.Cells.Add(cell14);
            row1.Cells.Add(cell15);
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
                while(sdr.Read())
                {
                    alindex.Add(sdr[0].ToString());
                    alvalue.Add(sdr[1].ToString());
                    alunit.Add(sdr[2].ToString());
                }
            }
            catch(Exception ey) { }
            finally
            {
                sdr.Close();
                conn.Close();
            }
            cmd.CommandText = "select top 30 * from 行政物料出入库 order by id desc";
            try
            {
                conn.Open();
                sdr = cmd.ExecuteReader();
                while(sdr.Read())
                {
                    TableRow row = new TableRow();
                    TableCell cell21 = new TableCell();
                    cell21.Text = Convert.ToDateTime(sdr[5].ToString()).ToShortDateString();
                    TableCell cell22 = new TableCell();
                    int x = alindex.IndexOf(sdr[1].ToString());
                    cell22.Text =alvalue[x].ToString();
                    TableCell cell23 = new TableCell();
                    cell23.Text = sdr[2].ToString()+alunit[x].ToString();
                    TableCell cell24 = new TableCell();
                    cell24.Text = sdr[3].ToString();
                    TableCell cell25 = new TableCell();
                    cell25.Text = sdr[4].ToString();
                    row.Cells.Add(cell21);
                    row.Cells.Add(cell22);
                    row.Cells.Add(cell23);
                    row.Cells.Add(cell24);
                    row.Cells.Add(cell25);
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
    public void Display()
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        HSSFWorkbook workbook = new HSSFWorkbook();
        MemoryStream ms = new MemoryStream();
        // 新增試算表。
        ISheet sheet = workbook.CreateSheet("行政物料出入库流水");
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
        cmd.CommandText = "select * from 行政物料出入库 order by id desc";        
        try
        {
            conn.Open();
            sdr = cmd.ExecuteReader();

            for (int m = 0; sdr.Read(); m++)
            {
                IRow row = sheet.CreateRow(m);
               ICell cell10 = row.CreateCell(0);
               cell10.SetCellValue(Convert.ToDateTime(sdr[5].ToString()).ToShortDateString());
                ICell cell11 = row.CreateCell(1);
                int x = alindex.IndexOf(sdr[1].ToString());
                cell11.SetCellValue(alvalue[x].ToString());
                ICell cell12 = row.CreateCell(2);
                cell12.SetCellValue(sdr[2].ToString() + alunit[x].ToString());
                ICell cell13 = row.CreateCell(3);
                cell13.SetCellValue(sdr[3].ToString());
                ICell cell14 = row.CreateCell(4);
                cell14.SetCellValue(sdr[4].ToString());
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