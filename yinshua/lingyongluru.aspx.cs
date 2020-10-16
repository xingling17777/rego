using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class yinshua_lingyongluru : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        //SqlConnection conn = new SqlConnection("server=192.168.0.18;database=XinWa_Elector_DB;uid=sa;pwd=REgo123456");

        if (txtNum.Text.Trim() != "" && txtorder.Text.Trim() != "" && txtWidth.Text.Trim() != "")
        {
            SqlConnection conn = new SqlConnection("server=192.168.0.18;database=rego;uid=sa;pwd=REgo123456");
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "insert into 领料录入 values('" + DateTime.Now + "','" + txtorder.Text.Trim() + "'," + txtWidth.Text.Trim() + "," + txtNum.Text.Trim() + ")";
            try
            {
                conn.Open();
                if (cmd.ExecuteNonQuery() == 1)
                {


                }
            }
            catch (Exception ey) { }
            finally
            {
                conn.Close();

            }
            //找到客户编号，成品编号，订单数量；
            //登记该订单信息
            conn = new SqlConnection("server=192.168.0.18;database=XinWa_Elector_DB;uid=sa;pwd=REgo123456");
            cmd = conn.CreateCommand();
            cmd.CommandText = "select 客户编号,物料编号,订单数量 from Pro_生产单主表 where 订单编号 like '" + txtorder.Text + "'";
            string customerNO = "";
            string productNO = "";
            int OrderSum = 0;
            try
            {

                conn.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    customerNO = sdr[0].ToString().Trim();
                    productNO = sdr[1].ToString().Trim();
                    OrderSum = Convert.ToInt32(sdr[2].ToString().Trim());
                }
            }
            catch (Exception ey) { }
            finally
            {
                conn.Close();
            }
            string customerName = "", productName = "";
            cmd.CommandText = "select 客户名称 from Bas_客户信息表 where 客户编号 like '" + customerNO + "'";
            try
            {
                conn.Open();
                customerName = cmd.ExecuteScalar().ToString();
                cmd.CommandText = "select 物料描述 from Bas_物料信息表 where 物料编号 like '" + productNO + "'";
                productName = cmd.ExecuteScalar().ToString();
            }

            catch (Exception ey) { }
            finally
            {
                conn.Close();
            }
            int x = -1;
            int y = productName.Trim().LastIndexOf('*');
            if (productName.Trim().Substring(y - 2) == ".")
            {
                x = y - 4;
            }
            else
            {
                x = y - 2;
            }
            double dia = Convert.ToDouble(productName.Substring(x, y - x));
            double length = 0;
            if (productName.Trim().Substring(y).IndexOf(" ") != -1)
            {
                length = Convert.ToDouble(productName.Substring(y + 1, productName.Trim().Substring(y).IndexOf(" ") - 1));
            }
            else if (productName.Trim().Substring(y).IndexOf("　") != -1)
            {
                length = Convert.ToDouble(productName.Substring(y + 1, productName.Trim().Substring(y).IndexOf(" ")-1));
            }
            else
            {
                length = Convert.ToDouble(productName.Substring(y + 1));
            }

            conn = new SqlConnection("server=192.168.0.18;database=rego;uid=sa;pwd=REgo123456");
            cmd = conn.CreateCommand();
            try
            {
                conn.Open();
                cmd.CommandText = "insert into 订单描述 values('" + txtorder.Text.Trim() + "','" + customerName + "','" + productName + "'," + OrderSum + "," + txtWidth.Text.Trim() + "," + dia + "," + length + ")";
                cmd.ExecuteNonQuery();
                Response.Write("<script language='javascript'>alert('已录入！')</script>");
            }
            catch (Exception ey) { }
            finally
            {
                conn.Close();
            }
            txtNum.Text = "";
            txtorder.Text = "";
            txtWidth.Text = "";
        }
    }
}