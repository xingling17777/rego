using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

//TODO:核实纸箱与托盘下拉列表是否变化，并更正；
public partial class Purch_main : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //初始化下拉列表中的数据
        if (!IsPostBack)
        {
            DataBase db = new DataBase();
            SqlConnection conn = db.getSqlConnection();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "select id,昵称 from 客户信息 order by 昵称";
            TextBox7.Text = "1";
            try
            {
                conn.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                drpcus.Items.Clear();
                while (sdr.Read())
                {
                    drpcus.Items.Add(new ListItem(sdr[1].ToString(), sdr[0].ToString()));
                }
                if (drpcus.Items.Count > 0)
                {
                    drpcus.SelectedIndex = 0;
                }
                sdr.Close();
                cmd.CommandText = "select id,编号+'→'+规格 from 片材规格 order by 规格";
                sdr = cmd.ExecuteReader();
                DropDownList2.Items.Clear();
                while (sdr.Read())
                {
                    DropDownList2.Items.Add(new ListItem(sdr[1].ToString(), sdr[0].ToString()));
                }
                if (DropDownList2.Items.Count > 0)
                {
                    DropDownList2.SelectedIndex = 0;
                }
                sdr.Close();
                cmd.CommandText = "select distinct 纸质 from 纸箱";
                DropDownList5.Items.Clear();
                sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    DropDownList5.Items.Add(sdr[0].ToString());
                }
                if (DropDownList5.Items.Count > 0)
                {
                    DropDownList5.SelectedIndex = 0;
                }
                sdr.Close();
                cmd.CommandText = "select 价格,规格 from 纸箱 where 纸质='托盘' order by 价格";
                sdr = cmd.ExecuteReader();
                DropDownList7.Items.Clear();
                while (sdr.Read())
                {
                    DropDownList7.Items.Add(new ListItem(sdr[1].ToString(), sdr[0].ToString()));
                }
                if (DropDownList7.Items.Count > 0)
                {
                    DropDownList7.SelectedIndex = 0;
                }
                sdr.Close();
                cmd.CommandText = "select 盖子,id from 盖子";
                sdr = cmd.ExecuteReader();
                DropDownList10.Items.Clear();
                while (sdr.Read())
                {
                    DropDownList10.Items.Add(new ListItem(sdr[0].ToString(), sdr[1].ToString()));
                }
                if (DropDownList10.Items.Count > 0)
                {
                    DropDownList10.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            { }
            finally
            {
                conn.Close();
            }
        }
        //初始化Label控件
        {
            Label1.Style.Add("color", "red");
            Label2.Style.Add("color", "red");
            Label3.Style.Add("color", "red");
            Label4.Style.Add("color", "red");
            Label5.Style.Add("color", "red");
            Label6.Style.Add("color", "red");
            Label7.Style.Add("color", "red");
            Label8.Style.Add("color", "red");
            Label9.Style.Add("color", "red");
            Label12.Style.Add("color", "red");
            Label11.Style.Add("color", "red");
            if (DropDownList10.SelectedIndex != -1)
            {
                Label12.Text = DropDownList10.SelectedItem.ToString();
            }
            //Label1.Text = drpcus.SelectedItem.ToString();
            Label2.Text = drptype.SelectedValue.ToString();
            Label3.Text = DropDownList1.SelectedValue.ToString();
            if (DropDownList2.SelectedIndex != -1)
            {
                Label4.Text = DropDownList2.SelectedItem.ToString();
            }
            if (RadioButton1.Checked)
            {
                Label5.Text = "印刷";
            }
            else
            {
                Label5.Text = "白管";
            }
            Label6.Text = DropDownList3.SelectedValue.ToString() + "色丝印";
            Label7.Text = DropDownList4.SelectedValue.ToString() + "色冷烫";

        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (drpcus.SelectedIndex != -1 && txtpro.Text != "" && drptype.SelectedIndex != -1 &&
            TextBox2.Text != "" && DropDownList1.SelectedIndex != -1 && TextBox1.Text != "" && DropDownList2.SelectedIndex != -1
            )
        {

        }
    }

    protected void DropDownList9_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (DropDownList9.SelectedIndex == 4)
        {
            TextBox3.Visible = true;
        }
        else
        {
            TextBox3.Visible = false;
            Label11.Text = DropDownList9.SelectedItem.ToString();
        }
    }

    protected void DropDownList5_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (DropDownList5.SelectedIndex != -1)
        {
            SqlConnection conn = new DataBase().getSqlConnection();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "select 价格,规格 from 纸箱 where 纸质='" + DropDownList5.SelectedValue.ToString() + "' order by 规格";
            try
            {
                conn.Open();

                SqlDataReader sdr = cmd.ExecuteReader();
                DropDownList6.Items.Clear();
                while (sdr.Read())
                {
                    DropDownList6.Items.Add(new ListItem(sdr[1].ToString(), sdr[0].ToString()));
                }
                DropDownList6.SelectedIndex = 0;
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

    protected void DropDownList6_SelectedIndexChanged(object sender, EventArgs e)
    {
        Label8.Text = DropDownList5.SelectedItem.ToString() + DropDownList6.SelectedItem.ToString();
    }

    protected void DropDownList7_SelectedIndexChanged(object sender, EventArgs e)
    {
        Label9.Text = DropDownList7.SelectedItem.ToString();
    }

    protected void Button1_Click1(object sender, EventArgs e)
    //提交按钮
    {
        //不为空则开始计算
        if (drpcus.SelectedIndex != -1 && txtpro.Text != "" && drptype.SelectedIndex != -1 &&
           DropDownList1.SelectedIndex != -1 && TextBox1.Text != "" && DropDownList2.SelectedIndex != -1 && TextBox2.Text != "")
        {
            string keynote;
            //客户名称
            string cusname = drpcus.SelectedItem.ToString();
            //产品名称
            string product = txtpro.Text.Trim();
            //软管类别
            string type = drptype.SelectedValue.ToString();
            //订单数量
            int count = 0;
            try
            {
                count = Convert.ToInt32(TextBox2.Text.Trim());
            }
            catch (Exception ey)
            {
                //应给出提示并结束程序
            }
            //直径
            double dia = Convert.ToDouble(DropDownList1.SelectedValue.ToString());
            //管长
            double length = Convert.ToDouble(TextBox1.Text.Trim());
            SqlConnection conn = new DataBase().getSqlConnection();
            SqlCommand cmd = conn.CreateCommand();
            //提取片材单价
            cmd.CommandText = "select 单价 from 片材规格 where id=" + DropDownList2.SelectedValue; ;
            SqlDataReader sdr = null;
            double web = 0;
            try
            {
                conn.Open();
                sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    web = Convert.ToDouble(sdr[0].ToString());
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                sdr.Close();
                conn.Close();
            }
            //单支管所用面积
            double squqre = (3.14 * dia + 3) * length / 1000000;
            //柔印单价
            double print = 0;
            if (RadioButton1.Checked)
            {
                print = 1.2;
            }
            keynote = "(((" + web + "+" + print + "+2.5*" + DropDownList3.SelectedValue + "+4.8*" + DropDownList4.SelectedValue + ")*" + "(3.14*" + dia + "+3)*" + length + "/1000000";
            //印刷部分价格
            double temp = (web + print + 2.5 * Convert.ToInt32(DropDownList3.SelectedValue) + 4.8 * Convert.ToInt32(DropDownList4.SelectedValue)) * squqre;
            //管肩
            double shoulder = 0;

            cmd.CommandText = "select * from 管肩 where 管径=" + DropDownList1.SelectedValue;

            try
            {
                conn.Open();
                sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    shoulder = Convert.ToDouble(sdr[2].ToString());
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                sdr.Close();
                conn.Close();
            }
            double sunhao = 0;
            double lirun = 0;
            int xcount = (int)(count / 10000);

            if (xcount >= 10)
            {
                cmd.CommandText = "select * from 损耗利润 where 数量=10 and 软管类型='" + drptype.SelectedItem.ToString() + "'";
                try
                {
                    conn.Open();
                    sdr = cmd.ExecuteReader();
                    if (sdr.Read())
                    {
                        sunhao = Convert.ToDouble(sdr[3].ToString());
                        lirun = Convert.ToDouble(sdr[4].ToString());

                    }
                }
                catch (Exception ex)
                {

                }
                finally
                {
                    sdr.Close();
                    conn.Close();
                }
            }
            else
            {
                for (; xcount > 0; xcount--)
                {
                    cmd.CommandText = "select * from 损耗利润 where 数量=" + xcount + " and 软管类型 = '" + drptype.SelectedItem.ToString() + "'";
                    try
                    {
                        conn.Open();
                        sdr = cmd.ExecuteReader();
                        if (sdr.Read())
                        {
                            sunhao = Convert.ToDouble(sdr[3].ToString());
                            lirun = Convert.ToDouble(sdr[4].ToString());
                            break;
                        }
                    }
                    catch (Exception ex)
                    {

                    }
                    finally
                    {
                        sdr.Close();
                        conn.Close();
                    }

                }
            }
            //加管肩价格
            temp += 15 * shoulder / 1000;
            keynote += "+15*" + shoulder + "/1000)/(1-" + sunhao;
            //满版,损耗加5个点
            if (RadioButton3.Checked)
            {

                sunhao += 0.05;
                keynote += "-0.05";
                if (drptype.SelectedIndex == 1)
                {
                    lirun = 0.3;
                }
            }
            //定位,损耗加5个点
            if (RadioButton11.Checked)
            {
                sunhao += 0.05;
                keynote += "-0.05";
            }
            //封尾,损耗加5个点
            if (RadioButton7.Checked)
            {
                sunhao += 0.05;
                keynote += "-0.05";
            }

            //成品率
            temp /= (1 - sunhao);
            keynote += ")";
            //盖子
            double cap = 0;
            cmd.CommandText = "select 价格 from 盖子 where id=" + DropDownList10.SelectedValue;
            try
            {
                conn.Open();
                sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    cap = Convert.ToDouble(sdr[0].ToString());
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                sdr.Close();
                conn.Close();
            }
            temp += cap;
            keynote += "+" + cap;
            //封膜
            if (RadioButton5.Checked)
            {
                temp += 0.015;
                keynote += "+0.015";
            }
            //定位
            if (RadioButton11.Checked)
            {
                temp += 0.03;
                keynote += "+0.03";
            }
            //封尾
            if (RadioButton7.Checked)
            {
                temp += 0.06;
                keynote += "+0.06";
            }

            //纸箱
            int countperlayer = Convert.ToInt32(TextBox6.Text.Trim());
            int layer = Convert.ToInt32(TextBox7.Text.Trim());
            temp += Convert.ToDouble(DropDownList6.SelectedValue) / countperlayer / layer * 1.3;
            keynote += "+" + DropDownList6.SelectedValue + "/" + countperlayer + "/" + layer + "*1.3";
            temp += Convert.ToDouble(DropDownList7.SelectedValue) / countperlayer * 1.3;
            keynote += "+" + DropDownList7.SelectedValue + "/" + countperlayer + "*1.3";
            //运费
            //广东省内
            double trans = 0;
            if (DropDownList9.SelectedIndex == 1)
            {
                if (Convert.ToInt32(DropDownList1.SelectedValue) < 31)
                {
                    trans = 0.0095;
                    temp += 0.0095;
                    keynote += "+0.0095";
                }
                else
                {
                    trans = 0.0149;
                    temp += 0.0149;
                    keynote += "+0.0149";
                }

            }
            //广东省外
            if (DropDownList9.SelectedIndex == 2)
            {
                if (Convert.ToDouble(DropDownList1.SelectedValue) < 31)
                {
                    trans = 0.037;
                    temp += 0.037;
                    keynote += "+0.037";
                }
                else
                {
                    trans = 0.045;
                    temp += 0.045;
                    keynote += "+0.045";
                }
            }
            //FOB
            if (DropDownList9.SelectedIndex == 3)
            {
                string[] temev = DropDownList6.SelectedItem.ToString().Split('*');
                double v3 = Convert.ToDouble(temev[0]) / 1000 * Convert.ToDouble(temev[1]) / 1000 * Convert.ToDouble(temev[2]) / 1000;
                double xvy = count / layer / countperlayer * v3;

                if (xvy <= 5)
                {
                    trans = 3100 / count;
                    temp += 3100 / count;
                    keynote += "3100 / " + count;
                }
                else if (xvy <= 10)
                {
                    trans = 3500 / count;
                    temp += 3500 / count;
                    keynote += "3500 / " + count;
                }
                else if (xvy <= 15)
                {
                    trans = 3800 / count;
                    temp += 3800 / count;
                    keynote += "3800 / " + count;
                }
                else if (xvy <= 20)
                {
                    trans = 4500 / count;
                    temp += 4500 / count;
                    keynote += "4500 / " + count;
                }
                else if (xvy <= 25)
                {
                    trans = 5800 / count;
                    temp += 5800 / count;
                    keynote += "5800 / " + count;
                }
                else if (xvy <= 60)
                {
                    trans = 6000 / count;
                    temp += 6000 / count;
                    keynote += "6000 / " + count;
                }
                else
                {
                    //TODO:需重新设计此部分计算方式.
                    TextBox3.Visible = true;
                    TextBox3.Text = xvy.ToString() + "请手动设置运费";
                    //temp += 6000 / count;
                }
            }
            //手动设定运费
            if (DropDownList9.SelectedIndex == 4)
            {
                trans = temp += Convert.ToDouble(TextBox3.Text.Trim());
                keynote += "+" + TextBox3.Text;
            }
            //人工水电
            temp += 0.05;
            keynote += "+0.05";
            temp *= (1 + lirun);
            keynote += ")*(1+" + lirun + ")";
            if (RadioButton9.Checked)
            {
                temp *= (1 + 0.105);
                keynote += "*(1+0.105)";
            }
            //Response.Write("<script type='text/javascript'>alert('" + temp + "')</script>");
            cmd.CommandText = "insert into 核价单 values ('" + cusname + "','" + product + "','" + type + "'," + count + "," + dia + "," + length + ",'" + DropDownList2.SelectedItem.ToString() + "','" + (RadioButton1.Checked ? "是" : "否") + "',"
                + DropDownList3.SelectedValue + "," + DropDownList4.SelectedValue + ",'" + (RadioButton3.Checked ? "是" : "否") + "','" + (RadioButton5.Checked ? "是" : "否") + "','" + DropDownList10.SelectedItem.ToString() + "','" + (RadioButton11.Checked ? "是" : "否") + "','" + (RadioButton7.Checked ? "是" : "否") + "','" +
                DropDownList5.SelectedItem.ToString() + DropDownList6.SelectedItem.ToString() + "','" + DropDownList7.SelectedItem.ToString() + "'," +
                TextBox6.Text + "," + TextBox7.Text + "," + trans + "," + (TextBox4.Text == "" ? "0" : TextBox4.Text) + ",'" + (RadioButton3.Checked ? "是" : "否") + "','" + keynote + "','" + TextBox5.Text + "'," + temp + ")";
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ey)
            { }
            finally
            {
                TextBox2.Text = "";
                conn.Close();
            }
        }
    }

    protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
    {
        Label4.Text = DropDownList2.SelectedItem.ToString();
    }
}