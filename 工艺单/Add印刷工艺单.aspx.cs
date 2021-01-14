using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class 工艺单_Add印刷工艺单 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //加载客户名称和id
        if (Session["userName"] == null)
        {
            Session["url"] = Request.Url.ToString();
            Response.Redirect("../user/login.aspx");
        }
        else
        {
            if (!IsPostBack)
            {
                SqlConnection conn = new DataBase().getSqlConnection();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "select id,name from 客户信息 order by name";
                try
                {
                    conn.Open();
                    SqlDataReader sdr = cmd.ExecuteReader();
                    DropDownList2.Items.Clear();

                    DropDownList2.Items.Clear();
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
                if(DropDownList2.Items.Count!=0)
                {
                    DropDownList2.SelectedIndex = 0;
                    DropDownList2_SelectedIndexChanged(this.DropDownList2,e);
                }
            }
            else
            {
                //DropDownList1.SelectedIndex = x;
            }
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        if(DropDownList3.SelectedIndex!=-1)
        {
            string id = DropDownList3.SelectedValue.ToString();
            string WebProduce = TextBox8.Text.Trim().ToString();
            string WebMark= TextBox17.Text.Trim().ToString();
            string InkProduce= TextBox9.Text.Trim().ToString();
            string InkType= TextBox10.Text.Trim().ToString();
            string InkMark= TextBox18.Text.Trim().ToString();
            string OilProduce = TextBox11.Text.Trim().ToString();
            string OilType = TextBox12.Text.Trim().ToString();
            string OilMark = TextBox19.Text.Trim().ToString();
            string ColdProduce = TextBox13.Text.Trim().ToString();
            string ColdType = TextBox14.Text.Trim().ToString();
            string ColdMark = TextBox20.Text.Trim().ToString();
            string GlueProduce = TextBox15.Text.Trim().ToString();
            string GlueType = TextBox16.Text.Trim().ToString();
            string GlueMark = TextBox21.Text.Trim().ToString();
            string 底油 = RadioButton1.Checked ? "是" : "否";
            string 满版= RadioButton3.Checked ? "是" : "否";
            int 卷芯尺寸 = RadioButton5.Checked ? 3 : 6;
            string 出管方向= RadioButton7.Checked ? "管头" : "管尾";
            float 印刷长度1 = 0;
            try
            {
                印刷长度1=(float)Convert.ToDouble(TextBox1.Text.Trim().ToString());
            }
            catch(Exception ey) { }
            
            float 印刷长度2 = 0;
            try
            {
                印刷长度2 =(float)Convert.ToDouble(TextBox2.Text.Trim().ToString());
            }
            catch (Exception ey) { }
            float 切割宽度 = 0;
            try
            {
                切割宽度 = (float)Convert.ToDouble(TextBox3.Text.Trim().ToString());
            }
            catch (Exception ey) { }
            float 边距1 = 0;
            try
            {
                边距1 = (float)Convert.ToDouble(TextBox4.Text.Trim().ToString());
            }
            catch (Exception ey) { }
            float 边距2 = 0;
            try
            {
                边距2 = (float)Convert.ToDouble(TextBox5.Text.Trim().ToString());
            }
            catch (Exception ey) { }
            float 套色精度 = 0;
            try
            {
                套色精度 = (float)Convert.ToDouble(TextBox6.Text.Trim().ToString());
            }
            catch (Exception ey) { }
           string Glue3M = TextBox22.Text.Trim().ToString();
            string Mark = TextBox7.Text.Trim().ToString();
            SqlConnection conn = new DataBase().getSqlConnection();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "select count(*) from 印刷工艺单 where Product =" + id;
            try
            {
                conn.Open();
                if(cmd.ExecuteScalar().ToString()!="0")
                {
                    conn.Close();
                    return;
                }
                else
                {
                    cmd.CommandText = "insert into 印刷工艺单 values(" + id + ",'" + WebProduce + "','" + WebMark + "','" + InkProduce + "','" + InkType + "','" + InkMark + OilProduce + "','" + OilType + "','" + OilMark + "','" + ColdProduce + "','" + ColdType + "','" + ColdMark + "','" + GlueProduce + "','" + GlueType + "','" + GlueMark + "','" + 底油 + "','" + 满版 + "'," + 卷芯尺寸 + ",'" + 出管方向 + "'," + 印刷长度1 + "," + 印刷长度2 + "," + 切割宽度 + "," + 边距1 + "," + 边距2 + "," + 套色精度 + ",'" + Glue3M + "','" + Mark + "'";
                    if(cmd.ExecuteNonQuery()==1)
                    {
                        Response.Write("<script type='text/javascript'>alert('提交成功！')</script>");
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

    protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
    {
        if(DropDownList2.SelectedIndex!=-1)
        {
            string id = DropDownList2.SelectedValue.ToString();
            SqlConnection conn = new DataBase().getSqlConnection();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "select id, name from 成品编码_产品 where customer="+id+" order by name";
            try
            {
                conn.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                DropDownList3.Items.Clear();

                
                while (sdr.Read())
                {
                    DropDownList3.Items.Add(new ListItem(sdr[1].ToString(), sdr[0].ToString()));
                }
            }

            catch (Exception ey) { }
            finally
            {
                conn.Close();
            }
            if (DropDownList3.Items.Count != 0)
            {
                DropDownList3.SelectedIndex = 0;
            }
        }
    }

    protected void DropDownList3_SelectedIndexChanged(object sender, EventArgs e)
    {
        if(DropDownList3.SelectedIndex!=-1)
        {
            string id = DropDownList3.SelectedValue.ToString();
            SqlConnection conn = new DataBase().getSqlConnection();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "select * from 基础技术要求表 where no='"+id+"'";
            float dia = 0;
            float length = 0;
            float width = 0;
            string webtype = "";
            string manban = "";
            try
            {
                conn.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                while(sdr.Read())
                {
                    try
                    {
                        dia = (float)(Convert.ToDouble(sdr[2].ToString()));
                    }
                    catch(Exception ey) { }
                    try
                    {
                        length= (float)(Convert.ToDouble(sdr[3].ToString()));
                    }
                    catch(Exception ey) { }
                    try
                    {
                        width= (float)(Convert.ToDouble(sdr[8].ToString()));
                    }
                    catch(Exception ey) { }
                    webtype = sdr[7].ToString();
                    manban = sdr[9].ToString();
                }
            }
            catch(Exception ey) { }
            finally
            {
                conn.Close();
            }
            Label2.Text = width + "-" + webtype;
            Label3.Text = dia + " * " + length;
            if(manban=="是")
            {
                RadioButton3.Checked = true;
            }else
            {
                RadioButton4.Checked = true;
            }
        }
    }
}