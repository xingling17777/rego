using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class machine_machineAdd : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["userName"] == null)
        {
            Session["url"] = Request.Url.ToString();
            Response.Redirect("../user/login.aspx");
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        string id = txtNO.Text.Trim();
        string type = drpType.SelectedValue.ToString();
        string name = txtName.Text.Trim();
        string spec = txtType.Text.Trim();
        string Power = txtP.Text.Trim();
        string No = txtsNO.Text.Trim();
        string dates = txtDate.Text.Trim();
        string produce = txtManu.Text.Trim();
        string bumen = drpOr.SelectedValue.ToString();
        string state = drpstates.SelectedValue.ToString();
        if(id!="" && name!="")
            {
            SqlConnection conn = new DataBase().getSqlConnection();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "insert into machine values('"+id+"','"+type+"','"+name+"','"+spec+"','"+
                Power+"','"+No+"','"+dates+"','"+produce+"','"+bumen+"','"+state+"')";
            try
            {
                conn.Open();
                if(cmd.ExecuteNonQuery()==1)
                {
                    Response.Write("<script type=text/javascript>alert('成功添加新设备!')</script>");
                }
                else
                {
                    Response.Write("<script type=text/javascript>alert('未能添加新设备,请重试或联系管理员!')</script>");
                }
                txtDate.Text = "";
                txtManu.Text = "";
                txtName.Text = "";
                txtNO.Text = "";
                txtP.Text = "";
                txtsNO.Text = "";
                txtType.Text = "";
            }
            catch(Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
        }
    }
}