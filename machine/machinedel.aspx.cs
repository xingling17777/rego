using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class machine_machinedel : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["userName"] == null)
        {
            Session["url"] = Request.Url.ToString();
            Response.Redirect("../user/login.aspx");
        }
        if (!IsPostBack)
        {
            string id = "";
            if (Request["id"] != null && Request["action"] != null)
            {
                if (Request["action"] == "delete")
                {
                    id = Request["id"].ToString();
                    SqlConnection conn = new DataBase().getSqlConnection();
                    SqlCommand cmd = conn.CreateCommand();
                    cmd.CommandText = "delete from machine where id = " + id;

                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        cmd.CommandText = "delete from 设备保养记录 where MachineID = " + id;
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {

                    }
                    finally
                    {
                        conn.Close();
                        Response.Redirect("/machine/machinelist.aspx");
                    }
                }
                if (Request["action"] == "edit")
                {
                    id = Request["id"].ToString();
                    SqlConnection conn = new DataBase().getSqlConnection();
                    SqlCommand cmd = conn.CreateCommand();
                    cmd.CommandText = "select * from machine where id = " + id;

                    try
                    {
                        conn.Open();
                        SqlDataReader sdr = cmd.ExecuteReader();
                        while (sdr.Read())
                        {
                            txtNO.Text = sdr[1].ToString();
                            if (sdr[2].ToString() == "生产设备")
                            {
                                drpType.SelectedIndex = 0;
                            }
                            else
                            {
                                drpType.SelectedIndex = 1;
                            }
                            txtName.Text = sdr[3].ToString();
                            txtType.Text = sdr[4].ToString();
                            txtP.Text = sdr[5].ToString();
                            txtsNO.Text = sdr[6].ToString();
                            txtDate.Text = sdr[7].ToString();
                            txtManu.Text = sdr[8].ToString();
                            drpOr.SelectedValue = sdr[9].ToString();
                            drpstates.SelectedValue = sdr[10].ToString();

                            //

                        }
                    }
                    catch (Exception ex)
                    {

                    }
                    finally
                    {
                        conn.Close();

                    }

                }
            }
           
               
            }
        }
    

    protected void Button1_Click(object sender, EventArgs e)
    {
        string ID = txtNO.Text.Trim();
        string type = drpType.SelectedValue.ToString();
        string name = txtName.Text.Trim();
        string spec = txtType.Text.Trim();
        string Power = txtP.Text.Trim();
        string No = txtsNO.Text.Trim();
        string dates = txtDate.Text.Trim();
        string produce = txtManu.Text.Trim();
        string bumen = drpOr.SelectedValue.ToString();
        string state = drpstates.SelectedValue.ToString();
        if (ID != "" && name != "")
        {
            string id = "";
            id = Request["id"].ToString();
            SqlConnection conn = new DataBase().getSqlConnection();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "update machine set 设备编号='" + ID + "',设备类型='" + type + "',设备名称='" + name + "',型号规格='" + spec + "',功率='" +
                Power + "',出厂编号='" + No + "',进厂年月='" + dates + "',生产厂家='" + produce + "',安装地点='" + bumen + "',状态='" + state + "' where id=" + id;
            try
            {
                conn.Open();
                if (cmd.ExecuteNonQuery() == 1)
                {
                    Response.Write("<script type=text/javascript>alert('成功更新设备资料!')</script>");
                    Response.Redirect("/machine/machinelist.aspx");
                }
                else
                {
                    Response.Write("<script type=text/javascript>alert('未能更新设备资料,请重试或联系管理员!')</script>");
                }

            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
        }
    }
}