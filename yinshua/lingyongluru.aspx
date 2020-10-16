<%@ Page Language="C#" AutoEventWireup="true" CodeFile="lingyongluru.aspx.cs" Inherits="yinshua_lingyongluru" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>白片材领用录入</title>
    <link rel="stylesheet" type="text/css" href="../MainStyle.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div><a href="lingyongluru.aspx">片材领用录入|</a><a href="Report_Print.aspx">生产报表录入|</a><a href="chakanbaobiao.aspx">生产报表查看|</a><a href="chengpinlv.aspx">查看成品率|</a><a href="个人产量.aspx">查看个人产量</a>
            <table>
                <tr><td colspan="2">领料录入</td></tr>
                <tr><td>订单号</td><td>
                    <asp:TextBox ID="txtorder" runat="server"></asp:TextBox></td></tr>
                <tr><td>片材宽度(mm)</td><td>
                    <asp:TextBox ID="txtWidth" runat="server"></asp:TextBox></td></tr>
                 <tr><td>领用数量</td><td>
                     <asp:TextBox ID="txtNum" runat="server"></asp:TextBox>平方米</td></tr>
                 <tr><td colspan="2">
                     <asp:Button ID="Button1" runat="server" Text="提交" OnClick="Button1_Click" /></td></tr>
            </table>
        </div>
    </form>
</body>
</html>
