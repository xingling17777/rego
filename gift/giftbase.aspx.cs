using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.IO;

public partial class gift_giftbase : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        if (TextBox1.Text.Trim() != "")
        {
            string xy = "";
            SqlConnection conn = new DataBase().getSqlConnection();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "insert into gift values('" + TextBox1.Text.Trim() + "')";
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                TextBox1.Text = "";
                cmd.CommandText = "select top 1 id from gift order by id desc";
                xy = cmd.ExecuteScalar().ToString();
            }
            catch (Exception ey)
            {
                Response.Write(ey.Message);
            }
            finally
            {
                conn.Close();
            }
            if (FileUpload1.HasFile)
            {
                //指定上传文件在服务器上的保存路径
                string savePath = Server.MapPath("img/");
                //检查服务器上是否存在这个物理路径，如果不存在则创建
                if (!System.IO.Directory.Exists(savePath))
                {
                    //需要注意的是，需要对这个物理路径有足够的权限，否则会报错
                    //另外，这个路径应该是在网站之下，而将网站部署在C盘却把文件保存在D盘
                    System.IO.Directory.CreateDirectory(savePath);
                }
                savePath = savePath + "\\" + xy + Path.GetExtension(FileUpload1.FileName);
                FileUpload1.SaveAs(savePath);//保存文件         

            }
        }

    }
}