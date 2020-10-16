<%@ Page Language="C#" AutoEventWireup="true" CodeFile="chengpinlv.aspx.cs" Inherits="yinshua_chengpinlv" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>成品率</title>
    <link rel="stylesheet" type="text/css" href="../MainStyle.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
           <a href="lingyongluru.aspx">片材领用录入|</a><a href="Report_Print.aspx">生产报表录入|</a><a href="chakanbaobiao.aspx">生产报表查看|</a><a href="chengpinlv.aspx">查看成品率|</a><a href="个人产量.aspx">查看个人产量</a>
            <div>选择月份:<asp:DropDownList ID="DropDownList1" runat="server">
                <asp:ListItem Selected="True">1</asp:ListItem>
                <asp:ListItem>2</asp:ListItem>
                <asp:ListItem>3</asp:ListItem>
                <asp:ListItem>4</asp:ListItem>
                <asp:ListItem>5</asp:ListItem>
                <asp:ListItem>6</asp:ListItem>
                <asp:ListItem>7</asp:ListItem>
                <asp:ListItem>8</asp:ListItem>
                <asp:ListItem>9</asp:ListItem>
                <asp:ListItem>10</asp:ListItem>
                <asp:ListItem>11</asp:ListItem>
                <asp:ListItem>12</asp:ListItem>
                </asp:DropDownList><asp:Button ID="Button1" runat="server" Text="提交" OnClick="Button1_Click" />
                           <asp:FileUpload ID="FileUpload1" runat="server" />
                <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="导入制管报表" />
                <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="导出下表" />
                           </div>
           
            <asp:Table ID="Table1" runat="server"></asp:Table>
        </div>
    </form>
</body>
</html>
