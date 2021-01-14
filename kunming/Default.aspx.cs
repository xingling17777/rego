using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Collections;

public partial class kunming_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            
                SqlConnection conn = new DataBase().getSqlConnection();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "select sum(count) from 云南白药订单 where finish = ''";
            double sum = 0, RegoSum = 0, YNBYSum = 0;
            try
            {
                conn.Open();
                sum = Convert.ToDouble(cmd.ExecuteScalar());
                cmd.CommandText = "select sum(count) from 云南白药订单 where finish = '' and baiyaoorder=''";
                RegoSum= Convert.ToDouble(cmd.ExecuteScalar());

            }
            catch(Exception ey) { }
            finally
            {
                conn.Close();
            }
            
           

           
            cmd.CommandText = "select * from 云南白药订单 where finish='' order by id desc";

            ArrayList OrderID = new ArrayList();
            ArrayList OrderNO = new ArrayList();
            ArrayList Product = new ArrayList();
            ArrayList ProductCount = new ArrayList();
            ArrayList TranslateCount = new ArrayList();
            ArrayList GuanZhuang = new ArrayList();
            ArrayList Products = new ArrayList();
            ArrayList BaiYaoOrder = new ArrayList();
            ArrayList ProduceCount = new ArrayList();
            ArrayList RuKuCount = new ArrayList();
            ArrayList PO = new ArrayList();
            try
            {
                conn.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    OrderID.Add(sdr[0].ToString());
                    OrderNO.Add(sdr[1].ToString());
                    Product.Add(sdr[2].ToString());
                    ProductCount.Add(sdr[3].ToString());
                    BaiYaoOrder.Add(sdr[6].ToString());
                    PO.Add(sdr[7].ToString());
                }
                sdr.Close();
                foreach (string s in Product)
                {
                    cmd.CommandText = "select name from 白药产品名称 where id=" + s;
                    Products.Add(cmd.ExecuteScalar());
                }
                foreach (string s in OrderID)
                {
                    cmd.CommandText = "select COALESCE(sum(productcount),0) from 云南白药送货 where orderid=" + s;

                    TranslateCount.Add(cmd.ExecuteScalar().ToString());


                }
                foreach (string s in OrderID)
                {
                    cmd.CommandText = "select COALESCE(sum(productcount),0) from 云南白药灌装 where orderid=" + s;

                    GuanZhuang.Add(cmd.ExecuteScalar().ToString());
                }
                foreach (string s in OrderID)
                {
                    cmd.CommandText = "select COALESCE(sum(producecount),0) from 云南白药生产 where orderid=" + s;

                    ProduceCount.Add(cmd.ExecuteScalar().ToString());
                }
                foreach (string s in OrderID)
                {
                    cmd.CommandText = "select COALESCE(sum(ordercount),0) from 云南白药入库 where orderid=" + s;

                    RuKuCount.Add(cmd.ExecuteScalar().ToString());
                }
            }
            catch (Exception ey) { }
            finally
            {
                conn.Close();
            }
            double SumProduce = 0, SumTrans = 0, SumRuKu = 0, SumGuan = 0;
            foreach(string x in ProduceCount)
            {

                SumProduce += Convert.ToDouble(x);
            }
            foreach (string  x in TranslateCount)
            {
                SumTrans += Convert.ToDouble(x);
            }
            foreach (string  x in RuKuCount)
            {
                SumRuKu += Convert.ToDouble(x);
            }
            foreach (string  x in GuanZhuang)
            {
                SumGuan += Convert.ToDouble(x);
            }
            Label1.Text = "目前在线订单" + sum + "，其中，云南白药下单" + (sum - RegoSum) + "，我司备库" + RegoSum + ", 已生产"+SumProduce+"，已入库白药"+SumRuKu+"，已灌装"+SumGuan+"，不合格品    ";
            TableRow row = new TableRow();
            TableCell cell011 = new TableCell();
            cell011.Text = "白药订单号";
            TableCell cell0111 = new TableCell();
            cell0111.Text = "白药批号";
            TableCell cell01 = new TableCell();
            cell01.Text = "内部订单号";
            TableCell cell02 = new TableCell();
            cell02.Text = "产品名称";
            TableCell cell03 = new TableCell();
            cell03.Text = "下单数量";
            TableCell cell033 = new TableCell();
            cell033.Text = "已生产数量";
            TableCell cell04 = new TableCell();
            cell04.Text = "已送货数量";
            TableCell cell044 = new TableCell();
            cell044.Text = "白药入库数量";
            TableCell cell05 = new TableCell();
            cell05.Text = "已灌装数量";
            row.Cells.Add(cell011);
            row.Cells.Add(cell0111);
            row.Cells.Add(cell01);
            row.Cells.Add(cell02);
            row.Cells.Add(cell03);
            row.Cells.Add(cell033);
            row.Cells.Add(cell04);
            row.Cells.Add(cell044);
            row.Cells.Add(cell05);
            Table1.Rows.Add(row);
            for (int i = 0; i < OrderID.Count; i++)
            {
                TableRow row1 = new TableRow();
                TableCell cell20 = new TableCell();
                cell20.Text = BaiYaoOrder[i].ToString();
                TableCell cell200 = new TableCell();
                cell200.Text = PO[i].ToString();
                TableCell cell21 = new TableCell();
                cell21.Text = OrderNO[i].ToString();
                TableCell cell22 = new TableCell();
                cell22.Text = Products[i].ToString();
                TableCell cell23 = new TableCell();
                cell23.Text = ProductCount[i].ToString();
                TableCell cell233 = new TableCell();
                cell233.Text = ProduceCount[i].ToString();
                TableCell cell24 = new TableCell();
                cell24.Text = TranslateCount[i].ToString();
                TableCell cell244 = new TableCell();
                cell244.Text = RuKuCount[i].ToString();
                TableCell cell25 = new TableCell();
                cell25.Text = GuanZhuang[i].ToString();
                row1.Cells.Add(cell20);
                row1.Cells.Add(cell200);
                row1.Cells.Add(cell21);
                row1.Cells.Add(cell22);
                row1.Cells.Add(cell23);
                row1.Cells.Add(cell233);
                row1.Cells.Add(cell24);
                row1.Cells.Add(cell244);
                row1.Cells.Add(cell25);
                Table1.Rows.Add(row1);
            }
        }
    }
}