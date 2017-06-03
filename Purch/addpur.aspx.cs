using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class Purch_addpur : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["userName"] == null)
        {
            Session["url"] = Request.Url.ToString();
            Response.Redirect("/user/login.aspx");
        }
        else
        {
            SqlConnection conn = new DataBase().getSqlConnection();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "select * from 用户权限 where no=" + Session["userID"].ToString() + " and 功能='报价清单'";
            try
            {
                conn.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                if (sdr.Read())
                {
                    if (sdr[3].ToString() == "1")
                    {

                    }
                    else
                    {
                        Response.Write("<script type=text/javascript>alert('没有此权限，即将退出！')</script>");
                        Response.Redirect("/Default.aspx");
                    }
                }
                else
                {
                    Response.Write("<script type=text/javascript>alert('没有此权限，即将退出！')</script>");
                    Response.Redirect("/Default.aspx");
                }
            }
            catch (Exception ey) { }
            finally
            {
                conn.Close();
            }
        }
        if (!IsPostBack)
        {
            SqlConnection conn = new DataBase().getSqlConnection();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "select id,昵称 from 客户信息 order by 昵称";
            try
            {
                conn.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                DropDownList1.Items.Clear();
                while (sdr.Read())
                {
                    DropDownList1.Items.Add(new ListItem(sdr[1].ToString(), sdr[0].ToString()));
                }
            }
            catch (Exception ey) { }
            finally
            {
                conn.Close();
            }
            cmd.CommandText = "select id,编号+'-'+规格 from 片材规格 order by 编号";
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
            //加载传递过来的值
            if(Request["id"]!=null)
            {
                cmd.CommandText = "select * from 报价清单 where id=" + Request["id"].ToString();
                try
                {
                    if(conn.State!=ConnectionState.Open)
                    {
                        conn.Open();
                    }
                    
                    SqlDataReader sdr = cmd.ExecuteReader();
                    while(sdr.Read())
                    {
                        DropDownList1.SelectedValue = sdr[1].ToString();
                        TextBox11.Text = sdr[17].ToString();
                        TextBox1.Text = sdr[2].ToString();
                        DropDownList2.SelectedValue = sdr[3].ToString();
                        TextBox2.Text = sdr[4].ToString();
                        TextBox3.Text = sdr[5].ToString();
                        DropDownList3.SelectedValue = sdr[6].ToString();
                        TextBox4.Text = sdr[7].ToString();
                        if(sdr[8].ToString()=="是")
                        {
                            RadioButton1.Checked = true;
                        }
                        else
                        {
                            RadioButton2.Checked = true;
                        }
                        TextBox5.Text = sdr[9].ToString();
                        if (sdr[10].ToString() == "是")
                        {
                            RadioButton3.Checked = true;
                        }
                        else
                        {
                            RadioButton4.Checked = true;
                        }
                        TextBox6.Text = sdr[11].ToString();
                        TextBox7.Text = sdr[12].ToString();
                        if (sdr[13].ToString() == "是")
                        {
                            RadioButton5.Checked = true;
                        }
                        else
                        {
                            RadioButton6.Checked = true;
                        }
                        TextBox10.Text =Convert.ToDateTime(sdr[15].ToString()).ToShortDateString();
                        TextBox8.Text = sdr[14].ToString();
                        TextBox9.Text = sdr[16].ToString();
                    }
                }
                catch(Exception ey)
                { }
                finally
                {
                    if(conn.State!=ConnectionState.Closed)
                    {
                        conn.Close();
                    }
                }
            }
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        if(TextBox1.Text.Trim().ToString()=="")
        {
            Response.Write("<script type=text/javascript>alert('产品名称不能为空!')</script>");
            return;
        }
        if(TextBox11.Text=="")
        {
            TextBox11.Text = DateTime.Now.Year.ToString()+DateTime.Now.Month+DateTime.Now.Day;
        }
        string customer = DropDownList1.SelectedValue.ToString();
        string product = TextBox1.Text.Trim().ToString();
        string type = DropDownList2.SelectedValue.ToString();
        double dia = 0;
        if (TextBox2.Text.Trim().ToString() != "")
        {
            dia = Convert.ToDouble(TextBox2.Text.Trim().ToString());
        }
        double length = 0;
        if (TextBox3.Text.Trim().ToString() != "")
        {
            length = Convert.ToDouble(TextBox3.Text.Trim().ToString());
        }
        string webtype = DropDownList3.SelectedValue.ToString();
        string print = TextBox4.Text.Trim().ToString();
        string fengmo = RadioButton1.Checked ? "是" : "否";
        string cap = TextBox5.Text.Trim().ToString();
        string fengwei = RadioButton3.Checked ? "是" : "否";
        string des = TextBox6.Text.Trim().ToString();
        int num = 0;
        if (TextBox7.Text.Trim().ToString() != "")
        {
            num = Convert.ToInt32(TextBox7.Text.Trim().ToString());
        }
        string shui = RadioButton5.Checked ? "是" : "否";
        double price = 0;
        if (TextBox8.Text.Trim().ToString() != "")
        {
            price = Convert.ToDouble(TextBox8.Text.Trim().ToString());
        }
        DateTime dt;
        if (TextBox10.Text != "")
        {
            dt = Convert.ToDateTime(TextBox10.Text.Trim().ToString());
        }
        else
        {
            dt = System.DateTime.Now;
        }
        string remark = TextBox9.Text.Trim().ToString();
        SqlConnection conn = new DataBase().getSqlConnection();
        SqlCommand cmd = conn.CreateCommand();
        cmd.CommandText = "insert into 报价清单 values(" + customer + ",'" + product + "','" + type + "'," + dia + "," + length + "," + webtype + ",'" + print + "','" + fengmo + "','" + cap + "','" + fengwei + "','" + des + "'," + num + ",'" + shui + "'," + price + ",'" + dt.ToShortDateString() + "','" + remark + "','"+TextBox11.Text.Trim().ToString()+"')";
        try
        {
            conn.Open();
            if (cmd.ExecuteNonQuery() == 1)
            {
                Response.Write("<script type=text/javascript>alert('提交成功!')</script>");
            }
            else
            {
                Response.Write("<script type=text/javascript>alert('提交失败!')</script>");
            }
        }
        catch (Exception ey) { }
        finally
        {
            conn.Close();
        }

    }

    protected void TextBox12_TextChanged(object sender, EventArgs e)
    {
        for(int i=0;i<DropDownList1.Items.Count;i++)
        {
            if(DropDownList1.Items[i].Text.ToString().Contains(TextBox12.Text.Trim().ToString()))
            {
                DropDownList1.SelectedIndex = i;
                return;
            }
        }
    }

    protected void Button2_Click(object sender, EventArgs e)
    {

    }
}