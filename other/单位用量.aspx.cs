using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class other_单位用量 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        double dia = 0;
       if(TextBox1.Text.ToString()=="")
        {
            Response.Write("<script language=javascript>alert('管径不能为空！')</script>");
            return;
        }
        try
        {
            dia = Convert.ToDouble(TextBox1.Text.Trim().ToString());
        }
        catch(Exception ey)
        {
            Response.Write("<script language=javascript>alert('请输入正确的管径值')</script>");
            return;
        }

        //tube length;
        double length = 0;
        if (TextBox2.Text.ToString() == "")
        {
            Response.Write("<script language=javascript>alert('管长不能为空！')</script>");
            return;
        }
        try
        {
            length = Convert.ToDouble(TextBox2.Text.Trim().ToString());
        }
        catch (Exception ey)
        {
            Response.Write("<script language=javascript>alert('请输入正确的管长值！')</script>");
            return;
        }
        if(dia==0 || length==0)
        {
            Response.Write("<script language=javascript>alert('管径或管长不能为0！')</script>");
            return;
        }
        double width = 0;
        if (TextBox3.Text != "") { 
        try
        {
           width = Convert.ToDouble(TextBox3.Text.Trim().ToString());
        }
        catch (Exception ey)
        {
            Response.Write("<script language=javascript>alert('请输入正确的片材宽度！')</script>");
            return;
        }
        }
        if(width!=0)
        {
            int n = (int)(width / 3.14 / dia);
            if(n==0)
            {
                Response.Write("<script language=javascript>alert('片材宽度不够！')</script>");
                return;
            }
            Label1.Text = (width * length / n / 1000000).ToString();
        }
        Label2.Text = (length / 1000).ToString();
        int mm = 0;
        
        if (TextBox4.Text != "")
        {
            try
            {
                mm = Convert.ToInt32(TextBox4.Text.Trim().ToString());
            }
            catch (Exception ey)
            {
                Response.Write("<script language=javascript>alert('请输入纸箱正确的装箱数量！')</script>");
                return;
            }
            Label3.Text = (1.0 / mm).ToString();
        }
        if (TextBox5.Text != "")
        {
            try
            {
                mm = Convert.ToInt32(TextBox5.Text.Trim().ToString());
            }
            catch (Exception ey)
            {
                Response.Write("<script language=javascript>alert('请输入托盘正确的装箱数量！')</script>");
                return;
            }
            Label4.Text = (1.0 / mm).ToString();
        }
    }
}