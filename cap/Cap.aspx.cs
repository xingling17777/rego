using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.IO;
public partial class Cap : System.Web.UI.Page
{
    static  int nx = 0;
    static int ny = 0;
    protected void Page_Load(object sender, EventArgs e)
    {
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
                    DropDownList1.Items.Add(new ListItem(sdr[1].ToString(), sdr[0].ToString()));
                }
            }
            catch(Exception ey)
            { }
            finally
            {
                conn.Close();
            }
            
        }
    }

    // void btn2_Click(object sender, EventArgs e)
    //{
    // Response.Redirect("");
    //}



    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        if(DropDownList1.SelectedIndex!=-1)
        {
            lblsup.Text = DropDownList1.SelectedItem.ToString();
            DropDownList2.Items.Clear();
            DropDownList2.Items.Add("-");
            SqlConnection conn = new DataBase().getSqlConnection();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "select id,name from cap where supplier=" + DropDownList1.SelectedValue.ToString();
            try
            {
                conn.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                while(sdr.Read())
                {
                    DropDownList2.Items.Add(new ListItem(sdr[1].ToString(), sdr[0].ToString()));
                }
            }
            catch(Exception ey) { }
            finally
            {
                conn.Close();
            }
        }
        
    }

    protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
    {
        if(DropDownList2.SelectedIndex>0)
        {
            //txtID.Text = DropDownList2.SelectedValue.ToString();
            SqlConnection conn = new DataBase().getSqlConnection();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "select * from cap where id='" + DropDownList2.SelectedValue.ToString()+"'";
            try
            {
                conn.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                while(sdr.Read())
                {
                   txtID.Text= sdr[3].ToString();
                    lblname.Text = sdr[2].ToString();
                    lblupdia.Text = sdr[4].ToString();
                    lbldowndia.Text = sdr[5].ToString();
                    lblheight.Text = sdr[6].ToString();
                    lbltopdia.Text = sdr[7].ToString();
                    lblbotdia.Text = sdr[8].ToString();
                    lblori.Text = sdr[9].ToString();
                    lblcolor.Text = sdr[11].ToString();
                    Label10.Text = sdr[12].ToString();
                    lblweight.Text = sdr[10].ToString();
                    //ImageButton1.ImageUrl = "~/file/cap/1/img/小旋盖1.png";
                }
            }
            catch(Exception ey) { }
            finally
            {
                conn.Close();
            }
            //string ss= Server.MapPath("~") + @"file\cap\" + DropDownList2.SelectedValue + @"\img\";
            string ss = @"~/file/cap/" + DropDownList2.SelectedValue + @"/img/";
            if (Directory.Exists( Server.MapPath(ss)))
            {
                string[] files = Directory.GetFileSystemEntries(Server.MapPath(ss));
                if(files.Length!=0)
                {
                    string sy = Path.GetFileName(files[0].ToString());
                    ImageButton1.ImageUrl = ss + sy;
                    nx = 0;ny = files.Length;
                   
                }
            }
            else
            {
                ImageButton1.ImageUrl = "";
                nx = ny = 0;
            }
        }
    }

    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        if(nx<ny-1)
        {
            string ss =  @"/file/cap/" + DropDownList2.SelectedValue + @"/img/";
            if (Directory.Exists(Server.MapPath(ss)))
            {
                string[] files = Directory.GetFileSystemEntries(Server.MapPath(ss));
                if (files.Length != 0)
                {
                    nx++;
                    ImageButton1.ImageUrl = ss+Path.GetFileName( files[nx].ToString());
                    
                }
            }
        }
        else
        {
            string ss = @"/file/cap/" + DropDownList2.SelectedValue + @"/img/";
            if (Directory.Exists( Server.MapPath(ss)))
            {
                string[] files = Directory.GetFileSystemEntries(Server.MapPath(ss));
                if (files.Length != 0)
                {
                    ImageButton1.ImageUrl = ss+ Path.GetFileName(files[0].ToString());
                    nx = 0;
                }
            }
        }
    }
}