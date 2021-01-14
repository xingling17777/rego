using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

/// <summary>
/// LoadCustomer 的摘要说明
/// </summary>
public class Customer
{
    public Customer()
    {
        //
        // TODO: 在此处添加构造函数逻辑
        //
    }
    public void Load()
    {
        SqlConnection conn = new DataBase().getSqlConnection();
        SqlCommand cmd = conn.CreateCommand();
        cmd.CommandText = "select * from ";
    }
}