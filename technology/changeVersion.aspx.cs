using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class technology_changeVersion : System.Web.UI.Page
{
    string Customer, Product;
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
                SqlConnection conn = new DataBase().getSqlConnection();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "select no,version from 成品编码_印刷 where id=" + id;
                try
                {
                    conn.Open();
                    SqlDataReader sdr = cmd.ExecuteReader();
                    string version = "";
                    while (sdr.Read())
                    {
                        version = sdr[1].ToString();

                        cmd.CommandText = "select top 1 version from 成品编码_印刷 order by id desc where no=" + sdr[0].ToString();
                        Label2.Text = ((char)((int)(cmd.ExecuteScalar().ToString().ToCharArray()[0]) + 1)).ToString();
                        cmd.CommandText = "select customer,name from 成品编码_成品 where id=" + sdr[0].ToString();
                        SqlDataReader sdrz = cmd.ExecuteReader();
                        while (sdrz.Read())
                        {
                            Product = sdrz[1].ToString();
                            cmd.CommandText = "select name from 成品编码_客户信息 where id=" + sdrz[0].ToString();
                            SqlDataReader ssdr = cmd.ExecuteReader();
                            while (ssdr.Read())
                            {
                                Customer = ssdr[0].ToString();
                            }
                        }

                        Label1.Text = version;
                        //Label2.Text = ((char)((int)(version.ToString().ToCharArray()[0])+1)).ToString();
                    }
                }
                catch (Exception ey) { }
                finally
                {
                    conn.Close();
                }
            }
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string id = "";
        if (Request["id"] != null)
        {
            id = Request["id"].ToString();
        }
        SqlConnection conn = new DataBase().getSqlConnection();
            SqlCommand cmd = conn.CreateCommand();
        if(RadioButton1.Checked==true)
        {
            
            cmd.CommandText = "update 成品编码_印刷 set version='" + Label2.Text + "',样板=-1,菲林=-1,树脂版=-1,片材=-1,彩稿=-1 where id=" + id;
            try
            {
                conn.Open();
                if(cmd.ExecuteNonQuery()==1)
                {
                    cmd.CommandText = "insert into 系统日志 values ('" + Session["userName"].ToString() + "','" + System.DateTime.Now.ToShortDateString() + "','将" + Customer + "的" + Product + "-版本" + Label1.Text.ToString()+ "改为"+Label2.Text.ToString()+"且旧版本已作废!')";
                    cmd.ExecuteNonQuery();
                    Response.Write("<script language=javascript>alert('版本更新已提交！')</script>");
                }
            }
            catch(Exception ey) { }
            finally
            {
                conn.Close();
                Response.Redirect("list_a.aspx");
            }
        }
        else
        {
            
            try
            {
                
                string no = cmd.ExecuteScalar().ToString();                
                cmd.CommandText = "insert into 成品编码_印刷 (no,version,样板,菲林,树脂版,片材,彩稿) values (" + no + ",'"+Label2.Text+ "',-1,-1,-1,-1,-1)";
                conn.Open();
                cmd.ExecuteNonQuery();
                cmd.CommandText = "insert into 系统日志 values ('" + Session["userName"].ToString() + "','" + System.DateTime.Now.ToShortDateString() + "','将" + Customer + "的" + Product + "-版本" + Label1.Text.ToString() + "改为" + Label2.Text.ToString() + "且旧版本未作废!')";
                cmd.ExecuteNonQuery();
                Response.Write("<script language=javascript>alert('版本更新已提交！')</script>");
            }
            catch(Exception ey) { }
            finally {
                conn.Close();
                Response.Redirect("list_a.aspx");
            }
        }
    }
}