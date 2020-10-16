using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;


public partial class machine_shebeiweixiu : System.Web.UI.Page
{
    string id = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["userName"] == null)
        {
            Session["url"] = Request.Url.ToString();
            Response.Redirect("../user/login.aspx");
        }
        if(!IsPostBack)
        {
            
            string machineName = "";
            if(Request["id"]!=null && Request["machineName"]!=null)
            {
                id = Request["id"].ToString();
                machineName = Request["machineName"].ToString();
                SqlConnection conn = new DataBase().getSqlConnection();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "select * from 维修记录 where id="+id;
                try
                {
                    conn.Open();
                    SqlDataReader sdr = cmd.ExecuteReader();
                    while(sdr.Read())
                    {
                        lblname.Text = machineName;
                        txtdescription.Text = sdr[3].ToString();
                        rpDate.Text = Convert.ToDateTime(sdr[2].ToString()).ToShortDateString();
                        Condate.Text = sdr[5].ToString();

                    }
                }
                catch(Exception ey)
                {

                }
                finally
                {
                    conn.Close();
                }
            }else
        {
            Response.Redirect("/machine/weixiuchaxun.aspx");
        }
        }
        
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        if(txtRes.Text=="" || txtSolution.Text=="")
        {
            Response.Write("<script type=text/javascript>alert('原因分析和解决方案不能为空!')</script>");
            return;
        }
        string dt;
        if(fixDate.Text.ToString()=="")
        {
            dt = DateTime.Now.ToShortDateString();
        }
        else
        {
            try
            {
                dt = Convert.ToDateTime(fixDate.Text.ToString()).ToShortDateString();
            }
            catch(Exception ey)
            {
                dt = DateTime.Now.ToShortDateString();
            }
        }
        SqlConnection conn = new DataBase().getSqlConnection();
        SqlCommand cmd = conn.CreateCommand();
        cmd.CommandText = "update 维修记录 set 原因分析='" + txtRes.Text.ToString().Trim() + "',解决方案='" + txtSolution.Text.ToString().Trim() + "',解决人员='" + txtDuty.Text.ToString().Trim() + "',解决日期='" + dt + "' where id=" + Request["id"].ToString();
        try
        {
            conn.Open();
            if(cmd.ExecuteNonQuery()==1)
            {
                Response.Write("<script type=text/javascript>alert('更新成功')</script>");
                
            }
            else
            {
                Response.Write("<script type=text/javascript>alert('更新失败,请重新输入或联系管理员!')</script>");
                
            }
        }
        catch(Exception ey)
        {
            Response.Write("<script type=text/javascript>alert('数据库连接失败!请重试或联系管理员!')</script>");
        }
        finally
        {
            conn.Close();
            Response.Redirect("/machine/weixiuchaxun.aspx");
        }
    }
}