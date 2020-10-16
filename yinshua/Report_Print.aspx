<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Report_Print.aspx.cs" Inherits="other_Report_Print" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>生产报表录入</title>
        <link rel="stylesheet" type="text/css" href="../MainStyle.css" />

</head>
<body>
    <form id="form1" runat="server">
        <div>
            <a href="lingyongluru.aspx">片材领用录入|</a><a href="Report_Print.aspx">生产报表录入|</a><a href="chakanbaobiao.aspx">生产报表查看|</a><a href="chengpinlv.aspx">查看成品率|</a><a href="个人产量.aspx">查看个人产量</a>
            <table>
                <tr><th colspan="2">生产报表录入</th></tr>
                <tr><td>日期</td><td>
                    <asp:TextBox ID="TextBox1" runat="server" Width="35px"></asp:TextBox>年<asp:TextBox ID="TextBox2" runat="server" Width="35px"></asp:TextBox>月<asp:TextBox ID="TextBox3" runat="server" Width="35px"></asp:TextBox>日
                </td></tr>
                <tr><td>班组</td><td>
                    <asp:RadioButtonList ID="RadioButtonList1" runat="server">
                        <asp:ListItem Selected="True">A班</asp:ListItem>
                        <asp:ListItem>B班</asp:ListItem>
                    </asp:RadioButtonList></td></tr>
                <tr><td>机台</td><td>
                    <asp:DropDownList ID="DropDownList1" runat="server">
                        <asp:ListItem Selected="True">6-1</asp:ListItem>
                        <asp:ListItem>6-2</asp:ListItem>
                        <asp:ListItem>7C</asp:ListItem>
                        <asp:ListItem>8-1</asp:ListItem>
                        <asp:ListItem>8-2</asp:ListItem>
                        <asp:ListItem>8-3</asp:ListItem>
                        <asp:ListItem>SY3-1</asp:ListItem>
                        <asp:ListItem>SY3-2</asp:ListItem>
                        <asp:ListItem>SY2-1</asp:ListItem>
                    </asp:DropDownList></td></tr>
                <tr><td>开机人员人员</td><td>
                    <asp:TextBox ID="txtName1" runat="server" Width="70px"></asp:TextBox> - <asp:TextBox ID="txtName2" runat="server" Width="70px"></asp:TextBox></td></tr>
                <tr><td>订单号</td><td>
                    <asp:TextBox ID="txtOrder" runat="server" OnTextChanged="txtOrder_TextChanged"></asp:TextBox></td></tr>
                <tr><td>订单名称</td><td>
                    <asp:Label ID="Label1" runat="server" Text=""></asp:Label></td></tr>
                <tr><td>订单类别</td><td>
                    <asp:RadioButtonList ID="RadioButtonList2" runat="server">
                        <asp:ListItem Selected="True">牙膏</asp:ListItem>
                        <asp:ListItem>化妆品</asp:ListItem>
                        <asp:ListItem>特殊</asp:ListItem>
                    </asp:RadioButtonList></td></tr>
                                <tr><td>印刷片材米数</td><td>
                    <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox></td></tr>
                <tr><td colspan="2">
                    <asp:Button ID="Button1" runat="server" Text="提交" OnClick="Button1_Click" /></td></tr>
            </table>
        </div>
    </form>
</body>
</html>
