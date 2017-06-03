using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class capAdd : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //需要初始化供应商列表
        if(!IsPostBack)
        { 
        DropDownList1.Items.Clear();
        SqlConnection conn = new DataBase().getSqlConnection();
        SqlCommand cmd = conn.CreateCommand();
        cmd.CommandText = "select * from 供应商 order by name";
        try
        {
            conn.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            while(sdr.Read())
            {
                DropDownList1.Items.Add(new ListItem(sdr[1].ToString(),sdr[0].ToString()));
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

    protected void Button1_Click(object sender, EventArgs e)
    {
        string supplier = DropDownList1.SelectedValue.ToString();
        string name = txtname.Text.Trim().ToString();
        string updia = txtud.Text.Trim().ToString();
        string ddia = txtdd.Text.Trim().ToString();
        string height = txth.Text.Trim().ToString();
        string tt = txttd.Text.Trim().ToString();
        string td = txtbd.Text.Trim().ToString();
        string oo = txtor.Text.Trim().ToString();
        string weight = txtw.Text.Trim().ToString();
        string color = txtc.Text.Trim().ToString();
        string remark = txtreMark.Text.Trim().ToString();
        string id = txtID.Text.Trim().ToString();
        if(supplier!="" && name!="")
        {
            SqlConnection conn = new DataBase().getSqlConnection();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "insert into cap (supplier,name,编号,上沿外径,下沿外径,高度,顶螺纹,底螺纹,内口径,重量,颜色,备注) values(" + supplier+",'"+name+"','"+ id + "','" + updia + "','" + ddia + "','" + height + "','" + tt + "','" + td+ "','" + oo + "','" + weight + "','" + color + "','" + remark + "')";
            try
            {
                conn.Open();
                if(cmd.ExecuteNonQuery()==1)
                {
                    Response.Write("<script type=text/javascript>alert('数据更新成功！')</script>");
                }
                else
                {
                    Response.Write("<script type=text/javascript>alert('数据更新失败！')</script>");
                }
            }
            catch(Exception ex)
            {
                Response.Write("<script type=text/javascript>alert('数据库打开失败，请重试或联系管理员！')</script>");
            }
            finally
            {
                conn.Close();
            }
        }
        else
        {
            Response.Write("<script type=text/javascript>alert('请选择供应商并输入帽盖名称：')</script>");
        }
    }
}