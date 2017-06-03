using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class components_componentsdev : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if( Session["userName"]==null)
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
                    DropDownList1.Items.Add(new ListItem(sdr[1].ToString(), sdr[0].ToString()));
                }
                DropDownList1.SelectedIndex = 0;

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
        Label1.Text = "";
        if (DropDownList1.SelectedIndex != -1 && TextBox1.Text.Trim().ToString() != "")
        {
            int num = 0;
            try
            {
                num = Convert.ToInt32(TextBox1.Text.Trim().ToString());
                
            }
            catch (Exception ex)
            {
                return;
            }
            if(RadioButton2.Checked)
            {
                //待测试；
                num = -num;
            }
            if(RadioButton1.Checked && TextBox3.Text=="")
            {
                TextBox3.Text = "入库";
            }
            SqlConnection conn = new DataBase().getSqlConnection();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "insert into 配件流水 values(" + DropDownList1.SelectedValue.ToString() + "," + num + ",'" + TextBox2.Text.Trim().ToString() + "','" + TextBox3.Text.Trim().ToString() + "','"+System.DateTime.Now.ToShortDateString()+"')";
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                
                cmd.CommandText = "select count(*) from 配件库存 where 配件编号=" + DropDownList1.SelectedValue.ToString();
                if(cmd.ExecuteScalar().ToString()=="0")
                {
                    string name="", type="",useage="",address="";
                    cmd.CommandText = "select name,type,useage,address from 配件基础信息 where id=" + DropDownList1.SelectedValue.ToString();
                    SqlDataReader sdr = cmd.ExecuteReader();
                    while(sdr.Read())
                    {
                        name = sdr[0].ToString();
                        type = sdr[1].ToString();
                        useage = sdr[2].ToString();
                        address = sdr[3].ToString();
                    }
                    sdr.Close();
                    cmd.CommandText = "insert into 配件库存 values(" + DropDownList1.SelectedValue.ToString() + ",'" + name + "','" + type + "','"+useage+"','"+address+"'," + num + ")";
                    cmd.ExecuteNonQuery();
                }
                else
                {
                    cmd.CommandText = "select 库存 from 配件库存 where 配件编号="+DropDownList1.SelectedValue.ToString();
                    int k = Convert.ToInt32(cmd.ExecuteScalar().ToString());
                    int sum = k + num;
                    cmd.CommandText="update 配件库存 set 库存="+sum+ "  where 配件编号=" + DropDownList1.SelectedValue.ToString();
                    cmd.ExecuteNonQuery();
                }

                Label1.Text = DropDownList1.SelectedItem.ToString() + " " + (RadioButton1.Checked == true ? "入库 " : "出库 ") + num + "件";
            }
            catch (Exception ex)
            {
                Label1.Text = "出入库操作失败,请重试或联系管理员!";
            }
            finally
            {
                conn.Close();
            }
        }
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        if(DropDownList1.SelectedIndex!=-1)
        {
            string keyID = DropDownList1.SelectedValue.ToString();
            SqlConnection conn = new DataBase().getSqlConnection();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "delete from 配件基础信息 where id=" + keyID;
            
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                cmd.CommandText = "delete from 配件库存 where 配件编号=" + keyID;
                cmd.ExecuteNonQuery();
                cmd.CommandText= "delete from 配件流水 where 配件编号=" + keyID;
                cmd.ExecuteNonQuery();
            }
            catch(Exception ey)
            {

            }
            finally
            {
                conn.Close();
            }
            Response.Write("<script type=text/css>alert('已删除成功!')</script>");
            Response.Redirect("/components/componentsdev.aspx");
        }
    }
}