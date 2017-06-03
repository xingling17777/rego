using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class Purch_customer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            //加载已有客户信息,id与昵称
            DropDownList1.Items.Clear();
            SqlConnection conn = new DataBase().getSqlConnection();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "select * from 客户信息 order by 昵称";
            try
            {
                conn.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    DropDownList1.Items.Add(new ListItem(sdr[2].ToString(), sdr[0].ToString()));
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
        }
    }

    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (DropDownList1.SelectedIndex != -1)
        {
            Button1.Text = "提交修改";

            SqlConnection conn = new DataBase().getSqlConnection();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "select * from 客户信息 where id = " + DropDownList1.SelectedValue.ToString();
            try
            {
                conn.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    TextBox1.Text = sdr[3].ToString();
                    TextBox2.Text = sdr[4].ToString();
                    TextBox3.Text = sdr[5].ToString();
                    TextBox4.Text = sdr[6].ToString();
                    TextBox5.Text = sdr[7].ToString();
                    TextBox6.Text = sdr[8].ToString();
                    TextBox7.Text = sdr[9].ToString();
                    TextBox8.Text = sdr[10].ToString();
                    TextBox9.Text = sdr[11].ToString();
                    TextBox10.Text = sdr[12].ToString();
                    TextBox11.Text = sdr[13].ToString();
                    TextBox12.Text = sdr[2].ToString();

                }
            }
            catch (Exception ex)
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
        if (TextBox1.Text != "")
        {
            SqlConnection conn = new DataBase().getSqlConnection();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "select count(*) from 客户信息 where 全称 = '" + TextBox1.Text.ToString().Trim() + "'";
            if(TextBox12.Text.Trim()=="")
            {
                TextBox12.Text = TextBox1.Text;
            }
            try
            {
                conn.Open();
              
                if (Convert.ToInt32(cmd.ExecuteScalar().ToString())==1)
                {
                    cmd.CommandText = "update 客户信息 set 全称 = '" + TextBox1.Text.ToString().Trim() + "',联系人='"+TextBox2.Text.ToString().Trim()+
                        "',手机='"+TextBox3.Text.ToString().Trim() + "',QQ='" + TextBox4.Text.ToString().Trim() +
                         "',微信='" + TextBox5.Text.ToString().Trim() + "',网址='" + TextBox6.Text.ToString().Trim() +
                          "',固定电话='" + TextBox7.Text.ToString().Trim() + "',传真='" + TextBox8.Text.ToString().Trim() +
                           "',邮箱='" + TextBox9.Text.ToString().Trim() + "',地址='" + TextBox10.Text.ToString().Trim() +
                            "',备注='" + TextBox11.Text.ToString().Trim() +"',昵称='"+TextBox12.Text.ToString().Trim()+ "' where 名称 = '" + TextBox1.Text.ToString().Trim() + "'";
                    cmd.ExecuteNonQuery();
                    if(conn.State==ConnectionState.Open)
                    {
                        conn.Close();
                    }
                    
                }
                else
                {
                    SqlCommand cmm = conn.CreateCommand();
                    cmm.CommandText = "select top 1 no from 客户信息 order by id desc";
                    if(conn.State==ConnectionState.Closed)
                    {
                        conn.Open();
                    }
                    SqlDataReader sdd = cmm.ExecuteReader();
                    int no = 0;
                    if(sdd.Read())
                    {
                        no = Convert.ToInt32(sdd[0].ToString())+1;
                       if(conn.State==ConnectionState.Open)
                        {
                            conn.Close();
                        }
                    }
                    else
                    {
                        return;
                    }
                    if(conn.State==ConnectionState.Closed)
                    {
                        conn.Open();
                    }
                    cmd.CommandText = "insert into 客户信息 values("+no+",'"+TextBox12.Text.Trim().ToString()+"','"+TextBox1.Text.ToString().Trim()+"','"+TextBox2.Text.ToString().Trim()+"','"
                        + TextBox3.Text.ToString().Trim() + "','" + TextBox4.Text.ToString().Trim() + "','"
                        + TextBox5.Text.ToString().Trim() + "','" + TextBox6.Text.ToString().Trim() + "','"
                        + TextBox7.Text.ToString().Trim() + "','" + TextBox8.Text.ToString().Trim() + "','"
                        + TextBox9.Text.ToString().Trim() + "','" + TextBox10.Text.ToString().Trim() + "','"
                        + TextBox11.Text.ToString().Trim() + "')" ;
                    cmd.ExecuteNonQuery();
                    Response.Write("<script type=text/javascript>alert('客户信息提交成功！')</script>");
                    
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                if(conn.State==ConnectionState.Open)
                conn.Close();
            }
        }
    }
}