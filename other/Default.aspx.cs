using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        {
            if (!IsPostBack)
            {
                DropDownList1.Visible = false;
                Label5.Visible = false;
            }

            TextBox5.Text = "";
            DropDownList1.ToolTip = "水的密度为1.0 g/ml\n化妆品的密度为1.06 - 1.08 g/ml\n药膏的密度为1.26 - 1.28 g/ml\n牙膏的密度为1.40 - 1.48 g/ml";

        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        {
            Convert.ToInt32(TextBox1.Text.ToString().Trim());
        }
        catch (Exception e1)
        {
            Response.Write("<script language='javascript'>alert('纸箱长度不是有效的数字！')</script>");
            return;
        }
        int length = Convert.ToInt32(TextBox1.Text.ToString().Trim());
        try
        {
            Convert.ToInt32(TextBox2.Text.ToString().Trim());

        }
        catch (Exception e2)
        {
            Response.Write("<script language='javascript'>alert('纸箱宽度不是有效的数字！')</script>");
            return;
        }
        int width = Convert.ToInt32(TextBox2.Text.ToString().Trim());
        try
        {
            Convert.ToDouble(TextBox3.Text.ToString().Trim());
        }
        catch (Exception e3)
        {
            Response.Write("<script language='javascript'>alert('管径不是有效的数字！')</script>");
            return;
        }
        double dia = Convert.ToDouble(TextBox3.Text.ToString().Trim());

        double x = length / dia;
        double y = (2 * width - 2 * dia) / dia / Math.Sqrt(3) + 1;
        int xx = (int)x;
        int yy = (int)y;
        //if (x - xx >= 0.5)
        {
            Response.Write("<script language='javascript'>alert(" + xx * yy + ")</script>");
        }
        //else
        //{
        //    Response.Write("<script language='javascript'>alert(" +( xx * yy-(int)(yy/2) )+ ")</script>");
        //}
    }

    public void key()
    {
        ArrayList 管径 = new ArrayList();
        double[] tem = new double[] { 12.7, 13.5, 16, 19, 22, 25, 28, 30, 32, 35, 38, 40, 45, 50, 55, 63.5 };
        管径.AddRange(tem);
        if (TextBox4.Text == "")
        {
            TextBox5.Text = "";
            return;
        }
        double s = 0;
        string sx = TextBox4.Text.Trim().ToString();
        try
        {
            s = Convert.ToDouble(sx);
        }
        catch (Exception ex)
        {
            Response.Write("<script language='javascript'>alert(请输入数字!)</script>");

            TextBox4.Text = "";
        }
        if (radioButton2.Checked == true)
        {
            s *= 28.35;
        }

        TextBox5.Text = "";
        TextBox5.Text = "推荐以下软管规格：\n";
        for (int i = 0; i < 管径.Count; i++)
        {
            //MessageBox.Show(管径.Items[i].ToString());
            double n = (Convert.ToDouble(管径[i].ToString()));
            //MessageBox.Show(comboBox1.SelectedItem.ToString());
            double m = Convert.ToDouble(DropDownList1.SelectedItem.Value);
            int len = (int)(4000 * s / (3.14 * n * n * m) + 10 + n);
            if (len > 216)
            {

                continue;
            }

            TextBox5.Text += "Φ" + 管径[i].ToString() + " * " + len + "mm\n";
        }
    }
    protected void radioButton2_CheckedChanged(object sender, EventArgs e)
    {
        if (radioButton2.Checked)
        {
            DropDownList1.Visible = true;
            Label5.Visible = true;
            //lstboxx.Items.Add("水的密度为1.0 g/ml\n化妆品的密度为1.06 - 1.08 g/ml\n药膏的密度为1.26 - 1.28 g/ml\n牙膏的密度为1.40 - 1.48 g/ml");
            this.key();
        }
    }

    protected void radioButton1_CheckedChanged(object sender, EventArgs e)
    {
        if (radioButton1.Checked == true)
        {
            DropDownList1.SelectedIndex = 0;
            DropDownList1.Visible = false;
            Label5.Visible = false;
            this.key();
        }
    }

    protected void radioButton3_CheckedChanged(object sender, EventArgs e)
    {
        if (radioButton3.Checked)
        {
            DropDownList1.Visible = true;
            Label5.Visible = true;
            this.key();
        }
    }

    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        this.key();
    }

    protected void TextBox4_TextChanged(object sender, EventArgs e)
    {
        this.key();
    }



    protected void btnokC_Click(object sender, EventArgs e)
    {
        this.key();
    }
}