using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class other_video : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(ListBox1.SelectedIndex==-1)
        {
            ListBox1.SelectedIndex = 0;
        }
    }
}