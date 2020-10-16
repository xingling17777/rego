<%@ Page Language="C#" AutoEventWireup="true" CodeFile="churuku.aspx.cs" Inherits="xingzheng_churuku" %>

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
        <li><a href="kucun.aspx">库存</a></li>
    </ul>
    <br />    <form id="form1" runat="server">
        <div>
            <asp:RadioButton ID="RadioButton1" runat="server" GroupName="group" Text="出库" Checked="True" /><asp:RadioButton ID="RadioButton2" runat="server" GroupName="group" Text="入库" /><br />
            名称：<asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList><br />
            数量：<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br />
            部门：<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox><br />
            员工：<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox><br />
            日期：<asp:TextBox ID="TextBox4" runat="server" Width="35px"></asp:TextBox>年<asp:TextBox ID="TextBox5" runat="server" Width="20px"></asp:TextBox>月<asp:TextBox ID="TextBox6" runat="server" Width="20px"></asp:TextBox>日<br />
            <asp:Button ID="Button1" runat="server" Text="提交" OnClick="Button1_Click" />
        </div>
    </form>
</body>
</html>
