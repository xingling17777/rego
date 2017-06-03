using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class other_cartoon : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        if(TextBox1.Text!="")
        {
            double length = 0;
            try
            {
                length = Convert.ToDouble(TextBox1.Text.Trim().ToString());
            }
            catch(Exception ex)
            {
                return;
            }
            ListBox1.Items.Clear();
            ListBox1.Items.Add("装一层,纸箱为BLC/ALB 620*400*"+((length+8)%10>2?((int)(length+8)/10+1)*10: ((int)(length+8) / 10 ) * 10));
            int lemp= (int)((length + 5) * 2 + 20);
            ListBox1.Items.Add("装两层,纸箱为BL3LB 600*400*" +(lemp%10<=2? lemp/10*10:(lemp/10<5? lemp/ 10*10+5:lemp/ 10 *10+ 10)));
            lemp = (int)((length + 5) * 3 + 20);
            if (lemp > 630)
                return;
            ListBox1.Items.Add("装三层,纸箱为BL3LB 600*400*" + (lemp % 10 <= 2 ? lemp / 10 * 10 : (lemp % 10 < 5 ? lemp / 10 * 10 + 5 : lemp / 10 * 10 + 10)));
            lemp = (int)((length + 5) * 4 + 20); if (lemp > 630)
                return;
            ListBox1.Items.Add("装四层,纸箱为BL3LB 600*400*" + (lemp % 10 <= 2 ? lemp / 10 * 10 : (lemp % 10 < 5 ? lemp / 10 * 10 + 5 : lemp / 10 * 10 + 10)));
            lemp = (int)((length + 5) * 5 + 20); if (lemp > 630)
                return;
            ListBox1.Items.Add("装五层,纸箱为BL3LB 600*400*" + (lemp % 10 <= 2 ? lemp / 10 * 10 : (lemp % 10 < 5 ? lemp / 10 * 10 + 5 : lemp / 10 * 10 + 10)));
        }
    }
}