using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class gift_giftin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            SqlConnection conn = new DataBase().getSqlConnection();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "select * from gift order by giftName";
            try
            {
                conn.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    drp1.Items.Add(new ListItem(sdr[1].ToString(), sdr[0].ToString()));
                }
            }
            catch (Exception ey)
            {
                Response.Write("<script>alert('" + ey.Message + "')</script>");
            }
            finally
            {

                conn.Close();
            }
        }
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        if (drp1.SelectedIndex != -1)
        {
            string giftName = drp1.SelectedValue.ToString();
            double giftSum = Convert.ToDouble(txtbox1.Text.Trim().ToString());
            string giftUnit = txtbox2.Text.Trim().ToString();
            SqlConnection conn = new DataBase().getSqlConnection();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "insert into giftList values("+giftName+","+giftSum+",'"+giftUnit+"',"+DateTime.Now.ToShortDateString()+")";

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                Response.Write("<script>alert('已入库！')</script>");
               
            }
            catch(Exception ey) {
                Response.Write("<script>alert('"+ey.Message+"')</script>");
            }
            finally
            {
                conn.Close();
                txtbox1.Text = "";
                txtbox2.Text = "";
            }
        }
        else
        {
            Response.Write("<script>alert('请选择产品名字！')</script>");
        }
    }
}