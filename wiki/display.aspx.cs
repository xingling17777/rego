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
        if (Request["path"] != null)
        {
            string[] abc = Request["path"].ToString().Split('/');
            Literal1.Text = "当前位于：-><a href=Default.aspx><h3 style='display:inline-block;'>Wiki根目录</h3></a>";
            
            string tem = "-><a href=Default.aspx?path=./rego";
            for (int i = 2; i < abc.Length-1; i++)
            {
                Literal1.Text += (tem + "/" + abc[i] + "><h3 style='display:inline-block;'>" + abc[i] + "</h3></a>");
                tem += "/" + abc[i];
            }
            Literal1.Text += "<a style='float:right;display:inline-block;' href=/wiki/edit.aspx?path=" + Request["path"].ToString()+">编辑当前页面</a>";
         
            Literal1.Text += "<hr />";
            if (File.Exists(Server.MapPath(Request["path"].ToString())))
            {
                FileStream fs = new FileStream(Server.MapPath(Request["path"].ToString()), FileMode.Open);
                StreamReader sr = new StreamReader(fs);

                Literal1.Text += sr.ReadToEnd();
                sr.Close();
                fs.Close();
            }
        }
        else
        {
            Response.Redirect("Default.aspx");
        }

    }
}