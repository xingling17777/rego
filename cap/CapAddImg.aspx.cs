using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.IO;

public partial class CapAddImg : System.Web.UI.Page
{
   
    protected void Page_Load(object sender, EventArgs e)
    {
        //DropDownList1.Items.Clear();
        if (!IsPostBack)
        {
            DropDownList1.Items.Clear();
            SqlConnection conn = new DataBase().getSqlConnection();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "select * from 供应商 order by name";
            try
            {
                conn.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    DropDownList1.Items.Add(new ListItem(sdr[1].ToString(), sdr[0].ToString()));
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

    protected void Button1_Click(object sender, EventArgs e)
    {
       
        if (DropDownList2.SelectedIndex==-1)
        {
            Response.Write("<script tyep=text/javascript>alert('请选择帽盖！')</script>");
        }
        else
        {
            string sss = @"/file/cap/" + DropDownList2.SelectedValue + @"/img";
            if (!Directory.Exists(Server.MapPath("~")+@"file/cap/"+DropDownList2.SelectedValue+@"/img/"))
            {
                Directory.CreateDirectory(Server.MapPath("~") + @"file/cap/" + DropDownList2.SelectedValue + @"/img");
            }
           
            if(FileUpload1.HasFile)
            {
               
                FileUpload1.PostedFile.SaveAs(Server.MapPath("~") + @"file/cap/" + DropDownList2.SelectedValue + @"/img/"+System.DateTime.Now.Year+DateTime.Now.Month+DateTime.Now.Day+DateTime.Now.Hour+DateTime.Now.Minute+ FileUpload1.FileName);
            }
            if (FileUpload2.HasFile)
            {

                FileUpload2.PostedFile.SaveAs(Server.MapPath("~") + @"file/cap/" + DropDownList2.SelectedValue + @"/img/" + System.DateTime.Now.Year + DateTime.Now.Month + DateTime.Now.Day + DateTime.Now.Hour + DateTime.Now.Minute + FileUpload2.FileName);
            }
            if (FileUpload3.HasFile)
            {

                FileUpload3.PostedFile.SaveAs(Server.MapPath("~") + @"file/cap/" + DropDownList2.SelectedValue + @"/img/" + System.DateTime.Now.Year + DateTime.Now.Month + DateTime.Now.Day + DateTime.Now.Hour + DateTime.Now.Minute + FileUpload3.FileName);
            }

            Response.Write("<script tyep=text/javascript>alert('文件已上传！')</script>");
        }
    }

    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (DropDownList1.SelectedIndex != -1)
        {
           // lblsup.Text = DropDownList1.SelectedValue.ToString();
            DropDownList2.Items.Clear();
            SqlConnection conn = new DataBase().getSqlConnection();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "select id,name from cap where supplier=" + DropDownList1.SelectedValue.ToString();
            try
            {
                conn.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    DropDownList2.Items.Add(new ListItem(sdr[1].ToString(), sdr[0].ToString()));
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