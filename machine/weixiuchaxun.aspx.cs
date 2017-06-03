using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Collections;

public partial class machine_weixiuchaxun : System.Web.UI.Page
{
    Hashtable tb=new Hashtable();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["userName"] == null)
        {
            Session["url"] = Request.Url.ToString();
            Response.Redirect("/user/login.aspx");
        }
        SqlConnection conn = new DataBase().getSqlConnection();
        SqlCommand cmd = conn.CreateCommand();
        cmd.CommandText = "select id,设备名称 from machine";
        try
        {
            conn.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            tb.Clear();
            while (sdr.Read())
            {
                tb.Add(sdr[0].ToString(),sdr[1].ToString());
            }
        }
        catch (Exception ey)
        {

        }
        finally
        {
            conn.Close();
        }
        this.dis();
    }
    public void dis()
    {
        TableCell cell1 = new TableCell();
        cell1.Text = "报修日期";
        TableCell cell2 = new TableCell();
        cell2.Text = "报修人员";
        TableCell cell3 = new TableCell();
        cell3.Text = "设备名称";
        TableCell cell4 = new TableCell();
        cell4.Text = "故障描述";
        TableCell cell5 = new TableCell();
        cell5.Text = "原因分析";
        TableCell cell6 = new TableCell();
        cell6.Text = "解决方案";
        TableCell cell7 = new TableCell();
        cell7.Text = "维修人员";
        TableCell cell8 = new TableCell();
        cell8.Text = "维修日期";
        TableCell cell9 = new TableCell();
        cell9.Text = "维修处理";
        TableRow row1 = new TableRow();
        row1.Cells.Add(cell1);
        row1.Cells.Add(cell2);
        row1.Cells.Add(cell3);
        row1.Cells.Add(cell4);
        row1.Cells.Add(cell5);
        row1.Cells.Add(cell6);
        row1.Cells.Add(cell7);
        row1.Cells.Add(cell8);
        row1.Cells.Add(cell9);
        TableCell cell10 = new TableCell();
        row1.Style.Add("background-color", "green");
        row1.Style.Add("color", "white");
        cell10.Text = "维修处理";
        Table1.Rows.Add(row1);
        SqlConnection conn = new DataBase().getSqlConnection();
        SqlCommand cmd = conn.CreateCommand();
        cmd.CommandText = "select * from 维修记录 order by id desc";
        try
        {
            conn.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                TableCell cella = new TableCell();
                cella.Width = Unit.Pixel(80);
               if(sdr[2].ToString()!="")
                { 
                cella.Text = Convert.ToDateTime(sdr[2].ToString()).ToShortDateString();
                    //报修日期
                }
                TableCell cellb = new TableCell();
                cellb.Width = Unit.Pixel(80);
                cellb.Text = sdr[4].ToString();//报修人员
                TableCell cellc = new TableCell();
                cellc.Width = Unit.Pixel(80);
                cellc.Text = tb[sdr[1].ToString()].ToString();//设备名称
                TableCell celld = new TableCell();
                celld.Text = sdr[3].ToString();//故障描述
                TableCell celle = new TableCell();
                celle.Text = sdr[6].ToString();//原因分析
                TableCell cellf = new TableCell();
                cellf.Text = sdr[7].ToString();//解决方案
                TableCell cellg = new TableCell();
                cellg.Text = sdr[8].ToString();//解决人员
                cellg.Width = Unit.Pixel(80);
                TableCell cellh = new TableCell();
                cellh.Width = Unit.Pixel(80);
                if (sdr[9].ToString()!="")
                { 
                cellh.Text = Convert.ToDateTime(sdr[9].ToString()).ToShortDateString();//维修日期
                }
                TableCell cellk = new TableCell();
                cellk.Width = Unit.Pixel(80);
                //if (sdr[6].ToString() == "" || sdr[7].ToString()=="")
                {
                    LinkButton lkbtn = new LinkButton();
                    lkbtn.PostBackUrl = "/machine/shebeiweixiu.aspx?id="+sdr[0].ToString()+"&machineName="+cellc.Text.ToString();
                    lkbtn.Text = "维修设备";
                    cellk.Controls.Add(lkbtn);
                }
                TableRow row = new TableRow();
                row.Cells.Add(cella);
                row.Cells.Add(cellb);
                row.Cells.Add(cellc);
                row.Cells.Add(celld);
                row.Cells.Add(celle);
                row.Cells.Add(cellf);
                row.Cells.Add(cellg);
                row.Cells.Add(cellh);
                row.Cells.Add(cellk);
                Table1.Rows.Add(row);
            }
        }
        catch (Exception ey)
        {

        }
        finally
        {
            conn.Close();
        }
    }
}