using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
//展示清单，并添加到购物车
//序号，列数，名称，数量
public partial class gift_giftlist : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //验证登陆状态，然后加载库存；
        //TODO:暂时不使用购物车功能，在申请单里面选择；
        if (Session["userName"] == null)
        {
            Response.Redirect("login.aspx");
        }
        else
        {
            TableRow row1 = new TableRow();
            TableCell cell1 = new TableCell();
            cell1.Text = "序号";
            TableCell cell2 = new TableCell();
            cell2.Text = "名称";
            TableCell cell3 = new TableCell();
            cell3.Text = "图片";
            TableCell cell4 = new TableCell();
            cell4.Text = "数量";
            TableCell cell5 = new TableCell();
            row1.Cells.Add(cell1);
            row1.Cells.Add(cell2);
            row1.Cells.Add(cell3);
            row1.Cells.Add(cell4);
            row1.Cells.Add(cell5);
            Table1.Rows.Add(row1);
            //TODO:开始加载,图片暂时不做
            SqlConnection conn = new DataBase().getSqlConnection();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "select * from giftList order by date";
            try
            {
                conn.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                int i = 1;
                while (sdr.Read())
                {
                    TableRow row = new TableRow();
                    TableCell cell11 = new TableCell();
                    cell11.Text = i.ToString();
                    i++;
                    TableCell cell12 = new TableCell();
                    cell12.Text = sdr[1].ToString();
                    TableCell cell13 = new TableCell();
                    TableCell cell14 = new TableCell();
                    cell14.Text = sdr[2].ToString() + sdr[3].ToString();
                    TableCell cell15 = new TableCell();
                    Button btn = new Button();
                    btn.ID = "btn" + sdr[0].ToString();
                    btn.Click += new EventHandler(btn_Click);
                    cell15.Controls.Add(btn);
                    row.Cells.Add(cell11);
                    row.Cells.Add(cell12);
                    row.Cells.Add(cell13);
                    row.Cells.Add(cell14);
                    row.Cells.Add(cell15);
                }
            }
            catch (Exception ey)
            {
                Response.Write("<script>alert('" + ey.Message + "')</script>");
            }
            finally
            {
                conn.Close();
            }
        }
    }
    void btn_Click(object sender, EventArgs e)
    {

        var btn = sender as Button;
        SqlConnection conn = new DataBase().getSqlConnection();
        SqlCommand cmd = conn.CreateCommand();
        cmd.CommandText = "";
        try
        {
            conn.Open();
            cmd.ExecuteNonQuery();
        }
        catch (Exception ey)
        {
            Response.Write("<script>alert('"+ey.Message+"')</script>");
        }
        finally
        {
            conn.Close();
        }

    }
}
