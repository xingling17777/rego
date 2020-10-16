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

public partial class technology_list_a : System.Web.UI.Page
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
            if (!IsPostBack)
            {
                DropDownList1.Items.Clear();
                ListBox1.Items.Clear();
                SqlConnection conn = new DataBase().getSqlConnection();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "select id,name from 客户信息 order by name";
                try
                {
                    conn.Open();
                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        DropDownList1.Items.Add(new ListItem(sdr[1].ToString(), sdr[0].ToString()));
                        ListBox1.Items.Add(new ListItem(sdr[1].ToString(), sdr[0].ToString()));
                    }
                }
                catch (Exception ey)
                {
                    Response.Write("<script language=text/javascript>alert('客户信息加载失败,请联系管理员!')</script>");
                }
                finally
                {
                    conn.Close();
                }
                //if (DropDownList1.Items.Count > 0)
                {
                    //this.Display(DropDownList1.Items[0].Value.ToString());
                }
            }
        }
    }
    public void Display(string id)
    {
        if (id == "")
        {
            return;
        }
        SqlConnection conn = new DataBase().getSqlConnection();

        SqlCommand cmd = conn.CreateCommand();

        cmd.CommandText = "select no from 客户信息 where id=" + id;
        int customerID = 0;
        try
        {
            conn.Open();
            customerID = Convert.ToInt32(cmd.ExecuteScalar().ToString());

        }
        catch (Exception ey)
        { }
        finally
        {
            conn.Close();
        }


        TableCell cell11 = new TableCell();
        cell11.Text = "产品名称";
        TableCell cell12 = new TableCell();
        cell12.Text = "物资编码";
        TableCell cella1 = new TableCell();
        cella1.Text = "色数";
        TableCell cella2 = new TableCell();
        cella2.Text = "版筒";
        TableCell cella3 = new TableCell();
        cella3.Text = "个数";
        TableCell cell13 = new TableCell();
        cell13.Text = "版本号";
        TableCell cell14 = new TableCell();
        cell14.Text = "样板";
        TableCell cell15 = new TableCell();
        cell15.Text = "菲林";
        TableCell cell16 = new TableCell();
        cell16.Text = "树脂版";
        TableCell cell17 = new TableCell();
        cell17.Text = "片材";
        TableCell cell18 = new TableCell();
        cell18.Text = "彩稿";
        TableCell cell181 = new TableCell();
        cell181.Text = "存放库位";
        TableCell cell182 = new TableCell();
        cell182.Text = "自编序号";
        TableCell cell183 = new TableCell();
        cell183.Text = "状态";
        TableCell cell19 = new TableCell();
        cell19.Text = "管理";
        TableRow row1 = new TableRow();
        row1.Style.Add("background-color", "green");
        row1.Style.Add("color", "white");

        row1.Cells.Add(cell11);
        row1.Cells.Add(cell12);
        row1.Cells.Add(cell13);
        row1.Cells.Add(cella1);
        row1.Cells.Add(cella2);
        row1.Cells.Add(cella3);       
        row1.Cells.Add(cell14);
        row1.Cells.Add(cell15);
        row1.Cells.Add(cell16);
        row1.Cells.Add(cell17);
        row1.Cells.Add(cell18);
        row1.Cells.Add(cell181);
        row1.Cells.Add(cell182);
        row1.Cells.Add(cell183);
        row1.Cells.Add(cell19);
        Table1.Rows.Add(row1);
        cmd.CommandText = "select * from 成品编码_产品 where customer=" + id;

        try
        {
            conn.Open();

            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                SqlConnection cony = new DataBase().getSqlConnection();
                SqlCommand cmz = cony.CreateCommand();
                cmz.CommandText = "select * from 成品编码_印刷 where no=" + sdr[0].ToString();
                try
                {
                    if (cony.State != ConnectionState.Open)
                    {
                        cony.Open();
                    }
                    SqlDataReader sdz = cmz.ExecuteReader();
                    while (sdz.Read())
                    {
                        TableRow row2 = new TableRow();
                        TableCell cell21 = new TableCell();
                        cell21.Text = sdr[2].ToString();
                        TableCell cell22 = new TableCell();
                        cell22.Text = customerID.ToString() + string.Format("{0:000}", Convert.ToInt32(sdr[3].ToString()));
                        TableCell b1 = new TableCell();
                        if (sdr[4].ToString() == "-1")
                        {
                            b1.Text = "-";
                        }
                        else
                        {
                            b1.Text = sdr[4].ToString();
                        }

                        TableCell b2 = new TableCell();
                        if (sdr[5].ToString() == "-1")
                        {
                            b2.Text = "-";
                        }
                        else
                        {
                            b2.Text = sdr[5].ToString();
                        }
                        TableCell b3 = new TableCell();
                        if (sdr[6].ToString() == "-1")
                        {
                            b3.Text = "-";
                        }
                        else
                        {
                            b3.Text = sdr[6].ToString();
                        }
                        TableCell cell23 = new TableCell();
                        cell23.Text = sdz[2].ToString();
                        TableCell cell24 = new TableCell();
                        cell24.Text = (sdz[3].ToString() == "-1" ? "-" : (sdz[3].ToString() == "1" ? "已存档" : "使用中"));
                        TableCell cell25 = new TableCell();
                        cell25.Text = (sdz[4].ToString() == "-1" ? "-" : (sdz[4].ToString() == "1" ? "已存档" : "使用中"));
                        TableCell cell26 = new TableCell();
                        cell26.Text = (sdz[5].ToString() == "-1" ? "-" : (sdz[5].ToString() == "1" ? "已存档" : "使用中"));
                        TableCell cell27 = new TableCell();
                        cell27.Text = (sdz[6].ToString() == "-1" ? "-" : (sdz[6].ToString() == "1" ? "已存档" : "使用中"));
                        TableCell cell28 = new TableCell();
                        cell28.Text = (sdz[7].ToString() == "-1" ? "-" : (sdz[7].ToString() == "1" ? "已存档" : "使用中"));
                        TableCell cell30 = new TableCell();
                        cell30.Text = sdz[9].ToString();
                        TableCell cell31 = new TableCell();
                        cell31.Text = sdz[10].ToString();
                        TableCell cell32 = new TableCell();
                        cell32.Text = (sdz[8].ToString() == "" ? "有效" : "无效");
                        TableCell cell29 = new TableCell();
                        LinkButton btn1 = new LinkButton();
                        btn1.Text = "更改版本";
                        btn1.PostBackUrl = "changeVersion.aspx?id=" + sdz[0].ToString();
                        LinkButton btn2 = new LinkButton();
                        btn2.Text = "印版管理";

                        btn2.PostBackUrl = "printManage.aspx?id=" + sdz[0].ToString();

                        cell29.Controls.Add(btn1);
                        btn1.Style.Add("float", "left");

                        cell29.Controls.Add(btn2);
                        btn2.Style.Add("float", "right");

                        row2.Cells.Add(cell21);
                        row2.Cells.Add(cell22);
                        row2.Cells.Add(cell23);
                        row2.Cells.Add(b1);
                        row2.Cells.Add(b2);
                        row2.Cells.Add(b3);
                        
                        row2.Cells.Add(cell24);
                        row2.Cells.Add(cell25);
                        row2.Cells.Add(cell26);
                        row2.Cells.Add(cell27);
                        row2.Cells.Add(cell28);
                        row2.Cells.Add(cell30);
                        row2.Cells.Add(cell31);
                        row2.Cells.Add(cell32);
                        row2.Cells.Add(cell29);
                        
                        Table1.Rows.Add(row2);
                    }
                }
                catch (Exception ey) { }
                finally
                {
                    cony.Close();
                }
            }
        }
        catch (Exception ey)
        { }
        finally
        {
            conn.Close();
        }


    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
       // if (DropDownList1.SelectedIndex != -1)
        {
           // this.Display(DropDownList1.SelectedValue.ToString());
        }

    }



    protected void Button1_Click(object sender, EventArgs e)
    {
        if(TextBox1.Text.Trim().ToString()=="" && TextBox2.Text.Trim().ToString()=="")
        {
            Response.Write("<script type=text/javascript>alert('请输入产品名字或编码!')</script>");
            if (DropDownList1.Items.Count > 0)
            {
                this.Display(DropDownList1.Items[0].Value.ToString());
            }
            return;
        }
        if(TextBox2.Text.Trim().ToString()!="")
        {
            SqlConnection conn = new DataBase().getSqlConnection();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "select no from 客户信息 order by name";
            ArrayList customerAL = new ArrayList();

            try
            {
                conn.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    customerAL.Add(sdr[0].ToString());
                }
            }
            catch (Exception ey) { }
            finally { conn.Close(); }

            string keyNO = TextBox2.Text.Trim().ToString();
            TableCell cell10 = new TableCell();
            cell10.Width = Unit.Pixel(180);
            cell10.Text = "客户名称";
            TableCell cell11 = new TableCell();
            cell11.Text = "产品名称";
            cell11.Width = Unit.Pixel(230);
            TableCell cell12 = new TableCell();
            cell12.Text = "物资编码";
            TableCell cella1 = new TableCell();
            cella1.Text = "色数";
            TableCell cella2 = new TableCell();
            cella2.Text = "版筒";
            TableCell cella3 = new TableCell();
            cella3.Text = "个数";
            TableCell cell13 = new TableCell();
            cell13.Text = "版本号";
            TableCell cell14 = new TableCell();
            cell14.Text = "样板";
            TableCell cell15 = new TableCell();
            cell15.Text = "菲林";
            TableCell cell16 = new TableCell();
            cell16.Text = "树脂版";
            TableCell cell17 = new TableCell();
            cell17.Text = "片材";
            TableCell cell18 = new TableCell();
            cell18.Text = "彩稿";
            TableCell cell181 = new TableCell();
            cell181.Text = "存放库位";
            TableCell cell182 = new TableCell();
            cell182.Text = "自编序号";
            TableCell cell183 = new TableCell();
            cell183.Text = "状态";
            TableCell cell19 = new TableCell();
            cell19.Text = "管理";
            TableRow row1 = new TableRow();
            row1.Style.Add("background-color", "green");
            row1.Style.Add("color", "white");
            row1.Cells.Add(cell10);
            row1.Cells.Add(cell11);
            row1.Cells.Add(cell12);
            row1.Cells.Add(cell13);
            row1.Cells.Add(cella1);
            row1.Cells.Add(cella2);
            row1.Cells.Add(cella3);
           
            row1.Cells.Add(cell14);
            row1.Cells.Add(cell15);
            row1.Cells.Add(cell16);
            row1.Cells.Add(cell17);
            row1.Cells.Add(cell18);
            
            row1.Cells.Add(cell181);
            row1.Cells.Add(cell182);
            row1.Cells.Add(cell183);
            row1.Cells.Add(cell19);
            Table1.Rows.Add(row1);
            string customer = keyNO.Substring(0, 3);
            try {
                //int n = customerAL.IndexOf(customer);
                //string x = DropDownList1.Items[n].Value.ToString();
                //string y = DropDownList1.Items[n - 1].Value.ToString();
                //string z = DropDownList1.Items[n + 1].ToString();
            cmd.CommandText = "select * from 成品编码_产品 where customer=" + DropDownList1.Items[customerAL.IndexOf(customer)].Value.ToString() + " and no=" + Convert.ToInt32(keyNO.Substring(3));
            }
            catch(Exception)
            {
                Response.Write("<script type=text/javascript>alert('请输入正确的产品编码!')</script>");
               
                return;
            }
            try
            {
                conn.Open();

                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    SqlConnection cony = new DataBase().getSqlConnection();
                    SqlCommand cmz = cony.CreateCommand();
                    cmz.CommandText = "select * from 成品编码_印刷 where no=" + sdr[0].ToString();
                    try
                    {
                        if (cony.State != ConnectionState.Open)
                        {
                            cony.Open();
                        }
                        SqlDataReader sdz = cmz.ExecuteReader();
                        while (sdz.Read())
                        {
                            TableRow row2 = new TableRow();
                            TableCell cell20 = new TableCell();
                            cell20.Width = Unit.Pixel(180);
                            cell20.Text = DropDownList1.Items.FindByValue(sdr[1].ToString()).Text.ToString();
                            TableCell cell21 = new TableCell();
                            cell21.Width = Unit.Pixel(230);
                            cell21.Text = sdr[2].ToString();
                            TableCell cell22 = new TableCell();
                            cell22.Text = customerAL[DropDownList1.Items.IndexOf(DropDownList1.Items.FindByValue(sdr[1].ToString()))].ToString() + string.Format("{0:000}", Convert.ToInt32(sdr[3].ToString()));
                            TableCell b1 = new TableCell();
                            if (sdr[4].ToString() == "-1")
                            {
                                b1.Text = "-";
                            }
                            else
                            {
                                b1.Text = sdr[4].ToString();
                            }

                            TableCell b2 = new TableCell();
                            if (sdr[5].ToString() == "-1")
                            {
                                b2.Text = "-";
                            }
                            else
                            {
                                b2.Text = sdr[5].ToString();
                            }
                            TableCell b3 = new TableCell();
                            if (sdr[6].ToString() == "-1")
                            {
                                b3.Text = "-";
                            }
                            else
                            {
                                b3.Text = sdr[6].ToString();
                            }
                            TableCell cell23 = new TableCell();
                            cell23.Text = sdz[2].ToString();
                            TableCell cell24 = new TableCell();
                            cell24.Text = (sdz[3].ToString() == "-1" ? "-" : (sdz[3].ToString() == "1" ? "已存档" : "使用中"));
                            TableCell cell25 = new TableCell();
                            cell25.Text = (sdz[4].ToString() == "-1" ? "-" : (sdz[4].ToString() == "1" ? "已存档" : "使用中"));
                            TableCell cell26 = new TableCell();
                            cell26.Text = (sdz[5].ToString() == "-1" ? "-" : (sdz[5].ToString() == "1" ? "已存档" : "使用中"));
                            TableCell cell27 = new TableCell();
                            cell27.Text = (sdz[6].ToString() == "-1" ? "-" : (sdz[6].ToString() == "1" ? "已存档" : "使用中"));
                            TableCell cell28 = new TableCell();
                            cell28.Text = (sdz[7].ToString() == "-1" ? "-" : (sdz[7].ToString() == "1" ? "已存档" : "使用中"));
                            TableCell cell30 = new TableCell();
                            cell30.Text = sdz[9].ToString();
                            TableCell cell31 = new TableCell();
                            cell31.Text = sdz[10].ToString();
                            TableCell cell32 = new TableCell();
                            cell32.Text = (sdz[8].ToString() == "" ? "有效" : "无效");
                            TableCell cell29 = new TableCell();
                          
                            LinkButton btn1 = new LinkButton();
                            btn1.Text = "更改版本";
                            btn1.PostBackUrl = "changeVersion.aspx?id=" + sdz[0].ToString();
                            LinkButton btn2 = new LinkButton();
                            btn2.Text = "印版管理";

                            btn2.PostBackUrl = "printManage.aspx?id=" + sdz[0].ToString();

                            cell29.Controls.Add(btn1);
                            btn1.Style.Add("float", "left");

                            cell29.Controls.Add(btn2);
                            btn2.Style.Add("float", "right");
                            row2.Cells.Add(cell20);
                            row2.Cells.Add(cell21);
                            row2.Cells.Add(cell22);
                            row2.Cells.Add(cell23);
                            row2.Cells.Add(b1);
                            row2.Cells.Add(b2);
                            row2.Cells.Add(b3);

                            row2.Cells.Add(cell24);
                            row2.Cells.Add(cell25);
                            row2.Cells.Add(cell26);
                            row2.Cells.Add(cell27);
                            row2.Cells.Add(cell28);
                            row2.Cells.Add(cell30);
                            row2.Cells.Add(cell31);
                            row2.Cells.Add(cell32);
                            row2.Cells.Add(cell29);
                            Table1.Rows.Add(row2);
                        }
                    }
                    catch (Exception ey) { }
                    finally
                    {
                        cony.Close();
                    }
                }
            }
            catch (Exception ey)
            { }
            finally
            {
                conn.Close();
            }
        }
        else
        {

            SqlConnection conn = new DataBase().getSqlConnection();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "select no from 客户信息 order by name";
            ArrayList customerAL = new ArrayList();

            try
            {
                conn.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    customerAL.Add(sdr[0].ToString());
                }
            }
            catch (Exception ey) { }
            finally { conn.Close(); }

            string keyName = TextBox1.Text.Trim().ToString();
            TableCell cell10 = new TableCell();
            cell10.Width = Unit.Pixel(180);
            cell10.Text = "客户名称";
            TableCell cell11 = new TableCell();
            cell11.Text = "产品名称";
            cell11.Width = Unit.Pixel(230);
            TableCell cell12 = new TableCell();
            cell12.Text = "物资编码";
            TableCell cella1 = new TableCell();
            cella1.Text = "色数";
            TableCell cella2 = new TableCell();
            cella2.Text = "版筒";
            TableCell cella3 = new TableCell();
            cella3.Text = "个数";
            TableCell cell13 = new TableCell();
            cell13.Text = "版本号";
            TableCell cell14 = new TableCell();
            cell14.Text = "样板";
            TableCell cell15 = new TableCell();
            cell15.Text = "菲林";
            TableCell cell16 = new TableCell();
            cell16.Text = "树脂版";
            TableCell cell17 = new TableCell();
            cell17.Text = "片材";
            TableCell cell18 = new TableCell();
            cell18.Text = "彩稿";
            TableCell cell181 = new TableCell();
            cell181.Text = "存放库位";
            TableCell cell182 = new TableCell();
            cell182.Text = "自编序号";
            TableCell cell183 = new TableCell();
            cell183.Text = "状态";
            TableCell cell19 = new TableCell();
            cell19.Text = "管理";
            TableRow row1 = new TableRow();
            row1.Style.Add("background-color", "green");
            row1.Style.Add("color", "white");
            row1.Cells.Add(cell10);
            row1.Cells.Add(cell11);
            row1.Cells.Add(cell12);  row1.Cells.Add(cell13);
            row1.Cells.Add(cella1);
            row1.Cells.Add(cella2);
            row1.Cells.Add(cella3);
          
            row1.Cells.Add(cell14);
            row1.Cells.Add(cell15);
            row1.Cells.Add(cell16);
            row1.Cells.Add(cell17);
            row1.Cells.Add(cell18);
            
            row1.Cells.Add(cell181);
            row1.Cells.Add(cell182);
            row1.Cells.Add(cell183);
            row1.Cells.Add(cell19);
            Table1.Rows.Add(row1);

            cmd.CommandText = "select * from 成品编码_产品 where name like '%" + keyName + "%' order by customer";
            try
            {
                conn.Open();

                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    SqlConnection cony = new DataBase().getSqlConnection();
                    SqlCommand cmz = cony.CreateCommand();
                    cmz.CommandText = "select * from 成品编码_印刷 where no=" + sdr[0].ToString();
                    try
                    {
                        if (cony.State != ConnectionState.Open)
                        {
                            cony.Open();
                        }
                        SqlDataReader sdz = cmz.ExecuteReader();
                        while (sdz.Read())
                        {
                            TableRow row2 = new TableRow();
                            TableCell cell20 = new TableCell();
                            cell20.Width = Unit.Pixel(180);
                            cell20.Text = DropDownList1.Items.FindByValue(sdr[1].ToString()).Text.ToString();
                            TableCell cell21 = new TableCell();
                            cell21.Width = Unit.Pixel(230);
                            cell21.Text = sdr[2].ToString();
                            TableCell cell22 = new TableCell();
                            cell22.Text = customerAL[DropDownList1.Items.IndexOf(DropDownList1.Items.FindByValue(sdr[1].ToString()))].ToString() + string.Format("{0:000}", Convert.ToInt32(sdr[3].ToString()));
                            TableCell b1 = new TableCell();
                            if (sdr[4].ToString() == "-1")
                            {
                                b1.Text = "-";
                            }
                            else
                            {
                                b1.Text = sdr[4].ToString();
                            }

                            TableCell b2 = new TableCell();
                            if (sdr[5].ToString() == "-1")
                            {
                                b2.Text = "-";
                            }
                            else
                            {
                                b2.Text = sdr[5].ToString();
                            }
                            TableCell b3 = new TableCell();
                            if (sdr[6].ToString() == "-1")
                            {
                                b3.Text = "-";
                            }
                            else
                            {
                                b3.Text = sdr[6].ToString();
                            }
                            TableCell cell23 = new TableCell();
                            cell23.Text = sdz[2].ToString();
                            TableCell cell24 = new TableCell();
                            cell24.Text = (sdz[3].ToString() == "-1" ? "-" : (sdz[3].ToString() == "1" ? "已存档" : "使用中"));
                            TableCell cell25 = new TableCell();
                            cell25.Text = (sdz[4].ToString() == "-1" ? "-" : (sdz[4].ToString() == "1" ? "已存档" : "使用中"));
                            TableCell cell26 = new TableCell();
                            cell26.Text = (sdz[5].ToString() == "-1" ? "-" : (sdz[5].ToString() == "1" ? "已存档" : "使用中"));
                            TableCell cell27 = new TableCell();
                            cell27.Text = (sdz[6].ToString() == "-1" ? "-" : (sdz[6].ToString() == "1" ? "已存档" : "使用中"));
                            TableCell cell28 = new TableCell();
                            cell28.Text = (sdz[7].ToString() == "-1" ? "-" : (sdz[7].ToString() == "1" ? "已存档" : "使用中"));
                            TableCell cell30 = new TableCell();
                            cell30.Text = sdz[9].ToString();
                            TableCell cell31 = new TableCell();
                            cell31.Text = sdz[10].ToString();
                            TableCell cell32 = new TableCell();
                            cell32.Text = (sdz[8].ToString() == "" ? "有效" : "无效");
                           
                            TableCell cell29 = new TableCell();
                            LinkButton btn1 = new LinkButton();
                            btn1.Text = "更改版本";
                            btn1.PostBackUrl = "changeVersion.aspx?id=" + sdz[0].ToString();
                            LinkButton btn2 = new LinkButton();
                            btn2.Text = "印版管理";

                            btn2.PostBackUrl = "printManage.aspx?id=" + sdz[0].ToString();

                            cell29.Controls.Add(btn1);
                            btn1.Style.Add("float", "left");

                            cell29.Controls.Add(btn2);
                            btn2.Style.Add("float", "right");
                            row2.Cells.Add(cell20);
                            row2.Cells.Add(cell21);
                            row2.Cells.Add(cell22);
                            row2.Cells.Add(cell23);
                            row2.Cells.Add(b1);
                            row2.Cells.Add(b2);
                            row2.Cells.Add(b3);

                            row2.Cells.Add(cell24);
                            row2.Cells.Add(cell25);
                            row2.Cells.Add(cell26);
                            row2.Cells.Add(cell27);
                            row2.Cells.Add(cell28);
                            row2.Cells.Add(cell30);
                            row2.Cells.Add(cell31);
                            row2.Cells.Add(cell32);
                            row2.Cells.Add(cell29);
                            Table1.Rows.Add(row2);
                        }
                    }
                    catch (Exception ey) { }
                    finally
                    {
                        cony.Close();
                    }
                }
            }
            catch (Exception ey)
            { }
            finally
            {
                conn.Close();
            }
        }
    }



    protected void Button2_Click(object sender, EventArgs e)
    {
        int countRow = 0;
        HSSFWorkbook workbook = new HSSFWorkbook();
        MemoryStream ms = new MemoryStream();
        ISheet sheet = workbook.CreateSheet("菲林信息汇总");
        //标题行
        IRow row1 = sheet.CreateRow(countRow);

        ICell cell0 = row1.CreateCell(0);
        cell0.SetCellValue("物资编码");
        ICell cell1 = row1.CreateCell(1);
        cell1.SetCellValue("版本");
        ICell cell2 = row1.CreateCell(2);
        cell2.SetCellValue("客户名称");
        ICell cell3 = row1.CreateCell(3);
        cell3.SetCellValue("产品名称");
        ICell cell4 = row1.CreateCell(4);
        cell4.SetCellValue("色数");
        ICell cell5 = row1.CreateCell(5);
        cell5.SetCellValue("齿数");
        ICell cell6 = row1.CreateCell(6);
        cell6.SetCellValue("版筒个数");
        ICell cell7 = row1.CreateCell(7);
        cell7.SetCellValue("样板");
        ICell cell8 = row1.CreateCell(8);
        cell8.SetCellValue("菲林");
        ICell cell9 = row1.CreateCell(9);
        cell9.SetCellValue("树脂版");
        ICell cell10 = row1.CreateCell(10);
        cell10.SetCellValue("片材");
        ICell cell11 = row1.CreateCell(11);
        cell11.SetCellValue("彩稿");
        ICell cell111 = row1.CreateCell(11);
        cell111.SetCellValue("存放库位");
        ICell cell112 = row1.CreateCell(11);
        cell112.SetCellValue("存放序号");
        ICell cell113 = row1.CreateCell(11);
        cell113.SetCellValue("状态");
        //数据内容
        //客户信息
        SqlConnection conn = new DataBase().getSqlConnection();
        SqlCommand cmd = conn.CreateCommand();
        cmd.CommandText = "select * from 客户信息";
        ArrayList customerID = new ArrayList();
        ArrayList customerName = new ArrayList();
        ArrayList customerNO = new ArrayList();
        try
        {
            conn.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            while(sdr.Read())
            {
                customerID.Add(sdr[0].ToString());
                customerName.Add(sdr[1].ToString());
                customerNO.Add(sdr[2].ToString());
            }
        }
        catch(Exception ey) { }
        finally
        {
            conn.Close();
        }

        //产品信息
        cmd.CommandText = "select * from 成品编码_产品 order by customer,no";
        try
        {
            conn.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            while(sdr.Read())
            {
                SqlConnection cony = new DataBase().getSqlConnection();
                SqlCommand cmz = cony.CreateCommand();
                cmz.CommandText = "select * from 成品编码_印刷 where no=" + sdr[0].ToString();
                try
                {
                    if (cony.State != ConnectionState.Open)
                    {
                        cony.Open();
                    }
                    SqlDataReader sdz = cmz.ExecuteReader();
                    for(;sdz.Read();)
                    {
                        countRow++;
                        IRow row = sheet.CreateRow(countRow);
                        ICell cell20 = row.CreateCell(0);
                        cell20.SetCellValue(customerNO[customerID.IndexOf(sdr[1].ToString())].ToString()+ string.Format("{0:000}", Convert.ToInt32(sdr[3].ToString())));
                        ICell cell21 = row.CreateCell(1);
                        cell21.SetCellValue(sdz[2].ToString());
                        ICell cell22 = row.CreateCell(2);
                        cell22.SetCellValue(customerName[customerID.IndexOf(sdr[1].ToString())].ToString());
                        ICell cell13 = row.CreateCell(3);
                        cell13.SetCellValue(sdr[2].ToString());//产品名字
                        ICell cell14 = row.CreateCell(4);
                        if(sdr[4].ToString()=="-1")
                        {
                            cell14.SetCellValue("-");
                                }
                        else
                        {
                            cell14.SetCellValue(sdr[4].ToString());
                        }
                        
                        ICell cell15 = row.CreateCell(5);
                        if (sdr[5].ToString() == "-1")
                        {
                            cell15.SetCellValue("-");
                        }
                        else
                        {
                            cell15.SetCellValue(sdr[5].ToString());
                        }
                       
                        ICell cell16 = row.CreateCell(6);
                        if (sdr[6].ToString() == "-1")
                        {
                            cell16.SetCellValue("-");
                        }
                        else
                        {
                            cell16.SetCellValue(sdr[6].ToString());
                        }
                        for (int i=7;i<12;i++)
                        {
                            ICell cell = row.CreateCell(i);
                            cell.SetCellValue((sdz[i-4].ToString() == "-1" ? "-" : (sdz[i - 4].ToString() == "1" ? "已存档" : "使用中")));
                        }
                        ICell cell221 = row.CreateCell(12);
                        cell221.SetCellValue(sdz[9].ToString());
                        ICell cell222 = row.CreateCell(13);
                        cell222.SetCellValue(sdz[10].ToString());
                        ICell cell223 = row.CreateCell(14);
                        cell223.SetCellValue(sdz[8].ToString() == "" ? "有效" : "无效");
                    }
                }
                catch (Exception ey) { }
                finally
                {
                    cony.Close();
                }
            }
        }
        catch(Exception ez) { }
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



    protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
        //if (ListBox1.SelectedIndex!=-1)
        {
            //this.Display(ListBox1.SelectedValue.ToString());
        }
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        ListBox1.Items.Clear();
        SqlConnection conn = new DataBase().getSqlConnection();
        SqlCommand cmd = conn.CreateCommand();
        cmd.CommandText = "select id,name from 客户信息 order by name";
        try
        {
            conn.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                
                ListBox1.Items.Add(new ListItem(sdr[1].ToString(), sdr[0].ToString()));
            }
        }
        catch (Exception ey)
        {
            Response.Write("<script language=text/javascript>alert('客户信息加载失败,请联系管理员!')</script>");
        }
        finally
        {
            conn.Close();
        }
        for(int n=0;n<ListBox1.Items.Count;n++)
        {
            if(txtCustomer.Text.ToString()!="")
            { 
            if(ListBox1.Items[n].ToString().IndexOf(txtCustomer.Text.Trim().ToString())==-1)
            {
                ListBox1.Items.RemoveAt(n);
                n--;
            }}
        }
        //if (ListBox1.Items.Count > 0)
        {
           // this.Display(ListBox1.Items[0].Value.ToString());
        }
    }

    protected void Button4_Click(object sender, EventArgs e)
    {
        if(ListBox1.SelectedIndex!=-1)
        {
            this.Display(ListBox1.SelectedValue.ToString());
        }
    }
}