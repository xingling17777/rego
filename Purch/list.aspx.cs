using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class Purch_list : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["userName"] == null)
        {
            Session["url"] = Request.Url.ToString();
            Response.Redirect("/user/login.aspx");
        }
        else
        {
            SqlConnection conn = new DataBase().getSqlConnection();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "select * from 用户权限 where no=" + Session["userID"].ToString() + " and 功能='报价清单'";
            try
            {
                conn.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                if (sdr.Read())
                {
                    if (sdr[6].ToString() == "1")
                    {

                    }
                    else
                    {
                        Response.Write("<script type=text/javascript>alert('没有此权限，即将退出！')</script>");
                        Response.Redirect("/Default.aspx");
                    }
                }
                else
                {
                    Response.Write("<script type=text/javascript>alert('没有此权限，即将退出！')</script>");
                    Response.Redirect("/Default.aspx");
                }
            }
            catch (Exception ey) { }
            finally
            {
                conn.Close();
            }
        }
        if (!IsPostBack)
        {
            SqlConnection conn = new DataBase().getSqlConnection();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "select id,昵称 from 客户信息 order by 昵称";
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();

                }
                SqlDataReader sdr = cmd.ExecuteReader();
                DropDownList1.Items.Clear();
                while (sdr.Read())
                {
                    DropDownList1.Items.Add(new ListItem(sdr[1].ToString(), sdr[0].ToString()));
                }
            }
            catch (Exception ey) { }
            finally
            {
                if (conn.State != ConnectionState.Closed)
                {
                    conn.Close();
                }
            }
            if (DropDownList1.Items.Count != 0)
            {
                this.Display(DropDownList1.Items[0].Value.ToString());
            }
        }

    }

    public void Display(string id)
    {
        TableRow row1 = new TableRow();
        row1.Style.Add("background-color", "green");
        row1.Style.Add("color", "white");
        TableCell cellxy = new TableCell();
        cellxy.Text = "项目名称";
        row1.Cells.Add(cellxy);
        TableCell cell10 = new TableCell();
        cell10.Text = "类别";
        row1.Cells.Add(cell10);
        TableCell cell11 = new TableCell();
        cell11.Text = "产品名称";
        row1.Cells.Add(cell11);
        TableCell cell12 = new TableCell();
        cell12.Text = "规格";
        row1.Cells.Add(cell12);
        TableCell cell13 = new TableCell();
        cell13.Text = "片材";
        row1.Cells.Add(cell13);
        TableCell cell14 = new TableCell();
        cell14.Text = "印刷";
        row1.Cells.Add(cell14);
        TableCell cell15 = new TableCell();
        cell15.Text = "封膜";
        row1.Cells.Add(cell15);
        TableCell cell16 = new TableCell();
        cell16.Text = "盖子";
        row1.Cells.Add(cell16);

        TableCell cell17 = new TableCell();
        cell17.Text = "封尾";
        row1.Cells.Add(cell17);
        TableCell cell18 = new TableCell();
        cell18.Text = "运输";
        row1.Cells.Add(cell18);
        TableCell cell19 = new TableCell();
        cell19.Text = "数量";
        row1.Cells.Add(cell19);
        TableCell cell120 = new TableCell();
        cell120.Text = "含税";
        row1.Cells.Add(cell120);
        TableCell cell122 = new TableCell();
        cell122.Text = "日期";
        row1.Cells.Add(cell122);
        TableCell cell121 = new TableCell();
        cell121.Text = "价格";
        row1.Cells.Add(cell121);
        Table1.Rows.Add(row1);
        SqlConnection conn = new DataBase().getSqlConnection();
        SqlCommand cmd = conn.CreateCommand();
        cmd.CommandText = "select * from 报价清单 where 客户=" + id + " order by 直径,管长,类别 ";
        try
        {
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();

            }
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                TableRow row = new TableRow();
                TableCell cellxz = new TableCell();
                cellxz.Text = sdr[17].ToString();
                row.Cells.Add(cellxz);
                TableCell cell20 = new TableCell();
                cell20.Text = sdr[3].ToString();
                row.Cells.Add(cell20);
                TableCell cell21 = new TableCell();
                cell21.Text = sdr[2].ToString();
                row.Cells.Add(cell21);
                TableCell cell22 = new TableCell();
                cell22.Text = sdr[4].ToString() + "*" + sdr[5].ToString();
                row.Cells.Add(cell22);
                TableCell cell23 = new TableCell();
                if (sdr[6].ToString() != "")
                {
                    SqlConnection conm = new DataBase().getSqlConnection();
                    SqlCommand comn = conm.CreateCommand();
                    comn.CommandText = "select 规格 from 片材规格 where id=" + sdr[6].ToString();
                    try
                    {
                        conm.Open();
                        cell23.Text = comn.ExecuteScalar().ToString();
                    }
                    catch (Exception ey) { }
                    finally
                    {
                        conm.Close();
                    }
                    row.Cells.Add(cell23);
                    TableCell cell24 = new TableCell();
                    cell24.Text = sdr[7].ToString();
                    row.Cells.Add(cell24);
                    TableCell cell25 = new TableCell();
                    cell25.Text = sdr[8].ToString();
                    row.Cells.Add(cell25);
                    TableCell cell26 = new TableCell();
                    cell26.Text = sdr[9].ToString();
                    row.Cells.Add(cell26);
                    TableCell cell27 = new TableCell();
                    cell27.Text = sdr[10].ToString();
                    row.Cells.Add(cell27);
                    TableCell cell28 = new TableCell();
                    cell28.Text = sdr[11].ToString();
                    row.Cells.Add(cell28);
                    TableCell cell29 = new TableCell();
                    cell29.Text = sdr[12].ToString();
                    row.Cells.Add(cell29);
                    TableCell cell210 = new TableCell();
                    cell210.Text = sdr[13].ToString();
                    row.Cells.Add(cell210);
                    TableCell cell211 = new TableCell();
                    cell211.Text = Convert.ToDateTime(sdr[15].ToString()).ToShortDateString();
                    row.Cells.Add(cell211);
                    TableCell cell212 = new TableCell();
                    cell212.Text = sdr[14].ToString();
                    row.Cells.Add(cell212);
                    TableCell cell213 = new TableCell();
                    LinkButton btn = new LinkButton();
                    btn.Text = "复制";
                    btn.PostBackUrl = "/Purch/addpur.aspx?id=" + sdr[0].ToString();
                    cell213.Controls.Add(btn);
                    row.Cells.Add(cell213);
                    Table1.Rows.Add(row);
                }
            }
        }
        catch (Exception ey) { }
        finally
        {
            if (conn.State != ConnectionState.Closed)
            {
                conn.Close();
            }
        }
    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (DropDownList1.SelectedIndex != -1)
        {
            this.Display(DropDownList1.SelectedValue.ToString());
        }
    }
}