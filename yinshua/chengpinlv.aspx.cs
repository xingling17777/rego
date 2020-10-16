using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Collections;
using System.IO;
using System.Text;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;

public partial class yinshua_chengpinlv : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        int month = Convert.ToInt32(DropDownList1.SelectedValue.ToString());
        int year = DateTime.Now.Year;
        if (month > DateTime.Now.Month)
        {
            year--;
        }
        DateTime dt1 = new DateTime(year, month, 1);
        DateTime dt2 = dt1.AddMonths(1).AddDays(-1);
        SqlConnection conn = new SqlConnection("server=192.168.0.18;database=rego;uid=sa;pwd=REgo123456;MultipleActiveResultSets=true");
        SqlCommand cmd = conn.CreateCommand();
        cmd.CommandText = "select orderNO,sum(sum) from 报表录入 where date between '" + dt1 + "' and '" + dt2 + "' group by orderNO";
        
        TableRow row11 = new TableRow();
        TableCell cell11 = new TableCell();
        cell11.Text = "订单号";
        TableCell cell12 = new TableCell();
        cell12.Text = "客户名称";
        TableCell cell13 = new TableCell();
        cell13.Text = "产品名称";
        TableCell cell14 = new TableCell();
        cell14.Text = "印刷成品率";
        TableCell cell15 = new TableCell();
        cell15.Text = "制管成品率";

        row11.Cells.Add(cell11);
        row11.Cells.Add(cell12);
        row11.Cells.Add(cell13);
        row11.Cells.Add(cell14);
        row11.Cells.Add(cell15);
        Table1.Rows.Add(row11);
        SqlDataReader sdr;
        try
        {
            conn.Open();
            sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                string orderNo = sdr[0].ToString();
                double printWeb = Convert.ToDouble(sdr[1].ToString());
                SqlCommand cmz = conn.CreateCommand();
                cmz.CommandText = "select width,sum(sum) from 领料录入 where orderNO='" + orderNo + "' group by width";
                SqlDataReader sdz = cmz.ExecuteReader();
                double width = 0;
                double sum = 0;
                while(sdz.Read())
                {
                    width = Convert.ToDouble(sdz[0].ToString());
                    sum = Convert.ToDouble(sdz[1].ToString());
                }
                double chengpinlv = 0;
                string customerName="", productName="";
                double dia=0;
                double length = 0;
                SqlCommand cmk = conn.CreateCommand();
                cmk.CommandText = "select * from 订单描述 where orderNO='" + orderNo + "'";
                SqlDataReader sdd = cmk.ExecuteReader();
                while(sdd.Read())
                {
                    customerName = sdd[2].ToString();
                    productName = sdd[3].ToString();
                    dia = Convert.ToDouble(sdd[6].ToString());
                  length = Convert.ToDouble(sdd[7].ToString());
                }
                chengpinlv = printWeb / (sum / width*1000 * Math.Round(width / 3.14 / dia)) * 100;
                sdd.Close();
                cmk.CommandText= "select sum(sum) from 制管报表 where orderNO='" + orderNo + "'";
                string TubeCount = cmk.ExecuteScalar().ToString();
                int tubeCount = 0;
                if(TubeCount!="")
                {
                    try
                    { 
                    tubeCount = Convert.ToInt32(TubeCount);
                    }
                    catch(Exception ey) { tubeCount = 0; }
                }
                double tubeChengpinlv = 0;
                tubeChengpinlv = tubeCount / (printWeb * 0.97 * Math.Round(width / 3.14 / dia)/length*1000)*100;
                                TableRow row = new TableRow();
                TableCell cell1 = new TableCell();
                cell1.Text = orderNo;
                TableCell cell2 = new TableCell();
                cell2.Text = customerName;
                TableCell cell3 = new TableCell();
                cell3.Text = productName;
                TableCell cell4 = new TableCell();
                cell4.Text = chengpinlv.ToString("#0.00") + "%";
                TableCell cell5 = new TableCell();
                cell5.Text = tubeChengpinlv.ToString("#0.00") + "%";
                row.Cells.Add(cell1);
                row.Cells.Add(cell2);
                row.Cells.Add(cell3);
                row.Cells.Add(cell4);
                row.Cells.Add(cell5);
                Table1.Rows.Add(row);
            }
        }
        catch (Exception ey) { }
        finally
        {
            conn.Close();
        }
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        if(FileUpload1.HasFile)
        {
            if (Path.GetExtension(FileUpload1.FileName) != ".txt")
            {

                return;
            }
            string savePath = Server.MapPath("~/upload/");
            //检查服务器上是否存在这个物理路径，如果不存在则创建
            if (System.IO.Directory.Exists(savePath))
            {
                Directory.Delete(savePath, true);
            }
                if (!System.IO.Directory.Exists(savePath))
            {
                //需要注意的是，需要对这个物理路径有足够的权限，否则会报错
                //另外，这个路径应该是在网站之下，而将网站部署在C盘却把文件保存在D盘
                System.IO.Directory.CreateDirectory(savePath);
            }
            savePath = savePath + "\\" + DateTime.Now.ToString("yyyyMMddHHmmssfff") + FileUpload1.FileName;
            
            FileUpload1.SaveAs(savePath);
            FileStream fs = new FileStream(savePath ,FileMode.Open);
            StreamReader sr = new StreamReader(fs, Encoding.Default);
                        SqlConnection conn = new SqlConnection("server=192.168.0.18;database=rego;uid=sa;pwd=REgo123456;MultipleActiveResultSets=true");
            SqlCommand cmd = conn.CreateCommand();
            try
            {
                conn.Open();
                string s;
                while ((s = sr.ReadLine()) != "" && s != null)
                {

                    //if (al.Contains(s.Split('\t')[0].ToString()))
                    {
                        string gonghao = s.Split('\t')[0].ToString();
                        string tubeCount = s.Split('\t')[1].ToString();
                        
                        cmd.CommandText = "insert into 制管报表 values('" + gonghao + "'," + tubeCount +  ") ";
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ey) {  }
            finally
            {
                conn.Close();
            }
            sr.Close();
            fs.Close();


        }
        
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        HSSFWorkbook workbook = new HSSFWorkbook();
        ISheet sheet = workbook.CreateSheet();
        MemoryStream ms = new MemoryStream();
        int month = Convert.ToInt32(DropDownList1.SelectedValue.ToString());
        int year = DateTime.Now.Year;
        if (month > DateTime.Now.Month)
        {
            year--;
        }
        DateTime dt1 = new DateTime(year, month, 1);
        DateTime dt2 = dt1.AddMonths(1).AddDays(-1);
        SqlConnection conn = new SqlConnection("server=192.168.0.18;database=rego;uid=sa;pwd=REgo123456;MultipleActiveResultSets=true");
        SqlCommand cmd = conn.CreateCommand();
        cmd.CommandText = "select orderNO,sum(sum) from 报表录入 where date between '" + dt1 + "' and '" + dt2 + "' group by orderNO";

        IRow row1 = sheet.CreateRow(0);
        ICell cell11 = row1.CreateCell(0);
        cell11.SetCellValue("订单号");
        ICell cell12 = row1.CreateCell(1);
        cell12.SetCellValue("印刷成品率");
        ICell cell13 = row1.CreateCell(2);
        cell13.SetCellValue("制管成品率");
        SqlDataReader sdr;
        try
        {
            conn.Open();
            sdr = cmd.ExecuteReader();
            int m = 1;
            while (sdr.Read())
            {
                string orderNo = sdr[0].ToString();
                double printWeb = Convert.ToDouble(sdr[1].ToString());
                SqlCommand cmz = conn.CreateCommand();
                cmz.CommandText = "select width,sum(sum) from 领料录入 where orderNO='" + orderNo + "' group by width";
                SqlDataReader sdz = cmz.ExecuteReader();
                double width = 0;
                double sum = 0;
                while (sdz.Read())
                {
                    width = Convert.ToDouble(sdz[0].ToString());
                    sum = Convert.ToDouble(sdz[1].ToString());
                }
                double chengpinlv = 0;
                string customerName = "", productName = "";
                double dia = 0;
                double length = 0;
                SqlCommand cmk = conn.CreateCommand();
                cmk.CommandText = "select * from 订单描述 where orderNO='" + orderNo + "'";
                SqlDataReader sdd = cmk.ExecuteReader();
                while (sdd.Read())
                {
                    customerName = sdd[2].ToString();
                    productName = sdd[3].ToString();
                    dia = Convert.ToDouble(sdd[6].ToString());
                    length = Convert.ToDouble(sdd[7].ToString());
                }
                chengpinlv = printWeb / (sum / width * 1000 * Math.Round(width / 3.14 / dia)) * 100;
                sdd.Close();
                cmk.CommandText = "select sum(sum) from 制管报表 where orderNO='" + orderNo + "'";
                string TubeCount = cmk.ExecuteScalar().ToString();
                int tubeCount = 0;
                if (TubeCount != "")
                {
                    try
                    {
                        tubeCount = Convert.ToInt32(TubeCount);
                    }
                    catch (Exception ey) { tubeCount = 0; }
                }
                double tubeChengpinlv = 0;
                tubeChengpinlv = tubeCount / (printWeb * 0.97 * Math.Round(width / 3.14 / dia) / length * 1000) * 100;
                IRow row = sheet.CreateRow(m);
                ICell cell31 = row.CreateCell(1);
                cell31.SetCellValue(orderNo);
                ICell cell32= row.CreateCell(2);
                cell32.SetCellValue(chengpinlv);
                ICell cell33 = row.CreateCell(3);
                cell33.SetCellValue(tubeChengpinlv);
                m++;
                
            }
        }
        catch (Exception ey) { }
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