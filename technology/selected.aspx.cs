using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class technology_selected : System.Web.UI.Page
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
            if(!IsPostBack)
            {
                TableRow row1 = new TableRow();
                TableCell cell11 = new TableCell();
                cell11.Text = "编号";
                TableCell cell12 = new TableCell();
                cell12.Text = "上次使用日期";
                row1.Cells.Add(cell11);
                row1.Cells.Add(cell12);
                Table1.Rows.Add(row1);
                SqlConnection conn = new DataBase().getSqlConnection();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "select top 30 no,lastdate from lastvisityinban order by lastdate";
                try
                {
                    conn.Open();
                    SqlDataReader sdr = cmd.ExecuteReader();
                    while(sdr.Read())
                    {
                        TableRow row2 = new TableRow();
                        TableCell cell21 = new TableCell();
                        string no = sdr[0].ToString();
                        SqlCommand cmx = conn.CreateCommand();
                        cmx.CommandText = "select no,version from 成品编码_印刷 where id=" + no;
                        SqlDataReader sdrx = cmx.ExecuteReader();
                        string version="";
                        while(sdrx.Read())
                        {
                            no = sdrx[0].ToString();
                            version = sdrx[1].ToString();
                        }
                        sdrx.Close();
                        cmx.CommandText = "select customer,no from 成品编码_产品 where id=" + no;
                        sdrx = cmx.ExecuteReader();
                        string customer = "";
                        while(sdrx.Read())
                        {
                            customer = sdrx[0].ToString();
                            no = sdrx[1].ToString();
                        }
                        sdrx.Close();
                        cmx.CommandText = "select no from 客户信息 where id=" + customer;
                        customer = cmx.ExecuteScalar().ToString();
                        cell21.Text = customer + string.Format("{0:000}", Convert.ToInt32(no)) + version;
                        TableCell cell22 = new TableCell();
                        cell22.Text =Convert.ToDateTime( sdr[1].ToString()).ToShortDateString();
                        row2.Cells.Add(cell21);
                        row2.Cells.Add(cell22);
                        Table1.Rows.Add(row2);
                    }
                }
                catch(Exception ey) {
                    Response.Write("<script language=javascript>alert('"+ey.Message+"')</script>");
                }
                finally
                {
                    conn.Close();
                }
            }
        }
    }
}