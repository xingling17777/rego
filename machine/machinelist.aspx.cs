using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.IO;

public partial class machine_machinelist : System.Web.UI.Page
{
    string order = "select * from machine order by 设备编号";
    string  des;
    public void display()
    {
        SqlConnection conn = new DataBase().getSqlConnection();
        SqlCommand cmd = conn.CreateCommand();
        cmd.CommandText = order;
        SqlDataReader sdr;
        try
        {
            conn.Open();
            sdr = cmd.ExecuteReader();
            TableRow row1 = new TableRow();
            row1.Style.Add("background-color", "green");
            row1.Style.Add("color", "white");
            TableCell cells = new TableCell();
            cells.Text = "维修/保养信息";
            row1.Cells.Add(cells);
            TableCell cell11 = new TableCell();
            cell11.Text = "设备编号";
            row1.Cells.Add(cell11);
            TableCell cell1 = new TableCell();
            cell1.Text = "设备类型";
            row1.Cells.Add(cell1);
            TableCell cell2 = new TableCell();
            cell2.Text = "设备名称";
            row1.Cells.Add(cell2);
            TableCell cell3 = new TableCell();
            cell3.Text = "型号规格";
            row1.Cells.Add(cell3);
            TableCell cell4 = new TableCell();
            cell4.Text = "功率";
            row1.Cells.Add(cell4);
            TableCell cell5 = new TableCell();
            cell5.Text = "出厂编号";
            row1.Cells.Add(cell5);
            TableCell cell6 = new TableCell();
            cell6.Text = "进厂日期";
            row1.Cells.Add(cell6);
            TableCell cell7 = new TableCell();
            cell7.Text = "生产厂家";
            row1.Cells.Add(cell7);
            TableCell cell8 = new TableCell();
            cell8.Text = "安装地点";
            row1.Cells.Add(cell8);
            TableCell cell9 = new TableCell();
            cell9.Text = "状态";
            row1.Cells.Add(cell9);
            TableCell ces = new TableCell();
            ces.Text = "更新资料";row1.Cells.Add(ces);
            Table1.Rows.Add(row1);
            while (sdr.Read())
            {

                TableRow row = new TableRow();
                TableCell cellk = new TableCell();
                LinkButton linkbtn = new LinkButton();
                linkbtn.Text = "查看详情";
                linkbtn.PostBackUrl = "/machine/machinelvli.aspx?id=" + sdr[0].ToString();
                cellk.Controls.Add(linkbtn);
                row.Cells.Add(cellk);
                for (int i = 0; i < 10; i++)
                {
                    TableCell cell = new TableCell();
                    cell.Text = sdr[i + 1].ToString();
                    row.Cells.Add(cell);
                }
                TableCell cellkk = new TableCell();
                //LinkButton linkbtnk = new LinkButton();
                //linkbtnk.Text = "删除设备";
                //linkbtnk.PostBackUrl = "/machine/machinedel.aspx?id=" + sdr[0].ToString()+"&action=delete";
                //cellkk.Controls.Add(linkbtnk);
                LinkButton linkbtnedit = new LinkButton();
                linkbtnedit.Text = "修改设备资料";
                linkbtnedit.PostBackUrl= "/machine/machinedel.aspx?id=" + sdr[0].ToString() + "&action=edit";
                cellkk.Controls.Add(linkbtnedit);
                row.Cells.Add(cellkk);
                try
                {
                    row.Cells[7].Text = (Convert.ToDateTime(row.Cells[7].Text)).ToShortDateString();
                }
                catch (Exception ey)
                { }
                finally { }
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
        if (Session["userName"] == null)
        {
            Session["url"] = Request.Url.ToString();
            Response.Redirect("/user/login.aspx");
        }
        if (!IsPostBack)
        {
            drporder.SelectedIndex = 1;
            this.display();
        }
    }


    protected void drporder_SelectedIndexChanged(object sender, EventArgs e)
    {
        if(drporder.SelectedIndex!=-1)
        {
            order= "select * from machine order by "+drporder.SelectedValue.ToString();
            orderbyasc.SelectedIndex = 0;
            this.display();
        }
    }

    protected void orderbyasc_SelectedIndexChanged(object sender, EventArgs e)
    {
        if(orderbyasc.SelectedIndex!=-1)
        {
            
            if(orderbyasc.SelectedIndex==0)
            {
                order = "select * from machine order by " + drporder.SelectedValue.ToString();
            }
            else
            {
                order = "select * from machine order by " + drporder.SelectedValue.ToString()+" desc";
            }
            
            this.display();
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
      
        Response.Redirect("http://192.168.0.18/file/设备台账.xls");
    }
}