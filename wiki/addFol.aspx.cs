using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

public partial class wiki_addFol : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(Request["path"]==null)
        {
            Response.Redirect("/wiki/Default.aspx");
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        if(TextBox1.Text.Trim().ToString()!="")
        {
            Directory.CreateDirectory(Server.MapPath(Request["path"].ToString()) + "\\" + TextBox1.Text.Trim().ToString());
        }
        Response.Redirect("/wiki/Default.aspx?path=" + Request["path"].ToString());
    }
}