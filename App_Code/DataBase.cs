using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

/// <summary>
/// DataBase 的摘要说明
/// </summary>
public class DataBase
{
    public DataBase()
    {
        //
        // TODO: 在此处添加构造函数逻辑
        //
    }
    public SqlConnection getSqlConnection()
    {
        //SqlConnection conn = new SqlConnection("server=192.168.0.18;database=rego;uid=sa;pwd=hundun");
        SqlConnection conn = new SqlConnection("server=hds117139411.my3w.com;database=hds117139411_db;uid=hds117139411;pwd=rego123456;MultipleActiveResultSets=true");
        return conn;
       
    }
}

    