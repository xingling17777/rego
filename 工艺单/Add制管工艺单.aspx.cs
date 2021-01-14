using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class 工艺单_Add制管工艺单 : System.Web.UI.Page
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
                if (DropDownList1.Items.Count != 0)
                {
                    DropDownList1.SelectedIndex = 0;
                    DropDownList1_SelectedIndexChanged(this.DropDownList1, e);
                }
            }
            else
            {
                //DropDownList1.SelectedIndex = x;
            }
        }
    }

    protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
    {

        if (DropDownList2.SelectedIndex != -1)
        {
            string id = DropDownList2.SelectedValue.ToString();
            SqlConnection conn = new DataBase().getSqlConnection();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "select * from 基础技术要求表 where no='" + id + "'";
            double dia = 0;
            double length = 0;
            double diamouth = 0;
            try
            {
                conn.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                while(sdr.Read())
                {
                    Label1.Text = sdr[7].ToString();
                    Label2.Text = sdr[16].ToString();
                    Label4.Text = "Φ"+sdr[2].ToString();
                    Label5.Text = sdr[13].ToString()+ sdr[14].ToString();
                }
            }
            catch(Exception ey) { }
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
            string id = DropDownList1.SelectedValue.ToString();
            SqlConnection conn = new DataBase().getSqlConnection();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "select id, name from 成品编码_产品 where customer=" + id + " order by name";
            try
            {
                conn.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
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
            if (DropDownList2.Items.Count != 0)
            {
                DropDownList2.SelectedIndex = 0;
            }
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        string ProductID = DropDownList2.SelectedValue.ToString();
        string ModelNO = TextBox52.Text.Trim().ToString();
        string LuoWen = TextBox2.Text.Trim().ToString();
        double length1 = 0, length2 = 0, length3 = 0;
        try
        {
            length1 = Convert.ToDouble(TextBox3.Text.Trim().ToString());
        }
        catch (Exception ey) { }
        try
        {
            length2 = Convert.ToDouble(TextBox4.Text.Trim().ToString());
        }
        catch (Exception ey) { }
        try
        {
            length3 = Convert.ToDouble(TextBox5.Text.Trim().ToString());
        }
        catch (Exception ey) { }
        double OutDia1 = 0, OutDia2 = 0, OutDia3 = 0;
        try
        {
            OutDia1 = Convert.ToDouble(TextBox6.Text.Trim().ToString());
        }
        catch (Exception ey) { }
        try
        {
            OutDia2 = Convert.ToDouble(TextBox7.Text.Trim().ToString());
        }
        catch (Exception ey) { }
        try
        {
            OutDia3 = Convert.ToDouble(TextBox8.Text.Trim().ToString());
        }
        catch (Exception ey) { }
        double InnerDia1 = 0, InnerDia2 = 0, InnerDia3 = 0;
        try
        {
            InnerDia1 = Convert.ToDouble(TextBox9.Text.Trim().ToString());
        }
        catch (Exception ey) { }
        try
        {
            InnerDia2 = Convert.ToDouble(TextBox10.Text.Trim().ToString());
        }
        catch (Exception ey) { }
        try
        {
            InnerDia3 = Convert.ToDouble(TextBox11.Text.Trim().ToString());
        }
        catch (Exception ey) { }
        double MouthInnerDia1 = 0, MouthInnerDia2 = 0, MouthInnerDia3 = 0;
        try
        {
            MouthInnerDia1 = Convert.ToDouble(TextBox12.Text.Trim().ToString());
        }
        catch (Exception ey) { }
        try
        {
            MouthInnerDia2 = Convert.ToDouble(TextBox13.Text.Trim().ToString());
        }
        catch (Exception ey) { }
        try
        {
            MouthInnerDia3 = Convert.ToDouble(TextBox14.Text.Trim().ToString());
        }
        catch (Exception ey) { }
        double E001 = 0, E002 = 0, E003 = 0;
        try
        {
            E001 = Convert.ToDouble(TextBox15.Text.Trim().ToString());
        }
        catch (Exception ey) { }
        try
        {
            E002 = Convert.ToDouble(TextBox16.Text.Trim().ToString());
        }
        catch (Exception ey) { }
        try
        {
            E003 = Convert.ToDouble(TextBox17.Text.Trim().ToString());
        }
        catch (Exception ey) { }
        double F001 = 0, F002 = 0, F003 = 0;
        try
        {
            F001 = Convert.ToDouble(TextBox18.Text.Trim().ToString());
        }
        catch (Exception ey) { }
        try
        {
            F002 = Convert.ToDouble(TextBox19.Text.Trim().ToString());
        }
        catch (Exception ey) { }
        try
        {
            F003 = Convert.ToDouble(TextBox20.Text.Trim().ToString());
        }
        catch (Exception ey) { }
        double G001 = 0, G002 = 0, G003 = 0;
        try
        {
            G001 = Convert.ToDouble(TextBox21.Text.Trim().ToString());
        }
        catch (Exception ey) { }
        try
        {
            G002 = Convert.ToDouble(TextBox22.Text.Trim().ToString());
        }
        catch (Exception ey) { }
        try
        {
            G003 = Convert.ToDouble(TextBox23.Text.Trim().ToString());
        }
        catch (Exception ey) { }
        double H001 = 0;
        try
        {
            H001 = Convert.ToDouble(TextBox24.Text.Trim().ToString());
        }
        catch (Exception ey) { }
        double I001 = 0, I002 = 0, I003 = 0;
        try
        {
            I001 = Convert.ToDouble(TextBox25.Text.Trim().ToString());
        }
        catch (Exception ey) { }
        try
        {
            I002 = Convert.ToDouble(TextBox26.Text.Trim().ToString());
        }
        catch (Exception ey) { }
        try
        {
            I003 = Convert.ToDouble(TextBox27.Text.Trim().ToString());
        }
        catch (Exception ey) { }
        double K001 = 0, K002 = 0;
        try
        {
            K001 = Convert.ToDouble(TextBox28.Text.Trim().ToString());
        }
        catch (Exception ey)
        {

        }
        try
        {
            K002 = Convert.ToDouble(TextBox29.Text.Trim().ToString());
        }
        catch (Exception ey) { }
        double L001 = 0, L002 = 0, L003 = 0;
        try
        {
            L001 = Convert.ToDouble(TextBox30.Text.Trim().ToString());
        }
        catch (Exception ey) { }
        try
        {
            L002 = Convert.ToDouble(TextBox31.Text.Trim().ToString());
        }
        catch (Exception ey) { }
        try
        {
            L003 = Convert.ToDouble(TextBox32.Text.Trim().ToString());
        }
        catch (Exception ey) { }
        double N001, N002;
        try
        {
            N001 = Convert.ToDouble(TextBox33.Text.Trim().ToString());
        }
        catch(Exception ey) { }
        try
        {
            N002 = Convert.ToDouble(TextBox34.Text.Trim().ToString());
        }
        catch (Exception ey) { }
        double O001;
        try
        {
            O001 = Convert.ToDouble(TextBox35.Text.Trim().ToString());
        }
        catch (Exception ey) { }
        double Q001, R001, S001, U001;
        try
        {
            Q001 = Convert.ToDouble(TextBox36.Text.Trim().ToString());
        }
        catch (Exception ey) { }
        try
        {
            R001 = Convert.ToDouble(TextBox37.Text.Trim().ToString());
        }
        catch (Exception ey) { }
        try
        {
            S001 = Convert.ToDouble(TextBox38.Text.Trim().ToString());
        }
        catch (Exception ey) { }
        try
        {
            U001 = Convert.ToDouble(TextBox39.Text.Trim().ToString());
        }
        catch (Exception ey) { }
        string FengMo = "";
        if(RadioButton1.Checked)
        {
            FengMo = RadioButton1.ToString();
        }
        if (RadioButton2.Checked)
        {
            FengMo = RadioButton2.ToString();
        }
        if (RadioButton3.Checked)
        {
            FengMo = RadioButton3.ToString();
        }
        if (RadioButton4.Checked)
        {
            FengMo = RadioButton4.ToString();
        }
        double LengthFengWei = 0;
        try
        {
            LengthFengWei = Convert.ToDouble(TextBox40.Text.Trim().ToString());
        }
        catch(Exception ey) { }
        double WidthYaWen = 0;
        try
        {
            WidthYaWen = Convert.ToDouble(TextBox41.Text.Trim().ToString());
        }
        catch (Exception ey) { }
        string ZhiXiang = TextBox42.Text.Trim().ToString();
        string TuoPan= TextBox43.Text.Trim().ToString();
        int ZhuangXiangZhiShu = 0;
        try
        {
            ZhuangXiangZhiShu = Convert.ToInt32(TextBox44.Text.Trim().ToString());
        }
        catch (Exception ey) { }
        string NeiMoDai = TextBox45.Text.Trim().ToString();
        string ZhuangXiangFangShi = RadioButtonList1.SelectedValue;
        string NeiMoDaiYaoQiu= TextBox46.Text.Trim().ToString();
        string FengXiangFangShi = RadioButtonList2.SelectedValue;
        string FengXiangJiaoYaoQiu = RadioButtonList3.SelectedValue;
        string TuoPanGuiGe= TextBox47.Text.Trim().ToString();
        int xxxx, yyyy, zzzz;
        try
        {
            xxxx = Convert.ToInt32(TextBox48.Text.Trim().ToString());
            yyyy = Convert.ToInt32(TextBox49.Text.Trim().ToString());
            zzzz = Convert.ToInt32(TextBox50.Text.Trim().ToString());
        }
        catch(Exception ey) { }
        string Mark = TextBox51.Text.Trim().ToString();
        //先判断数据库里面有没有这一款的工艺单，如有，则不提交数据；
        SqlConnection conn = new DataBase().getSqlConnection();
        SqlCommand cmd = conn.CreateCommand();
        cmd.CommandText = "select * from ";
    }
}