using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

public partial class wiki_display : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request["path"] != null) { 
        if (File.Exists(Server.MapPath(Request["path"].ToString())))
        {
            FileStream fs = new FileStream(Server.MapPath(Request["path"].ToString()), FileMode.Open);
            StreamReader sr = new StreamReader(fs);

           Literal1.Text= sr.ReadToEnd();
            sr.Close();
            fs.Close();
        }
        }
        else
        {
            Response.Redirect("/wiki/Default.aspx");
        }

    }
}