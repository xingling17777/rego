using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

public partial class wiki_edit : System.Web.UI.Page
{
    public bool fileexist()
    {
        if (Request["path"] != null)
        {
            if(File.Exists(Request["path"].ToString()))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        return false;

    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if(fileexist())
        {
            FileStream fs = new FileStream(Request["path"].ToString(),FileMode.Open);
            StreamReader sr = new StreamReader(fs);

            content1.Value = sr.ReadToEnd();
            sr.Close();
            fs.Close();
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        if(fileexist())
        {
            FileStream fs = new FileStream(Request["path"].ToString(), FileMode.Open);
            StreamWriter sw = new StreamWriter(fs);
            sw.Write(content1.Value.ToString());
            sw.Close();
            fs.Close();

        }
        else
        {
            FileStream fs = new FileStream(Request["path"].ToString()+"\\"+TextBox1.Text.Trim().ToString()+".wk", FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);
            sw.Write(content1.Value.ToString());
            sw.Close();
            fs.Close();
        }
        Response.Redirect("/wiki");
    }
}