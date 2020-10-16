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
                cell1.Text = "<img src=../img/folder.png />";
                cell1.Style.Add("width", "30px");
                TableCell cell2 = new TableCell();
                cell2.Style.Add("text-align", "left");
                LinkButton lbt = new LinkButton();
                lbt.PostBackUrl = "Default.aspx?path=" + pathFile + "/" + Path.GetFileName(s);
                lbt.Text = Path.GetFileName(s);
                cell2.Controls.Add(lbt);
                TableCell cell13 = new TableCell();
                TextBox txtBox1 = new TextBox();
                txtBox1.ID = "dir" + lbt.Text.ToString();
                txtBox1.Visible = false;
                Button btn2 = new Button();
                btn2.Text = "重命名当前目录";
                btn2.CommandName = "btnName";
                btn2.CommandArgument = s;
                btn2.Command += new CommandEventHandler(btn2_Click);
                cell13.Controls.Add(txtBox1);
                cell13.Controls.Add(btn2);
                TableCell cell4 = new TableCell();
                Button btn1 = new Button();
                btn1.Text = "删除目录";
                btn1.CommandName = "btnName";
                btn1.CommandArgument = s;
                btn1.Command += new CommandEventHandler(btn_Click);
                cell4.Controls.Add(btn1);                           
                row1.Cells.Add(cell1);
                row1.Cells.Add(cell2);
                row1.Cells.Add(cell4);
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
                cell21.Text = "<img src=../img/page.png />";
                cell21.Style.Add("width", "30px");
                TableCell cell22 = new TableCell();
                cell22.Style.Add("text-align", "left");
                LinkButton lbtn = new LinkButton();
                lbtn.PostBackUrl = "Default.aspx?path=" + pathFile + "/" + Path.GetFileName(s);
                lbtn.Text=Path.GetFileNameWithoutExtension(s);
                cell22.Controls.Add(lbtn);
                TableCell cell23 = new TableCell();
                Button btn1 = new Button();
                btn1.Text = "删除页面";
                btn1.CommandName = "btnName";
                btn1.CommandArgument = s;
                btn1.Command += new CommandEventHandler(btn_Click);
                cell23.Controls.Add(btn1);
                row2.Cells.Add(cell21);
                row2.Cells.Add(cell22);
                row2.Cells.Add(cell23);
                Table1.Rows.Add(row2);
            }
        }
        else
        {
            Response.Redirect("display.aspx?path="+ pathFile);
        }


    }
    public void btn2_Click(object sender, CommandEventArgs e)
    {
        
    }

    public void btn_Click(object sender,CommandEventArgs e)
    {
        if(Directory.Exists(e.CommandArgument.ToString()))
        {
            Directory.Delete(e.CommandArgument.ToString());
        }
        else if(File.Exists(e.CommandArgument.ToString()))
        {
            File.Delete(e.CommandArgument.ToString());
        }
        Response.Redirect("Default.aspx?path=" + Request["path"].ToString());
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if(Request["path"]!=null)
        {
            path = Request["path"].ToString();
        }
        string[] abc = path.Split('/');        
            Literal1.Text = "当前位于：-><a href=Default.aspx><h3>Wiki根目录</h3></a>";
        string tem= "-><a href=Default.aspx?path=./rego";
        for (int i=2;i<abc.Length;i++)
        {
            Literal1.Text +=(tem+"/"+abc[i]+"><h3>"+abc[i]+"</h3></a>");
            tem += "/" + abc[i];
        }
        this.finder(path);
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("addFol.aspx?path="+path);
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("edit.aspx?path="+ path);
    }
}