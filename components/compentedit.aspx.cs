using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class components_compentedit : System.Web.UI.Page
{
        protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["userName"] == null)
        {
            Session["url"] = Request.Url.ToString();
            Response.Redirect("/user/login.aspx");
        }
        if (!IsPostBack)
        {
            SqlConnection conn = new DataBase().getSqlConnection();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "select id,name+type from 配件基础信息 order by name,type";
            try
            {
                conn.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    DropDownList2.Items.Add(new ListItem(sdr[1].ToString(), sdr[0].ToString()));
                }
                DropDownList2.SelectedIndex = 0;

            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }

           
        }
        else
        {
            //Response.Redirect("/components/componentslist.aspx");
        }
        
    }
    public void display(string id)
    {
        if (id != "")
        {
            SqlConnection conn = new DataBase().getSqlConnection();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "select * from 配件基础信息 where id=" + id;
            SqlDataReader sdr = null;
            try
            {
                conn.Open();
                sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    TextBox1.Text = sdr[1].ToString();
                    TextBox2.Text = sdr[2].ToString();
                    TextBox3.Text = sdr[3].ToString();
                    TextBox4.Text = sdr[4].ToString();
                    DropDownList1.SelectedValue = sdr[5].ToString();
                    TextBox5.Text = sdr[6].ToString();
                    TextBox6.Text = sdr[7].ToString();
                }
            }
            catch (Exception ex)
            {
                Response.Write("<script type='javascript'>alert('数据读取失败！')</script>");
                Response.Redirect("/components/componentslist.aspx");
            }
            finally
            {

                conn.Close();
            }
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (TextBox1.Text != "" && DropDownList2.SelectedIndex!=-1)
        {

            SqlConnection conn = new DataBase().getSqlConnection();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "update 配件基础信息 set name='" + TextBox1.Text + "',type='" + TextBox2.Text + "',useage='" + TextBox3.Text + "',address='" + TextBox4.Text +"',仓库='"+DropDownList1.SelectedValue.ToString()+ "',lessat="+TextBox5.Text.Trim().ToString()+",unit='"+TextBox6.Text.Trim().ToString()+"' where id=" + DropDownList2.SelectedValue.ToString();
            try
            {
                conn.Open();
               if( cmd.ExecuteNonQuery()==1)
                {
                    cmd.CommandText= "update 配件库存 set name = '" + TextBox1.Text + "',type = '" + TextBox2.Text + "',useage = '" + TextBox3.Text + "',address = '" + TextBox4.Text + "' where 配件编号 = " + DropDownList2.SelectedValue.ToString();
                    if(cmd.ExecuteNonQuery()==1)
                    {
                        Response.Write("< script type = 'text/javascript' > alert('数据更新成功！') </ script >");
                        Response.Redirect("/components/compentedit.aspx");
                    }
                }
            }
            catch(Exception ey)
            {
                Response.Write("< script type = 'text/javascript' > alert('数据更新失败！') </ script >");
            }
            finally
            {
                conn.Close();
               

            }
        }

    }

    protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
    {
        if(DropDownList2.SelectedIndex!=-1)
        {
            this.display(DropDownList2.SelectedValue.ToString());
        }
    }
}