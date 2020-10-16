using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Collections;

public partial class yinshua_chengpinlv : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        int month = Convert.ToInt32(DropDownList1.SelectedValue.ToString());
        int year = DateTime.Now.Year;
        if (month > DateTime.Now.Month)
        {
            year--;
        }
        DateTime dt1 = new DateTime(year, month, 1);
        DateTime dt2 = dt1.AddMonths(1).AddDays(-1);
        SqlConnection conn = new SqlConnection("server=192.168.0.18;database=rego;uid=sa;pwd=REgo123456;MultipleActiveResultSets=true");
        SqlCommand cmd = conn.CreateCommand();
        cmd.CommandText = "select distinct people from 报表录入 where date between '" + dt1 + "' and '" + dt2 + "'";

        TableRow row11 = new TableRow();
        TableCell cell11 = new TableCell();
        cell11.Text = "姓名";
        TableCell cell12 = new TableCell();
        cell12.Text = "产量";

        row11.Cells.Add(cell11);
        row11.Cells.Add(cell12);
        Table1.Rows.Add(row11);
        SqlDataReader sdr;
        ArrayList people = new ArrayList();
        try
        {
            conn.Open();
            sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                string tmpPeople1, tmpPeople2;
                if (sdr[0].ToString().IndexOf(',') != -1)
                {
                    tmpPeople1 = sdr[0].ToString().Split(',')[0];
                    tmpPeople2 = sdr[0].ToString().Split(',')[1];
                    if (!people.Contains(tmpPeople1))
                    {
                        people.Add(tmpPeople1);
                    }
                    if (!people.Contains(tmpPeople2))
                    {
                        people.Add(tmpPeople2);
                    }
                }
                else
                {
                    tmpPeople1 = sdr[0].ToString();
                    tmpPeople2 = "";
                    if (!people.Contains(tmpPeople1))
                    {
                        people.Add(tmpPeople1);
                    }
                }
            }

        }
        catch (Exception ey) { }
        finally
        {
            conn.Close();
        }
        foreach (object s in people)
        {
            cmd.CommandText = "select orderNO,sum,type from 报表录入 where people like '%" + s.ToString() + "%' and date between '" + dt1 + "' and '" + dt2 + "'";
            string orderNo = "";
            double sum = 0;
            string type = "";
            double sumchanliang = 0;
            try
            {
                conn.Open();
                sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    orderNo = sdr[0].ToString();
                    sum = Convert.ToDouble(sdr[1].ToString());
                    type = sdr[2].ToString();
                    SqlCommand cmz = conn.CreateCommand();
                    cmz.CommandText = "select * from 订单描述 where orderNO='" + orderNo + "'";
                    try
                    {
                        SqlDataReader sdz = cmz.ExecuteReader();
                   
                    sdz.Read();
                    
                    int sumOrder = Convert.ToInt32(sdz[4].ToString());
                    double width = Convert.ToDouble(sdz[5].ToString());
                    double dia = Convert.ToDouble(sdz[6].ToString());
                    double length = Convert.ToDouble(sdz[7].ToString());
                    sum = sum / Math.Round(width / (3.14 * dia));
                    
                    if (type == "化妆品")
                    {
                        sum = 1.5 * sum;
                    }
                        if (type == "特殊")
                        {
                            sum = 1.3 * sum;
                        }
                        if (sumOrder*length/1000<=850)
                    {
                        sum = sum * 3;
                    }
                    else if(sumOrder * length / 1000 <=1700)
                    {
                        sum = sum * 2.5;
                    }
                    else if (sumOrder * length / 1000 <= 3000)
                    {
                        sum = sum * 2;
                    }
                    }
                    catch (Exception ey)
                    {
                        continue;
                    }
                    sumchanliang += sum;
                }

            }catch(Exception ey) { }
            finally
            {
                conn.Close();
            }
            TableRow row = new TableRow();
            TableCell cell1 = new TableCell();
            cell1.Text = s.ToString();
            TableCell cell2 = new TableCell();
            cell2.Text = sumchanliang.ToString();            
            row.Cells.Add(cell1);
            row.Cells.Add(cell2);            
            Table1.Rows.Add(row);
        }
    }
}