<%@ Page Language="C#" AutoEventWireup="true" CodeFile="chakanbaobiao.aspx.cs" Inherits="yinshua_chakanbaobiao" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>
        
    </title>
     <link rel="stylesheet" type="text/css" href="../MainStyle.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <a href="lingyongluru.aspx">片材领用录入|</a><a href="Report_Print.aspx">生产报表录入|</a><a href="chengpinlv.aspx">查看成品率|</a><a href="个人产量.aspx">查看个人产量</a>
            <asp:Table ID="Table1" runat="server"></asp:Table>
        </div>
    </form>
</body>
</html>
