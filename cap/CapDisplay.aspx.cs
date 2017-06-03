using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.IO;

public partial class CapDisplay : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string id = "";
        if (Request["id"] != null)
        {
            id = Request["id"].ToString();
            SqlConnection conn = new DataBase().getSqlConnection();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "select * from cap where id=" + id;
            SqlDataReader sdr = null;
            try
            {
                conn.Open();
                sdr = cmd.ExecuteReader();
                if (sdr.Read())
                {
                    Label1.Text = sdr[1].ToString();
                    Label2.Text = sdr[2].ToString();
                    Label3.Text = sdr[3].ToString();
                    Label4.Text = sdr[4].ToString();
                    Label5.Text = sdr[5].ToString();
                    TextBox1.Text = sdr[7].ToString();
                }

            }
            catch (Exception ex)

            {
                Response.Write("数据库连接出错");
            }
            finally
            {
                sdr.Close();
                conn.Close();
            }
        }
        if (id != "")
        {
            string imgpath = Server.MapPath("~")+@"file\cap\" + id + @"\img\";
            if(Directory.Exists(imgpath))
            { 
            if (Directory.GetFiles(imgpath) != null)
            {
                int countImg = Directory.GetFiles(imgpath).Length;
                if (countImg != 0)
                {
                    for (int i = 0; i < countImg; i++)
                    {
                        string s = Directory.GetFiles(imgpath)[i].ToString();
                        string ss = Path.GetFileName(s);
                        img.InnerHtml += "<img style=\"width:500px;\" src=\"file/cap/"+id+"/img/" + ss + "\" />" + "<br />";
                    }
                }
            }
            }


        }
    }
}