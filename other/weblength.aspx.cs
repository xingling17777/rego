using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class other_weblength : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {

        if (txtbox1.Text != "" && txtdia.Text != "")
        {
            double wei = 0;
            double dia = 0;
            try
            {
                wei = Convert.ToDouble(txtbox1.Text.Trim().ToString());
                dia = Convert.ToDouble(txtdia.Text.Trim().ToString());
            }
            catch { }
            finally { }
            double length = 0;
            double DIA = 0;
            if (radiobtn3.Checked == true)
            {
                DIA = 93;
            }
            else
            {
                DIA = 175;
            }
            if (rbtrol.Checked == true)
            {
                length = 3.14 * (dia + DIA) * (dia - DIA) / 4 / wei;

            }
            else
            {
                length = Math.Sqrt(dia * 4 * wei / 3.14 + DIA * DIA);
            }
            
            Label1.Text = (rbtrol.Checked?"片材长度(m):  ":"卷绕外径(mm):  ")+ length.ToString("f2");
        }
    }


}