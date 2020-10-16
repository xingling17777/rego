<%@ Page Language="C#" AutoEventWireup="true" CodeFile="sopo.aspx.cs" Inherits="other_sopo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            导出最近<asp:TextBox ID="TextBox1" runat="server">300</asp:TextBox>条记录<asp:Button ID="Button1" runat="server" Text="导出" OnClick="Button1_Click" />
        </div>
    </form>
</body>
</html>
