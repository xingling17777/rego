using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class machine_machinelvli : System.Web.UI.Page
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
            string id = "";
            if (Request["id"] != null)
            {
                id = Request["id"].ToString();
                SqlConnection conn = new DataBase().getSqlConnection();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "select * from machine where id = "+id;
                SqlDataReader sdr = null;
                try
                {
                    conn.Open();
                    sdr = cmd.ExecuteReader();
                    if (sdr.Read())
                    {
                        TableRow row1 = new TableRow();
                        TableCell cell11 = new TableCell();
                        TableCell cell12 = new TableCell();
                        cell12.ColumnSpan = 3;
                        cell11.Text = "设备名称";
                        row1.Cells.Add(cell11);
                        cell12.Text = sdr[3].ToString();
                        row1.Cells.Add(cell12);
                        Table1.Rows.Add(row1);
                        TableRow row2 = new TableRow();
                        TableCell cell22 = new TableCell();
                        TableCell cell21 = new TableCell();
                        cell21.Text = "设备规格";
                        cell22.ColumnSpan = 3;
                        cell22.Text = sdr[4].ToString();
                        row2.Cells.Add(cell21);
                        row2.Cells.Add(cell22);
                        Table1.Rows.Add(row2);
                        TableRow row3 = new TableRow();
                        TableCell cell32 = new TableCell();
                        TableCell cell31 = new TableCell();
                        cell32.ColumnSpan = 3;
                        cell31.Text = "出厂编号";
                        cell32.Text = sdr[6].ToString();
                        row3.Cells.Add(cell31);
                        row3.Cells.Add(cell32);
                        Table1.Rows.Add(row3);
                        TableRow row4 = new TableRow();
                        TableCell cell42 = new TableCell();
                        TableCell cell41 = new TableCell();
                        cell41.Text = "内部编号";
                        cell42.Text = sdr[1].ToString();
                        cell42.ColumnSpan = 3;
                        row4.Cells.Add(cell41);
                        row4.Cells.Add(cell42);
                        Table1.Rows.Add(row4);
                        TableRow row5 = new TableRow();
                        TableCell cell52 = new TableCell();
                        TableCell cell51 = new TableCell();
                        cell51.Text = "供应商";
                        cell52.Text = sdr[8].ToString();
                        cell52.ColumnSpan = 3;
                        row5.Cells.Add(cell51);
                        row5.Cells.Add(cell52);
                        Table1.Rows.Add(row5);
                        TableRow row6= new TableRow();
                        TableCell cell62 = new TableCell();
                        TableCell cell61 = new TableCell();
                        cell62.ColumnSpan = 3;
                        cell61.Text = "购置日期";
                        cell62.Text = Convert.ToDateTime(sdr[7].ToString()).ToShortDateString();
                        
                        row6.Cells.Add(cell61);
                        row6.Cells.Add(cell62);
                        Table1.Rows.Add(row6);
                        TableRow row7 = new TableRow();
                        TableCell cell72 = new TableCell();
                        TableCell cell71 = new TableCell();
                        cell71.Text = "使用部门";
                        cell72.Text = sdr[9].ToString();
                        cell72.ColumnSpan = 3;
                        row7.Cells.Add(cell71);
                        row7.Cells.Add(cell72);
                        Table1.Rows.Add(row7);
                        TableRow row8 = new TableRow();
                        TableCell cell81 = new TableCell();
                        TableCell cell82 = new TableCell();
                        TableCell cell83 = new TableCell();
                        TableCell cell84 = new TableCell();
                        TableCell cell85 = new TableCell();
                        cell81.Text = "日期";
                        //cell81.Style.Add("width","10%");
                        cell82.Text = "保养内容";

                        //cell82.Style.Add("width", "60%");
                        cell83.Text = "保养人";
                        //cell83.Style.Add("width", "18%");
                        row8.Cells.Add(cell81);
                        row8.Cells.Add(cell82);
                        
                       
                        row8.Cells.Add(cell83);
                        Table1.Rows.Add(row8);
                        //待增加只检索最近12次保养纪录.
                        cmd.CommandText = "select top 8 * from 设备保养记录 where MachineID="+id+" order by id desc";
                        sdr.Close();
                        sdr = cmd.ExecuteReader();
                        while(sdr.Read())
                        {
                            TableRow row = new TableRow();
                            for(int i=0;i<3;i++)
                            {
                                TableCell cell = new TableCell();
                                cell.Text = sdr[i+2].ToString();
                                row.Cells.Add(cell);
                            }
                            TableCell cellx = new TableCell();
                            LinkButton lnkbtn = new LinkButton();
                            lnkbtn.Text = "删除该条记录";
                            lnkbtn.PostBackUrl = "/other/lst.aspx?id="+sdr[0].ToString()+"&action=delete";
                            cellx.Controls.Add(lnkbtn);
                            row.Cells.Add(cellx);
                            try
                            {
                                row.Cells[0].Text = (Convert.ToDateTime(row.Cells[0].Text)).ToShortDateString();
                            }
                            catch(Exception ey)
                            { }
                            finally { }
                            Table1.Rows.Add(row);
                        }
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
                Response.Redirect("/machine/machinelist.aspx");
            }
        }
    }
}