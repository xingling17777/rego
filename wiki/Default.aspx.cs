using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

public partial class wiki_Default : System.Web.UI.Page
{
    string path = "./rego";

    protected void finder(string pathFile)
    {
        if(Directory.Exists(Server.MapPath(pathFile)))
        {
            string[] dir = Directory.GetDirectories(Server.MapPath(pathFile));
            foreach (string s in dir)
            {
                TableRow row1 = new TableRow();
                TableCell cell1 = new TableCell();
                cell1.Text = "<img src=/img/folder.png />";
                TableCell cell2 = new TableCell();
                
                LinkButton lbt = new LinkButton();
                lbt.PostBackUrl = "/wiki/Default.aspx?path=" + pathFile + "/" + Path.GetFileName(s);
                lbt.Text = Path.GetFileName(s);
                cell2.Controls.Add(lbt);
                row1.Cells.Add(cell1);
                row1.Cells.Add(cell2);
                Table1.Rows.Add(row1);
            }
            string[] fil = Directory.GetFiles(Server.MapPath(pathFile));
            foreach (string s in fil)
            {
                if(Path.GetExtension(s)!=".wk")//过滤文件
                {
                    continue;
                }
                TableRow row2 = new TableRow();
                TableCell cell21 = new TableCell();
                cell21.Text = "<img src=/img/page.png />";
                TableCell cell22 = new TableCell();
                
                LinkButton lbtn = new LinkButton();
                lbtn.PostBackUrl = "/wiki/Default.aspx?path=" + pathFile + "/" + Path.GetFileName(s);
                lbtn.Text=Path.GetFileNameWithoutExtension(s);
                cell22.Controls.Add(lbtn);
                row2.Cells.Add(cell21);
                row2.Cells.Add(cell22);
                Table1.Rows.Add(row2);
            }
        }
        else
        {
            Response.Redirect("display.aspx?path="+ pathFile);
        }


    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if(Request["path"]!=null)
        {
            path = Request["path"].ToString();
        }
        this.finder(path);
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("/wiki/addFol.aspx?path="+path);
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("/wiki/edit.aspx?path="+ path);
    }
}