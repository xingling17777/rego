using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class technology_printManage : System.Web.UI.Page
{
    string Customer,Product,VVersion;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["userName"] == null)
        {
            Session["url"] = Request.Url.ToString();
           Response.Redirect("/user/login.aspx");
        }
        else
        {
            if (!IsPostBack)
            {
                string id = "";
                if (Request["id"] != null)
                {
                    id = Request["id"].ToString();
                }
                else
                {
                    Response.Redirect("list_a.aspx");
                }
                SqlConnection conn = new DataBase().getSqlConnection();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "select no,version from 成品编码_印刷 where id=" + id;
                try
                {
                    conn.Open();
                    SqlDataReader sdr = cmd.ExecuteReader();

                    while (sdr.Read())
                    {
                        VVersion = sdr[1].ToString();
                        cmd.CommandText = "select customer,name from 成品编码_成品 where id=" + sdr[0].ToString();
                        SqlDataReader sdrz = cmd.ExecuteReader();
                        while(sdrz.Read())
                        {
                            Product = sdrz[1].ToString();
                            cmd.CommandText = "select name from 成品编码_客户信息 where id=" + sdrz[0].ToString();
                            SqlDataReader ssdr = cmd.ExecuteReader();
                            while (ssdr.Read())
                            {
                                Customer = ssdr[0].ToString();
                            }
                        }
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

    protected void Button1_Click(object sender, EventArgs e)
    {
       if(RadioButton1.Checked==false && RadioButton2.Checked==false &&RadioButton3.Checked==false)
        {
            Response.Write("<script language=javascript>alert('请选择领用、存档或报废！')</script>");
            return;
        }
        SqlConnection conn = new DataBase().getSqlConnection();
        SqlCommand cmd = conn.CreateCommand();
        if (RadioButton3.Checked == false)
        {
            cmd.CommandText = "select * from 成品编码_印刷 where id=" + Request["id"].ToString();
            int yangban = -1, feilin = -1, shuzhi = -1, piancai = -1, caigao = -1;
            try
            {
                conn.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    yangban = Convert.ToInt32(sdr[3].ToString());
                    feilin = Convert.ToInt32(sdr[4].ToString());
                    shuzhi = Convert.ToInt32(sdr[5].ToString());
                    piancai = Convert.ToInt32(sdr[6].ToString());
                    caigao = Convert.ToInt32(sdr[7].ToString());
                }
            }
            catch (Exception ey) { }
            finally
            {
                conn.Close();
            }


            if (RadioButton1.Checked == true)
            {
                if (CheckBox1.Checked == true)
                {
                    yangban = 0;
                }
                if (CheckBox2.Checked == true)
                {
                    feilin = 0;
                }
                if (CheckBox3.Checked == true)
                {
                    shuzhi = 0;
                }
                if (CheckBox4.Checked == true)
                {
                    piancai = 0;
                }
                if (CheckBox5.Checked == true)
                {
                    caigao = 0;
                }
            }
            else
            {
                if (CheckBox1.Checked == true)
                {
                    yangban = 1;
                }
                if (CheckBox2.Checked == true)
                {
                    feilin = 1;
                }
                if (CheckBox3.Checked == true)
                {
                    shuzhi = 1;
                }
                if (CheckBox4.Checked == true)
                {
                    piancai = 1;
                }
                if (CheckBox5.Checked == true)
                {
                    caigao = 1;
                }
            }

            cmd.CommandText = "update 成品编码_印刷 set 样板=" + yangban + ",菲林=" + feilin + ",树脂版=" + shuzhi + ",片材=" + piancai + ",彩稿=" + caigao + " where id=" + Request["id"].ToString();
        }
        else
        { 
        cmd.CommandText = "delete from 成品编码_印刷 where id=" + Request["id"].ToString();
        }
        try
        {
            conn.Open();
            if(cmd.ExecuteNonQuery()==1)
            {

                Response.Write("<script language=javascript>alert('信息已更新！')</script>");
                if (RadioButton3.Checked == true) { 
                cmd.CommandText = "insert into 系统日志 values ('" + Session["userName"].ToString() + "','" + System.DateTime.Now.ToShortDateString() + "','将" +Customer+"的"+Product+"-版本"+VVersion+ "的相关资料标记为作废!')";
                cmd.ExecuteNonQuery();
                }
                else
                {
                    string act = "";
                    if (RadioButton1.Checked == true)
                    {
                        act = "领用了" + Customer + "的" + Product + " - 版本" + VVersion + "的";
                    }
                    else
                    {
                        act = "存档了" + Customer + "的" + Product + " - 版本" + VVersion + "的";
                    }
                    if(CheckBox1.Checked==true)
                    {
                        act += "样板，";
                    }
                    if (CheckBox2.Checked == true)
                    {
                        act += "菲林，";
                    }
                    if (CheckBox3.Checked == true)
                    {
                        act += "树脂版，";
                    }
                        if(CheckBox4.Checked==true)
                    {
                        act += "片材，";
                    }
                    if (CheckBox5.Checked == true)
                    {
                        act += "彩稿";
                    }
                    cmd.CommandText = "insert into 系统日志 values ('" + Session["userName"].ToString() + "','" + System.DateTime.Now.ToShortDateString() + "','" + act+"!')";
                    cmd.ExecuteNonQuery();
                }
                Response.Redirect("list_a.aspx");
            }
        }
        catch(Exception ey) { }
        finally
        {
            conn.Close();
        }
    }
}