using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class kunming_不合格品 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            new userAccess().getUserAccess("云南白药不合格品",1);
            DropDownList1.Items.Clear();
            SqlConnection conn = new DataBase().getSqlConnection();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "select * from 云南白药订单 where finish='' order by id desc";
            SqlDataReader sdr = null; ;
            try
            {
                conn.Open();
                sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    DropDownList1.Items.Add(new ListItem(sdr[1].ToString(), sdr[0].ToString()));
                }

            }
            catch (Exception ey) { }
            finally
            {
                sdr.Close();
                conn.Close();
            }
            if (DropDownList1.Items.Count > 0)
            {
                DropDownList1.SelectedIndex = 0;
            }
        }
    }

    protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        DropDownList2.Items.Clear();
        SqlConnection conn = new DataBase().getSqlConnection();
        SqlCommand cmd = conn.CreateCommand();
        if (RadioButtonList1.SelectedIndex == 0)
        {
            cmd.CommandText = "insert into 云南白药生产 values("+DropDownList1.SelectedValue+",-"+TextBox1.Text+","+DropDownList2.SelectedValue+",'')";
            cmd.ExecuteNonQuery();
        }
        if (RadioButtonList1.SelectedIndex == 1)
        {
            cmd.CommandText = "insert into 云南白药送货 values(" + DropDownList1.SelectedValue + ",-" + TextBox1.Text + "," + DropDownList2.SelectedValue + ",'')";
        }
        if (RadioButtonList1.SelectedIndex == 2)
        {
            cmd.CommandText = "insert into 云南白药入库 values(" + DropDownList1.SelectedValue + ",-" + TextBox1.Text + "," + DropDownList2.SelectedValue + ",'')";
        }
        if (RadioButtonList1.SelectedIndex == 3)
        {
            cmd.CommandText = "insert into 云南白药灌装 values(" + DropDownList1.SelectedValue + ",-" + TextBox1.Text + "," + DropDownList2.SelectedValue + ",'')";
        }
        SqlDataReader sdr = null;
        try
        {
            conn.Open();
            sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                DropDownList2.Items.Add(new ListItem(Convert.ToDateTime(sdr[1].ToString()).ToShortDateString(), sdr[0].ToString()));
            }
        }
        catch (Exception ey) { }
        finally
        {
            sdr.Close();
            conn.Close();
        }
        if (DropDownList2.Items.Count > 0)
        {
            DropDownList2.SelectedIndex = 0;
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        //
        if(DropDownList2.SelectedIndex!=-1)
        {
            double sum = 0;
            try
            {
                sum = Convert.ToDouble(TextBox1.Text.Trim().ToString());
            }
            catch(Exception ey)
            { }
            SqlConnection conn = new DataBase().getSqlConnection();
            SqlCommand cmd = conn.CreateCommand();

            if(RadioButtonList1.SelectedIndex==0)
            {
                cmd.CommandText = "insert into 云南白药不合格品 values('生产'," + DropDownList2.SelectedValue + "," + sum + ")";
            }
            if (RadioButtonList1.SelectedIndex == 0)
            {
                cmd.CommandText = "insert into 云南白药不合格品 values('送货'," + DropDownList2.SelectedValue + "," + sum + ")";
            }
            if (RadioButtonList1.SelectedIndex == 0)
            {
                cmd.CommandText = "insert into 云南白药不合格品 values('入库'," + DropDownList2.SelectedValue + "," + sum + ")";
            }
            if (RadioButtonList1.SelectedIndex == 0)
            {
                cmd.CommandText = "insert into 云南白药不合格品 values('灌装'," + DropDownList2.SelectedValue + "," + sum + ")";
            }
            try
            {
                conn.Open();
                if (cmd.ExecuteNonQuery() == 1)
                {
                    Response.Write("<script type='text/javascript'>alert('不合格品录入成功！')</script>");
                    if (RadioButtonList1.SelectedIndex == 0)
                    {
                        cmd.CommandText = "select id,producedate from 云南白药生产 where orderid=" + DropDownList1.SelectedValue + " order by id desc";
                    }
                    if (RadioButtonList1.SelectedIndex == 1)
                    {
                        cmd.CommandText = "select id,productdate from 云南白药送货 where orderid=" + DropDownList1.SelectedValue + " order by id desc";
                    }
                    if (RadioButtonList1.SelectedIndex == 2)
                    {
                        cmd.CommandText = "select id,orderdate from 云南白药入库 where orderid=" + DropDownList1.SelectedValue + " order by id desc";
                    }
                    if (RadioButtonList1.SelectedIndex == 3)
                    {
                        cmd.CommandText = "select id,productdate from 云南白药灌装 where orderid=" + DropDownList1.SelectedValue + " order by id desc";
                    }
                }
                else
                {
                    Response.Write("<script type='text/javascript'>alert('数据提交失败，请联系管理员！')</script>");
                }

            }
            catch(Exception ey) { }
            finally
            {
                conn.Close();
            }
        }
    }
}