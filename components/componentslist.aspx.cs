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
using NPOI.SS.UserModel;
using System.IO;

public partial class components_componentslist : System.Web.UI.Page
{
    string key = "where 库存!=0";
    ArrayList idst = new ArrayList();
    public void search()
    {
        TableRow row1 = new TableRow();
        TableCell cell1 = new TableCell();
        cell1.Wrap = true;
        cell1.Width = Unit.Pixel(120);
        cell1.Text = "配件名称";
        TableCell cell2 = new TableCell();
        cell2.Wrap = true;
        cell2.Width = Unit.Pixel(120);
        cell2.Text = "配件规格";
        TableCell cell3 = new TableCell();
        cell3.Wrap = true;
        cell3.Width = Unit.Pixel(80);
        cell3.Text = "实有库存";
        TableCell cell8 = new TableCell();
        cell8.Wrap = true;
        cell8.Width = Unit.Pixel(40);
        cell8.Text = "单位";
        TableCell cell7 = new TableCell();
        cell7.Wrap = true;
        cell7.Width = Unit.Pixel(80);
        cell7.Text = "最低库存";
        TableCell cell4 = new TableCell();
        cell4.Wrap = true;
        cell4.Width = Unit.Pixel(80);

        cell4.Text = "存放地点";
        TableCell cell5 = new TableCell();
        cell5.Wrap = true;
        cell5.Width = Unit.Pixel(120);
        cell5.Text = "使用部门及设备";
        TableCell cell6 = new TableCell();
        cell6.Wrap = true;
        cell6.Width = Unit.Pixel(120);
        cell6.Text = "查看流水";
       
        row1.Cells.Add(cell1);
        row1.Cells.Add(cell2);
        row1.Cells.Add(cell3);
        row1.Cells.Add(cell8);
        row1.Cells.Add(cell7);
        row1.Cells.Add(cell4);
        row1.Cells.Add(cell5);
        row1.Cells.Add(cell6);
       
        row1.Style.Add("position", "fixed");
        row1.Style.Add("background-color", "green");
        row1.Style.Add("color", "white");
        //row1.Style.Add("z-index", "-1");
        Table1.Rows.Add(row1);
        TableRow row2 = new TableRow();
        TableCell cel21 = new TableCell();
        cel21.Wrap = true;
        cel21.Width = Unit.Pixel(120);
        cel21.Text = "配件名称";
        TableCell cel22 = new TableCell();
        cel22.Wrap = true;
        cel22.Width = Unit.Pixel(120);
        cel22.Text = "配件规格";
        TableCell cel23 = new TableCell();
        cel23.Wrap = true;
        cel23.Width = Unit.Pixel(80);
        cel23.Text = "实有库存";
        TableCell cel28 = new TableCell();
        cel28.Wrap = true;
        cel28.Width = Unit.Pixel(40);
        cel28.Text = "单位";
        TableCell cell27 = new TableCell();
        cell27.Wrap = true;
        cell27.Width = Unit.Pixel(80);
        cell27.Text = "最低库存";
        TableCell cel24 = new TableCell();
        cel24.Wrap = true;
        cel24.Width = Unit.Pixel(80);
        cel24.Text = "存放地点";
        TableCell cel25 = new TableCell();
        cel25.Text = "使用部门及设备";
        cel25.Wrap = true;
        cel25.Width = Unit.Pixel(120);
        TableCell cel26 = new TableCell();
        cel26.Text = "查看流水";
        cel26.Wrap = true;
        cel26.Width = Unit.Pixel(120);
       
        row2.Cells.Add(cel21);
        row2.Cells.Add(cel22);
        row2.Cells.Add(cel23);
        row2.Cells.Add(cel28);
        row2.Cells.Add(cell27);
        row2.Cells.Add(cel24);
        row2.Cells.Add(cel25);
        row2.Cells.Add(cel26);
       
        row2.Style.Add("background-color", "green");
        row2.Style.Add("color", "white");
       
        Table1.Rows.Add(row2);

        SqlConnection conn = new DataBase().getSqlConnection();
        SqlCommand cmd = conn.CreateCommand();
        cmd.CommandText = "select 配件编号,name,type,库存,useage,address from 配件库存 " + key + " order by name,type";
        SqlDataReader sdr = null;
        try
        {
            conn.Open();
            sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                if (idst.Count != 0)
                {
                    if (!idst.Contains(sdr[0].ToString()))
                    {
                        continue;
                    }
                }
                TableRow row = new TableRow();
                TableCell k1 = new TableCell();
                k1.Width= Unit.Pixel(120);
                k1.Wrap = true;
                k1.Text = sdr[1].ToString();
                row.Cells.Add(k1);
                TableCell k2 = new TableCell();
                k2.Width = Unit.Pixel(120);
                k2.Wrap = true;
                k2.Text = sdr[2].ToString();
                row.Cells.Add(k2);
                TableCell k3 = new TableCell();
                k3.Width = Unit.Pixel(80);
                k3.Wrap = true;
                k3.Text = sdr[3].ToString();
                row.Cells.Add(k3);
                TableCell k8 = new TableCell();
                k8.Wrap = true;
                k8.Width = Unit.Pixel(40);
                SqlConnection cony = new DataBase().getSqlConnection();
                SqlCommand cmy = cony.CreateCommand();
                cmy.CommandText = "select lessat,unit from 配件基础信息 where id=" + sdr[0].ToString();
                cony.Open();
                SqlDataReader sdrr = cmy.ExecuteReader();
                if (sdrr.Read())
                {
                    k8.Text = sdrr[1].ToString();
                }
                
                row.Cells.Add(k8);
                TableCell k7 = new TableCell();
                k7.Text = sdrr[0].ToString();
                k7.Width = Unit.Pixel(80);
                k7.Wrap = true;
                row.Cells.Add(k7);
                cony.Close();
                TableCell k4 = new TableCell();
                k4.Width = Unit.Pixel(80);
                k4.Wrap = true;
                k4.Text = sdr[5].ToString();
                row.Cells.Add(k4);
                TableCell k5 = new TableCell();
                k5.Wrap = true;
                k5.Width = Unit.Pixel(120);
                k5.Text = sdr[4].ToString();
                row.Cells.Add(k5);
                TableCell k6 = new TableCell();
                LinkButton linkbtn = new LinkButton();
                linkbtn.PostBackUrl = "/components/list.aspx?id=" + sdr[0].ToString();
                linkbtn.Text = "查看流水";
                k6.Controls.Add(linkbtn);
                k6.Wrap = true;
                k6.Width = Unit.Pixel(120);
                row.Cells.Add(k6);
                //TableCell k7 = new TableCell();
                //LinkButton inkbtnfix = new LinkButton();
                //inkbtnfix.PostBackUrl = "/components////compentedit.aspx?id=" + sdr[0].ToString();
                //inkbtnfix.Text = "修改配件信息";
                // k7.Controls.Add(inkbtnfix);
                //k7.Wrap = true;
                // k7.Width = Unit.Pixel(120);
                //row.Cells.Add(k7);
                //row.Style.Add("z-index", "-2");
                Table1.Rows.Add(row);
            }
        }
        catch (Exception ex)
        {

        }
        finally
        {
            conn.Close();
        }
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        //DropDownList1.SelectedIndex = 0;
        this.Page.Form.DefaultButton = Button1.ClientID.Replace('_', '$');
        if (!IsPostBack)
        {
            this.search();
        }

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        if (DropDownList1.SelectedIndex != -1)
        {
            if(DropDownList1.SelectedIndex==0)
            {
                idst.Clear();
            }
            else
            {
                string cangku = DropDownList1.SelectedValue.ToString();
                SqlConnection conn = new DataBase().getSqlConnection();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "select id from 配件基础信息 where 仓库='" + cangku + "'";
                try
                {
                    conn.Open();
                    SqlDataReader sdr = cmd.ExecuteReader();
                    idst.Clear();
                    while (sdr.Read())
                    {
                        idst.Add(sdr[0].ToString());
                    }
                }

                catch (Exception ep)
                {

                }
                finally
                {
                    conn.Close();
                }
                if (idst.Count == 0)
                {
                    Response.Write("<script type='text/javascript'>alert('此仓库无数据记录，请重新查询！')</script>");
                    return;
                }
                else
                {
                   
                }
            }
            
            

        }
        if (CheckBox1.Checked == true)
        {
            key = "where 0 = 0";
        }
        else
        {
            key = "where 库存!=0";
        }
        //需要增加按部门检索
        key += "and (name like '%" + TextBox1.Text.Trim().ToString() + "%' or type like '%" + TextBox1.Text.Trim().ToString() + "%') ";

        this.search();
    }

    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
       if(DropDownList1.SelectedIndex==0)
        {
            idst.Clear();
        } 
    }

    protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
    {
        //if(CheckBox1.Checked==true)
        //{
        //    key= "where 0 = 0";
        //}
        //else
        //{
        //    key="where 库存!=0";
        //}
        //this.search();
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        if (Session["userName"] == null)
        {
            Session["url"] = Request.Url.ToString();
            Response.Redirect("/user/login.aspx");
        }
        HSSFWorkbook workbook = new HSSFWorkbook();
        ISheet sheet = workbook.CreateSheet();
        MemoryStream ms = new MemoryStream();
        SqlConnection conn = new DataBase().getSqlConnection();
        SqlCommand cmd = conn.CreateCommand();
        cmd.CommandText = "select name,type,库存,address from 配件库存 where 库存!=0";
        try
        {
            conn.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            IRow row1 = sheet.CreateRow(0);
            ICell cell01 = row1.CreateCell(0);
            cell01.SetCellValue("配件名称");
            ICell cell02 = row1.CreateCell(1);
            cell02.SetCellValue("规格");
            ICell cell03 = row1.CreateCell(2);
            cell03.SetCellValue("库存数量");
            ICell cell04 = row1.CreateCell(3);
            cell04.SetCellValue("存放地点");
            for (int m = 1; sdr.Read(); m++)
            {
                IRow row = sheet.CreateRow(m);
                for (int i = 0; i < sdr.FieldCount; i++)
                {
                    ICell cell = row.CreateCell(i);
                    cell.SetCellValue(sdr[i].ToString());
                }
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