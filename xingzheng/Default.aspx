<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="xingzheng_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <style type="text/css">
        body {
            text-align: center;
            line-height:1.5em;
        }
        table {
            width:98%;
            border-collapse: collapse;
        }
        table, th, td {
            border: 1px solid black;
            padding:3px 10px 3px 10px;
            
        }
        
        li {
            list-style-type: none;
            padding-left: 10px;
            float: left;
        }

        ul a {
            display: block;
            text-decoration: none;
        }
    </style>
</head>
<body>
    <ul>
        <li><a href="wuliaomingcheng.aspx">功能：录入新物料名称</a></li>
        <li><a href="churuku.aspx">出入库</a></li>
        <li><a href="Default.aspx">流水</a></li>
         <li><a href="kucun.aspx">库存</a></li>
    </ul>    
    <br />
    <form id="form1" runat="server">

        <div>
            <asp:Button ID="Button1" runat="server" Text="导出" OnClick="Button1_Click" />           
            <asp:Table ID="Table1" runat="server"></asp:Table>
        </div>
    </form>
</body>
</html>
