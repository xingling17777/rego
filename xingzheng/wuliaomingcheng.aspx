<%@ Page Language="C#" AutoEventWireup="true" CodeFile="wuliaomingcheng.aspx.cs" Inherits="xingzheng_wuliaomingcheng" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        body{
            line-height:2em;
            text-align:center;
        }

    </style>
    <style type="text/css">
        li{
            list-style-type:none;
           //border:1px solid red;
            padding-left:10px;
            float:left;
        }
        ul a{
            display:block;
            text-decoration:none;
        }
    </style>
</head>
<body>
        <ul>
        <li><a href="wuliaomingcheng.aspx">功能：录入新物料名称</a></li>
        <li><a href="churuku.aspx">出入库</a></li>
        <li><a href="Default.aspx">流水</a></li>
    </ul><br />
    <form id="form1" runat="server">
        <div>
            <h3>录入新物料名称</h3>
            名称：<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br />
            单位：<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox><br />
            <asp:Button ID="Button3" runat="server" Text="提交" OnClick="Button3_Click" />
        </div>
    </form>
</body>
</html>
