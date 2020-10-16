using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using NPOI.HSSF.UserModel;
using System.IO;
using NPOI.SS.UserModel;

public partial class other_sopo : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        HSSFWorkbook workbook = new HSSFWorkbook();
        MemoryStream ms = new MemoryStream();
        // 新增試算表。
        ISheet sheet = workbook.CreateSheet("PO");
        //IRow row = sheet.CreateRow(1);
        SqlConnection conn = new SqlConnection("server = 192.168.0.18; database = XinWa_Elector_DB; uid = sa; pwd = REgo123456; MultipleActiveResultSets = true");
        SqlCommand cmd = conn.CreateCommand();
        int n = 300;
        if(TextBox1.Text!="")
        {
            try
            {
                n = Convert.ToInt32(TextBox1.Text.Trim().ToString());
            }
            catch (Exception ey) { }

        }
        cmd.CommandText = "select top "+n+" 订单编号,客户订单号 from Pro_生产单主表 order by 订单编号 desc";
        SqlDataReader sdr = null;
               
        try
        {
            conn.Open();
            sdr = cmd.ExecuteReader();
            IRow row1 = sheet.CreateRow(0);
            ICell cell00 = row1.CreateCell(0);
            cell00.SetCellValue("订单号");
            ICell cell01 = row1.CreateCell(1);
            cell01.SetCellValue("客户PO号");
            for (int m = 1; sdr.Read(); m++)
            {
                IRow row = sheet.CreateRow(m);
                ICell cell10 = row.CreateCell(0);                
                cell10.SetCellValue(sdr[0].ToString());
                ICell cell11 = row.CreateCell(1);
                cell11.SetCellValue(sdr[1].ToString());
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