<%@ Page Language="C#" AutoEventWireup="true" CodeFile="addFol.aspx.cs" Inherits="wiki_addFol" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link rel="stylesheet" type="text/css" href="../MainStyle.css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
    目录名字：<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><asp:Button ID="Button1" runat="server" Text="提交" OnClick="Button1_Click" />
    </div>
    </form>
</body>
</html>
