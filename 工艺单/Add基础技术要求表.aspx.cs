using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class 工艺单_Add基础技术要求表 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (new UserAccess().getUserAccess("基础技术要求表", 1))
        {
            DropDownList1.Items.Clear();
            SqlConnection conn = new DataBase().getSqlConnection();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "select * from 客户信息 order by name";
            try
            {
                conn.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
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
            if (DropDownList1.Items.Count > 0)
            {
                DropDownList1.SelectedIndex = 0;
            }
            if (DropDownList1.SelectedIndex != -1)
            {
                DropDownList2.Items.Clear();
                cmd.CommandText = "select * from 成品编码_产品 where customer=" + DropDownList1.SelectedValue.ToString() + " order by name";
                try
                {
                    conn.Open();
                    SqlDataReader sdr = cmd.ExecuteReader() ;
                    while (sdr.Read())
                    {
                        DropDownList2.Items.Add(new ListItem(sdr[2].ToString(), sdr[0].ToString()));
                    }
                }
                catch (Exception ey) { }
                finally
                {
                    conn.Close();
                }
                if (DropDownList2.Items.Count > 0)
                {
                    DropDownList2.SelectedIndex = 0;
                }
            }

        }
    }

    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (DropDownList1.SelectedIndex != -1)
        {
            DropDownList2.Items.Clear();
            SqlConnection conn = new DataBase().getSqlConnection();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "select * from 成品编码_产品 where customer=" + DropDownList1.SelectedValue.ToString() + " order by name";
            try
            {
                conn.Open();
                SqlDataReader sdr = null;
                while (sdr.Read())
                {
                    DropDownList2.Items.Add(new ListItem(sdr[2].ToString(), sdr[0].ToString()));
                }
            }
            catch (Exception ey) { }
            finally
            {
                conn.Close();
            }
            if (DropDownList2.Items.Count > 0)
            {
                DropDownList2.SelectedIndex = 0;
            }
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        string id = "";
        if (DropDownList2.SelectedIndex != -1)
        {
            id = DropDownList2.SelectedValue.ToString();
        }
        else
        {

            Response.Write("<script type='text/javascript'>alert('请选择产品！')</script>");
        }
        double dia = 0;
        if (TextBox1.Text != "")
        {
            try { dia = Convert.ToDouble(TextBox1.Text.ToString()); }
            catch (Exception ey)
            {
                Response.Write("<script type='text/javascript'>alert('请输入正确的管径数值！')</script>");
            }
        }
        else
        {
            Response.Write("<script type='text/javascript'>alert('请输入正确的管径数值！')</script>");
        }
        double length = 0;
        if (TextBox2.Text != "")
        {
            try { length = Convert.ToDouble(TextBox2.Text.ToString()); }
            catch (Exception ey)
            {
                Response.Write("<script type='text/javascript'>alert('请输入正确的管长数值！')</script>");
            }
        }
        else
        {
            Response.Write("<script type='text/javascript'>alert('请输入正确的管长数值！')</script>");
        }
        string standard = "";
        if (RadioButton1.Checked)
        {
            standard = "企业标准";
        }
        else
        {
            standard = "客户标准";
        }
        string neirongwu = "";
        if (RadioButton3.Checked)
        {
            neirongwu = "牙膏";
        }
        if (RadioButton4.Checked)
        {
            neirongwu = "化妆品";
        }
        if (RadioButton5.Checked)
        {
            neirongwu = "其它";
        }
        string guoyou = "";
        if (RadioButton6.Checked)
        {
            guoyou = "光油";
        }
        if (RadioButton7.Checked)
        {
            guoyou = "哑油";
        }
        if (RadioButton8.Checked)
        {
            guoyou = "局部光哑油";
        }
        string web = "";
        if (TextBox4.Text != "")
        {
            web = TextBox4.Text.Trim().ToString();
        }
        double width = 0;
        if (TextBox5.Text != "")
        {
            try
            {
                width = Convert.ToDouble(TextBox5.Text.Trim().ToString());
            }
            catch (Exception ey) { }

        }
        string ManBan = "否";
        if (RadioButton9.Checked)
        {
            ManBan = "是";
        }
        string ModelNo = "";
        ModelNo = TextBox6.Text.Trim().ToString();
        double MouthDia = 0;
        if (TextBox7.Text != "")
        {
            try
            {
                MouthDia = Convert.ToDouble(TextBox7.Text.Trim().ToString());
            }
            catch (Exception ey) { }
        }
        //封膜
        string sealing = "否";
        if (RadioButton11.Checked)
        {
            sealing = "是";
        }
        //封尾
        string FengWei = "否";
        if (RadioButton14.Checked)
        {
            FengWei = "封直角";
        }
        if (RadioButton15.Checked)
        {
            FengWei = "封圆角";
        }
        if (RadioButton16.Checked)
        {
            FengWei = "封扇形";
        }
        //帽盖名称
        string CapType = "";
        CapType = TextBox8.Text.Trim().ToString();
        //帽盖颜色
        string CapColor = "";
        CapColor = TextBox9.Text.Trim().ToString();
        //管肩颜色
        string ShoulderColor = "";
        ShoulderColor = TextBox10.Text.Trim().ToString();
        //帽盖定位
        string CapOnly = "否";
        if (RadioButton17.Checked)
        {
            CapOnly = "是";
        }
        //纸箱尺寸
        string CartonSize = "";
        CartonSize = TextBox11.Text.Trim().ToString();
        //托盘尺寸
        string TuoPanSize = "";
        TuoPanSize = TextBox12.Text.Trim().ToString();
        //纸箱材质
        string CartonType = "A4B";
        if (RadioButton19.Checked)
        {
            CartonType = "B4B";
        }
        if (RadioButton21.Checked)
        {
            CartonType = "BL3LB";
        }
        if (RadioButton22.Checked)
        {
            CartonType = "KOK";
        }
        if (RadioButton23.Checked)
        {
            CartonType = "K=A";
        }
        //装箱支数
        int Num = 0;
        try
        {
            Num = Convert.ToInt32(TextBox13.Text.Trim().ToString());
        }
        catch (Exception ey)
        {

        }
        //装箱方向
        string TubeDirection = "管尾向上";
        if (RadioButton25.Checked)
        {
            TubeDirection = "管尾向下";
        }
        //内膜袋规格
        string MoDaiSize = TextBox14.Text.Trim().ToString();
        //封箱胶
        string FengXiangJiao = "无";
        if (RadioButton27.Checked)
        {
            FengXiangJiao = "有LOGO";
        }
        if (RadioButton28.Checked)
        {
            FengXiangJiao = "无LOGO";
        }
        //封箱方式
        string FengXiangType = "无";
        if (RadioButton29.Checked)
        {
            FengXiangType = "一字封";
        }
        if (RadioButton30.Checked)
        {
            FengXiangType = "工字封";
        }
        if (RadioButton31.Checked)
        {
            FengXiangType = "十字封";
        }
        //备注
        string ReMark = TextBox15.Text.Trim().ToString();

        //提交到数据库
        if (id != "")
        {
            SqlConnection conn = new DataBase().getSqlConnection();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "select count(*) from 基础技术要求表 where no='" + id + "'";
            try
            {
                conn.Open();
                if (cmd.ExecuteScalar().ToString() != "0")
                {
                    Response.Write("<script type='text/javascript'>alert('重复的数据，请勿再次提交！')</script>");

                }

            }
            catch (Exception ey) { }
            finally
            {
                conn.Close();
            }
            cmd.CommandText = "insert into 基础技术要求表 values('" + id + "'," + dia + "," + length + ",'" + standard + "','" + neirongwu + "','" + guoyou + "','" + web + "'," + width + ",'" + ManBan + "','" + ModelNo + "'," + MouthDia + ",'" + sealing + "','" + FengWei + "','" + CapType + "','" + CapColor + "','" + ShoulderColor + "','" + CapOnly + "','" + CartonSize + "','" + TuoPanSize + "','" + CartonType + "'," + Num + ",'" + TubeDirection + "','" + MoDaiSize + "','" + FengXiangJiao + "','" + FengXiangType + "','" + ReMark + "')";
            try
            {
                conn.Open();
                if (cmd.ExecuteNonQuery() == 1)
                {
                    Response.Write("<script type='text/javascript'>alert('数据提交成功！')</script>");
                }
                else
                {
                    Response.Write("<script type='text/javascript'>alert('数据提交失败！')</script>");
                }
            }
            catch (Exception ey) { }
            finally
            {
                conn.Close();
            }
        }
    }
}